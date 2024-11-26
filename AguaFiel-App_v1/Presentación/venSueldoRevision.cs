using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AguaFiel_App_v1
{
    public partial class venSueldoRevision : Form
    {
        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";
        private decimal sueldoBase;
        private decimal sueldoFinal;
        public event Action DatosActualizados;

        public venSueldoRevision()
        {
            this.ControlBox = false;
            InitializeComponent();
            cbPago.Items.Add("Quincenal");
            cbPago.Items.Add("Mensual");
            cbPago.SelectedIndex = 0;
        }

        private void venSueldoRevision_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT idEmpleado, nombre, apellido, nombreCargo, sueldo_base, sueldo_final, fechaContrato, total_faltas 
                                 FROM Descuento
                                 WHERE activo = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleados.DataSource = dt;
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvEmpleados.CurrentRow.Cells["apellido"].Value.ToString();
                txtCargo.Text = dgvEmpleados.CurrentRow.Cells["nombreCargo"].Value.ToString();
                dtpFechaContrato.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fechaContrato"].Value);

                sueldoBase = Convert.ToDecimal(dgvEmpleados.CurrentRow.Cells["sueldo_base"].Value);
                sueldoFinal = Convert.ToDecimal(dgvEmpleados.CurrentRow.Cells["sueldo_final"].Value);

                txtSueldo.Text = sueldoBase.ToString("0.00");
                txtSueldoIngresado.Text = sueldoFinal.ToString("0.00");

                chbxGrati.Checked = false;
                chbxESS.Checked = false;
            }
        }

        private void chbxGrati_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarSueldoCalculado();
        }

        private void chbxESS_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarSueldoCalculado();
        }

        private void ActualizarSueldoCalculado()
        {
            decimal sueldoCalculado = sueldoFinal;

            if (chbxGrati.Checked)
            {
                decimal gratificacion = sueldoBase * 0.10m;
                sueldoCalculado += gratificacion;
            }

            if (chbxESS.Checked)
            {
                decimal essalud = sueldoBase * 0.09m;
                sueldoCalculado += essalud;
            }

            txtSueldoIngresado.Text = sueldoCalculado.ToString("0.00");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado del listado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value);
            decimal sueldoCalculado = Convert.ToDecimal(txtSueldoIngresado.Text);
            bool tieneGrati = chbxGrati.Checked;
            bool tieneESS = chbxESS.Checked;
            DateTime fechaPago = DateTime.Now; // Puedes usar un `DateTimePicker` si deseas seleccionar una fecha

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Inserta el sueldo calculado en la tabla SueldosCalculados
                string query = @"INSERT INTO SueldosCalculados (idEmpleado, sueldoCalculado, tieneGrati, tieneESS, fechaPago)
                         VALUES (@idEmpleado, @sueldoCalculado, @tieneGrati, @tieneESS, @fechaPago)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@sueldoCalculado", sueldoCalculado);
                    cmd.Parameters.AddWithValue("@tieneGrati", tieneGrati);
                    cmd.Parameters.AddWithValue("@tieneESS", tieneESS);
                    cmd.Parameters.AddWithValue("@fechaPago", fechaPago);

                    cmd.ExecuteNonQuery();
                }

                // Actualiza el sueldo_final en la tabla Empleados
                string updateQuery = @"UPDATE Empleados
                               SET sueldo_final = @sueldoCalculado
                               WHERE idEmpleado = @idEmpleado";

                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, con))
                {
                    cmdUpdate.Parameters.AddWithValue("@sueldoCalculado", sueldoCalculado);
                    cmdUpdate.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                    cmdUpdate.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Sueldo calculado registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoPago = cbPago.SelectedItem.ToString();
            var empleadosSeleccionados = dgvEmpleados.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new
                {
                    idEmpleado = Convert.ToInt32(row.Cells["idEmpleado"].Value),
                }).ToList();

            if (!empleadosSeleccionados.Any())
            {
                MessageBox.Show("No hay empleados para agrupar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Agregar fecha de generación (fecha y hora actuales) al insertar el grupo de pago
                string queryGrupo = "INSERT INTO GruposPago (tipoPago, fechaGeneracion) OUTPUT INSERTED.idGrupoPago VALUES (@tipoPago, @fechaGeneracion)";
                int idGrupoPago;

                using (SqlCommand cmdGrupo = new SqlCommand(queryGrupo, con))
                {
                    cmdGrupo.Parameters.AddWithValue("@tipoPago", tipoPago);
                    cmdGrupo.Parameters.AddWithValue("@fechaGeneracion", DateTime.Now); // Fecha y hora actuales
                    idGrupoPago = (int)cmdGrupo.ExecuteScalar();
                }

                foreach (var empleado in empleadosSeleccionados)
                {
                    // Insertar detalles del grupo de pago
                    string queryDetalle = "INSERT INTO DetalleGrupoPago (idGrupoPago, idEmpleado) VALUES (@idGrupoPago, @idEmpleado)";
                    using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con))
                    {
                        cmdDetalle.Parameters.AddWithValue("@idGrupoPago", idGrupoPago);
                        cmdDetalle.Parameters.AddWithValue("@idEmpleado", empleado.idEmpleado);
                        cmdDetalle.ExecuteNonQuery();
                    }

                    // Actualizar el tipo de pago de los empleados
                    string queryEmpleado = "UPDATE Empleados SET tipoPago = @tipoPago WHERE idEmpleado = @idEmpleado";
                    using (SqlCommand cmdEmpleado = new SqlCommand(queryEmpleado, con))
                    {
                        cmdEmpleado.Parameters.AddWithValue("@tipoPago", tipoPago);
                        cmdEmpleado.Parameters.AddWithValue("@idEmpleado", empleado.idEmpleado);
                        cmdEmpleado.ExecuteNonQuery();
                    }
                }

                // Mensaje de confirmación
                MessageBox.Show($"Grupo de pago ({tipoPago}) registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar empleados (o hacer cualquier otra acción que sea necesaria)
                CargarEmpleados();

                // Notificar que los datos han sido actualizados
                DatosActualizados?.Invoke();
            }
        }
    }
}
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
    public partial class venEmpleadoReg : Form
    {
        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";

        public venEmpleadoReg()
        {
            InitializeComponent();
        }

        private void CargarCargos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT idCargo, nombreCargo FROM Cargos";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCargos.DisplayMember = "nombreCargo";
                cbCargos.ValueMember = "idCargo";
                cbCargos.DataSource = dt;
            }
        }

        private void CargarEmpleados()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT E.idEmpleado, E.nombre, E.apellido, C.nombreCargo, C.sueldo, E.fechaContrato 
                         FROM Empleados E
                         JOIN Cargos C ON E.idCargo = C.idCargo
                         WHERE E.activo = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleados.DataSource = dt;
            }
        }

        private void RegistrarEmpleado()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellidos.Text;
            DateTime fechaContrato = dtpFechaContrato.Value;
            int idCargo = Convert.ToInt32(cbCargos.SelectedValue);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Empleados (nombre, apellido, idCargo, fechaContrato, activo) VALUES (@nombre, @apellido, @idCargo, @fechaContrato, 1)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@idCargo", idCargo);
                    cmd.Parameters.AddWithValue("@fechaContrato", fechaContrato);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Empleado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEmpleados();
        }


        private void ModificarEmpleado(int idEmpleado)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellidos.Text;
            DateTime fechaContrato = dtpFechaContrato.Value;
            int idCargo = Convert.ToInt32(cbCargos.SelectedValue);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Empleados SET nombre = @nombre, apellido = @apellido, idCargo = @idCargo, fechaContrato = @fechaContrato WHERE idEmpleado = @idEmpleado";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@idCargo", idCargo);
                    cmd.Parameters.AddWithValue("@fechaContrato", fechaContrato);
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Empleado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEmpleados();
        }

        private void InhabilitarEmpleado(int idEmpleado)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Empleados SET activo = 0 WHERE idEmpleado = @idEmpleado";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Empleado inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEmpleados();
        }

        private void venEmpleadoReg_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarCargos();
            CargarEmpleados();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value);
                ModificarEmpleado(idEmpleado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value);
                InhabilitarEmpleado(idEmpleado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para inhabilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCargos.SelectedIndexChanged += cbCargos_SelectedIndexChanged;

            if (cbCargos.SelectedValue != null)
            {
                int idCargo = Convert.ToInt32(cbCargos.SelectedValue);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT sueldo FROM Cargos WHERE idCargo = @idCargo";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idCargo", idCargo);
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtSueldo.Text = result.ToString();
                        }
                    }
                }
            }
        }
    }
}
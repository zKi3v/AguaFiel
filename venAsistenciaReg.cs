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
    public partial class venAsistenciaReg : Form
    {
        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";

        public event Action DatosActualizados;

        public venAsistenciaReg()
        {
            InitializeComponent();
        }

        private void venAsistenciaReg_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarEmpleados();

            cbAsistenciaReg.Items.Add("Asistió");
            cbAsistenciaReg.Items.Add("Faltó");

            dtpFechaReg.Value = DateTime.Now;
            dtpFechaReg.Enabled = false;
        }

        private void CargarEmpleados()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT E.idEmpleado, E.nombre, E.apellido, C.nombreCargo FROM Empleados E JOIN Cargos C ON E.idCargo = C.idCargo";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleado.AutoGenerateColumns = false;
                dgvEmpleado.DataSource = dt;

                // Configurar columna de asistencia si no existe
                if (!dgvEmpleado.Columns.Contains("presente"))
                {
                    DataGridViewComboBoxColumn asistenciaColumn = new DataGridViewComboBoxColumn
                    {
                        Name = "presente",
                        HeaderText = "Asistencia",
                        DataSource = new List<string> { "Asistió", "Faltó" }
                    };
                    dgvEmpleado.Columns.Add(asistenciaColumn);
                }

                // Ocultar la columna de asistencia
                dgvEmpleado.Columns["presente"].Visible = false;

                // Eliminar opciones del ComboBox en la columna de asistencia
                if (dgvEmpleado.Columns["presente"] is DataGridViewComboBoxColumn comboBoxColumn)
                {
                    comboBoxColumn.DataSource = new List<string>(); // Configura una lista vacía
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchId = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(searchId))
            {
                foreach (DataGridViewRow row in dgvEmpleado.Rows)
                {
                    if (row.Cells["idEmpleado"].Value.ToString().Equals(searchId))
                    {
                        row.Selected = true;
                        dgvEmpleado.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
                MessageBox.Show("Empleado no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un ID de empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.CurrentRow != null && cbAsistenciaReg.SelectedItem != null)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleado.CurrentRow.Cells["idEmpleado"].Value);
                bool presente = cbAsistenciaReg.SelectedItem.ToString() == "Asistió";
                DateTime fecha = dtpFechaReg.Value;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Asistencia (idEmpleado, fecha, presente) VALUES (@idEmpleado, @fecha, @presente)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@presente", presente ? 1 : 0);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Asistencia registrada exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado y un estado de asistencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarEmpleados();
            }
            CargarEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechaReg.Value;
            string nombreGrupo = "Grupo " + fecha.ToString("dd-MM-yyyy");
            int idGrupo;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Verificar si ya existe un grupo para la fecha seleccionada
                string queryCheck = "SELECT idGrupo FROM GruposAsistencia WHERE fecha = @fecha";
                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, con))
                {
                    cmdCheck.Parameters.AddWithValue("@fecha", fecha);
                    con.Open();

                    var result = cmdCheck.ExecuteScalar();
                    if (result != null)
                    {
                        idGrupo = Convert.ToInt32(result);
                    }
                    else
                    {
                        // Crear un nuevo grupo si no existe
                        string queryInsertGrupo = "INSERT INTO GruposAsistencia (fecha, nombreGrupo) OUTPUT INSERTED.idGrupo VALUES (@fecha, @nombreGrupo)";
                        using (SqlCommand cmdInsertGrupo = new SqlCommand(queryInsertGrupo, con))
                        {
                            cmdInsertGrupo.Parameters.AddWithValue("@fecha", fecha);
                            cmdInsertGrupo.Parameters.AddWithValue("@nombreGrupo", nombreGrupo);
                            idGrupo = (int)cmdInsertGrupo.ExecuteScalar();
                        }
                    }
                    con.Close();
                }

                // Asociar todos los empleados con asistencia de la fecha al grupo
                foreach (DataGridViewRow row in dgvEmpleado.Rows)
                {
                    if (row.Cells["idEmpleado"].Value != null && row.Cells["presente"].Value != null)
                    {
                        int idEmpleado = Convert.ToInt32(row.Cells["idEmpleado"].Value);
                        bool presente = Convert.ToBoolean(row.Cells["presente"].Value);

                        string queryInsertAsistencia = "INSERT INTO Asistencia (idEmpleado, fecha, presente, idGrupo) VALUES (@idEmpleado, @fecha, @presente, @idGrupo)";
                        using (SqlCommand cmdInsertAsistencia = new SqlCommand(queryInsertAsistencia, con))
                        {
                            cmdInsertAsistencia.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                            cmdInsertAsistencia.Parameters.AddWithValue("@fecha", fecha);
                            cmdInsertAsistencia.Parameters.AddWithValue("@presente", presente);
                            cmdInsertAsistencia.Parameters.AddWithValue("@idGrupo", idGrupo);
                            con.Open();
                            cmdInsertAsistencia.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            MessageBox.Show("Grupo y asistencias guardados exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DatosActualizados?.Invoke();
        }
    }
}

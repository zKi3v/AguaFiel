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
    public partial class venEmpleadoPermiso : Form
    {

        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS; Initial Catalog=RRHHAguaFiel; Integrated Security=True;";

        public venEmpleadoPermiso()
        {
            InitializeComponent();
        }

        private void LoadPermisos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT P.idPermiso, E.nombre + ' ' + E.apellido AS Empleado, P.tipoPermiso, P.descripcion, P.fechaSolicitud, P.estadoPermiso " +
                               "FROM Permisos P " +
                               "INNER JOIN Empleados E ON P.idEmpleado = E.idEmpleado";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPermisos.DataSource = dt;
                }
            }
        }

        private void venEmpleadoPermiso_Load(object sender, EventArgs e)
        {
            cbMotivo.Items.AddRange(new string[]
            {
                "Vacaciones",
                "Permiso Médico",
                "Asuntos Personales",
                "Capacitación",
                "Otro"
            });
            LoadPermisos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || cbMotivo.SelectedItem == null)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEmpleado = int.Parse(txtID.Text);
            string tipoPermiso = cbMotivo.SelectedItem.ToString();
            string descripcion = txtEspecificacion.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Permisos (idEmpleado, tipoPermiso, descripcion) VALUES (@idEmpleado, @tipoPermiso, @descripcion)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@tipoPermiso", tipoPermiso);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Permiso registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadPermisos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPermisos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un permiso para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPermiso = (int)dgvPermisos.SelectedRows[0].Cells["idPermiso"].Value;
            string nuevoTipoPermiso = cbMotivo.SelectedItem.ToString();
            string nuevaDescripcion = txtEspecificacion.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Permisos SET tipoPermiso = @tipoPermiso, descripcion = @descripcion WHERE idPermiso = @idPermiso";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@tipoPermiso", nuevoTipoPermiso);
                    cmd.Parameters.AddWithValue("@descripcion", nuevaDescripcion);
                    cmd.Parameters.AddWithValue("@idPermiso", idPermiso);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Permiso modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadPermisos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPermisos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un permiso para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPermiso = (int)dgvPermisos.SelectedRows[0].Cells["idPermiso"].Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Permisos WHERE idPermiso = @idPermiso";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idPermiso", idPermiso);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Permiso eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadPermisos();
        }
    }
}

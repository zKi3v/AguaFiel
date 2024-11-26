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
    public partial class venAsistenciaAprobacion : Form
    {
        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";

        public venAsistenciaAprobacion()
        {
            InitializeComponent();
            venAsistenciaReg regForm = new venAsistenciaReg();
            regForm.DatosActualizados += CargarGrupos;
        }
        private void CargarGrupos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM GruposAsistencia";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGrupos.DataSource = dt;
            }
        }
        private void venAsistenciaAprobacion_Load(object sender, EventArgs e)
        {
            CargarGruposAsistencia();
        }

        private void CargarGruposAsistencia()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT idGrupo, nombreGrupo, fecha, CASE WHEN aprobado = 1 THEN 'Sí' ELSE 'No' END AS aprobado FROM GruposAsistencia";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvGrupos.AutoGenerateColumns = true; // Permite generar columnas automáticamente
                dgvGrupos.DataSource = dt;
                dgvGrupos.Refresh();
            }
        }

        private void btnPermitir_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow != null)
            {
                int idGrupo = Convert.ToInt32(dgvGrupos.CurrentRow.Cells["idGrupo"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE GruposAsistencia SET aprobado = 1 WHERE idGrupo = @idGrupo";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Grupo de asistencia aprobado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGruposAsistencia(); // Actualiza la lista para reflejar cambios
            }
            else
            {
                MessageBox.Show("Seleccione un grupo de asistencia para aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void venAsistenciaAprobacion_Activated(object sender, EventArgs e)
        {
            CargarGrupos();
        }
    }
}

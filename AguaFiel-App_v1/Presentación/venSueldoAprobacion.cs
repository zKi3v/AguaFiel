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
    public partial class venSueldoAprobacion : Form
    {
        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";

        public venSueldoAprobacion()
        {
            InitializeComponent();
            venSueldoRevision regForm = new venSueldoRevision();
            regForm.DatosActualizados += CargarGruposSueldo;
        }

        private void venSueldoAprobacion_Load(object sender, EventArgs e)
        {
            CargarGruposSueldo();
        }

        private void CargarGruposSueldo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT idGrupoPago, tipoPago, fechaGeneracion, estado FROM GruposPago WHERE estado = 'Pendiente'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGruposSueldo.DataSource = dt;
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (dgvGruposSueldo.CurrentRow != null)
            {
                int idGrupoPago = Convert.ToInt32(dgvGruposSueldo.CurrentRow.Cells["idGrupoPago"].Value);

                // Aprobar el grupo de sueldo seleccionando el ID
                AprobarGrupoSueldo(idGrupoPago);
            }
            else
            {
                MessageBox.Show("Seleccione un grupo de sueldo para aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AprobarGrupoSueldo(int idGrupoPago)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Actualizar el estado del grupo de sueldo a 'Aprobado'
                string query = "UPDATE GruposPago SET estado = 'Aprobado' WHERE idGrupoPago = @idGrupoPago";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idGrupoPago", idGrupoPago);
                    cmd.ExecuteNonQuery();
                }

                // Mensaje de confirmación
                MessageBox.Show("El grupo de sueldo ha sido aprobado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar los grupos de sueldo
                CargarGruposSueldo();
            }
        }

        private void venSueldoAprobacion_Activated(object sender, EventArgs e)
        {
            CargarGruposSueldo();
        }
    }
}

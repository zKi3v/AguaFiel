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
    public partial class venSueldoLista : Form
    {

        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";

        public venSueldoLista()
        {
            InitializeComponent();
            venSueldoRevision regForm = new venSueldoRevision();
            regForm.DatosActualizados += MostrarDescuentoFaltas;
            CargarEmpleados();
            MostrarDescuentoFaltas();
        }

        private void MostrarDescuentoFaltas()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Descuento";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmpleado.DataSource = dt;
            }
        }

        private void CargarEmpleados()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT E.idEmpleado, E.nombre, E.apellido, C.nombreCargo, C.sueldo 
                         FROM Empleados E
                         JOIN Cargos C ON E.idCargo = C.idCargo
                         WHERE E.activo = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleado.DataSource = dt;
            }
        }

        private void venSueldoLista_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarEmpleados();
            MostrarDescuentoFaltas();
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

        private void dgvEmpleado_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void venSueldoLista_Activated(object sender, EventArgs e)
        {
            MostrarDescuentoFaltas();
        }
    }
}
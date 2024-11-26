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
    public partial class venEmpleadoLista : Form
    {
        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";

        public venEmpleadoLista()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void venEmpleadoLista_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT E.idEmpleado, E.nombre, E.apellido, E.fechaContrato, C.nombreCargo FROM Empleados E JOIN Cargos C ON E.idCargo = C.idCargo";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleado.AutoGenerateColumns = false;
                dgvEmpleado.DataSource = dt;
                dgvEmpleado.Refresh();
            }
        }

        private void venEmpleadoLista_Shown(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
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
    }
}

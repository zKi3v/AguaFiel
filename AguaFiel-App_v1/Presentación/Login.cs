using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AguaFiel_App_v1
{
    public partial class Login : Form
    {

        private string connectionString = "Data Source=DANIEL\\SQLEXPRESS;Initial Catalog=RRHHAguaFiel;Integrated Security=True;";
        
        Main main;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            txtPassword.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ingrese una contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbCargos.SelectedValue != null)
            {
                int idCargoLogin = Convert.ToInt32(cbCargos.SelectedValue);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT nombreCargo, password FROM CargosLogin WHERE idCargoLogin = @idCargoLogin";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idCargoLogin", idCargoLogin);
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombreCargo = reader["nombreCargo"].ToString();
                                string password = reader["password"].ToString();

                                if (txtPassword.Text == password)
                                {
                                    main = new Main(nombreCargo); // Pasar el rol directamente
                                    main.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña incorrecta. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cargo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cargo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCargos.SelectedIndexChanged += cbCargos_SelectedIndexChanged;

            if (cbCargos.SelectedValue != null)
            {
                int idCargoLogin = Convert.ToInt32(cbCargos.SelectedValue);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT sueldo FROM CargosLogin WHERE idCargoLogin = @idCargoLogin";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idCargoLogin", idCargoLogin);
                        con.Open();
                    }
                }
            }
        }

        private void CargarCargos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT idCargoLogin, nombreCargo FROM CargosLogin";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCargos.DisplayMember = "nombreCargo";
                cbCargos.ValueMember = "idCargoLogin";
                cbCargos.DataSource = dt;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            CargarCargos();
        }
    }
}

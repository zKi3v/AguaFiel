using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AguaFiel_App_v1
{
    public partial class Main : Form
    {
        public string UserRole { get; set; }

        bool sidebarExpand;
        bool sideheight;

        venInicio venInicio;
        venEmpleadoLista venEmpleadoLista;
        venEmpleadoReg venEmpleadoReg;
        venAsistenciaReg venAsistenciaReg;
        venSueldoLista venSueldoLista;
        venSueldoRevision venSueldoRevision;
        venEmpleadoPermiso venEmpleadoPermiso;
        venAsistenciaAprobacion venAsistenciaAprobacion;
        venSueldoAprobacion sueldoAprobacion;

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
        
        public Main(string userRole)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            mdiProp();
            UserRole = userRole;
            ConfigureActionsForRole();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void ConfigureActionsForRole()
        {
            switch (UserRole)
            {
                case "Analista de RR.HH":
                    //Sueldo
                    btnSueldo.Visible = true;
                    btnSueldoLista.Enabled = true;
                    btnAprobacionSueldo. Enabled = false;
                    btnRevision.Enabled = true;
                    //Asistencia
                    btnAsis.Visible = true;
                    btnAsisReg.Enabled = true;
                    btnAprobacion.Enabled = false;
                    //Empleado
                    btnEmployee.Visible = true;
                    btnEmpReg.Enabled = false;
                    btnEmpLista.Enabled = true;
                    btnPermisos.Enabled = false;
                    break;

                case "Jefe de RR.HH":
                    //Sueldo
                    btnSueldo.Visible = true;
                    btnSueldoLista.Enabled = true;
                    btnAprobacionSueldo.Enabled = false;
                    btnRevision.Enabled = false;
                    //Asistencia
                    btnAsis.Visible = true;
                    btnAsisReg.Enabled = false;
                    btnAprobacion.Enabled = true;
                    //Empleado
                    btnEmployee.Visible = true;
                    btnEmpReg.Enabled = true;
                    btnEmpLista.Enabled = true;
                    btnPermisos.Enabled = true;
                    break;

                case "Gerente":
                    //Sueldo
                    btnSueldo.Visible = true;
                    btnSueldoLista.Enabled = true;
                    btnAprobacionSueldo.Enabled = true;
                    btnRevision.Enabled = false;
                    //Asistencia
                    btnAsis.Visible = true;
                    btnAsisReg.Enabled = false;
                    btnAprobacion.Enabled = false;
                    //Empleado
                    btnEmployee.Visible = true;
                    btnEmpReg.Enabled = false;
                    btnEmpLista.Enabled = true;
                    btnPermisos.Enabled = false;
                    break;

                default:
                    MessageBox.Show("Rol desconocido. No se configuraron acciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void sidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flsidebar.Width -= 10;
                if (flsidebar.Width == flsidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar.Stop();
                }
            }
            else
            {
                flsidebar.Width += 10;
                if (flsidebar.Width == flsidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Start();
        }

        private void templ_Tick(object sender, EventArgs e)
        {
            if (sideheight)
            {
                pempl.Height -= 10;
                if (pempl.Height == pempl.MinimumSize.Height)
                {
                    sideheight = false;
                    templ.Stop();
                }
            }
            else
            {
                pempl.Height += 10;
                if (pempl.Height == pempl.MaximumSize.Height)
                {
                    sideheight = true;
                    templ.Stop();
                }
            }
        }  

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            templ.Start();
        }

        private void tasis_Tick(object sender, EventArgs e)
        {
            if (sideheight)
            {
                pasis.Height -= 10;
                if (pasis.Height == pasis.MinimumSize.Height)
                {
                    sideheight = false;
                    tasis.Stop();
                }
            }
            else
            {
                pasis.Height += 10;
                if (pasis.Height == pasis.MaximumSize.Height)
                {
                    sideheight = true;
                    tasis.Stop();
                }
            }
        }

        private void btnAsis_Click(object sender, EventArgs e)
        {
            tasis.Start();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            tsueldo.Start();
        }

        private void tsueldo_Tick(object sender, EventArgs e)
        {
            if (sideheight)
            {
                psueldo.Height -= 10;
                if (psueldo.Height == psueldo.MinimumSize.Height)
                {
                    sideheight = false;
                    tsueldo.Stop();
                }
            }
            else
            {
                psueldo.Height += 10;
                if (psueldo.Height == psueldo.MaximumSize.Height)
                {
                    sideheight = true;
                    tsueldo.Stop();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RestrictAccessBasedOnRole();
        }
        private void RestrictAccessBasedOnRole()
        {
            if (string.IsNullOrEmpty(UserRole))
            {
                MessageBox.Show("Error: El rol de usuario no está definido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rolePermissions = new Dictionary<string, List<Button>>
        {
            { "Gerente", new List<Button> { btnInicio } },
            { "Jefe de RR.HH", new List<Button> { btnInicio, btnRevision } },
            { "Analista de RR.HH", new List<Button> { btnInicio, btnSueldoLista } },
        };

            if (rolePermissions.TryGetValue(UserRole, out var allowedButtons))
            {
                foreach (Control control in Controls)
                {
                    if (control is Button button)
                        button.Visible = allowedButtons.Contains(button);
                }
            }
        }
        //venInicio

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (venInicio == null)
            {
                venInicio = new venInicio();
                venInicio.FormClosed += VenInicio_FormClosed;
                venInicio.MdiParent = this;
                venInicio.Dock = DockStyle.Fill;
                venInicio.Show();
            }
            else
            {
                venInicio.Activate();
            }
        }

        private void VenInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            venInicio = null;
        }

        //venEmpleadoReg
        private void btnEmpReg_Click(object sender, EventArgs e)
        {
            if (venEmpleadoReg == null)
            {
                venEmpleadoReg = new venEmpleadoReg();
                venEmpleadoReg.FormClosed += VenEmpleadoReg_FormClosed;
                venEmpleadoReg.MdiParent = this;
                venEmpleadoReg.Dock = DockStyle.Fill;
                venEmpleadoReg.Show();
            }
            else
            {
                venEmpleadoReg.Activate();
            }
        }

        private void VenEmpleadoReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            venEmpleadoReg = null;
        }

        //venAsistenciaReg
        private void btnAsisReg_Click(object sender, EventArgs e)
        {
            if (venAsistenciaReg == null)
            {
                venAsistenciaReg = new venAsistenciaReg();
                venAsistenciaReg.FormClosed += VenAsistenciaReg_FormClosed;
                venAsistenciaReg.MdiParent = this;
                venAsistenciaReg.Dock = DockStyle.Fill;
                venAsistenciaReg.Show();
            }
            else
            {
                venAsistenciaReg.Activate();
            }
        }

        private void VenAsistenciaReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            venAsistenciaReg = null;
        }

        //venEmpleadoLista
        private void btnEmpLista_Click(object sender, EventArgs e)
        {
            if (venEmpleadoLista == null)
            {
                venEmpleadoLista = new venEmpleadoLista();
                venEmpleadoLista.FormClosed += VenEmpleadoLista_FormClosed; ;
                venEmpleadoLista.MdiParent = this;
                venEmpleadoLista.Dock = DockStyle.Fill;
                venEmpleadoLista.Show();
            }
            else
            {
                venEmpleadoLista.Activate();
            }
        }

        private void VenEmpleadoLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            venEmpleadoLista = null;
        }

        //venSueldoLista
        private void btnSueldoLista_Click(object sender, EventArgs e)
        {
            if (venSueldoLista == null)
            {
                venSueldoLista = new venSueldoLista();
                venSueldoLista.FormClosed += VenSueldoLista_FormClosed;
                venSueldoLista.MdiParent = this;
                venSueldoLista.Dock = DockStyle.Fill;
                venSueldoLista.Show();
            }
            else
            {
                venSueldoLista.Activate();
            }
        }
        private void VenSueldoLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            venSueldoLista = null;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnRevision_Click(object sender, EventArgs e)
        {
            if (venSueldoRevision == null)
            {
                venSueldoRevision = new venSueldoRevision();
                venSueldoRevision.FormClosed += VenSueldoRevision_FormClosed; ;
                venSueldoRevision.MdiParent = this;
                venSueldoRevision.Dock = DockStyle.Fill;
                venSueldoRevision.Show();
            }
            else
            {
                venSueldoRevision.Activate();
            }
        }

        private void VenSueldoRevision_FormClosed(object sender, FormClosedEventArgs e)
        {
            venSueldoRevision = null;
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            if (venEmpleadoPermiso == null)
            {
                venEmpleadoPermiso = new venEmpleadoPermiso();
                venEmpleadoPermiso.FormClosed += VenEmpleadoPermiso_FormClosed; ;
                venEmpleadoPermiso.MdiParent = this;
                venEmpleadoPermiso.Dock = DockStyle.Fill;
                venEmpleadoPermiso.Show();
            }
            else
            {
                venEmpleadoPermiso.Activate();
            }
        }

        private void VenEmpleadoPermiso_FormClosed(object sender, FormClosedEventArgs e)
        {
            venEmpleadoPermiso = null;
        }

        private void btnAprobacion_Click(object sender, EventArgs e)
        {
            if (venAsistenciaAprobacion == null)
            {
                venAsistenciaAprobacion = new venAsistenciaAprobacion();
                venAsistenciaAprobacion.FormClosed += VenAsistenciaAprobacion_FormClosed; ;
                venAsistenciaAprobacion.MdiParent = this;
                venAsistenciaAprobacion.Dock = DockStyle.Fill;
                venAsistenciaAprobacion.Show();
            }
            else
            {
                venAsistenciaAprobacion.Activate();
            }
        }

        private void VenAsistenciaAprobacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            venAsistenciaAprobacion = null;
        }

        private void btnAprobacionSueldo_Click(object sender, EventArgs e)
        {
            if (sueldoAprobacion == null)
            {
                sueldoAprobacion = new venSueldoAprobacion();
                sueldoAprobacion.FormClosed += SueldoAprobacion_FormClosed; ;
                sueldoAprobacion.MdiParent = this;
                sueldoAprobacion.Dock = DockStyle.Fill;
                sueldoAprobacion.Show();
            }
            else
            {
                sueldoAprobacion.Activate();
            }
        }

        private void SueldoAprobacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            sueldoAprobacion = null;
        }
    }
}

namespace AguaFiel_App_v1
{
    partial class venEmpleadoPermiso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.idPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPERMISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.paneld1 = new AguaFiel_App_v1.paneld();
            this.paneld2 = new AguaFiel_App_v1.paneld();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspecificacion = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.paneld2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AllowUserToResizeColumns = false;
            this.dgvPermisos.AllowUserToResizeRows = false;
            this.dgvPermisos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPermiso,
            this.Empleado,
            this.TIPOPERMISO,
            this.fechaSolicitud,
            this.estadoPermiso,
            this.descripcion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermisos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPermisos.EnableHeadersVisualStyles = false;
            this.dgvPermisos.Location = new System.Drawing.Point(267, 264);
            this.dgvPermisos.MultiSelect = false;
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.ReadOnly = true;
            this.dgvPermisos.RowHeadersVisible = false;
            this.dgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisos.Size = new System.Drawing.Size(763, 281);
            this.dgvPermisos.TabIndex = 3;
            // 
            // idPermiso
            // 
            this.idPermiso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPermiso.DataPropertyName = "idPermiso";
            this.idPermiso.HeaderText = "ID";
            this.idPermiso.Name = "idPermiso";
            this.idPermiso.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empleado.DataPropertyName = "Empleado";
            this.Empleado.HeaderText = "EMPLEADO";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // TIPOPERMISO
            // 
            this.TIPOPERMISO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TIPOPERMISO.DataPropertyName = "tipoPermiso";
            this.TIPOPERMISO.HeaderText = "TIPO_PERMISO";
            this.TIPOPERMISO.Name = "TIPOPERMISO";
            this.TIPOPERMISO.ReadOnly = true;
            // 
            // fechaSolicitud
            // 
            this.fechaSolicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaSolicitud.DataPropertyName = "fechaSolicitud";
            this.fechaSolicitud.HeaderText = "FECHA_SOLICITUD";
            this.fechaSolicitud.Name = "fechaSolicitud";
            this.fechaSolicitud.ReadOnly = true;
            // 
            // estadoPermiso
            // 
            this.estadoPermiso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoPermiso.DataPropertyName = "estadoPermiso";
            this.estadoPermiso.HeaderText = "ESTADO_PERMISO";
            this.estadoPermiso.Name = "estadoPermiso";
            this.estadoPermiso.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "ESPECIFICACIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnModificar.Location = new System.Drawing.Point(856, 199);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 38);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(947, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // paneld1
            // 
            this.paneld1.BorderRadius = 30;
            this.paneld1.ColorBottom = System.Drawing.Color.Black;
            this.paneld1.ColorTop = System.Drawing.Color.Indigo;
            this.paneld1.Location = new System.Drawing.Point(243, 252);
            this.paneld1.Name = "paneld1";
            this.paneld1.Size = new System.Drawing.Size(810, 312);
            this.paneld1.TabIndex = 12;
            // 
            // paneld2
            // 
            this.paneld2.BorderRadius = 30;
            this.paneld2.ColorBottom = System.Drawing.Color.White;
            this.paneld2.ColorTop = System.Drawing.Color.White;
            this.paneld2.Controls.Add(this.label4);
            this.paneld2.Controls.Add(this.label1);
            this.paneld2.Controls.Add(this.cbMotivo);
            this.paneld2.Controls.Add(this.label2);
            this.paneld2.Controls.Add(this.btnRegistrar);
            this.paneld2.Controls.Add(this.label3);
            this.paneld2.Controls.Add(this.txtEspecificacion);
            this.paneld2.Controls.Add(this.txtID);
            this.paneld2.Location = new System.Drawing.Point(168, 11);
            this.paneld2.Name = "paneld2";
            this.paneld2.Size = new System.Drawing.Size(951, 576);
            this.paneld2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(271, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "SOLICITUD DE PERMISOS PARA EMPLEADOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(72, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese ID del empleado:";
            // 
            // cbMotivo
            // 
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Location = new System.Drawing.Point(233, 118);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(180, 21);
            this.cbMotivo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(97, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione el motivo:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRegistrar.Location = new System.Drawing.Point(729, 108);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 36);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(150, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Especifique:";
            // 
            // txtEspecificacion
            // 
            this.txtEspecificacion.Location = new System.Drawing.Point(233, 157);
            this.txtEspecificacion.Multiline = true;
            this.txtEspecificacion.Name = "txtEspecificacion";
            this.txtEspecificacion.Size = new System.Drawing.Size(286, 60);
            this.txtEspecificacion.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(233, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(69, 20);
            this.txtID.TabIndex = 0;
            // 
            // venEmpleadoPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 599);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.paneld1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.paneld2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "venEmpleadoPermiso";
            this.Text = "venEmpleadoPermisoSolicitar";
            this.Load += new System.EventHandler(this.venEmpleadoPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.paneld2.ResumeLayout(false);
            this.paneld2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEspecificacion;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMotivo;
        private paneld paneld1;
        private paneld paneld2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPERMISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}
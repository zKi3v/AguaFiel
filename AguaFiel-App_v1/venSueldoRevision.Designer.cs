namespace AguaFiel_App_v1
{
    partial class venSueldoRevision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneld1 = new AguaFiel_App_v1.paneld();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelec = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.chbxESS = new System.Windows.Forms.CheckBox();
            this.chbxGrati = new System.Windows.Forms.CheckBox();
            this.txtSueldoIngresado = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.btnReg = new System.Windows.Forms.Button();
            this.paneld2 = new AguaFiel_App_v1.paneld();
            this.paneld1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // paneld1
            // 
            this.paneld1.BackColor = System.Drawing.Color.Transparent;
            this.paneld1.BorderRadius = 30;
            this.paneld1.ColorBottom = System.Drawing.Color.White;
            this.paneld1.ColorTop = System.Drawing.Color.White;
            this.paneld1.Controls.Add(this.btnGuardar);
            this.paneld1.Controls.Add(this.cbPago);
            this.paneld1.Controls.Add(this.label7);
            this.paneld1.Controls.Add(this.btnSelec);
            this.paneld1.Controls.Add(this.txtNombre);
            this.paneld1.Controls.Add(this.txtApellido);
            this.paneld1.Controls.Add(this.txtCargo);
            this.paneld1.Controls.Add(this.chbxESS);
            this.paneld1.Controls.Add(this.chbxGrati);
            this.paneld1.Controls.Add(this.txtSueldoIngresado);
            this.paneld1.Controls.Add(this.dgvEmpleados);
            this.paneld1.Controls.Add(this.label6);
            this.paneld1.Controls.Add(this.label5);
            this.paneld1.Controls.Add(this.label4);
            this.paneld1.Controls.Add(this.label3);
            this.paneld1.Controls.Add(this.label2);
            this.paneld1.Controls.Add(this.label1);
            this.paneld1.Controls.Add(this.txtSueldo);
            this.paneld1.Controls.Add(this.dtpFechaContrato);
            this.paneld1.Controls.Add(this.btnReg);
            this.paneld1.Controls.Add(this.paneld2);
            this.paneld1.Location = new System.Drawing.Point(173, 29);
            this.paneld1.Name = "paneld1";
            this.paneld1.Size = new System.Drawing.Size(914, 543);
            this.paneld1.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(783, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 66);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "GUARDAR REGISTRO";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Location = new System.Drawing.Point(535, 199);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(144, 21);
            this.cbPago.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(532, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "PAGO:";
            // 
            // btnSelec
            // 
            this.btnSelec.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSelec.Location = new System.Drawing.Point(771, 256);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(112, 27);
            this.btnSelec.TabIndex = 48;
            this.btnSelec.Text = "SELECCIONAR";
            this.btnSelec.UseVisualStyleBackColor = true;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(360, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 47;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(360, 125);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 46;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(360, 162);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(121, 20);
            this.txtCargo.TabIndex = 45;
            // 
            // chbxESS
            // 
            this.chbxESS.AutoSize = true;
            this.chbxESS.Location = new System.Drawing.Point(535, 131);
            this.chbxESS.Name = "chbxESS";
            this.chbxESS.Size = new System.Drawing.Size(144, 17);
            this.chbxESS.TabIndex = 44;
            this.chbxESS.Text = "AFILIADO A ESSASULD";
            this.chbxESS.UseVisualStyleBackColor = true;
            this.chbxESS.CheckedChanged += new System.EventHandler(this.chbxESS_CheckedChanged);
            // 
            // chbxGrati
            // 
            this.chbxGrati.AutoSize = true;
            this.chbxGrati.Location = new System.Drawing.Point(535, 109);
            this.chbxGrati.Name = "chbxGrati";
            this.chbxGrati.Size = new System.Drawing.Size(143, 17);
            this.chbxGrati.TabIndex = 43;
            this.chbxGrati.Text = "TIENE GRATIFICACIÓN";
            this.chbxGrati.UseVisualStyleBackColor = true;
            this.chbxGrati.CheckedChanged += new System.EventHandler(this.chbxGrati_CheckedChanged);
            // 
            // txtSueldoIngresado
            // 
            this.txtSueldoIngresado.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSueldoIngresado.Location = new System.Drawing.Point(550, 154);
            this.txtSueldoIngresado.Name = "txtSueldoIngresado";
            this.txtSueldoIngresado.Size = new System.Drawing.Size(121, 20);
            this.txtSueldoIngresado.TabIndex = 41;
            this.txtSueldoIngresado.Tag = "Ingrese el sueldo...";
            this.txtSueldoIngresado.Text = "Ingrese el sueldo...";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeight = 35;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.nombre,
            this.apellido,
            this.fechaContrato,
            this.nombreCargo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.Color.LightGray;
            this.dgvEmpleados.Location = new System.Drawing.Point(34, 302);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 25;
            this.dgvEmpleados.RowTemplate.DividerHeight = 1;
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(849, 204);
            this.dgvEmpleados.TabIndex = 37;
            // 
            // idEmpleado
            // 
            this.idEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "ID";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 200F;
            this.nombre.HeaderText = "NOMBRES";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellido.DataPropertyName = "apellido";
            this.apellido.FillWeight = 200F;
            this.apellido.HeaderText = "APELLIDOS";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // fechaContrato
            // 
            this.fechaContrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaContrato.DataPropertyName = "fechaContrato";
            this.fechaContrato.HeaderText = "FECHA DE CONTRATO";
            this.fechaContrato.Name = "fechaContrato";
            this.fechaContrato.ReadOnly = true;
            // 
            // nombreCargo
            // 
            this.nombreCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCargo.DataPropertyName = "nombreCargo";
            this.nombreCargo.FillWeight = 200F;
            this.nombreCargo.HeaderText = "CARGO";
            this.nombreCargo.Name = "nombreCargo";
            this.nombreCargo.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(359, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "REVISIÓN DE SUELDOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(298, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "SUELDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(228, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "FECHA DE CONTRATO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(306, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "CARGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(285, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "APELLIDOS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(290, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRES:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(360, 242);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(121, 20);
            this.txtSueldo.TabIndex = 8;
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaContrato.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpFechaContrato.Location = new System.Drawing.Point(372, 203);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaContrato.TabIndex = 7;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnReg.Location = new System.Drawing.Point(559, 235);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(97, 37);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "REGISTRAR";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // paneld2
            // 
            this.paneld2.BorderRadius = 15;
            this.paneld2.ColorBottom = System.Drawing.Color.Black;
            this.paneld2.ColorTop = System.Drawing.Color.Indigo;
            this.paneld2.Location = new System.Drawing.Point(15, 299);
            this.paneld2.Name = "paneld2";
            this.paneld2.Size = new System.Drawing.Size(885, 224);
            this.paneld2.TabIndex = 38;
            // 
            // venSueldoRevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 599);
            this.Controls.Add(this.paneld1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "venSueldoRevision";
            this.Text = "venSueldoCalculo";
            this.Load += new System.EventHandler(this.venSueldoRevision_Load);
            this.paneld1.ResumeLayout(false);
            this.paneld1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private paneld paneld1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private paneld paneld2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtSueldoIngresado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.CheckBox chbxGrati;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.CheckBox chbxESS;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCargo;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
    }
}
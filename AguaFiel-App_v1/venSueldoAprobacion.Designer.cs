namespace AguaFiel_App_v1
{
    partial class venSueldoAprobacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPermitir = new System.Windows.Forms.Button();
            this.paneld2 = new AguaFiel_App_v1.paneld();
            this.dgvGruposSueldo = new System.Windows.Forms.DataGridView();
            this.idGrupoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaGeneracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneld1.SuspendLayout();
            this.paneld2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // paneld1
            // 
            this.paneld1.BackColor = System.Drawing.SystemColors.Control;
            this.paneld1.BorderRadius = 30;
            this.paneld1.ColorBottom = System.Drawing.Color.White;
            this.paneld1.ColorTop = System.Drawing.Color.White;
            this.paneld1.Controls.Add(this.label1);
            this.paneld1.Controls.Add(this.btnPermitir);
            this.paneld1.Controls.Add(this.paneld2);
            this.paneld1.Location = new System.Drawing.Point(174, 27);
            this.paneld1.Name = "paneld1";
            this.paneld1.Size = new System.Drawing.Size(944, 544);
            this.paneld1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(326, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "APROBACIÓN DE SUELDOS";
            // 
            // btnPermitir
            // 
            this.btnPermitir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPermitir.Location = new System.Drawing.Point(824, 110);
            this.btnPermitir.Name = "btnPermitir";
            this.btnPermitir.Size = new System.Drawing.Size(78, 37);
            this.btnPermitir.TabIndex = 1;
            this.btnPermitir.Text = "APROBAR";
            this.btnPermitir.UseVisualStyleBackColor = true;
            this.btnPermitir.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // paneld2
            // 
            this.paneld2.BorderRadius = 30;
            this.paneld2.ColorBottom = System.Drawing.Color.Black;
            this.paneld2.ColorTop = System.Drawing.Color.Indigo;
            this.paneld2.Controls.Add(this.dgvGruposSueldo);
            this.paneld2.Location = new System.Drawing.Point(25, 49);
            this.paneld2.Name = "paneld2";
            this.paneld2.Size = new System.Drawing.Size(753, 477);
            this.paneld2.TabIndex = 0;
            // 
            // dgvGruposSueldo
            // 
            this.dgvGruposSueldo.AllowUserToAddRows = false;
            this.dgvGruposSueldo.AllowUserToDeleteRows = false;
            this.dgvGruposSueldo.AllowUserToResizeColumns = false;
            this.dgvGruposSueldo.AllowUserToResizeRows = false;
            this.dgvGruposSueldo.BackgroundColor = System.Drawing.Color.White;
            this.dgvGruposSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGruposSueldo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGruposSueldo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGruposSueldo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGruposSueldo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGrupoPago,
            this.fechaGeneracion,
            this.tipoPago,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGruposSueldo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGruposSueldo.EnableHeadersVisualStyles = false;
            this.dgvGruposSueldo.Location = new System.Drawing.Point(21, 21);
            this.dgvGruposSueldo.MultiSelect = false;
            this.dgvGruposSueldo.Name = "dgvGruposSueldo";
            this.dgvGruposSueldo.ReadOnly = true;
            this.dgvGruposSueldo.RowHeadersVisible = false;
            this.dgvGruposSueldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGruposSueldo.Size = new System.Drawing.Size(710, 433);
            this.dgvGruposSueldo.TabIndex = 0;
            // 
            // idGrupoPago
            // 
            this.idGrupoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idGrupoPago.DataPropertyName = "idGrupoPago";
            this.idGrupoPago.HeaderText = "idGrupoPago";
            this.idGrupoPago.Name = "idGrupoPago";
            this.idGrupoPago.ReadOnly = true;
            // 
            // fechaGeneracion
            // 
            this.fechaGeneracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaGeneracion.DataPropertyName = "fechaGeneracion";
            this.fechaGeneracion.HeaderText = "fechaGeneracion";
            this.fechaGeneracion.Name = "fechaGeneracion";
            this.fechaGeneracion.ReadOnly = true;
            // 
            // tipoPago
            // 
            this.tipoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoPago.DataPropertyName = "tipoPago";
            this.tipoPago.HeaderText = "tipoPago";
            this.tipoPago.Name = "tipoPago";
            this.tipoPago.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // venSueldoAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 599);
            this.Controls.Add(this.paneld1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "venSueldoAprobacion";
            this.Text = "venSueldoAprobacion";
            this.Activated += new System.EventHandler(this.venSueldoAprobacion_Activated);
            this.Load += new System.EventHandler(this.venSueldoAprobacion_Load);
            this.paneld1.ResumeLayout(false);
            this.paneld1.PerformLayout();
            this.paneld2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruposSueldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private paneld paneld1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPermitir;
        private paneld paneld2;
        private System.Windows.Forms.DataGridView dgvGruposSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaGeneracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}
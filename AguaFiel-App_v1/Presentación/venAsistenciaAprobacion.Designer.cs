namespace AguaFiel_App_v1
{
    partial class venAsistenciaAprobacion
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
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.idGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneld1.SuspendLayout();
            this.paneld2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
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
            this.paneld1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(326, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "APROBACIÓN DE ASISTENCIAS";
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
            this.btnPermitir.Click += new System.EventHandler(this.btnPermitir_Click);
            // 
            // paneld2
            // 
            this.paneld2.BorderRadius = 30;
            this.paneld2.ColorBottom = System.Drawing.Color.Black;
            this.paneld2.ColorTop = System.Drawing.Color.Indigo;
            this.paneld2.Controls.Add(this.dgvGrupos);
            this.paneld2.Location = new System.Drawing.Point(25, 49);
            this.paneld2.Name = "paneld2";
            this.paneld2.Size = new System.Drawing.Size(753, 477);
            this.paneld2.TabIndex = 0;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.AllowUserToResizeColumns = false;
            this.dgvGrupos.AllowUserToResizeRows = false;
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGrupo,
            this.nombreGrupo,
            this.fecha,
            this.aprobado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupos.EnableHeadersVisualStyles = false;
            this.dgvGrupos.Location = new System.Drawing.Point(21, 21);
            this.dgvGrupos.MultiSelect = false;
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.RowHeadersVisible = false;
            this.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupos.Size = new System.Drawing.Size(710, 433);
            this.dgvGrupos.TabIndex = 0;
            // 
            // idGrupo
            // 
            this.idGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idGrupo.DataPropertyName = "idGrupo";
            this.idGrupo.HeaderText = "ID";
            this.idGrupo.Name = "idGrupo";
            this.idGrupo.ReadOnly = true;
            // 
            // nombreGrupo
            // 
            this.nombreGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreGrupo.DataPropertyName = "nombreGrupo";
            this.nombreGrupo.HeaderText = "NOMBRE";
            this.nombreGrupo.Name = "nombreGrupo";
            this.nombreGrupo.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // aprobado
            // 
            this.aprobado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aprobado.DataPropertyName = "aprobado";
            this.aprobado.HeaderText = "APROBADO?";
            this.aprobado.Name = "aprobado";
            this.aprobado.ReadOnly = true;
            // 
            // venAsistenciaAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 599);
            this.Controls.Add(this.paneld1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "venAsistenciaAprobacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "venAsistenciaAprobacion";
            this.Activated += new System.EventHandler(this.venAsistenciaAprobacion_Activated);
            this.Load += new System.EventHandler(this.venAsistenciaAprobacion_Load);
            this.paneld1.ResumeLayout(false);
            this.paneld1.PerformLayout();
            this.paneld2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private paneld paneld1;
        private System.Windows.Forms.Button btnPermitir;
        private paneld paneld2;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprobado;
    }
}
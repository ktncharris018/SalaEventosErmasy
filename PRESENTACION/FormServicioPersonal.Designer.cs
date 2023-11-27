namespace PRESENTACION
{
    partial class FormServicioPersonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblServicioPersonal = new System.Windows.Forms.DataGridView();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbTipoPersonal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblServicioPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio Personal";
            // 
            // tblServicioPersonal
            // 
            this.tblServicioPersonal.AllowUserToAddRows = false;
            this.tblServicioPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblServicioPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tblServicioPersonal.Location = new System.Drawing.Point(46, 132);
            this.tblServicioPersonal.Name = "tblServicioPersonal";
            this.tblServicioPersonal.Size = new System.Drawing.Size(545, 150);
            this.tblServicioPersonal.TabIndex = 2;
            // 
            // d
            // 
            this.d.HeaderText = "IdServicio";
            this.d.Name = "d";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdReserva";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TipoPersonal";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "cantidadHoras";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ValorServicio";
            this.Column4.Name = "Column4";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(229, 336);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 31);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbTipoPersonal
            // 
            this.cmbTipoPersonal.FormattingEnabled = true;
            this.cmbTipoPersonal.Items.AddRange(new object[] {
            "Logistica",
            "Musico"});
            this.cmbTipoPersonal.Location = new System.Drawing.Point(148, 82);
            this.cmbTipoPersonal.Name = "cmbTipoPersonal";
            this.cmbTipoPersonal.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPersonal.TabIndex = 7;
            this.cmbTipoPersonal.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoPersonal_SelectionChangeCommitted);
            this.cmbTipoPersonal.SelectedValueChanged += new System.EventHandler(this.cmbTipoPersonal_SelectedValueChanged);
            this.cmbTipoPersonal.Click += new System.EventHandler(this.cmbTipoPersonal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo Personal";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(78, 336);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 31);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar Servicios";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FormServicioPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoPersonal);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tblServicioPersonal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicioPersonal";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.tblServicioPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblServicioPersonal;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cmbTipoPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
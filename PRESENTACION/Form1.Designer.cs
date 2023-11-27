namespace PRESENTACION
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelServicios = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panePrueba = new System.Windows.Forms.Panel();
            this.btnReportePago = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panelServicios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 38);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.panel3.Controls.Add(this.btnReportePago);
            this.panel3.Controls.Add(this.panelServicios);
            this.panel3.Controls.Add(this.btnServicios);
            this.panel3.Controls.Add(this.btnCliente);
            this.panel3.Controls.Add(this.btnReserva);
            this.panel3.Controls.Add(this.btnInicio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 423);
            this.panel3.TabIndex = 3;
            // 
            // panelServicios
            // 
            this.panelServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.panelServicios.Controls.Add(this.button6);
            this.panelServicios.Controls.Add(this.button5);
            this.panelServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServicios.Location = new System.Drawing.Point(0, 180);
            this.panelServicios.Name = "panelServicios";
            this.panelServicios.Size = new System.Drawing.Size(211, 98);
            this.panelServicios.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(0, 40);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(211, 40);
            this.button6.TabIndex = 1;
            this.button6.Text = "SERVICIO INSTALACION";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(211, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "SERVICIO PERSONAL";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnServicios.Location = new System.Drawing.Point(0, 135);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServicios.Size = new System.Drawing.Size(211, 45);
            this.btnServicios.TabIndex = 3;
            this.btnServicios.Text = "SERVICIOS";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCliente.Location = new System.Drawing.Point(0, 90);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(211, 45);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReserva.Location = new System.Drawing.Point(0, 45);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReserva.Size = new System.Drawing.Size(211, 45);
            this.btnReserva.TabIndex = 1;
            this.btnReserva.Text = "RESERVAS";
            this.btnReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(211, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panePrueba
            // 
            this.panePrueba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panePrueba.Location = new System.Drawing.Point(210, 100);
            this.panePrueba.Name = "panePrueba";
            this.panePrueba.Size = new System.Drawing.Size(742, 423);
            this.panePrueba.TabIndex = 4;
            // 
            // btnReportePago
            // 
            this.btnReportePago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportePago.FlatAppearance.BorderSize = 0;
            this.btnReportePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePago.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReportePago.Location = new System.Drawing.Point(0, 278);
            this.btnReportePago.Name = "btnReportePago";
            this.btnReportePago.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportePago.Size = new System.Drawing.Size(211, 45);
            this.btnReportePago.TabIndex = 5;
            this.btnReportePago.Text = "REPORTE PAGO";
            this.btnReportePago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePago.UseVisualStyleBackColor = true;
            this.btnReportePago.Click += new System.EventHandler(this.btnReportePago_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 561);
            this.Controls.Add(this.panePrueba);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panelServicios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panePrueba;
        private System.Windows.Forms.Button btnReportePago;
    }
}


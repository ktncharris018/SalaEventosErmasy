namespace PRESENTACION
{
    partial class NewSerInstalacion
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
            this.txtTipoInstalacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.txtIdservicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTipoInstalacion
            // 
            this.txtTipoInstalacion.Enabled = false;
            this.txtTipoInstalacion.Location = new System.Drawing.Point(143, 149);
            this.txtTipoInstalacion.Name = "txtTipoInstalacion";
            this.txtTipoInstalacion.Size = new System.Drawing.Size(123, 20);
            this.txtTipoInstalacion.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAgregar.Location = new System.Drawing.Point(155, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 33);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Location = new System.Drawing.Point(36, 327);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 33);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(143, 180);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(143, 112);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(123, 20);
            this.txtIdReserva.TabIndex = 18;
            // 
            // txtIdservicio
            // 
            this.txtIdservicio.Enabled = false;
            this.txtIdservicio.Location = new System.Drawing.Point(143, 77);
            this.txtIdservicio.Name = "txtIdservicio";
            this.txtIdservicio.Size = new System.Drawing.Size(123, 20);
            this.txtIdservicio.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo Instalacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad de horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "FORMULARIO SERVICIO INSTALACION";
            // 
            // NewSerInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 372);
            this.Controls.Add(this.txtTipoInstalacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.txtIdservicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewSerInstalacion";
            this.Text = "NewSerInstalacion";
            this.Load += new System.EventHandler(this.NewSerInstalacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipoInstalacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.TextBox txtIdservicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
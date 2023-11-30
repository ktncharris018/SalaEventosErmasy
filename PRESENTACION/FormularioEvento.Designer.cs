namespace PRESENTACION
{
    partial class FormularioEvento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.dateTimeHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dateTimeHoraFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO RESERVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo Evento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observaciones";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Enabled = false;
            this.txtIdReserva.Location = new System.Drawing.Point(146, 82);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(155, 20);
            this.txtIdReserva.TabIndex = 8;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(146, 236);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(155, 20);
            this.txtCliente.TabIndex = 11;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(146, 318);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(155, 70);
            this.txtObservaciones.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(250, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearReserva.Location = new System.Drawing.Point(331, 405);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(75, 33);
            this.btnCrearReserva.TabIndex = 14;
            this.btnCrearReserva.Text = "Crear";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.btnCrearReserva_Click);
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Items.AddRange(new object[] {
            "Boda",
            "Cumpleaños"});
            this.cmbTipoEvento.Location = new System.Drawing.Point(146, 273);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(155, 21);
            this.cmbTipoEvento.TabIndex = 15;
            // 
            // dateTimeHoraInicio
            // 
            this.dateTimeHoraInicio.CustomFormat = "d";
            this.dateTimeHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHoraInicio.Location = new System.Drawing.Point(146, 156);
            this.dateTimeHoraInicio.Name = "dateTimeHoraInicio";
            this.dateTimeHoraInicio.Size = new System.Drawing.Size(155, 20);
            this.dateTimeHoraInicio.TabIndex = 16;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(146, 117);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(155, 20);
            this.txtFecha.TabIndex = 17;
            // 
            // dateTimeHoraFin
            // 
            this.dateTimeHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHoraFin.Location = new System.Drawing.Point(146, 196);
            this.dateTimeHoraFin.Name = "dateTimeHoraFin";
            this.dateTimeHoraFin.Size = new System.Drawing.Size(155, 20);
            this.dateTimeHoraFin.TabIndex = 18;
            // 
            // FormularioEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimeHoraFin);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dateTimeHoraInicio);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.btnCrearReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioEvento";
            this.Text = "FormularioEvento";
            this.Load += new System.EventHandler(this.FormularioEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.DateTimePicker dateTimeHoraInicio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DateTimePicker dateTimeHoraFin;
    }
}
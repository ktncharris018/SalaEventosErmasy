namespace PRESENTACION
{
    partial class FormInformeReservas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tblReservas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iluminacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservas)).BeginInit();
            this.MenuStrip2.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORME RESERVAS";
            // 
            // tblReservas
            // 
            this.tblReservas.AllowUserToAddRows = false;
            this.tblReservas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tblReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.tblReservas.ContextMenuStrip = this.MenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblReservas.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblReservas.GridColor = System.Drawing.Color.PaleTurquoise;
            this.tblReservas.Location = new System.Drawing.Point(28, 133);
            this.tblReservas.Name = "tblReservas";
            this.tblReservas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblReservas.Size = new System.Drawing.Size(654, 150);
            this.tblReservas.TabIndex = 1;
            this.tblReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblReservas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdReserva";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora Inicio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora Fin";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cliente";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo Evento";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.ContextMenuStrip = this.MenuStrip2;
            this.Column7.HeaderText = "Estado";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // MenuStrip2
            // 
            this.MenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagadoToolStripMenuItem});
            this.MenuStrip2.Name = "MenuStrip2";
            this.MenuStrip2.Size = new System.Drawing.Size(115, 26);
            // 
            // pagadoToolStripMenuItem
            // 
            this.pagadoToolStripMenuItem.Name = "pagadoToolStripMenuItem";
            this.pagadoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.pagadoToolStripMenuItem.Text = "Pagado";
            this.pagadoToolStripMenuItem.Click += new System.EventHandler(this.pagadoToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(176, 48);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logisticaToolStripMenuItem,
            this.musicoToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.item1ToolStripMenuItem.Text = "Servicio Personal";
            this.item1ToolStripMenuItem.Click += new System.EventHandler(this.item1ToolStripMenuItem_Click);
            // 
            // logisticaToolStripMenuItem
            // 
            this.logisticaToolStripMenuItem.Name = "logisticaToolStripMenuItem";
            this.logisticaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logisticaToolStripMenuItem.Text = "Logistica";
            this.logisticaToolStripMenuItem.Click += new System.EventHandler(this.logisticaToolStripMenuItem_Click);
            // 
            // musicoToolStripMenuItem
            // 
            this.musicoToolStripMenuItem.Name = "musicoToolStripMenuItem";
            this.musicoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.musicoToolStripMenuItem.Text = "Musico";
            this.musicoToolStripMenuItem.Click += new System.EventHandler(this.musicoToolStripMenuItem_Click);
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iluminacionToolStripMenuItem,
            this.sonidoToolStripMenuItem});
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.item2ToolStripMenuItem.Text = "Servicio Instalacion";
            this.item2ToolStripMenuItem.Click += new System.EventHandler(this.item2ToolStripMenuItem_Click);
            // 
            // iluminacionToolStripMenuItem
            // 
            this.iluminacionToolStripMenuItem.Name = "iluminacionToolStripMenuItem";
            this.iluminacionToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.iluminacionToolStripMenuItem.Text = "Iluminacion";
            this.iluminacionToolStripMenuItem.Click += new System.EventHandler(this.iluminacionToolStripMenuItem_Click);
            // 
            // sonidoToolStripMenuItem
            // 
            this.sonidoToolStripMenuItem.Name = "sonidoToolStripMenuItem";
            this.sonidoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sonidoToolStripMenuItem.Text = "Sonido";
            this.sonidoToolStripMenuItem.Click += new System.EventHandler(this.sonidoToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar por Evento";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Items.AddRange(new object[] {
            "Seleccionar",
            "Boda",
            "Cumpleaños"});
            this.cmbTipoEvento.Location = new System.Drawing.Point(161, 89);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEvento.TabIndex = 3;
            this.cmbTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEvento_SelectedIndexChanged);
            // 
            // FormInformeReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 377);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblReservas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInformeReservas";
            this.Text = "FormInformeReservas";
            ((System.ComponentModel.ISupportInitialize)(this.tblReservas)).EndInit();
            this.MenuStrip2.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblReservas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pagadoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolStripMenuItem logisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iluminacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonidoToolStripMenuItem;
    }
}
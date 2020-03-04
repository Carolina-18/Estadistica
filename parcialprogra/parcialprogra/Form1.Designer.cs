namespace parcialprogra
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
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cboa = new System.Windows.Forms.ComboBox();
            this.cbode = new System.Windows.Forms.ComboBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "monedas",
            "almacenamiento"});
            this.cbotipo.Location = new System.Drawing.Point(62, 44);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 21);
            this.cbotipo.TabIndex = 0;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // cboa
            // 
            this.cboa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboa.FormattingEnabled = true;
            this.cboa.Items.AddRange(new object[] {
            "Dólares               ",
            "Colones (SV)    ",
            "Yenes                 ",
            "Rupia                  ",
            "Peso (Chileno)   ",
            "Peso (MX)    ",
            "Peso (Argentino)",
            "Bitcoin    ",
            "Megabyte ",
            "bit ",
            "byte",
            "Kilobyte ",
            "Gigabyte",
            "Terabyte          "});
            this.cboa.Location = new System.Drawing.Point(62, 202);
            this.cboa.Name = "cboa";
            this.cboa.Size = new System.Drawing.Size(121, 21);
            this.cboa.TabIndex = 1;
            // 
            // cbode
            // 
            this.cbode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbode.FormattingEnabled = true;
            this.cbode.Items.AddRange(new object[] {
            "Dólares               ",
            "Colones (SV)    ",
            "Yenes                 ",
            "Rupia                  ",
            "Peso (Chileno)   ",
            "Peso (MX)    ",
            "Peso (Argentino)",
            "Bitcoin  ",
            "        ",
            "Megabyte ",
            "bit ",
            "byte",
            "Kilobyte ",
            "Gigabyte",
            "Terabyte   "});
            this.cbode.Location = new System.Drawing.Point(62, 127);
            this.cbode.Name = "cbode";
            this.cbode.Size = new System.Drawing.Size(121, 21);
            this.cbode.TabIndex = 2;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(268, 94);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(53, 13);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "respuesta";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(244, 45);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 4;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(89, 249);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(81, 37);
            this.btnconvertir.TabIndex = 5;
            this.btnconvertir.Text = "convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 135);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(22, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "DE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.cbode);
            this.Controls.Add(this.cboa);
            this.Controls.Add(this.cbotipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cboa;
        private System.Windows.Forms.ComboBox cbode;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
    }
}


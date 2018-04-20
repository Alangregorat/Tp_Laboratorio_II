namespace MiCalculadora
{
    partial class Form1
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
            this.CmbBox = new System.Windows.Forms.ComboBox();
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConvBin = new System.Windows.Forms.Button();
            this.BtnConvDec = new System.Windows.Forms.Button();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbBox
            // 
            this.CmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbBox.FormattingEnabled = true;
            this.CmbBox.Items.AddRange(new object[] {
            "/",
            "*",
            "-",
            "+"});
            this.CmbBox.Location = new System.Drawing.Point(183, 41);
            this.CmbBox.Name = "CmbBox";
            this.CmbBox.Size = new System.Drawing.Size(54, 21);
            this.CmbBox.TabIndex = 0;
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(12, 86);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(129, 40);
            this.BtnOperar.TabIndex = 1;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(156, 86);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(129, 40);
            this.BtnLimpiar.TabIndex = 2;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(305, 86);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(129, 40);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConvBin
            // 
            this.BtnConvBin.Location = new System.Drawing.Point(41, 132);
            this.BtnConvBin.Name = "BtnConvBin";
            this.BtnConvBin.Size = new System.Drawing.Size(168, 40);
            this.BtnConvBin.TabIndex = 4;
            this.BtnConvBin.Text = "Convertir a Binario";
            this.BtnConvBin.UseVisualStyleBackColor = true;
            this.BtnConvBin.Click += new System.EventHandler(this.BtnConvBin_Click);
            // 
            // BtnConvDec
            // 
            this.BtnConvDec.Location = new System.Drawing.Point(215, 132);
            this.BtnConvDec.Name = "BtnConvDec";
            this.BtnConvDec.Size = new System.Drawing.Size(168, 40);
            this.BtnConvDec.TabIndex = 5;
            this.BtnConvDec.Text = "Convertir a Decimal";
            this.BtnConvDec.UseVisualStyleBackColor = true;
            this.BtnConvDec.Click += new System.EventHandler(this.BtnConvDec_Click);
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(52, 42);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(100, 20);
            this.TxtBox1.TabIndex = 6;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(283, 42);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(100, 20);
            this.TxtBox2.TabIndex = 7;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(302, 9);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(0, 13);
            this.Lbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 192);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.BtnConvDec);
            this.Controls.Add(this.BtnConvBin);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.Controls.Add(this.CmbBox);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculadora de Alan Gregorat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBox;
        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConvBin;
        private System.Windows.Forms.Button BtnConvDec;
        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.Label Lbl;
    }
}


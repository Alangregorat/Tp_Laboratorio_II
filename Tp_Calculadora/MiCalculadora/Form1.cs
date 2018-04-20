using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            CenterToScreen();

        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(this.TxtBox1.Text);
            Numero num2 = new Numero(this.TxtBox2.Text);
            this.Lbl.Text = Calculadora.Operar(num1, num2, this.CmbBox.Text).ToString();
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.CmbBox.Text="";
            this.TxtBox1.Text = "";
            this.TxtBox2.Text = "";
            this.Lbl.Text = "";

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvBin_Click(object sender, EventArgs e)
        {
            Numero num = new Numero(this.Lbl.Text);
            this.Lbl.Text=num.BinarioDecimal(num.GetNumero.ToString());
           
            //Numero num3 = new Numero(this.Lbl.Text);
            //this.Lbl.Text = num3.BinarioDecimal(num3.GetNumero.ToString());

        }

        private void BtnConvDec_Click(object sender, EventArgs e)
        {
            Numero num = new Numero(this.Lbl.Text);
            this.Lbl.Text = num.DecimalBinario(num.GetNumero);
        }
    }
}

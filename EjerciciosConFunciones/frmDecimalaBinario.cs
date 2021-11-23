using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosConFunciones
{
    public partial class frmDecimalaBinario : Form
    {
        public frmDecimalaBinario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool esNumCorrecto=int.TryParse(this.txtEntero.Text,out int numero);
            if(!esNumCorrecto)
            {
                MessageBox.Show("Debe Ingresar un valor numerico");
                return;
            }

            if(!(numero>=0 && numero<= 255))
            {
                MessageBox.Show("Numero fuera de rango... ");
                return;
                    
            }

            int num1 = int.Parse(this.txtEntero.Text);
            int [] res = binario(num1);
            Console.WriteLine("Inicio");
            for(int i=res.Length; i>=0; i--)
            {
                Console.WriteLine("{0}", res[i]);
            }
            Console.WriteLine("fin");


            this.checkBox8.Checked = res[7] == 1 ? true : false;
            this.checkBox7.Checked = res[6] == 1 ? true : false;
            this.checkBox6.Checked = res[5] == 1 ? true : false;
            this.checkBox5.Checked = res[4] == 1 ? true : false;
            this.checkBox4.Checked = res[3] == 1 ? true : false;
            this.checkBox3.Checked = res[2] == 1 ? true : false;
            this.checkBox2.Checked = res[1] == 1 ? true : false;
            this.checkBox1.Checked = res[0] == 1 ? true : false;
                       
           /*
           if (checkBox1.Checked)
            {
                this.checkBox1.Checked = true;               
            }            
           else if (checkBox2.Checked)
            {
                this.checkBox2.Checked = true;
            }
           else if (checkBox3.Checked)
            {
                this.checkBox3.Checked = true;
            }
           else if (checkBox4.Checked)
            {
                this.checkBox4.Checked = true;
            }
           else if (checkBox5.Checked)
            {
                this.checkBox5.Checked = true;
            }
           else if (checkBox6.Checked)
            {
                this.checkBox6.Checked = true;
            }
           else if (checkBox7.Checked)
            {
                this.checkBox7.Checked = true;
            }
           else if (checkBox8.Checked)
            {
                this.checkBox8.Checked = true;
            }
           */
           
            
        }

        
        private int[] binario(int num)
        {
            int[] bin = { 0, 0, 0, 0, 0, 0, 0, 0 };
            //int[]bin=new int[8];

            int i = 0;
            int resto = 0;
            while(num >0 )
            {
                resto = num % 2;
                bin[i++] = resto;
                num = num / 2;
                Console.WriteLine("{0}", resto);
            }

            return bin;
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (checkBox1.Checked) num += 1;
            if (checkBox2.Checked) num += 2;
            if (checkBox3.Checked) num += 4;
            if (checkBox4.Checked) num += 8;
            if (checkBox5.Checked) num += 16;
            if (checkBox6.Checked) num += 32;
            if (checkBox7.Checked) num += 64;
            if (checkBox8.Checked) num += 128;
            this.txtEntero.Text = num.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sumarBinarioaDecimal();
        }
        void sumarBinarioaDecimal()
        {
            int num = 0;
            if (checkBox1.Checked) num += 1;
            if (checkBox2.Checked) num +=2;
            if (checkBox3.Checked) num +=4;
            if (checkBox4.Checked) num += 8;
            if (checkBox5.Checked) num += 16;
            if (checkBox6.Checked) num += 32;
            if (checkBox7.Checked) num += 64;
            if (checkBox8.Checked) num += 128;

            this.txtEntero.Text = num.ToString();
                    

        }
    }
}

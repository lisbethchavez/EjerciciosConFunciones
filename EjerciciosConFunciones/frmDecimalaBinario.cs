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
            int numero = int.Parse(this.txtEntero.Text);
            int [] res = binario(numero);
            Console.WriteLine("Inicio");
            for(int i=res.Length; i>=0; i--)
            {
                Console.WriteLine("{0}", res[i]);
            }
            Console.WriteLine("fin");

            


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
    }
}

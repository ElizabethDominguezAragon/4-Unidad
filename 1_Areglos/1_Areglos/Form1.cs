using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Areglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random(Environment.TickCount);
            int[] Areglo_Numero = new int[8];
            int[] Areglo_Cuadrado = new int[8];
            for (int i = 0; i < 8; i++) {
                int Numero = aleatorio.Next(1, 10);
                Areglo_Numero[i] = Numero;
                Areglo_Cuadrado[i] = Numero * Numero;
            }
            for (int i = 0; i < 8; i++)
            {
                MessageBox.Show("el cuadrado del numero: " + Areglo_Numero[i] + " es " + Areglo_Cuadrado[i]);
   
            }

        }
    }
}

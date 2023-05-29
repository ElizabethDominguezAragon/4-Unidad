using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglos_Invertidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            NumerosInvertidos.Items.Clear();
            NumerosRamdom.Items.Clear();
            Random rm = new Random(Environment.TickCount);
            int[] Arreglo = new int[20];
           
            for (int i = 0; i < 20; i++){
                Arreglo[i] = rm.Next(10,150);
                NumerosRamdom.Items.Add(" ৹  " + Arreglo[i]);
            }
           
            for (int i = 19; i >=0; i--){
                NumerosInvertidos.Items .Add(" ৹  " + Arreglo[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumerosRamdom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumerosInvertidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

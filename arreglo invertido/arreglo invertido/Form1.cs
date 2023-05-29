using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglo_invertido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            int[] Ar1 = new int[20];
            int[] Ar2 = new int[20];

            Random ale =new Random();
            
            for (int i = 0; i < 20; i++)
            {
                int num = ale.Next(10, 150);
                Ar1[i] = num;
                Lista1.Items.Add(num);
                Ar2[19 - i] = num;
                Lista2.Items.Add(num);
            }
        }
    }
}

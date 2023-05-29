namespace Arreglos_Matrices1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LLenarMatriz_Click(object sender, EventArgs e)
        {
            Random rm = new Random();
            int numero =rm.Next(50,250);
            int[,] matriz= new int[4,3];
            int[] sumaRenglones = new int[4];
            int suma = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numero = rm.Next(50, 250);
                    matriz[i, j] = numero;
                    suma += numero;
                }
                sumaRenglones[i] = suma;
                suma =0;
            }
            
        }
    }
}
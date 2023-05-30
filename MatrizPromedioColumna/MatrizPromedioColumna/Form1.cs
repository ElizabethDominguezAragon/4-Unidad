namespace MatrizPromedioColumna
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
            int numero = rm.Next(50, 250);
            int[,] matriz = new int[4, 3];
            int[] sumaRenglones = new int[3];
            int SUMAfila = 0, promedio=0;
            string mensaje = "", ImprimirM="";
            //llenar matrisz
            for (int i = 0; i < 4; i++){
                for (int j = 0; j < 3; j++){
                    numero = rm.Next(50, 250);
                    matriz[i, j] = numero;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ImprimirM += "["+ matriz[i, j]+"] ";
                }
                ImprimirM += "\n";
            }

            for (int i = 0; i < 3; i++){
                SUMAfila = 0;
                for (int j = 0; j < 4; j++)
                {
                    SUMAfila += matriz[j, i];
                }
                promedio = (SUMAfila / 4);
                mensaje += "el promedio de la fila " + (i + 1) + " es: " + promedio + "\n";
            }
            MessageBox.Show(ImprimirM + mensaje);

        }
        
    }
}
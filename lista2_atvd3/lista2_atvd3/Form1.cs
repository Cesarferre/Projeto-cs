using System.Configuration;

namespace lista2_atvd3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numerodaconta = new int[2];
        string[] titular = new string[2];
        string[] tipomovimento = new string[2];
        float[] valor = new float[2];


        int x = 0, y;
        float saldo = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            numerodaconta[x] = int.Parse(txtnumero.Text);
            titular[x] = txttitular.Text;
            tipomovimento[x] = cmbmovimentacao.Text;
            valor[x] = float.Parse(txtvalor.Text);

            x++;

            txtnumero.Clear();
            txttitular.Clear();
            txtvalor.Clear();

            if (x == 2)
            {
                btncalcular.Enabled = false;

                for (y = 0; y < valor.Length; y++)
                {
                    if (tipomovimento[y] == "Deposito")
                    {
                        saldo = (saldo - valor[y]);
                    }
                    else
                    {
                        saldo = (saldo + valor[y]);
                    }

                    lstresultado.Items.Add(numerodaconta[y] + " - " + titular[y] + " - " + tipomovimento[y] + " - " + valor[y] + " - " + saldo);
                }
            }

        }
    }
}
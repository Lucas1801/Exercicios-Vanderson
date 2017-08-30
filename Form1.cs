//Lucas Rodrigues Chaves 1601259
//Ronaldo de souza santos 1600715
//Raphael Rodrigues 1510203
//Leando Tadeu 1600328
//Isak Silva 1600364
//Wesley Saldanha Rosa 141198


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
          public Form1()
        {
            InitializeComponent();
        }
       
          public void Exercicio1()
          {
              int soma = 0;
              for (int i = 0; i <= 100; i++)
              {
                  soma = soma + i;
              }
              MessageBox.Show("Resultado da soma dos numeros de 1 a 100 é: " + soma);
          }
        //--------------------------------------------------------------------
          public void Exercicio2()
          {
              //exercicio 2

              int resultado;
            String menssagem = String.Empty;
              for (int j = 1; j <= 200; j++)
              {
                  resultado = 7 * j;
                  if (resultado < 200)
                  {
                    menssagem += (resultado).ToString() + Environment.NewLine;
                }

              }
            MessageBox.Show(menssagem);
        }
        //--------------------------------------------------------------------
          public void Exercicio3()
          {
           
            //exercicio 3 
            int numero;
            String menssagem = String.Empty;
            for (numero = 1; numero <= 100; numero++)
            {
                if (numero % 4 == 0)
                    menssagem += (numero).ToString() + Environment.NewLine;
            }
           
            MessageBox.Show(menssagem);
        }
        //-------------------------------------------------------------------
          public void Exercicio4()
          {
              double resultado = 0;
              double numeroUsuario = Convert.ToInt32(txtExercicio4.Text);
              int sinal = 1;

              for (int i = 1; i <= 3; i++)
              {
                  resultado += sinal * (numeroUsuario / i);
                  sinal *= -1;
                  MessageBox.Show(Convert.ToString(resultado));  
              }
              
          }
        //--------------------------------------------------------------------
          public void Exercicio5()
          {
              //exercicio 5
              int a = 0;
              
              string menssagem = string.Empty;
              
              
              
              
            
                for (int c = 0; c <= 10; c++)
                {
                while (a <= c)

                {
                    menssagem += (c * 5).ToString() + Environment.NewLine;
                    a++;

                }
               
            }
            MessageBox.Show(menssagem);
        }
        //--------------------------------------------------------------------
          private void Exercicio6()
          {
              string tabuada = string.Empty;

              int numeroUsuario = Convert.ToInt32(txttabuada.Text);
              for (int i = 1; i <= 10; i++)
              {
                  
                  tabuada += (numeroUsuario + " x " + i + "=" +numeroUsuario * i).ToString() + Environment.NewLine;
              }
              MessageBox.Show(tabuada);
          }

        private void Exercicio7()
        {
            double valorP = 10, valorV = 20;
            int nProdutosP = 0, nProdutosV = 0;
            nProdutosP = (Convert.ToInt32(txtP.Text)); 
            nProdutosV = (Convert.ToInt32(txtV.Text));

            double valorTotal = ((nProdutosP * valorP) + (nProdutosV * valorV));
            MessageBox.Show("Valor total é :" + valorTotal);
             

        }

       




        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio1();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            Exercicio2();
        }
        
        
        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            Exercicio3();
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            Exercicio5();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercicio6();
        }

        private void txttabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                e.Handled = true;

        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            Exercicio4();
        }

        private void txtExercicio4_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            Exercicio7();

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

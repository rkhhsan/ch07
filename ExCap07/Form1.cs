using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCap07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 1; // 
        double number; //     
        double maior; // 
        double segundoMaior;
        double menor;
        double soma;
        double media;
        bool primeiraVez = true;
        bool segundaVez = false;

        public static double n;
        public static decimal i, PV, PMT, FV;

        public static decimal S(decimal i, double n)
        {
            i = i / 100;
            decimal q = 1 + i;
            decimal s = (decimal)(Math.Pow((double)q, n) - 1);

            return s / i;
        }

        public static decimal A(decimal i, double n)
        {
            i = i / 100;
            decimal q = 1 + i;
            decimal a = (decimal)(1 - Math.Pow((double)q, -n));

            return a / i;
        }

        private void IncluiButton_Click(object sender, EventArgs e)
        {
            displayListBox.Font = new Font("Courier", 12);
            if (inputTextBox.Text != "")
            {
                displayListBox.Items.Add(inputTextBox.Text);
                number = Convert.ToDouble(inputTextBox.Text);
                if (primeiraVez)
                {
                    menor = maior = segundoMaior = soma = number;
                    primeiraVez = false;
                    segundaVez = true;
                }
                else if (segundaVez)
                {
                    counter++;
                    soma = soma + number;
                    segundaVez = false;
                    if (number > maior)
                    {
                        maior = number;
                    }
                    else if (number < menor)
                    {
                        menor = segundoMaior = number;
                    }

                }
                else
                {
                    counter++;
                    soma = soma + number;
                    if (number >= maior)
                    {
                        segundoMaior = maior;
                        maior = number;
                    }
                    else if (number < menor)
                    {
                        menor = number;
                    }
                    else if ((number > segundoMaior) && (number <= maior))
                    {
                        segundoMaior = number;
                    }
                }
                inputTextBox.Clear();
                inputTextBox.Focus();
            }
            else
                inputTextBox.Focus();

        }

        private void RemoveButt_Click(object sender, EventArgs e)
        {
            // check whether item is selected; if so, remove
            if (displayListBox.SelectedIndex != -1)
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
            // end method removeButton_Click
        }

        private void LimpaButt_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            menor = maior = segundoMaior = soma = 0;
            primeiraVez = true;
            segundaVez = false;
            counter = 1;
            inputTextBox.Focus();
            displayListBox.Font = new Font("Courier", 12);
        }

        private void Ex5_23_Click(object sender, EventArgs e)
        {
            media = (double)soma / counter;
            displayListBox.Items.Add("O maior valor é: " + Convert.ToString(maior));
            displayListBox.Items.Add("O segundo maior valor é: " + Convert.ToString(segundoMaior));
            displayListBox.Items.Add("O menor valor é: " + Convert.ToString(menor));
            displayListBox.Items.Add("A soma é: " + Convert.ToString(soma));
            displayListBox.Items.Add("A média é: " + Convert.ToString(media));
        }

        private void Ex6_13_Click(object sender, EventArgs e)
        {
            displayListBox.Font = new Font("Courier", 12);
            double fat = 1;
            int j;
            number = Convert.ToInt32(inputTextBox.Text);
            for (int i = 1; i <= number; i++)
            {
                for (j = 1; j <= i; ++j)
                    fat = (double)fat * j;
                displayListBox.Items.Add("O fatorial de " + Convert.ToString(j - 1) + " é " + Convert.ToString(fat));
                fat = 1;
            }
        }

        private void Ex6_15_Click(object sender, EventArgs e)
        {
            string str = "";
            string esp = "  ";
            int i, j;
            displayListBox.Font = new Font("Courier New", 14);

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                    str = str + " *";
                displayListBox.Items.Add(str);
                str = "";
            }

            displayListBox.Items.Add("");//linha em branco

            for (i = 10; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                    str = str + " *";
                displayListBox.Items.Add(str);
                str = "";
            }

            displayListBox.Items.Add("12345678901234567890");//linha em branco

            for (i = 0; i <= 9; i++)
            {

                for (j = 1; j <= i; j++)
                    str = str + esp;
                for (j = 1; j <= 10 - i; j++)
                    str = str + "* ";
                displayListBox.Items.Add(str);
                str = "";
            }

            displayListBox.Items.Add("12345678901234567890");//linha em branco
            str = "";
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                    str = str + esp;
                for (j = 1; j <= i; j++)
                    str = str + "* ";
                displayListBox.Items.Add(str);
                str = "";
            }

        }

        private void FV_but_Click(object sender, EventArgs e)
        {

            PMT = Convert.ToDecimal(PMT_textBox.Text);
            n = Convert.ToDouble(n_textBox.Text);
            i = Convert.ToDecimal(i_textBox.Text);
            PV = Convert.ToDecimal(PV_textBox.Text);
            FV = PMT * S(i, n) + (PV * (decimal)Math.Pow(1 + (double)(i / 100), n));

            FV_textBox.Text = Convert.ToString(-FV);
        }

        private void PV_but_Click(object sender, EventArgs e)
        {
            PMT = Convert.ToDecimal(PMT_textBox.Text);
            n = Convert.ToDouble(n_textBox.Text);
            i = Convert.ToDecimal(i_textBox.Text);
            FV = Convert.ToDecimal(FV_textBox.Text);
            PV = PMT * A(i, n) + (FV / (decimal)Math.Pow(1 + (double)(i / 100), n));

            PV_textBox.Text = Convert.ToString(-PV);

        }

        private void PMT_but_Click(object sender, EventArgs e)
        {
            PV = Convert.ToDecimal(PV_textBox.Text);
            n = Convert.ToDouble(n_textBox.Text);
            i = Convert.ToDecimal(i_textBox.Text);
            FV = Convert.ToDecimal(FV_textBox.Text);
            PMT = FV + PV * (decimal)Math.Pow(1 + (double)(i / 100), n);
            PMT = PMT / S(i, n);
            PMT_textBox.Text = Convert.ToString(-PMT);

        }

        private void n_but_Click(object sender, EventArgs e)
        {
            PV = Convert.ToDecimal(PV_textBox.Text);
            i = Convert.ToDecimal(i_textBox.Text);
            i = i/100;
            FV = Convert.ToDecimal(FV_textBox.Text);
            PMT = Convert.ToDecimal(PMT_textBox.Text);
            n = Math.Log((double)(PMT - FV * i) / (double)(PV * i + PMT));
            n = n / Math.Log(1 + (double)i);
            n_textBox.Text = Convert.ToString(n);
        }


    }
}

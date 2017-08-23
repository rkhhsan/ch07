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

        private void IncluiButton_Click(object sender, EventArgs e)
        {
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


    }
}

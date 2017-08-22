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

        private void button1_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add(inputTextBox.Text);
            inputTextBox.Clear();
            inputTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // check whether item is selected; if so, remove
            if (displayListBox.SelectedIndex != -1)
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
            // end method removeButton_Click
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
        }
    }
}

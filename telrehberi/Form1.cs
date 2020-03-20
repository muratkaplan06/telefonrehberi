using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telrehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);


            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("lutfen listeden bir secim yapın");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                if (listBox1.Items[i].ToString().ToLower().Contains(txtBul.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                    listBox2.Items.Add(listBox1.Items[i + 1]);
                }

            }
            txtBul.Clear();
        }
    }
}

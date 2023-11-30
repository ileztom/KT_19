using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KT_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 150;
            int b = 200;
            int c = 190;
            int price = 0;
            int value;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (Int32.TryParse(textBox1.Text, out value))
                    {
                        price += b * value;
                    }
                    else
                    {
                        MessageBox.Show("Введите количество товаров");
                    }
                    listBox1.Items.Add(comboBox1.SelectedItem + " " + Convert.ToString(textBox1.Text));
                    textBox1.Text = "";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (Int32.TryParse(textBox1.Text, out value))
                    {
                        price += c * value;
                    }
                    else
                    {
                        MessageBox.Show("Введите количество товаров");
                    }
                    listBox1.Items.Add(comboBox1.SelectedItem + " " + Convert.ToString(textBox1.Text));
                    textBox1.Text = "";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    if (Int32.TryParse(textBox1.Text, out value))
                    {
                        price += a * value;
                    }
                    else
                    {
                        MessageBox.Show("Введите количество товаров");
                    }
                    listBox1.Items.Add(comboBox1.SelectedItem + " " + Convert.ToString(textBox1.Text));
                    textBox1.Text = "";
                }
                int price2 = price;
                label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + price2);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите элемент для удаления");
            }
            else
            {
                string s = listBox1.SelectedItem.ToString();
                string []words = s.Split(' ');
                int press = Convert.ToInt32(words[2]);
                label5.Text = (Convert.ToInt32(label5.Text)-press).ToString();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
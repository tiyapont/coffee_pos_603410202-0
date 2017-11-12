using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410202_0
{
    public partial class Form1 : Form
    {
        string coff = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void listm(string Menu, string Bath)
        {
            string[] name = { Menu, Bath };
            var listm = new ListViewItem(name);
            listView1.Items.Add(listm);
            lis();
        }
        private void button42_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listm("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listm("Esspresso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listm("Esspresso(Frappe)", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listm("Americano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listm("Americano(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listm("Latte(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listm("Latte(Ice)", "45");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listm("Latte(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listm("Mocha(Hot)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listm("Mocha(Ice)", "45");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listm("Mocha(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listm("Cappuccino(Hot)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listm("Cappuccino(Ice)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listm("Cappuccino(Frappe)", "50");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listm("Greentea(Hot)", "20");

        }

        private void button17_Click(object sender, EventArgs e)
        {
            listm("Greentea(Ice)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listm("Greentea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listm("Thaitea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listm("Thaitea(Ice)", "25");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listm("Thaitea(Frappe)", "30");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listm("Cocoa(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            listm("Cocoa(Ice)", "25");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listm("Cocoa(Frappe)", "30");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            listm("Milk(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            listm("Milk(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            listm("Milk(Frappe)", "30");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            listm("Milktea(Ice)", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listm("Milktea(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            listm("Lemontea(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            listm("Lemontea(Frappe)", "30");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            listm("Milo(Hot)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            listm("Milo(Ice)", "25");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            listm("Milo(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            listm("Nescafe(Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            listm("Nescafe(Ice)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            listm("Nescafe(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            listm("Nesteatea(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            listm("Nesteatea(Ice)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            listm("Nesteatea(Frappe)", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            listm("Italian Soda", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            listm("Red Lime Soda", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            listm("Honey Lime Soda", "25");
        }
        double bath;
        public string[] lis()
        {
            bath = 0;
            string[] it = new string[listView1.Items.Count];
            int it1 = listView1.Items.Count;
            for (int i = 0; i < it1; i++)
            {
                bath += double.Parse(listView1.Items[i].SubItems[1].Text);
                it[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label27.Text = bath.ToString();
            return it;
        }
        public void pm()
        {
            string[] x = lis();
            string[] y = lis();
            string date = "KKU_Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string date2 = "KKU_Coffee";
            date2 += "\r\n";
            for(int i = 0;i<listView1.Items.Count;i++)
            {
                date2 += x[i] + new string(' ', 20) + "\r\n";
            }
            date2 += "\r\n";
            date2 += "Total Price :" + label27.Text;
            System.IO.File.WriteAllText(coff + @"\" + date + ".txt", date2);
            textBox1.Text += date2 + "\r\n" + "\r\n" + "\r\n" + "Save File at" + x + @"\" + coff + ".txt";
        }
        bool pay = false;
        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (pay == false)
            {
                tabControl1.TabPages.Insert(1, tabPage2);
                pay = true;
                tabControl1.SelectedTab = tabPage2;
            }
            else tabControl1.SelectedTab = tabPage2;
            if (listView1.Items.Count > 0)
                pm();                                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPage2);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            pay = false;
            tabControl1.Controls.Remove(tabPage2);
            label27.Text = "";
            textBox1.Text = "";
        }
    }
}

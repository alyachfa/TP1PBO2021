using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        private void login(object sender, EventArgs e)
        {

                if (String.Equals(Convert.ToString(TextBox2.Text), "pbo123") && Convert.ToString(TextBox1.Text) != "")
                {
                    MenuUtama Menut = new MenuUtama();

                    Menut.ShowDialog();
                    this.Show();
                    MessageBox.Show("Kamu berhasil login");
                }
                else if (TextBox1.Text == "" && TextBox2.Text == "")
                {
                    MessageBox.Show("Kamu belum mengisi form login");
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah");
                }
            }
    }
}

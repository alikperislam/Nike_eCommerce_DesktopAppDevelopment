using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nike
{
    public partial class FORMLOGİN : Form
    {
        public FORMLOGİN()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text=="personel" && bunifuMaterialTextbox2.Text=="123456")
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış...");
            }
        }
    }
}

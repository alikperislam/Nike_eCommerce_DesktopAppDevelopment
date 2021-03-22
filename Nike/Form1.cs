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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formGetir(Form frm)
        {
            panelAna.Controls.Clear();// ana paneli temizledik ilk.
            frm.MdiParent = this;
            panelAna.Controls.Add(frm);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelalt.BackColor=Color.FromArgb(200,64, 233);
            panelsol.BackColor=Color.FromArgb(200,64, 233);
            panelüst.BackColor=Color.FromArgb(200,64, 233);
            comboBoxKrampon.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxJordan.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKaykay.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxSalon.BackColor = Color.FromArgb(200, 64, 233);

            /////////////

            if (comboBoxKrampon.Text=="Mercuriel Neymar jr.")
            {
                formNeymar fr = new formNeymar();
                formGetir(fr);
            }
            if (comboBoxKrampon.Text == "Mercuriel Vapor 13")
            {
                formMercurielVapor13 fr1 = new formMercurielVapor13();
                formGetir(fr1);
            }
            if (comboBoxKrampon.Text == "Phantom Vision Pro")
            {
                formVisible fr2 = new formVisible();
                formGetir(fr2);
            }
            if (comboBoxKrampon.Text == "Phantom GT")
            {
                formPhantom fr3 = new formPhantom();
                formGetir(fr3);
            }

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelalt.BackColor = Color.FromArgb(200, 64, 233);
            panelsol.BackColor = Color.FromArgb(200, 64, 233);
            panelüst.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKrampon.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxJordan.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKaykay.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxSalon.BackColor = Color.FromArgb(200, 64, 233);

            if (comboBoxJordan.Text == "Air Jordan XXXV Dna")
            {
                formjordanair fr = new formjordanair();
                formGetir(fr);
            }
            if (comboBoxJordan.Text == "Jordan Max Aura")
            {
                formJordanMax fr1 = new formJordanMax();
                formGetir(fr1);
            }
            if (comboBoxJordan.Text == "Jordan Jumpman")
            {
                formJordanJumpman fr2 = new formJordanJumpman();
                formGetir(fr2);
            }

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelalt.BackColor = Color.FromArgb(200, 64, 233);
            panelsol.BackColor = Color.FromArgb(200, 64, 233);
            panelüst.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKrampon.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxJordan.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKaykay.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxSalon.BackColor = Color.FromArgb(200, 64, 233);

            if (comboBoxKaykay.Text == "Dunk Low")
            {
                formDunkLow fr = new formDunkLow();
                formGetir(fr);
            }
            if (comboBoxKaykay.Text == "SB Adversay")
            {
                formadversay fr1 = new formadversay();
                formGetir(fr1);
            }
            if (comboBoxKaykay.Text == "Air Force 107")
            {
                formair107 fr2 = new formair107();
                formGetir(fr2);
            }
            if (comboBoxKaykay.Text == "Air Force Black")
            {
                formair1 fr3 = new formair1();
                formGetir(fr3);
            }
            if (comboBoxKaykay.Text == "Sb Charge")
            {
                formcharge fr4 = new formcharge();
                formGetir(fr4);
            }
            if (comboBoxKaykay.Text == "Sb Zoom")
            {
                formzoom fr5 = new formzoom();
                formGetir(fr5);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelalt.BackColor = Color.FromArgb(200, 64, 233);
            panelsol.BackColor = Color.FromArgb(200, 64, 233);
            panelüst.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKrampon.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxJordan.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKaykay.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxSalon.BackColor = Color.FromArgb(200, 64, 233);

            if (comboBoxSalon.Text == "Metcon 6 AMP")
            {
                formmetcon fr = new formmetcon();
                formGetir(fr);
            }
            if (comboBoxSalon.Text == "Super Rep Go")
            {
                formsalon2 fr1 = new formsalon2();
                formGetir(fr1);
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelalt.BackColor = Color.FromArgb(200, 64, 233);
            panelsol.BackColor = Color.FromArgb(200, 64, 233);
            panelüst.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKrampon.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxJordan.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKaykay.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxSalon.BackColor = Color.FromArgb(200, 64, 233);
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            panelalt.BackColor = Color.FromArgb(200, 64, 233);
            panelsol.BackColor = Color.FromArgb(200, 64, 233);
            panelüst.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKrampon.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxJordan.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKaykay.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxSalon.BackColor = Color.FromArgb(200, 64, 233);

            formsatis fr0 = new formsatis();
            formGetir(fr0);
        }
       
        private void btnİnternet_Click(object sender, EventArgs e)
        {
            panelalt.BackColor = Color.FromArgb(200, 64, 233);
            panelsol.BackColor = Color.FromArgb(200, 64, 233);
            panelüst.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKrampon.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxJordan.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxKaykay.BackColor = Color.FromArgb(200, 64, 233);
            comboBoxSalon.BackColor = Color.FromArgb(200, 64, 233);

            formWeb fw = new formWeb();
            formGetir(fw);
            

        }
    }
}

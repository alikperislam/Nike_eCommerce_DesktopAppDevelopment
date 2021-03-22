namespace Nike
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelalt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelsol = new System.Windows.Forms.Panel();
            this.btnİnternet = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.comboBoxKaykay = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.comboBoxJordan = new System.Windows.Forms.ComboBox();
            this.comboBoxKrampon = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelüst = new System.Windows.Forms.Panel();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelAna = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelalt.SuspendLayout();
            this.panelsol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelüst.SuspendLayout();
            this.panelAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelalt
            // 
            this.panelalt.BackColor = System.Drawing.Color.Black;
            this.panelalt.Controls.Add(this.label1);
            this.panelalt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelalt.Location = new System.Drawing.Point(0, 538);
            this.panelalt.Name = "panelalt";
            this.panelalt.Size = new System.Drawing.Size(928, 38);
            this.panelalt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright 2020 TBC Software Development All Right Reversed || Design and Coding b" +
    "y Alikper İslam ";
            // 
            // panelsol
            // 
            this.panelsol.BackColor = System.Drawing.Color.Black;
            this.panelsol.Controls.Add(this.btnİnternet);
            this.panelsol.Controls.Add(this.btnSatis);
            this.panelsol.Controls.Add(this.comboBoxKaykay);
            this.panelsol.Controls.Add(this.button3);
            this.panelsol.Controls.Add(this.button4);
            this.panelsol.Controls.Add(this.button2);
            this.panelsol.Controls.Add(this.button1);
            this.panelsol.Controls.Add(this.comboBoxSalon);
            this.panelsol.Controls.Add(this.comboBoxJordan);
            this.panelsol.Controls.Add(this.comboBoxKrampon);
            this.panelsol.Controls.Add(this.pictureBox2);
            this.panelsol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsol.Location = new System.Drawing.Point(0, 0);
            this.panelsol.Name = "panelsol";
            this.panelsol.Size = new System.Drawing.Size(178, 538);
            this.panelsol.TabIndex = 2;
            // 
            // btnİnternet
            // 
            this.btnİnternet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnİnternet.FlatAppearance.BorderSize = 0;
            this.btnİnternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİnternet.Image = ((System.Drawing.Image)(resources.GetObject("btnİnternet.Image")));
            this.btnİnternet.Location = new System.Drawing.Point(94, 486);
            this.btnİnternet.Name = "btnİnternet";
            this.btnİnternet.Size = new System.Drawing.Size(66, 38);
            this.btnİnternet.TabIndex = 14;
            this.btnİnternet.UseVisualStyleBackColor = true;
            this.btnİnternet.Click += new System.EventHandler(this.btnİnternet_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSatis.FlatAppearance.BorderSize = 0;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Image = ((System.Drawing.Image)(resources.GetObject("btnSatis.Image")));
            this.btnSatis.Location = new System.Drawing.Point(12, 486);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(67, 38);
            this.btnSatis.TabIndex = 13;
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // comboBoxKaykay
            // 
            this.comboBoxKaykay.BackColor = System.Drawing.Color.Black;
            this.comboBoxKaykay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKaykay.ForeColor = System.Drawing.Color.White;
            this.comboBoxKaykay.FormattingEnabled = true;
            this.comboBoxKaykay.Items.AddRange(new object[] {
            "Dunk Low",
            "SB Adversay",
            "Air Force 107",
            "Air Force Black",
            "Sb Charge",
            "Sb Zoom"});
            this.comboBoxKaykay.Location = new System.Drawing.Point(2, 368);
            this.comboBoxKaykay.Name = "comboBoxKaykay";
            this.comboBoxKaykay.Size = new System.Drawing.Size(175, 31);
            this.comboBoxKaykay.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 78);
            this.button3.TabIndex = 1;
            this.button3.Text = "Kaykay Ayakkabısı";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "Salon Ayakkabısı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Jordan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kramponlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.BackColor = System.Drawing.Color.Black;
            this.comboBoxSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSalon.ForeColor = System.Drawing.Color.White;
            this.comboBoxSalon.FormattingEnabled = true;
            this.comboBoxSalon.Items.AddRange(new object[] {
            "Metcon 6 AMP",
            "Super Rep Go"});
            this.comboBoxSalon.Location = new System.Drawing.Point(3, 256);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(175, 31);
            this.comboBoxSalon.TabIndex = 12;
            // 
            // comboBoxJordan
            // 
            this.comboBoxJordan.BackColor = System.Drawing.Color.Black;
            this.comboBoxJordan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxJordan.ForeColor = System.Drawing.Color.White;
            this.comboBoxJordan.FormattingEnabled = true;
            this.comboBoxJordan.Items.AddRange(new object[] {
            "Air Jordan XXXV Dna",
            "Jordan Max Aura",
            "Jordan Jumpman"});
            this.comboBoxJordan.Location = new System.Drawing.Point(3, 147);
            this.comboBoxJordan.Name = "comboBoxJordan";
            this.comboBoxJordan.Size = new System.Drawing.Size(175, 31);
            this.comboBoxJordan.TabIndex = 10;
            // 
            // comboBoxKrampon
            // 
            this.comboBoxKrampon.BackColor = System.Drawing.Color.Black;
            this.comboBoxKrampon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKrampon.ForeColor = System.Drawing.Color.White;
            this.comboBoxKrampon.FormattingEnabled = true;
            this.comboBoxKrampon.Items.AddRange(new object[] {
            "Mercuriel Neymar jr.",
            "Mercuriel Vapor 13",
            "Phantom GT",
            "Phantom Vision Pro"});
            this.comboBoxKrampon.Location = new System.Drawing.Point(3, 38);
            this.comboBoxKrampon.Name = "comboBoxKrampon";
            this.comboBoxKrampon.Size = new System.Drawing.Size(175, 31);
            this.comboBoxKrampon.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panelüst
            // 
            this.panelüst.BackColor = System.Drawing.Color.Black;
            this.panelüst.Controls.Add(this.btnMinus);
            this.panelüst.Controls.Add(this.btnExit);
            this.panelüst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelüst.Location = new System.Drawing.Point(178, 0);
            this.panelüst.Name = "panelüst";
            this.panelüst.Size = new System.Drawing.Size(750, 38);
            this.panelüst.TabIndex = 3;
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(667, 0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(43, 38);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(707, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelAna
            // 
            this.panelAna.Controls.Add(this.pictureBox1);
            this.panelAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAna.Location = new System.Drawing.Point(178, 38);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(750, 500);
            this.panelAna.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 576);
            this.Controls.Add(this.panelAna);
            this.Controls.Add(this.panelüst);
            this.Controls.Add(this.panelsol);
            this.Controls.Add(this.panelalt);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelalt.ResumeLayout(false);
            this.panelalt.PerformLayout();
            this.panelsol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelüst.ResumeLayout(false);
            this.panelAna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelAna;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelüst;
        private System.Windows.Forms.Panel panelsol;
        private System.Windows.Forms.Panel panelalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxKaykay;
        private System.Windows.Forms.ComboBox comboBoxSalon;
        private System.Windows.Forms.ComboBox comboBoxJordan;
        private System.Windows.Forms.ComboBox comboBoxKrampon;
        private System.Windows.Forms.Button btnİnternet;
        private System.Windows.Forms.Button btnSatis;
    }
}


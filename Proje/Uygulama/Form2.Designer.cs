namespace staj
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipucu = new System.Windows.Forms.Label();
            this.txtsoru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbk = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkad = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.ipucu);
            this.groupBox1.Controls.Add(this.txtsoru);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifremi Unuttum?";
            // 
            // ipucu
            // 
            this.ipucu.AutoSize = true;
            this.ipucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipucu.Location = new System.Drawing.Point(57, 95);
            this.ipucu.Name = "ipucu";
            this.ipucu.Size = new System.Drawing.Size(0, 13);
            this.ipucu.TabIndex = 3;
            // 
            // txtsoru
            // 
            this.txtsoru.Location = new System.Drawing.Point(50, 68);
            this.txtsoru.Name = "txtsoru";
            this.txtsoru.Size = new System.Drawing.Size(127, 23);
            this.txtsoru.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Güvenlik Sorusu Yanıtınız Nedir ?";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(50, 115);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(127, 34);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "Doğrula";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbk
            // 
            this.lbk.AutoSize = true;
            this.lbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbk.ForeColor = System.Drawing.Color.Black;
            this.lbk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbk.Location = new System.Drawing.Point(69, 253);
            this.lbk.Name = "lbk";
            this.lbk.Size = new System.Drawing.Size(120, 17);
            this.lbk.TabIndex = 11;
            this.lbk.TabStop = true;
            this.lbk.Text = "Şifremi Unuttum ?";
            this.lbk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbk_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ŞİFRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(62, 171);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(133, 23);
            this.txtsifre.TabIndex = 7;
            // 
            // txtkad
            // 
            this.txtkad.Enabled = false;
            this.txtkad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkad.Location = new System.Drawing.Point(62, 106);
            this.txtkad.Name = "txtkad";
            this.txtkad.Size = new System.Drawing.Size(133, 23);
            this.txtkad.TabIndex = 8;
            this.txtkad.Text = "admin";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(62, 212);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(133, 26);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "GİRİŞ";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.Navy;
            this.geri.ForeColor = System.Drawing.Color.White;
            this.geri.Location = new System.Drawing.Point(80, 267);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 4;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(273, 302);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.lbk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtkad);
            this.MaximumSize = new System.Drawing.Size(289, 341);
            this.MinimumSize = new System.Drawing.Size(289, 341);
            this.Name = "Form2";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.LinkLabel lbk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkad;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label ipucu;
    }
}
namespace WebCameraCapture
{
    partial class AnaMenu
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
            this.btn_Resmi_Kaydet = new System.Windows.Forms.Button();
            this.btn_Devam_Et = new System.Windows.Forms.Button();
            this.btn_Durdur = new System.Windows.Forms.Button();
            this.btn_Baslat = new System.Windows.Forms.Button();
            this.img_Alinan_Resim = new System.Windows.Forms.PictureBox();
            this.img_Web_Cam = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Resim_Cek = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Tekrar_Dene = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Alinan_Resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Web_Cam)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Resmi_Kaydet
            // 
            this.btn_Resmi_Kaydet.Location = new System.Drawing.Point(6, 491);
            this.btn_Resmi_Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Resmi_Kaydet.Name = "btn_Resmi_Kaydet";
            this.btn_Resmi_Kaydet.Size = new System.Drawing.Size(150, 50);
            this.btn_Resmi_Kaydet.TabIndex = 13;
            this.btn_Resmi_Kaydet.Text = "Resmi Kaydet";
            this.btn_Resmi_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Resmi_Kaydet.Click += new System.EventHandler(this.btn_Resmi_Kaydet_Click);
            // 
            // btn_Devam_Et
            // 
            this.btn_Devam_Et.Location = new System.Drawing.Point(322, 491);
            this.btn_Devam_Et.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Devam_Et.Name = "btn_Devam_Et";
            this.btn_Devam_Et.Size = new System.Drawing.Size(150, 50);
            this.btn_Devam_Et.TabIndex = 11;
            this.btn_Devam_Et.Text = "Devam Et";
            this.btn_Devam_Et.UseVisualStyleBackColor = true;
            this.btn_Devam_Et.Click += new System.EventHandler(this.btn_Devam_Et_Click);
            // 
            // btn_Durdur
            // 
            this.btn_Durdur.Location = new System.Drawing.Point(164, 491);
            this.btn_Durdur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Durdur.Name = "btn_Durdur";
            this.btn_Durdur.Size = new System.Drawing.Size(150, 50);
            this.btn_Durdur.TabIndex = 10;
            this.btn_Durdur.Text = "Durdur";
            this.btn_Durdur.UseVisualStyleBackColor = true;
            this.btn_Durdur.Click += new System.EventHandler(this.btn_Durdur_Click);
            // 
            // btn_Baslat
            // 
            this.btn_Baslat.Location = new System.Drawing.Point(6, 491);
            this.btn_Baslat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Baslat.Name = "btn_Baslat";
            this.btn_Baslat.Size = new System.Drawing.Size(150, 50);
            this.btn_Baslat.TabIndex = 9;
            this.btn_Baslat.Text = "Başla";
            this.btn_Baslat.UseVisualStyleBackColor = true;
            this.btn_Baslat.Click += new System.EventHandler(this.btn_Baslat_Click);
            // 
            // img_Alinan_Resim
            // 
            this.img_Alinan_Resim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Alinan_Resim.Dock = System.Windows.Forms.DockStyle.Top;
            this.img_Alinan_Resim.Location = new System.Drawing.Point(0, 0);
            this.img_Alinan_Resim.Margin = new System.Windows.Forms.Padding(4);
            this.img_Alinan_Resim.Name = "img_Alinan_Resim";
            this.img_Alinan_Resim.Size = new System.Drawing.Size(1056, 482);
            this.img_Alinan_Resim.TabIndex = 8;
            this.img_Alinan_Resim.TabStop = false;
            // 
            // img_Web_Cam
            // 
            this.img_Web_Cam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Web_Cam.Dock = System.Windows.Forms.DockStyle.Top;
            this.img_Web_Cam.Location = new System.Drawing.Point(0, 0);
            this.img_Web_Cam.Margin = new System.Windows.Forms.Padding(4);
            this.img_Web_Cam.Name = "img_Web_Cam";
            this.img_Web_Cam.Size = new System.Drawing.Size(1056, 482);
            this.img_Web_Cam.TabIndex = 7;
            this.img_Web_Cam.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 587);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resim Çek";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_Resim_Cek);
            this.panel1.Controls.Add(this.img_Web_Cam);
            this.panel1.Controls.Add(this.btn_Baslat);
            this.panel1.Controls.Add(this.btn_Durdur);
            this.panel1.Controls.Add(this.btn_Devam_Et);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 552);
            this.panel1.TabIndex = 0;
            // 
            // btn_Resim_Cek
            // 
            this.btn_Resim_Cek.Location = new System.Drawing.Point(480, 491);
            this.btn_Resim_Cek.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Resim_Cek.Name = "btn_Resim_Cek";
            this.btn_Resim_Cek.Size = new System.Drawing.Size(150, 50);
            this.btn_Resim_Cek.TabIndex = 13;
            this.btn_Resim_Cek.Text = "Resim Çek";
            this.btn_Resim_Cek.UseVisualStyleBackColor = true;
            this.btn_Resim_Cek.Click += new System.EventHandler(this.btn_Resim_Cek_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resmi Dışa Aktar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btn_Tekrar_Dene);
            this.panel2.Controls.Add(this.img_Alinan_Resim);
            this.panel2.Controls.Add(this.btn_Resmi_Kaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 552);
            this.panel2.TabIndex = 1;
            // 
            // btn_Tekrar_Dene
            // 
            this.btn_Tekrar_Dene.Location = new System.Drawing.Point(164, 491);
            this.btn_Tekrar_Dene.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tekrar_Dene.Name = "btn_Tekrar_Dene";
            this.btn_Tekrar_Dene.Size = new System.Drawing.Size(150, 50);
            this.btn_Tekrar_Dene.TabIndex = 14;
            this.btn_Tekrar_Dene.Text = "Tekrar Dene";
            this.btn_Tekrar_Dene.UseVisualStyleBackColor = true;
            this.btn_Tekrar_Dene.Click += new System.EventHandler(this.btn_Tekrar_Dene_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaMenu";
            this.Text = "Web Cam\'dan Resim Al";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Alinan_Resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Web_Cam)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Resmi_Kaydet;
        private System.Windows.Forms.Button btn_Devam_Et;
        private System.Windows.Forms.Button btn_Durdur;
        private System.Windows.Forms.Button btn_Baslat;
        private System.Windows.Forms.PictureBox img_Alinan_Resim;
        private System.Windows.Forms.PictureBox img_Web_Cam;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Resim_Cek;
        private System.Windows.Forms.Button btn_Tekrar_Dene;
    }
}


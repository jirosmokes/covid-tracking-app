
namespace SHINKANSENAPP
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.button1 = new System.Windows.Forms.Button();
            this.timernow = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.navigationpanel = new System.Windows.Forms.Panel();
            this.highlights = new System.Windows.Forms.Panel();
            this.aboutbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userui = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infogbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inquirybtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.formloader = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.navigationpanel.SuspendLayout();
            this.userui.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.formloader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(938, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timernow
            // 
            this.timernow.Enabled = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(603, 56);
            this.label7.TabIndex = 13;
            this.label7.Text = "Welcome To Shinkansen ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(446, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Version 1.00";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // navigationpanel
            // 
            this.navigationpanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.navigationpanel.BackgroundImage = global::SHINKANSENAPP.Properties.Resources.blue;
            this.navigationpanel.Controls.Add(this.highlights);
            this.navigationpanel.Controls.Add(this.aboutbtn);
            this.navigationpanel.Controls.Add(this.homebtn);
            this.navigationpanel.Controls.Add(this.userui);
            this.navigationpanel.Controls.Add(this.infogbtn);
            this.navigationpanel.Controls.Add(this.reportsbtn);
            this.navigationpanel.Controls.Add(this.inquirybtn);
            this.navigationpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationpanel.Location = new System.Drawing.Point(0, 0);
            this.navigationpanel.Name = "navigationpanel";
            this.navigationpanel.Size = new System.Drawing.Size(170, 512);
            this.navigationpanel.TabIndex = 0;
            // 
            // highlights
            // 
            this.highlights.BackColor = System.Drawing.Color.Gold;
            this.highlights.Location = new System.Drawing.Point(3, 152);
            this.highlights.Name = "highlights";
            this.highlights.Size = new System.Drawing.Size(5, 60);
            this.highlights.TabIndex = 0;
            // 
            // aboutbtn
            // 
            this.aboutbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.aboutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.aboutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutbtn.BorderRadius = 0;
            this.aboutbtn.ButtonText = "About";
            this.aboutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutbtn.DisabledColor = System.Drawing.Color.Gray;
            this.aboutbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.aboutbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.aboutbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("aboutbtn.Iconimage")));
            this.aboutbtn.Iconimage_right = null;
            this.aboutbtn.Iconimage_right_Selected = null;
            this.aboutbtn.Iconimage_Selected = null;
            this.aboutbtn.IconMarginLeft = 0;
            this.aboutbtn.IconMarginRight = 0;
            this.aboutbtn.IconRightVisible = true;
            this.aboutbtn.IconRightZoom = 0D;
            this.aboutbtn.IconVisible = true;
            this.aboutbtn.IconZoom = 90D;
            this.aboutbtn.IsTab = false;
            this.aboutbtn.Location = new System.Drawing.Point(3, 440);
            this.aboutbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.aboutbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.aboutbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.aboutbtn.selected = false;
            this.aboutbtn.Size = new System.Drawing.Size(170, 68);
            this.aboutbtn.TabIndex = 8;
            this.aboutbtn.Text = "About";
            this.aboutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutbtn.Textcolor = System.Drawing.Color.White;
            this.aboutbtn.TextFont = new System.Drawing.Font("Century Gothic", 7.8F);
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click_1);
            // 
            // homebtn
            // 
            this.homebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtn.BorderRadius = 0;
            this.homebtn.ButtonText = "Home";
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebtn.DisabledColor = System.Drawing.Color.Gray;
            this.homebtn.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.homebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.homebtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("homebtn.Iconimage")));
            this.homebtn.Iconimage_right = null;
            this.homebtn.Iconimage_right_Selected = null;
            this.homebtn.Iconimage_Selected = null;
            this.homebtn.IconMarginLeft = 0;
            this.homebtn.IconMarginRight = 0;
            this.homebtn.IconRightVisible = true;
            this.homebtn.IconRightZoom = 0D;
            this.homebtn.IconVisible = true;
            this.homebtn.IconZoom = 90D;
            this.homebtn.IsTab = false;
            this.homebtn.Location = new System.Drawing.Point(3, 144);
            this.homebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homebtn.Name = "homebtn";
            this.homebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.homebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.homebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.homebtn.selected = false;
            this.homebtn.Size = new System.Drawing.Size(170, 68);
            this.homebtn.TabIndex = 0;
            this.homebtn.Text = "Home";
            this.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homebtn.Textcolor = System.Drawing.Color.White;
            this.homebtn.TextFont = new System.Drawing.Font("Century Gothic", 7.8F);
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click_1);
            // 
            // userui
            // 
            this.userui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.userui.Controls.Add(this.textBox1);
            this.userui.Controls.Add(this.label1);
            this.userui.Controls.Add(this.pictureBox1);
            this.userui.Dock = System.Windows.Forms.DockStyle.Top;
            this.userui.Location = new System.Drawing.Point(0, 0);
            this.userui.Name = "userui";
            this.userui.Size = new System.Drawing.Size(170, 137);
            this.userui.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(63, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infogbtn
            // 
            this.infogbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.infogbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.infogbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infogbtn.BorderRadius = 0;
            this.infogbtn.ButtonText = "  Infographic";
            this.infogbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infogbtn.DisabledColor = System.Drawing.Color.Gray;
            this.infogbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.infogbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.infogbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("infogbtn.Iconimage")));
            this.infogbtn.Iconimage_right = null;
            this.infogbtn.Iconimage_right_Selected = null;
            this.infogbtn.Iconimage_Selected = null;
            this.infogbtn.IconMarginLeft = 0;
            this.infogbtn.IconMarginRight = 0;
            this.infogbtn.IconRightVisible = true;
            this.infogbtn.IconRightZoom = 0D;
            this.infogbtn.IconVisible = true;
            this.infogbtn.IconZoom = 90D;
            this.infogbtn.IsTab = false;
            this.infogbtn.Location = new System.Drawing.Point(0, 361);
            this.infogbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infogbtn.Name = "infogbtn";
            this.infogbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.infogbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.infogbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.infogbtn.selected = false;
            this.infogbtn.Size = new System.Drawing.Size(170, 68);
            this.infogbtn.TabIndex = 7;
            this.infogbtn.Text = "  Infographic";
            this.infogbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infogbtn.Textcolor = System.Drawing.Color.White;
            this.infogbtn.TextFont = new System.Drawing.Font("Century Gothic", 7.8F);
            this.infogbtn.Click += new System.EventHandler(this.infogbtn_Click_1);
            // 
            // reportsbtn
            // 
            this.reportsbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.reportsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.reportsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportsbtn.BorderRadius = 0;
            this.reportsbtn.ButtonText = "Reports";
            this.reportsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsbtn.DisabledColor = System.Drawing.Color.Gray;
            this.reportsbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.reportsbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.reportsbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reportsbtn.Iconimage")));
            this.reportsbtn.Iconimage_right = null;
            this.reportsbtn.Iconimage_right_Selected = null;
            this.reportsbtn.Iconimage_Selected = null;
            this.reportsbtn.IconMarginLeft = 0;
            this.reportsbtn.IconMarginRight = 0;
            this.reportsbtn.IconRightVisible = true;
            this.reportsbtn.IconRightZoom = 0D;
            this.reportsbtn.IconVisible = true;
            this.reportsbtn.IconZoom = 90D;
            this.reportsbtn.IsTab = false;
            this.reportsbtn.Location = new System.Drawing.Point(0, 286);
            this.reportsbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportsbtn.Name = "reportsbtn";
            this.reportsbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.reportsbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.reportsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.reportsbtn.selected = false;
            this.reportsbtn.Size = new System.Drawing.Size(170, 68);
            this.reportsbtn.TabIndex = 6;
            this.reportsbtn.Text = "Reports";
            this.reportsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportsbtn.Textcolor = System.Drawing.Color.White;
            this.reportsbtn.TextFont = new System.Drawing.Font("Century Gothic", 7.8F);
            this.reportsbtn.Click += new System.EventHandler(this.reportsbtn_Click_1);
            // 
            // inquirybtn
            // 
            this.inquirybtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.inquirybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.inquirybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inquirybtn.BorderRadius = 0;
            this.inquirybtn.ButtonText = "Symptoms";
            this.inquirybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inquirybtn.DisabledColor = System.Drawing.Color.Gray;
            this.inquirybtn.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.inquirybtn.Iconcolor = System.Drawing.Color.Transparent;
            this.inquirybtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("inquirybtn.Iconimage")));
            this.inquirybtn.Iconimage_right = null;
            this.inquirybtn.Iconimage_right_Selected = null;
            this.inquirybtn.Iconimage_Selected = null;
            this.inquirybtn.IconMarginLeft = 0;
            this.inquirybtn.IconMarginRight = 0;
            this.inquirybtn.IconRightVisible = true;
            this.inquirybtn.IconRightZoom = 0D;
            this.inquirybtn.IconVisible = true;
            this.inquirybtn.IconZoom = 90D;
            this.inquirybtn.IsTab = false;
            this.inquirybtn.Location = new System.Drawing.Point(0, 211);
            this.inquirybtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inquirybtn.Name = "inquirybtn";
            this.inquirybtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.inquirybtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.inquirybtn.OnHoverTextColor = System.Drawing.Color.White;
            this.inquirybtn.selected = false;
            this.inquirybtn.Size = new System.Drawing.Size(170, 68);
            this.inquirybtn.TabIndex = 5;
            this.inquirybtn.Text = "Symptoms";
            this.inquirybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inquirybtn.Textcolor = System.Drawing.Color.White;
            this.inquirybtn.TextFont = new System.Drawing.Font("Century Gothic", 7.8F);
            this.inquirybtn.Click += new System.EventHandler(this.inquirybtn_Click_1);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(123)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(120)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(170, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(994, 90);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::SHINKANSENAPP.Properties.Resources.iAcademy_logo1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(734, 108);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 185);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SHINKANSENAPP.Properties.Resources._1200px_Department_of_Health__DOH__PHL_svg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(56, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 185);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // formloader
            // 
            this.formloader.BackColor = System.Drawing.Color.White;
            this.formloader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formloader.BackgroundImage")));
            this.formloader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formloader.Controls.Add(this.pictureBox2);
            this.formloader.Controls.Add(this.pictureBox3);
            this.formloader.Controls.Add(this.pictureBox4);
            this.formloader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formloader.Location = new System.Drawing.Point(170, 85);
            this.formloader.Name = "formloader";
            this.formloader.Size = new System.Drawing.Size(994, 427);
            this.formloader.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(120, -41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(750, 577);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1164, 512);
            this.Controls.Add(this.formloader);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.navigationpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shinkansen";
            this.navigationpanel.ResumeLayout(false);
            this.userui.ResumeLayout(false);
            this.userui.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.formloader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationpanel;
        private System.Windows.Forms.Panel userui;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel highlights;
        private System.Windows.Forms.Timer timernow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton homebtn;
        private Bunifu.Framework.UI.BunifuFlatButton inquirybtn;
        private Bunifu.Framework.UI.BunifuFlatButton reportsbtn;
        private Bunifu.Framework.UI.BunifuFlatButton infogbtn;
        private Bunifu.Framework.UI.BunifuFlatButton aboutbtn;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel formloader;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}



namespace WordCloudUI
{
    partial class FormWordcloud
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
            this.Wordcloudbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CBfile = new System.Windows.Forms.CheckBox();
            this.CBbackpage = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBminh = new System.Windows.Forms.TextBox();
            this.TBmaxh = new System.Windows.Forms.TextBox();
            this.TBmaxs = new System.Windows.Forms.TextBox();
            this.TBmins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBmaxv = new System.Windows.Forms.TextBox();
            this.TBminv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Titlecolorbutton = new System.Windows.Forms.Button();
            this.Authorcolorbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBtitspecial = new System.Windows.Forms.CheckBox();
            this.TBwidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBheight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBminfont = new System.Windows.Forms.TextBox();
            this.TBmaxfont = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBtriangle = new System.Windows.Forms.RadioButton();
            this.RBrectangle = new System.Windows.Forms.RadioButton();
            this.RBellipse = new System.Windows.Forms.RadioButton();
            this.RBcircle = new System.Windows.Forms.RadioButton();
            this.CBtext = new System.Windows.Forms.CheckBox();
            this.TBcloudtitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBxspace = new System.Windows.Forms.TextBox();
            this.TByspace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Clipboardbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wordcloudbutton
            // 
            this.Wordcloudbutton.Location = new System.Drawing.Point(1282, 51);
            this.Wordcloudbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Wordcloudbutton.Name = "Wordcloudbutton";
            this.Wordcloudbutton.Size = new System.Drawing.Size(195, 55);
            this.Wordcloudbutton.TabIndex = 0;
            this.Wordcloudbutton.Text = "Create cloud";
            this.Wordcloudbutton.UseVisualStyleBackColor = true;
            this.Wordcloudbutton.Click += new System.EventHandler(this.Wordcloudbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1088, 1105);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1219, 884);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 228);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // CBfile
            // 
            this.CBfile.AutoSize = true;
            this.CBfile.Location = new System.Drawing.Point(1208, 161);
            this.CBfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBfile.Name = "CBfile";
            this.CBfile.Size = new System.Drawing.Size(185, 19);
            this.CBfile.TabIndex = 8;
            this.CBfile.Text = "File with word list and weights";
            this.CBfile.UseVisualStyleBackColor = true;
            this.CBfile.MouseHover += new System.EventHandler(this.CBfile_MouseHover);
            // 
            // CBbackpage
            // 
            this.CBbackpage.AutoSize = true;
            this.CBbackpage.Location = new System.Drawing.Point(1342, 312);
            this.CBbackpage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBbackpage.Name = "CBbackpage";
            this.CBbackpage.Size = new System.Drawing.Size(113, 19);
            this.CBbackpage.TabIndex = 9;
            this.CBbackpage.Text = "Backpage layout";
            this.CBbackpage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1337, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Set background color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1216, 523);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hue range";
            // 
            // TBminh
            // 
            this.TBminh.Location = new System.Drawing.Point(1307, 519);
            this.TBminh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBminh.Name = "TBminh";
            this.TBminh.Size = new System.Drawing.Size(51, 23);
            this.TBminh.TabIndex = 14;
            this.TBminh.Text = "0";
            // 
            // TBmaxh
            // 
            this.TBmaxh.Location = new System.Drawing.Point(1387, 519);
            this.TBmaxh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBmaxh.Name = "TBmaxh";
            this.TBmaxh.Size = new System.Drawing.Size(51, 23);
            this.TBmaxh.TabIndex = 15;
            this.TBmaxh.Text = "359";
            // 
            // TBmaxs
            // 
            this.TBmaxs.Location = new System.Drawing.Point(1387, 548);
            this.TBmaxs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBmaxs.Name = "TBmaxs";
            this.TBmaxs.Size = new System.Drawing.Size(51, 23);
            this.TBmaxs.TabIndex = 18;
            this.TBmaxs.Text = "99";
            // 
            // TBmins
            // 
            this.TBmins.Location = new System.Drawing.Point(1307, 549);
            this.TBmins.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBmins.Name = "TBmins";
            this.TBmins.Size = new System.Drawing.Size(51, 23);
            this.TBmins.TabIndex = 17;
            this.TBmins.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1191, 552);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Saturation range";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBmaxv
            // 
            this.TBmaxv.Location = new System.Drawing.Point(1387, 577);
            this.TBmaxv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBmaxv.Name = "TBmaxv";
            this.TBmaxv.Size = new System.Drawing.Size(51, 23);
            this.TBmaxv.TabIndex = 21;
            this.TBmaxv.Text = "99";
            // 
            // TBminv
            // 
            this.TBminv.Location = new System.Drawing.Point(1307, 577);
            this.TBminv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBminv.Name = "TBminv";
            this.TBminv.Size = new System.Drawing.Size(51, 23);
            this.TBminv.TabIndex = 20;
            this.TBminv.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1216, 580);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Brightness range";
            // 
            // Titlecolorbutton
            // 
            this.Titlecolorbutton.Location = new System.Drawing.Point(1334, 246);
            this.Titlecolorbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Titlecolorbutton.Name = "Titlecolorbutton";
            this.Titlecolorbutton.Size = new System.Drawing.Size(142, 27);
            this.Titlecolorbutton.TabIndex = 22;
            this.Titlecolorbutton.Text = "Set title color";
            this.Titlecolorbutton.UseVisualStyleBackColor = true;
            this.Titlecolorbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Authorcolorbutton
            // 
            this.Authorcolorbutton.Location = new System.Drawing.Point(1334, 279);
            this.Authorcolorbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Authorcolorbutton.Name = "Authorcolorbutton";
            this.Authorcolorbutton.Size = new System.Drawing.Size(142, 27);
            this.Authorcolorbutton.TabIndex = 23;
            this.Authorcolorbutton.Text = "Set author color";
            this.Authorcolorbutton.UseVisualStyleBackColor = true;
            this.Authorcolorbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 1154);
            this.panel2.TabIndex = 24;
            // 
            // CBtitspecial
            // 
            this.CBtitspecial.AutoSize = true;
            this.CBtitspecial.Location = new System.Drawing.Point(1342, 225);
            this.CBtitspecial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBtitspecial.Name = "CBtitspecial";
            this.CBtitspecial.Size = new System.Drawing.Size(87, 19);
            this.CBtitspecial.TabIndex = 25;
            this.CBtitspecial.Text = "Title special";
            this.CBtitspecial.UseVisualStyleBackColor = true;
            // 
            // TBwidth
            // 
            this.TBwidth.Location = new System.Drawing.Point(1250, 348);
            this.TBwidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBwidth.Name = "TBwidth";
            this.TBwidth.Size = new System.Drawing.Size(52, 23);
            this.TBwidth.TabIndex = 26;
            this.TBwidth.TabStop = false;
            this.TBwidth.Text = "1400";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1198, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1198, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Height";
            // 
            // TBheight
            // 
            this.TBheight.Location = new System.Drawing.Point(1250, 378);
            this.TBheight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBheight.Name = "TBheight";
            this.TBheight.Size = new System.Drawing.Size(52, 23);
            this.TBheight.TabIndex = 29;
            this.TBheight.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1351, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Minfont";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1351, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Maxfont";
            // 
            // TBminfont
            // 
            this.TBminfont.Location = new System.Drawing.Point(1407, 348);
            this.TBminfont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBminfont.Name = "TBminfont";
            this.TBminfont.Size = new System.Drawing.Size(48, 23);
            this.TBminfont.TabIndex = 32;
            this.TBminfont.Text = "12";
            // 
            // TBmaxfont
            // 
            this.TBmaxfont.Location = new System.Drawing.Point(1407, 378);
            this.TBmaxfont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBmaxfont.Name = "TBmaxfont";
            this.TBmaxfont.Size = new System.Drawing.Size(48, 23);
            this.TBmaxfont.TabIndex = 33;
            this.TBmaxfont.Text = "64";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtriangle);
            this.groupBox1.Controls.Add(this.RBrectangle);
            this.groupBox1.Controls.Add(this.RBellipse);
            this.groupBox1.Controls.Add(this.RBcircle);
            this.groupBox1.Location = new System.Drawing.Point(1203, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(125, 135);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cloud shape";
            // 
            // RBtriangle
            // 
            this.RBtriangle.AutoSize = true;
            this.RBtriangle.Location = new System.Drawing.Point(8, 105);
            this.RBtriangle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBtriangle.Name = "RBtriangle";
            this.RBtriangle.Size = new System.Drawing.Size(66, 19);
            this.RBtriangle.TabIndex = 3;
            this.RBtriangle.Text = "Triangle";
            this.RBtriangle.UseVisualStyleBackColor = true;
            // 
            // RBrectangle
            // 
            this.RBrectangle.AutoSize = true;
            this.RBrectangle.Location = new System.Drawing.Point(10, 77);
            this.RBrectangle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBrectangle.Name = "RBrectangle";
            this.RBrectangle.Size = new System.Drawing.Size(77, 19);
            this.RBrectangle.TabIndex = 2;
            this.RBrectangle.Text = "Rectangle";
            this.RBrectangle.UseVisualStyleBackColor = true;
            // 
            // RBellipse
            // 
            this.RBellipse.AutoSize = true;
            this.RBellipse.Checked = true;
            this.RBellipse.Location = new System.Drawing.Point(10, 51);
            this.RBellipse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBellipse.Name = "RBellipse";
            this.RBellipse.Size = new System.Drawing.Size(58, 19);
            this.RBellipse.TabIndex = 1;
            this.RBellipse.TabStop = true;
            this.RBellipse.Text = "Ellipse";
            this.RBellipse.UseVisualStyleBackColor = true;
            // 
            // RBcircle
            // 
            this.RBcircle.AutoSize = true;
            this.RBcircle.Location = new System.Drawing.Point(10, 24);
            this.RBcircle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBcircle.Name = "RBcircle";
            this.RBcircle.Size = new System.Drawing.Size(55, 19);
            this.RBcircle.TabIndex = 0;
            this.RBcircle.Text = "Circle";
            this.RBcircle.UseVisualStyleBackColor = true;
            // 
            // CBtext
            // 
            this.CBtext.AutoSize = true;
            this.CBtext.Checked = true;
            this.CBtext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBtext.Location = new System.Drawing.Point(1209, 136);
            this.CBtext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBtext.Name = "CBtext";
            this.CBtext.Size = new System.Drawing.Size(66, 19);
            this.CBtext.TabIndex = 35;
            this.CBtext.Text = "Text file";
            this.CBtext.UseVisualStyleBackColor = true;
            // 
            // TBcloudtitle
            // 
            this.TBcloudtitle.Location = new System.Drawing.Point(1282, 22);
            this.TBcloudtitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBcloudtitle.Name = "TBcloudtitle";
            this.TBcloudtitle.Size = new System.Drawing.Size(195, 23);
            this.TBcloudtitle.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1210, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Cloud title:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1213, 695);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "Horizontal spacing";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1213, 719);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Vertical spacing";
            // 
            // TBxspace
            // 
            this.TBxspace.Location = new System.Drawing.Point(1330, 691);
            this.TBxspace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBxspace.Name = "TBxspace";
            this.TBxspace.Size = new System.Drawing.Size(55, 23);
            this.TBxspace.TabIndex = 40;
            this.TBxspace.Text = "2";
            // 
            // TByspace
            // 
            this.TByspace.Location = new System.Drawing.Point(1330, 719);
            this.TByspace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TByspace.Name = "TByspace";
            this.TByspace.Size = new System.Drawing.Size(55, 23);
            this.TByspace.TabIndex = 41;
            this.TByspace.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1210, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Word source";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Clipboardbutton
            // 
            this.Clipboardbutton.Location = new System.Drawing.Point(1254, 780);
            this.Clipboardbutton.Name = "Clipboardbutton";
            this.Clipboardbutton.Size = new System.Drawing.Size(201, 40);
            this.Clipboardbutton.TabIndex = 43;
            this.Clipboardbutton.Text = "Copy cloud to clipboard";
            this.Clipboardbutton.UseVisualStyleBackColor = true;
            this.Clipboardbutton.Click += new System.EventHandler(this.Clipboardbutton_Click);
            // 
            // FormWordcloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 1180);
            this.Controls.Add(this.Clipboardbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TByspace);
            this.Controls.Add(this.TBxspace);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBcloudtitle);
            this.Controls.Add(this.CBtext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBmaxfont);
            this.Controls.Add(this.TBminfont);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBheight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBwidth);
            this.Controls.Add(this.CBtitspecial);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Authorcolorbutton);
            this.Controls.Add(this.Titlecolorbutton);
            this.Controls.Add(this.TBmaxv);
            this.Controls.Add(this.TBminv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBmaxs);
            this.Controls.Add(this.TBmins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBmaxh);
            this.Controls.Add(this.TBminh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBbackpage);
            this.Controls.Add(this.CBfile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Wordcloudbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormWordcloud";
            this.Text = "FormWordcloud";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wordcloudbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox CBfile;
        private System.Windows.Forms.CheckBox CBbackpage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBminh;
        private System.Windows.Forms.TextBox TBmaxh;
        private System.Windows.Forms.TextBox TBmaxs;
        private System.Windows.Forms.TextBox TBmins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBmaxv;
        private System.Windows.Forms.TextBox TBminv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Titlecolorbutton;
        private System.Windows.Forms.Button Authorcolorbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CBtitspecial;
        private System.Windows.Forms.TextBox TBwidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBheight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBminfont;
        private System.Windows.Forms.TextBox TBmaxfont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBrectangle;
        private System.Windows.Forms.RadioButton RBellipse;
        private System.Windows.Forms.RadioButton RBcircle;
        private System.Windows.Forms.CheckBox CBtext;
        private System.Windows.Forms.TextBox TBcloudtitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RBtriangle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBxspace;
        private System.Windows.Forms.TextBox TByspace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Clipboardbutton;
    }
}
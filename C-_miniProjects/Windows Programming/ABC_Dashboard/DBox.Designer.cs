namespace ABC_Dashboard
{
    partial class DBox
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
            OK = new Button();
            Cancel = new Button();
            tabControl1 = new TabControl();
            Txt = new TabPage();
            label2 = new Label();
            newTitle = new TextBox();
            label1 = new Label();
            OldTitle = new TextBox();
            Font = new TabPage();
            label3 = new Label();
            FontBox = new ComboBox();
            Color = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            tabControl1.SuspendLayout();
            Txt.SuspendLayout();
            Font.SuspendLayout();
            Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OK
            // 
            OK.Location = new Point(125, 294);
            OK.Name = "OK";
            OK.Size = new Size(197, 43);
            OK.TabIndex = 0;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(513, 294);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(169, 43);
            Cancel.TabIndex = 1;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Txt);
            tabControl1.Controls.Add(Font);
            tabControl1.Controls.Add(Color);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 288);
            tabControl1.TabIndex = 2;
            // 
            // Txt
            // 
            Txt.BorderStyle = BorderStyle.Fixed3D;
            Txt.Controls.Add(label2);
            Txt.Controls.Add(newTitle);
            Txt.Controls.Add(label1);
            Txt.Controls.Add(OldTitle);
            Txt.Cursor = Cursors.IBeam;
            Txt.Location = new Point(4, 24);
            Txt.Name = "Txt";
            Txt.Padding = new Padding(3);
            Txt.Size = new Size(794, 260);
            Txt.TabIndex = 0;
            Txt.Text = "Text";
            Txt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 100);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "New Title";
            // 
            // newTitle
            // 
            newTitle.Location = new Point(296, 97);
            newTitle.Name = "newTitle";
            newTitle.Size = new Size(237, 23);
            newTitle.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 49);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Old Title";
            // 
            // OldTitle
            // 
            OldTitle.Location = new Point(296, 46);
            OldTitle.Name = "OldTitle";
            OldTitle.Size = new Size(237, 23);
            OldTitle.TabIndex = 0;
            // 
            // Font
            // 
            Font.Controls.Add(label3);
            Font.Controls.Add(FontBox);
            Font.Location = new Point(4, 24);
            Font.Name = "Font";
            Font.Padding = new Padding(3);
            Font.Size = new Size(794, 260);
            Font.TabIndex = 1;
            Font.Text = "Font";
            Font.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 78);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "Font";
            // 
            // FontBox
            // 
            FontBox.FormattingEnabled = true;
            FontBox.Items.AddRange(new object[] { "\"Times New Roman\"", "\"Arial\"", "\"Calibri\"", "\"Courier New\"" });
            FontBox.Location = new Point(258, 75);
            FontBox.Name = "FontBox";
            FontBox.Size = new Size(314, 23);
            FontBox.TabIndex = 0;
            // 
            // Color
            // 
            Color.Controls.Add(label12);
            Color.Controls.Add(label11);
            Color.Controls.Add(label10);
            Color.Controls.Add(label9);
            Color.Controls.Add(label8);
            Color.Controls.Add(label7);
            Color.Controls.Add(label6);
            Color.Controls.Add(label5);
            Color.Controls.Add(label4);
            Color.Controls.Add(pictureBox1);
            Color.Location = new Point(4, 24);
            Color.Name = "Color";
            Color.Size = new Size(794, 260);
            Color.TabIndex = 2;
            Color.Text = "Color";
            Color.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 20);
            label10.MinimumSize = new Size(100, 55);
            label10.Name = "label10";
            label10.Size = new Size(100, 55);
            label10.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(41, 176);
            label9.MinimumSize = new Size(35, 10);
            label9.Name = "label9";
            label9.Size = new Size(35, 17);
            label9.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(41, 131);
            label8.MinimumSize = new Size(35, 10);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(41, 95);
            label7.MinimumSize = new Size(35, 10);
            label7.Name = "label7";
            label7.Size = new Size(35, 17);
            label7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 176);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 3;
            label6.Text = "B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 133);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 2;
            label5.Text = "G";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 95);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 1;
            label4.Text = "R";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Color_Spectrum_Wheel2;
            pictureBox1.Location = new Point(261, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 212);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 8;
            label11.Text = "Picked Color";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(101, 196);
            label12.MinimumSize = new Size(100, 55);
            label12.Name = "label12";
            label12.Size = new Size(100, 55);
            label12.TabIndex = 9;
            // 
            // DBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(Cancel);
            Controls.Add(OK);
            Name = "DBox";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            Txt.ResumeLayout(false);
            Txt.PerformLayout();
            Font.ResumeLayout(false);
            Font.PerformLayout();
            Color.ResumeLayout(false);
            Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OK;
        private Button Cancel;
        private TabControl tabControl1;
        private TabPage Txt;
        private TabPage Font;
        private TabPage Color;
        private TextBox OldTitle;
        private Label label2;
        private TextBox newTitle;
        private Label label1;
        private Label label3;
        private ComboBox FontBox;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label12;
        private Label label11;
    }
}
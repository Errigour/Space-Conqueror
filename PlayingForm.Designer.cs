namespace Space_Conqueror
{
    partial class PlayingForm
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
            pfpnl = new Label();
            label1 = new Label();
            pfsnl = new Label();
            label2 = new Label();
            panel1 = new Panel();
            Freedom = new Button();
            pftdl = new Label();
            pftpl = new Label();
            label10 = new Label();
            label9 = new Label();
            pfsaveb = new Button();
            pfdbb = new Button();
            pfsb = new Button();
            pffb = new Button();
            pfwdl = new Label();
            label5 = new Label();
            pfwnl = new Label();
            label4 = new Label();
            pfspb = new PictureBox();
            pfsal = new Label();
            pfspl = new Label();
            label3 = new Label();
            label6 = new Label();
            pfll = new Label();
            label7 = new Label();
            pfel = new Label();
            label8 = new Label();
            pfdl = new Label();
            menuStrip1 = new MenuStrip();
            skinToolStripMenuItem = new ToolStripMenuItem();
            goldBackgroundToolStripMenuItem = new ToolStripMenuItem();
            goldOnGreenToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            purpleOnPinkToolStripMenuItem = new ToolStripMenuItem();
            whiteOnBlackToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pfspb).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pfpnl
            // 
            pfpnl.AutoSize = true;
            pfpnl.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pfpnl.Location = new Point(12, 33);
            pfpnl.Name = "pfpnl";
            pfpnl.Size = new Size(34, 17);
            pfpnl.TabIndex = 0;
            pfpnl.Text = "null";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Ship";
            // 
            // pfsnl
            // 
            pfsnl.AutoSize = true;
            pfsnl.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pfsnl.Location = new Point(3, 0);
            pfsnl.Name = "pfsnl";
            pfsnl.Size = new Size(34, 17);
            pfsnl.TabIndex = 2;
            pfsnl.Text = "null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Armor:";
            // 
            // panel1
            // 
            panel1.Controls.Add(Freedom);
            panel1.Controls.Add(pftdl);
            panel1.Controls.Add(pftpl);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pfsaveb);
            panel1.Controls.Add(pfdbb);
            panel1.Controls.Add(pfsb);
            panel1.Controls.Add(pffb);
            panel1.Controls.Add(pfwdl);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pfwnl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pfspb);
            panel1.Controls.Add(pfsal);
            panel1.Controls.Add(pfspl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pfsnl);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(48, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 279);
            panel1.TabIndex = 4;
            // 
            // Freedom
            // 
            Freedom.Location = new Point(3, 137);
            Freedom.Name = "Freedom";
            Freedom.Size = new Size(89, 23);
            Freedom.TabIndex = 20;
            Freedom.Text = "Freedom";
            Freedom.UseVisualStyleBackColor = true;
            Freedom.Visible = false;
            Freedom.Click += Freedom_Click;
            // 
            // pftdl
            // 
            pftdl.AutoSize = true;
            pftdl.Location = new Point(44, 49);
            pftdl.Name = "pftdl";
            pftdl.Size = new Size(27, 15);
            pftdl.TabIndex = 19;
            pftdl.Text = "null";
            // 
            // pftpl
            // 
            pftpl.AutoSize = true;
            pftpl.Location = new Point(44, 101);
            pftpl.Name = "pftpl";
            pftpl.Size = new Size(27, 15);
            pftpl.TabIndex = 18;
            pftpl.Text = "null";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 49);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 17;
            label10.Text = "Total:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 101);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 16;
            label9.Text = "Total:";
            // 
            // pfsaveb
            // 
            pfsaveb.Location = new Point(3, 166);
            pfsaveb.Name = "pfsaveb";
            pfsaveb.Size = new Size(89, 23);
            pfsaveb.TabIndex = 12;
            pfsaveb.Text = "Save";
            pfsaveb.UseVisualStyleBackColor = true;
            pfsaveb.Click += pfsaveb_Click;
            // 
            // pfdbb
            // 
            pfdbb.Location = new Point(3, 253);
            pfdbb.Name = "pfdbb";
            pfdbb.Size = new Size(89, 23);
            pfdbb.TabIndex = 15;
            pfdbb.Text = "Docking Bay";
            pfdbb.UseVisualStyleBackColor = true;
            pfdbb.Click += pfdbb_Click;
            // 
            // pfsb
            // 
            pfsb.Location = new Point(3, 224);
            pfsb.Name = "pfsb";
            pfsb.Size = new Size(89, 23);
            pfsb.TabIndex = 14;
            pfsb.Text = "Shop";
            pfsb.UseVisualStyleBackColor = true;
            pfsb.Click += pfsb_Click;
            // 
            // pffb
            // 
            pffb.Location = new Point(3, 195);
            pffb.Name = "pffb";
            pffb.Size = new Size(89, 23);
            pffb.TabIndex = 13;
            pffb.Text = "Fight";
            pffb.UseVisualStyleBackColor = true;
            pffb.Click += pffb_Click;
            // 
            // pfwdl
            // 
            pfwdl.AutoSize = true;
            pfwdl.Location = new Point(63, 34);
            pfwdl.Name = "pfwdl";
            pfwdl.Size = new Size(27, 15);
            pfwdl.TabIndex = 11;
            pfwdl.Text = "null";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 34);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 10;
            label5.Text = "Damage:";
            // 
            // pfwnl
            // 
            pfwnl.AutoSize = true;
            pfwnl.Location = new Point(63, 19);
            pfwnl.Name = "pfwnl";
            pfwnl.Size = new Size(27, 15);
            pfwnl.TabIndex = 9;
            pfwnl.Text = "null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 19);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Weapon:";
            // 
            // pfspb
            // 
            pfspb.Location = new Point(98, 119);
            pfspb.Name = "pfspb";
            pfspb.Size = new Size(158, 158);
            pfspb.TabIndex = 7;
            pfspb.TabStop = false;
            // 
            // pfsal
            // 
            pfsal.AutoSize = true;
            pfsal.Location = new Point(53, 71);
            pfsal.Name = "pfsal";
            pfsal.Size = new Size(27, 15);
            pfsal.TabIndex = 6;
            pfsal.Text = "null";
            // 
            // pfspl
            // 
            pfspl.AutoSize = true;
            pfspl.Location = new Point(53, 86);
            pfspl.Name = "pfspl";
            pfspl.Size = new Size(27, 15);
            pfspl.TabIndex = 5;
            pfspl.Text = "null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 86);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Plating:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 48);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Level:";
            // 
            // pfll
            // 
            pfll.AutoSize = true;
            pfll.Location = new Point(49, 48);
            pfll.Name = "pfll";
            pfll.Size = new Size(27, 15);
            pfll.TabIndex = 6;
            pfll.Text = "null";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 48);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 7;
            label7.Text = "Experience:";
            // 
            // pfel
            // 
            pfel.AutoSize = true;
            pfel.Location = new Point(182, 48);
            pfel.Name = "pfel";
            pfel.Size = new Size(27, 15);
            pfel.TabIndex = 8;
            pfel.Text = "null";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 63);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 9;
            label8.Text = "Dollars:";
            // 
            // pfdl
            // 
            pfdl.AutoSize = true;
            pfdl.ForeColor = Color.ForestGreen;
            pfdl.Location = new Point(59, 63);
            pfdl.Name = "pfdl";
            pfdl.Size = new Size(27, 15);
            pfdl.TabIndex = 10;
            pfdl.Text = "null";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { skinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(344, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // skinToolStripMenuItem
            // 
            skinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { goldBackgroundToolStripMenuItem, goldOnGreenToolStripMenuItem, normalToolStripMenuItem, purpleOnPinkToolStripMenuItem, whiteOnBlackToolStripMenuItem });
            skinToolStripMenuItem.Name = "skinToolStripMenuItem";
            skinToolStripMenuItem.Size = new Size(41, 20);
            skinToolStripMenuItem.Text = "&Skin";
            // 
            // goldBackgroundToolStripMenuItem
            // 
            goldBackgroundToolStripMenuItem.Name = "goldBackgroundToolStripMenuItem";
            goldBackgroundToolStripMenuItem.Size = new Size(166, 22);
            goldBackgroundToolStripMenuItem.Text = "&Gold Background";
            goldBackgroundToolStripMenuItem.Click += goldBackgroundToolStripMenuItem_Click;
            // 
            // goldOnGreenToolStripMenuItem
            // 
            goldOnGreenToolStripMenuItem.Name = "goldOnGreenToolStripMenuItem";
            goldOnGreenToolStripMenuItem.Size = new Size(166, 22);
            goldOnGreenToolStripMenuItem.Text = "G&old on Green";
            goldOnGreenToolStripMenuItem.Click += goldOnGreenToolStripMenuItem_Click;
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(166, 22);
            normalToolStripMenuItem.Text = "&Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // purpleOnPinkToolStripMenuItem
            // 
            purpleOnPinkToolStripMenuItem.Name = "purpleOnPinkToolStripMenuItem";
            purpleOnPinkToolStripMenuItem.Size = new Size(166, 22);
            purpleOnPinkToolStripMenuItem.Text = "&Purple on Pink";
            purpleOnPinkToolStripMenuItem.Click += purpleOnPinkToolStripMenuItem_Click;
            // 
            // whiteOnBlackToolStripMenuItem
            // 
            whiteOnBlackToolStripMenuItem.Name = "whiteOnBlackToolStripMenuItem";
            whiteOnBlackToolStripMenuItem.Size = new Size(166, 22);
            whiteOnBlackToolStripMenuItem.Text = "&White on Black";
            whiteOnBlackToolStripMenuItem.Click += whiteOnBlackToolStripMenuItem_Click;
            // 
            // PlayingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 429);
            Controls.Add(pfdl);
            Controls.Add(label8);
            Controls.Add(pfel);
            Controls.Add(label7);
            Controls.Add(pfll);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pfpnl);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "PlayingForm";
            Text = "Space Conqueror";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pfspb).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pfpnl;
        private Label label1;
        private Label pfsnl;
        private Label label2;
        private Panel panel1;
        private Label pfsal;
        private Label pfspl;
        private Label label3;
        private PictureBox pfspb;
        private Label pfwnl;
        private Label label4;
        private Label pfwdl;
        private Label label5;
        private Button pfsaveb;
        public Button pffb;
        private Button pfdbb;
        private Button pfsb;
        private Label label6;
        private Label pfll;
        private Label label7;
        private Label pfel;
        private Label label8;
        public Label pfdl;
        private Label pftdl;
        private Label pftpl;
        private Label label10;
        private Label label9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem skinToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem whiteOnBlackToolStripMenuItem;
        private ToolStripMenuItem goldBackgroundToolStripMenuItem;
        private ToolStripMenuItem goldOnGreenToolStripMenuItem;
        private ToolStripMenuItem purpleOnPinkToolStripMenuItem;
        private Button Freedom;
    }
}
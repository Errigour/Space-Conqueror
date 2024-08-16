namespace Space_Conqueror
{
    partial class ShopForm
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
            sfwpb = new PictureBox();
            sfppb = new PictureBox();
            label1 = new Label();
            sfwpl = new Label();
            label3 = new Label();
            sfppl = new Label();
            label2 = new Label();
            sfpdl = new Label();
            label4 = new Label();
            sfwnl = new Label();
            sfpnl = new Label();
            label5 = new Label();
            sfdl = new Label();
            sfpl = new Label();
            sfwb = new Button();
            sfpb = new Button();
            ((System.ComponentModel.ISupportInitialize)sfwpb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sfppb).BeginInit();
            SuspendLayout();
            // 
            // sfwpb
            // 
            sfwpb.Location = new Point(12, 12);
            sfwpb.Name = "sfwpb";
            sfwpb.Size = new Size(75, 75);
            sfwpb.TabIndex = 0;
            sfwpb.TabStop = false;
            // 
            // sfppb
            // 
            sfppb.Location = new Point(12, 93);
            sfppb.Name = "sfppb";
            sfppb.Size = new Size(75, 75);
            sfppb.TabIndex = 1;
            sfppb.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 27);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Price:";
            // 
            // sfwpl
            // 
            sfwpl.AutoSize = true;
            sfwpl.Location = new Point(135, 27);
            sfwpl.Name = "sfwpl";
            sfwpl.Size = new Size(27, 15);
            sfwpl.TabIndex = 3;
            sfwpl.Text = "null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 108);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // sfppl
            // 
            sfppl.AutoSize = true;
            sfppl.Location = new Point(135, 108);
            sfppl.Name = "sfppl";
            sfppl.Size = new Size(27, 15);
            sfppl.TabIndex = 5;
            sfppl.Text = "null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 181);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Dollars:";
            // 
            // sfpdl
            // 
            sfpdl.AutoSize = true;
            sfpdl.ForeColor = Color.ForestGreen;
            sfpdl.Location = new Point(64, 181);
            sfpdl.Name = "sfpdl";
            sfpdl.Size = new Size(27, 15);
            sfpdl.TabIndex = 7;
            sfpdl.Text = "null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 42);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Damage:";
            // 
            // sfwnl
            // 
            sfwnl.AutoSize = true;
            sfwnl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sfwnl.Location = new Point(93, 12);
            sfwnl.Name = "sfwnl";
            sfwnl.Size = new Size(27, 15);
            sfwnl.TabIndex = 9;
            sfwnl.Text = "null";
            // 
            // sfpnl
            // 
            sfpnl.AutoSize = true;
            sfpnl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sfpnl.Location = new Point(93, 93);
            sfpnl.Name = "sfpnl";
            sfpnl.Size = new Size(27, 15);
            sfpnl.TabIndex = 10;
            sfpnl.Text = "null";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 123);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 11;
            label5.Text = "Plating:";
            // 
            // sfdl
            // 
            sfdl.AutoSize = true;
            sfdl.Location = new Point(153, 42);
            sfdl.Name = "sfdl";
            sfdl.Size = new Size(27, 15);
            sfdl.TabIndex = 12;
            sfdl.Text = "null";
            // 
            // sfpl
            // 
            sfpl.AutoSize = true;
            sfpl.Location = new Point(146, 123);
            sfpl.Name = "sfpl";
            sfpl.Size = new Size(27, 15);
            sfpl.TabIndex = 13;
            sfpl.Text = "null";
            // 
            // sfwb
            // 
            sfwb.Location = new Point(209, 12);
            sfwb.Name = "sfwb";
            sfwb.Size = new Size(75, 23);
            sfwb.TabIndex = 14;
            sfwb.Text = "Buy";
            sfwb.UseVisualStyleBackColor = true;
            sfwb.Click += sfwb_Click;
            // 
            // sfpb
            // 
            sfpb.Location = new Point(209, 93);
            sfpb.Name = "sfpb";
            sfpb.Size = new Size(75, 23);
            sfpb.TabIndex = 15;
            sfpb.Text = "Buy";
            sfpb.UseVisualStyleBackColor = true;
            sfpb.Click += sfpb_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 205);
            Controls.Add(sfpb);
            Controls.Add(sfwb);
            Controls.Add(sfpl);
            Controls.Add(sfdl);
            Controls.Add(label5);
            Controls.Add(sfpnl);
            Controls.Add(sfwnl);
            Controls.Add(label4);
            Controls.Add(sfpdl);
            Controls.Add(label2);
            Controls.Add(sfppl);
            Controls.Add(label3);
            Controls.Add(sfwpl);
            Controls.Add(label1);
            Controls.Add(sfppb);
            Controls.Add(sfwpb);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShopForm";
            Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)sfwpb).EndInit();
            ((System.ComponentModel.ISupportInitialize)sfppb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sfwpb;
        private PictureBox sfppb;
        private Label label1;
        private Label sfwpl;
        private Label label3;
        private Label sfppl;
        private Label label2;
        private Label sfpdl;
        private Label label4;
        private Label sfwnl;
        private Label sfpnl;
        private Label label5;
        private Label sfdl;
        private Label sfpl;
        private Button sfwb;
        private Button sfpb;
    }
}
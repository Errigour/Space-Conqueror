﻿namespace Space_Conqueror
{
    partial class NGNP
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
            nptb = new TextBox();
            npl = new Label();
            npb = new Button();
            SuspendLayout();
            // 
            // nptb
            // 
            nptb.Location = new Point(99, 6);
            nptb.Name = "nptb";
            nptb.Size = new Size(150, 23);
            nptb.TabIndex = 0;
            // 
            // npl
            // 
            npl.AutoSize = true;
            npl.Location = new Point(12, 9);
            npl.Name = "npl";
            npl.Size = new Size(81, 15);
            npl.TabIndex = 1;
            npl.Text = "Enter a Name:";
            // 
            // npb
            // 
            npb.Location = new Point(12, 35);
            npb.Name = "npb";
            npb.Size = new Size(237, 23);
            npb.TabIndex = 2;
            npb.Text = "Choose Name";
            npb.UseVisualStyleBackColor = true;
            npb.Click += npb_Click;
            // 
            // NGNP
            // 
            AcceptButton = npb;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 66);
            Controls.Add(npb);
            Controls.Add(npl);
            Controls.Add(nptb);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NGNP";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NGNP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nptb;
        private Label npl;
        private Button npb;
    }
}
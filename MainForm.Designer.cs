namespace Space_Conqueror
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ngb = new Button();
            lgb = new Button();
            SuspendLayout();
            // 
            // ngb
            // 
            ngb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ngb.Location = new Point(50, 400);
            ngb.Name = "ngb";
            ngb.Size = new Size(75, 23);
            ngb.TabIndex = 0;
            ngb.Text = "New Game";
            ngb.UseVisualStyleBackColor = true;
            ngb.Click += ngb_Click;
            // 
            // lgb
            // 
            lgb.Location = new Point(325, 400);
            lgb.Name = "lgb";
            lgb.Size = new Size(75, 23);
            lgb.TabIndex = 1;
            lgb.Text = "Load Game";
            lgb.UseVisualStyleBackColor = true;
            lgb.Click += lgb_Click;
            // 
            // MainForm
            // 
            AcceptButton = ngb;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(434, 461);
            Controls.Add(lgb);
            Controls.Add(ngb);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Space Conqueror";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ngb;
        private Button lgb;
    }
}

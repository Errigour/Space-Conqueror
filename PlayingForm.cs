using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Space_Conqueror
{
    public partial class PlayingForm : Form
    {
        public PS P = new();
        public PlayingForm()
        {
            InitializeComponent();
            CenterFormToScreen();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Program.MF.Show();
        }
        protected void CenterFormToScreen()
        {
            Screen screen = Screen.FromControl(this);
            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point(
                Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            );
        }
        public void UpdatePlayingFormLabels() // Define player form ship variables
        {
            int tp;
            int td;
            pfpnl.Text = P.Name;
            pfll.Text = P.Level.ToString("N0");
            pfel.Text = P.Exp.ToString("N0");
            pfdl.Text = String.Format("{0:C}", P.Dollars);
            pfsnl.Text = P.PShip.Name;
            pfsal.Text = P.PShip.Plate.Name;
            pfspl.Text = P.PShip.Plate.Plating.ToString("N0");
            pfspb.Image = P.PShip.PNG;
            pfwnl.Text = P.PShip.Arm.Name;
            pfwdl.Text = P.PShip.Arm.Dam.ToString("N0");
            tp = P.PShip.Plate.Plating + P.PShip.PlatingBonus;
            td = P.PShip.Arm.Dam + P.PShip.DamBonus;
            pftpl.Text = tp.ToString("N0");
            pftdl.Text = td.ToString("N0");

            if (P.Level >= 45 && P.PShip.Id >= 10 && P.PShip.Arm.Id >= 10 && P.PShip.Plate.Id >= 10)
                Freedom.Visible = true;
        }

        private void pfdbb_Click(object sender, EventArgs e)
        {
            DBayForm dBay = new DBayForm(this);
            dBay.ShowDialog();
        }

        private void pfsb_Click(object sender, EventArgs e)
        {
            ShopForm Shop = new ShopForm(this);
            Shop.ShowDialog();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = SystemColors.ControlText;
            menuStrip1.BackColor = this.BackColor;
            menuStrip1.ForeColor = this.ForeColor;
            pfdl.ForeColor = Color.ForestGreen;
            pfsaveb.BackColor = SystemColors.Control;
            pffb.BackColor = SystemColors.Control;
            pfdbb.BackColor = SystemColors.Control;
            pfsb.BackColor = SystemColors.Control;
            Freedom.BackColor = SystemColors.Control;
        }

        private void whiteOnBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            menuStrip1.BackColor = this.BackColor;
            menuStrip1.ForeColor = this.ForeColor;
            pfdl.ForeColor = Color.Gold;
            pfsaveb.BackColor = Color.Black;
            pffb.BackColor = Color.Black;
            pfdbb.BackColor = Color.Black;
            pfsb.BackColor = Color.Black;
            Freedom.BackColor = Color.Black;
        }

        private void goldBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
            this.ForeColor = SystemColors.ControlText;
            menuStrip1.BackColor = this.BackColor;
            menuStrip1.ForeColor = this.ForeColor;
            pfdl.ForeColor = Color.ForestGreen;
            pfsaveb.BackColor = SystemColors.Control;
            pffb.BackColor = SystemColors.Control;
            pfdbb.BackColor = SystemColors.Control;
            pfsb.BackColor = SystemColors.Control;
            Freedom.BackColor = SystemColors.Control;
        }

        private void goldOnGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
            this.ForeColor = Color.Gold;
            menuStrip1.BackColor = this.BackColor;
            menuStrip1.ForeColor = this.ForeColor;
            pfdl.ForeColor = Color.Gold;
            pfsaveb.BackColor = Color.ForestGreen;
            pffb.BackColor = Color.ForestGreen;
            pfdbb.BackColor = Color.ForestGreen;
            pfsb.BackColor = Color.ForestGreen;
            Freedom.BackColor = Color.ForestGreen;
        }

        private void purpleOnPinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            this.ForeColor = Color.Purple;
            menuStrip1.BackColor = this.BackColor;
            menuStrip1.ForeColor = this.ForeColor;
            pfdl.ForeColor = Color.Gold;
            pfsaveb.BackColor = Color.Pink;
            pffb.BackColor = Color.Pink;
            pfdbb.BackColor = Color.Pink;
            pfsb.BackColor = Color.Pink;
            Freedom.BackColor = Color.Pink;
        }
        private void pfsaveb_Click(object sender, EventArgs e)
        {
            SavedGame Save = new();

            Save.Name = P.Name;
            Save.ShipId = P.PShip.Id;
            Save.ArmId = P.PShip.Arm.Id;
            Save.PlateId = P.PShip.Plate.Id;
            Save.Exp = P.Exp;
            Save.Level = P.Level;
            Save.Dollars = P.Dollars;

            WriteToBinaryFile("Save.sg", Save);
        }

        private void pffb_Click(object sender, EventArgs e)
        {
            FightingForm FF = new FightingForm(this);

            this.Enabled = false;
            FF.Show();
            this.Enabled = true;
        }

        private void Freedom_Click(object sender, EventArgs e)
        {
            SavedGame Save = new();

            Save.Name = P.Name;
            Save.ShipId = P.PShip.Id;
            Save.ArmId = P.PShip.Arm.Id;
            Save.PlateId = P.PShip.Plate.Id;
            Save.Exp = P.Exp;
            Save.Level = P.Level;
            Save.Dollars = P.Dollars;

            WriteToBinaryFile("Save.sg", Save);

            this.Enabled = false;
            MessageBox.Show("You win!");
            this.Enabled = true;

            Environment.Exit(0);
        }

        // Writes the given object instance to a binary file.
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

    }
}

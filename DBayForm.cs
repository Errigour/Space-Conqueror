using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Conqueror
{
    public partial class DBayForm : Form
    {
        PlayingForm PForm;
        public DBayForm(PlayingForm pform)
        {
            InitializeComponent();
            CenterFormToScreen();

            PForm = pform;

            this.BackColor = pform.BackColor;
            this.ForeColor = pform.ForeColor;
            dbflb.BackColor = pform.pffb.BackColor;

            dbfs1pb.Image = Program.Ships[0].PNG;
            dbfs2pb.Image = Program.Ships[1].PNG;
            dbfs3pb.Image = Program.Ships[2].PNG;
            dbfs4pb.Image = Program.Ships[3].PNG;
            dbfs5pb.Image = Program.Ships[4].PNG;
            dbfs6pb.Image = Program.Ships[5].PNG;
            dbfs7pb.Image = Program.Ships[6].PNG;
            dbfs8pb.Image = Program.Ships[7].PNG;
            dbfs9pb.Image = Program.Ships[8].PNG;
            dbfs10pb.Image = Program.Ships[9].PNG;

            dbfs1nl.Text = Program.Ships[0].Name;
            dbfs2nl.Text = Program.Ships[1].Name;
            dbfs3nl.Text = Program.Ships[2].Name;
            dbfs4nl.Text = Program.Ships[3].Name;
            dbfs5nl.Text = Program.Ships[4].Name;
            dbfs6nl.Text = Program.Ships[5].Name;
            dbfs7nl.Text = Program.Ships[6].Name;
            dbfs8nl.Text = Program.Ships[7].Name;
            dbfs9nl.Text = Program.Ships[8].Name;
            dbfs10nl.Text = Program.Ships[9].Name;

            dbfs1dbl.Text = Program.Ships[0].DamBonus.ToString("N0");
            dbfs2dbl.Text = Program.Ships[1].DamBonus.ToString("N0");
            dbfs3dbl.Text = Program.Ships[2].DamBonus.ToString("N0");
            dbfs4dbl.Text = Program.Ships[3].DamBonus.ToString("N0");
            dbfs5dbl.Text = Program.Ships[4].DamBonus.ToString("N0");
            dbfs6dbl.Text = Program.Ships[5].DamBonus.ToString("N0");
            dbfs7dbl.Text = Program.Ships[6].DamBonus.ToString("N0");
            dbfs8dbl.Text = Program.Ships[7].DamBonus.ToString("N0");
            dbfs9dbl.Text = Program.Ships[8].DamBonus.ToString("N0");
            dbfs10dbl.Text = Program.Ships[9].DamBonus.ToString("N0");

            dbfs1pbl.Text = Program.Ships[0].PlatingBonus.ToString("N0");
            dbfs2pbl.Text = Program.Ships[1].PlatingBonus.ToString("N0");
            dbfs3pbl.Text = Program.Ships[2].PlatingBonus.ToString("N0");
            dbfs4pbl.Text = Program.Ships[3].PlatingBonus.ToString("N0");
            dbfs5pbl.Text = Program.Ships[4].PlatingBonus.ToString("N0");
            dbfs6pbl.Text = Program.Ships[5].PlatingBonus.ToString("N0");
            dbfs7pbl.Text = Program.Ships[6].PlatingBonus.ToString("N0");
            dbfs8pbl.Text = Program.Ships[7].PlatingBonus.ToString("N0");
            dbfs9pbl.Text = Program.Ships[8].PlatingBonus.ToString("N0");
            dbfs10pbl.Text = Program.Ships[9].PlatingBonus.ToString("N0");

            dbfs1ll.Text = Program.Ships[0].Level.ToString("N0");
            dbfs2ll.Text = Program.Ships[1].Level.ToString("N0");
            dbfs3ll.Text = Program.Ships[2].Level.ToString("N0");
            dbfs4ll.Text = Program.Ships[3].Level.ToString("N0");
            dbfs5ll.Text = Program.Ships[4].Level.ToString("N0");
            dbfs6ll.Text = Program.Ships[5].Level.ToString("N0");
            dbfs7ll.Text = Program.Ships[6].Level.ToString("N0");
            dbfs8ll.Text = Program.Ships[7].Level.ToString("N0");
            dbfs9ll.Text = Program.Ships[8].Level.ToString("N0");
            dbfs10ll.Text = Program.Ships[9].Level.ToString("N0");
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
        private void dbflb_Click(object sender, EventArgs e)
        {
            if (dbfs1rb.Checked == true)
            { PForm.P.PShip.CopyShip(Program.Ships[0]); }
            else if ( dbfs2rb.Checked == true && PForm.P.Level >= Program.Ships[1].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[1]); }
            else if ( dbfs3rb.Checked == true && PForm.P.Level >= Program.Ships[2].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[2]); }
            else if ( dbfs4rb.Checked == true && PForm.P.Level >= Program.Ships[3].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[3]); }
            else if ( dbfs5rb.Checked == true && PForm.P.Level >= Program.Ships[4].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[4]); }
            else if ( dbfs6rb.Checked == true && PForm.P.Level >= Program.Ships[5].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[5]); }
            else if ( dbfs7rb.Checked == true && PForm.P.Level >= Program.Ships[6].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[6]); }
            else if ( dbfs8rb.Checked == true && PForm.P.Level >= Program.Ships[7].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[7]); }
            else if ( dbfs9rb.Checked == true && PForm.P.Level >= Program.Ships[8].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[8]); }
            else if ( dbfs10rb.Checked == true && PForm.P.Level >= Program.Ships[9].Level)
            { PForm.P.PShip.CopyShip(Program.Ships[9]); }
            else
            { 
                this.Enabled = false;
                MessageBox.Show("You are Not a High Enough Level!");
                this.Enabled = true;
                return;
            }

            PForm.UpdatePlayingFormLabels();
            this.Close();
        }
    }
}

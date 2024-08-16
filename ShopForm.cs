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
    public partial class ShopForm : Form
    {
        PlayingForm PForm;
        Weapon? Weapon;
        Armor? Armor;
        public ShopForm(PlayingForm pform)
        {
            InitializeComponent();
            CenterFormToScreen();
            PForm = pform;
            DefineSW();
            DefineSA();
            DefineSD();

            this.BackColor = pform.BackColor;
            this.ForeColor = pform.ForeColor;
            sfpdl.ForeColor = pform.pfdl.ForeColor;
            sfwb.BackColor = pform.pffb.BackColor;
            sfpb.BackColor = pform.pffb.BackColor;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            PForm.UpdatePlayingFormLabels();
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
        private void sfwb_Click(object sender, EventArgs e)
        {
            if (Weapon != null && PForm.P.Dollars >= Weapon.Price)
            {
                PForm.P.Dollars -= Weapon.Price;
                PForm.P.PShip.EquipWeapon(Weapon);
                DefineSW();
                DefineSD();
                this.Enabled = false;
                MessageBox.Show("Thank You For Your Purchase!");
                this.Enabled = true;
            }
            else
            {
                this.Enabled = false;
                MessageBox.Show("You Can't Afford That!");
                this.Enabled = true;
            }
        }

        private void sfpb_Click(object sender, EventArgs e)
        {
            if (Armor != null && PForm.P.Dollars >= Armor.Price)
            {
                PForm.P.Dollars -= Armor.Price;
                PForm.P.PShip.EquipArmor(Armor);
                DefineSA();
                DefineSD();
                this.Enabled = false;
                MessageBox.Show("Thank You For Your Purchase!");
                this.Enabled = true;
            } else
            {
                this.Enabled = false;
                MessageBox.Show("You Can't Afford That!");
                this.Enabled = true;
            }
        }

        private void DefineSW()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (Program.Weapons[i].Id > PForm.P.PShip.Arm.Id)
                {
                    sfwpb.Image = Program.Weapons[i].PNG;
                    sfwnl.Text = Program.Weapons[i].Name;
                    sfwpl.Text = String.Format("{0:C}", Program.Weapons[i].Price);
                    sfdl.Text = Program.Weapons[i].Dam.ToString("N0");
                    Weapon = Program.Weapons[i];
                    break;
                }
            }
            if (i == 10)
            {
                sfwpb.Image = Properties.Resources.NoItemWeapon;
                sfwnl.Text = "Bought Out!";
                sfwpl.Text = "null";
                sfdl.Text = "null";
                Weapon = null;
                sfwb.Hide();
            }
            return;
        }
        private void DefineSA()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (Program.Armors[i].Id > PForm.P.PShip.Plate.Id)
                {
                    sfppb.Image = Program.Armors[i].PNG;
                    sfpnl.Text = Program.Armors[i].Name;
                    sfppl.Text = String.Format("{0:C}", Program.Armors[i].Price);
                    sfpl.Text = Program.Armors[i].Plating.ToString("N0");
                    Armor = Program.Armors[i];
                    break;
                }
            }
            if(i==10)
            {
                sfppb.Image = Properties.Resources.NoItemArmor;
                sfpnl.Text = "Bought Out!";
                sfppl.Text = "null";
                sfpl.Text = "null";
                Armor = null;
                sfpb.Hide();
            }
            return;
        }
        private void DefineSD()
        {
            sfpdl.Text = String.Format("{0:C}", PForm.P.Dollars);
        }
    }
}

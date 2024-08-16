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
    public partial class FightingForm : Form
    {
        PlayingForm PF;


        private int Tier;
        private bool Fighting = false;
        private int PlayerDam;
        private int PlayerPlating;
        private int EnemyDam;
        private int EnemyPlating;
        private int[] ExpToLevel = new int[46];
        
        public FightingForm(PlayingForm pf)
        {
            InitializeComponent();
            CenterFormToScreen();
            PF = pf;
            this.BackColor = PF.BackColor;
            this.ForeColor = PF.ForeColor;
            fft1b.BackColor = PF.pffb.BackColor;
            fft2b.BackColor = PF.pffb.BackColor;
            fft3b.BackColor = PF.pffb.BackColor;
            fft4b.BackColor = PF.pffb.BackColor;
            fft5b.BackColor = PF.pffb.BackColor;
            fft6b.BackColor = PF.pffb.BackColor;
            fft7b.BackColor = PF.pffb.BackColor;
            fft8b.BackColor = PF.pffb.BackColor;
            fft9b.BackColor = PF.pffb.BackColor;
            fft10b.BackColor = PF.pffb.BackColor;
            fffb.BackColor = PF.pffb.BackColor;
            ffcb.BackColor = PF.pffb.BackColor;

            int i;

            ExpToLevel[0] = 0;

            for(i = 1; i < 46; i++)
            {
                ExpToLevel[i] = i * 3 + ExpToLevel[i - 1];
            }
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            PF.UpdatePlayingFormLabels();
        }

        private void fft1b_Click(object sender, EventArgs e)
        {
            Tier = 1;
            StartFight();
        }

        private void fft2b_Click(object sender, EventArgs e)
        {
            Tier = 2;
            StartFight();
        }

        private void fft3b_Click(object sender, EventArgs e)
        {
            Tier = 3;
            StartFight();
        }

        private void fft4b_Click(object sender, EventArgs e)
        {
            Tier = 4;
            StartFight();
        }

        private void fft5b_Click(object sender, EventArgs e)
        {
            Tier = 5;
            StartFight();
        }

        private void fft6b_Click(object sender, EventArgs e)
        {
            Tier = 6;
            StartFight();
        }

        private void fft7b_Click(object sender, EventArgs e)
        {
            Tier = 7;
            StartFight();
        }

        private void fft8b_Click(object sender, EventArgs e)
        {
            Tier = 8;
            StartFight();
        }

        private void fft9b_Click(object sender, EventArgs e)
        {
            Tier = 9;
            StartFight();
        }

        private void fft10b_Click(object sender, EventArgs e)
        {
            Tier = 10;
            StartFight();
        }

        private void fffb_Click(object sender, EventArgs e)
        {
            Fight();
        }

        private void ffcb_Click(object sender, EventArgs e)
        {
            var r = new Random();
            int R = r.Next(2);
            if(R == 1)
            {
                Fighting = false;
                ffppl.Visible = false;
                fffb.Visible = false;
                ffcb.Visible = false;
                ffpprogb.Visible = false;
                ffepl.Visible = false;
                ffeprogb.Visible = false;
                ffepb.Visible = false;
            }
            else
            {
                Fight();
            }
        }

        private void StartFight()
        {
            if (PF.P.Level < ((Tier - 1) * 5) || Fighting == true)
            {
                if (Fighting == true)
                {
                    this.Enabled = false;
                    MessageBox.Show("You are Already Fighting!");
                    this.Enabled = true;
                }
                else
                {
                    this.Enabled = false;
                    MessageBox.Show($"Cannot face that Tier until Level {((Tier - 1) * 5)}");
                    this.Enabled = true;
                }
            }
            else
            {
                ffvl.Visible = false;

                Fighting = true;
                PlayerDam = PF.P.PShip.DamBonus + PF.P.PShip.Arm.Dam;
                PlayerPlating = PF.P.PShip.PlatingBonus + PF.P.PShip.Plate.Plating;
                EnemyDam = Program.Ships[Tier - 1].DamBonus;
                EnemyPlating = Program.Ships[Tier - 1].PlatingBonus;

                ffepb.Image = Program.Ships[Tier - 1].PNG;
                ffepb.Visible = true;

                ffeprogb.Minimum = 0;
                ffeprogb.Maximum = EnemyPlating;
                ffeprogb.Value = EnemyPlating;
                ffeprogb.Visible = true;

                ffepl.Text = $"{EnemyPlating}";
                ffepl.TextAlign = ContentAlignment.MiddleCenter;
                ffepl.Visible = true;

                ffpprogb.Minimum = 0;
                ffpprogb.Maximum = PlayerPlating;
                ffpprogb.Value = PlayerPlating;
                ffpprogb.Visible = true;

                ffppl.Text = $"{PlayerPlating}";
                ffppl.TextAlign = ContentAlignment.MiddleCenter;
                ffppl.Visible = true;

                fffb.Visible = true;
                ffcb.Visible = true;
            }
        }
        private void Fight()
        {
            var r = new Random();
            int R = r.Next(2);
            bool PlayerWins = true;

            EnemyPlating -= PlayerDam;
            PlayerPlating -= EnemyDam;

            if(PlayerPlating <= 0 && EnemyPlating <= 0 )
            {
                if (R == 1)
                    PlayerWins = true;
                else
                    PlayerWins = false;
            }
            else if (PlayerPlating <= 0)
            {
                PlayerWins = false;
            } 
            else if (EnemyPlating <= 0)
            {
                PlayerWins = true;
            }
            else
            {
                ffeprogb.Value = EnemyPlating;
                ffepl.Text = $"{EnemyPlating}";

                ffpprogb.Value = PlayerPlating;
                ffppl.Text = $"{PlayerPlating}";
                return;
            }

            if(PlayerWins == true)
            {
                int Dollars;
                int Exp;

                bool Leveled = false;

                if (Tier > 1) {
                    R = r.Next(((Tier - 1) * 5) + 4);
                    Exp = ExpToLevel[R];
                } else
                {
                    R = r.Next(5);
                    Exp = ExpToLevel[R];
                }

                Dollars = Exp * 50;

                PF.P.Dollars += Dollars;
                if (PF.P.Level < 45)
                {
                    PF.P.Exp += Exp;
                    while (ExpToLevel[PF.P.Level + 1] <= PF.P.Exp)
                    {
                        PF.P.Level += 1;
                        Leveled = true;
                        if (PF.P.Level >= 45)
                            break;
                    }
                }

                if (PF.P.Level >= 45)
                    ffvl.Text = $"Victory is yours!\nDollars: {Dollars}\nYou are already max level!";
                else if (Leveled)
                {
                    ffvl.Text = $"Victory is yours!\nDollars: {Dollars}\nExperience: {Exp}\nYou are now level {PF.P.Level}!";
                }
                else
                {
                    ffvl.Text = $"Victory is yours!\nDollars: {Dollars}\nExperience: {Exp}";
                }
            }
            else
            {
                ffvl.Text = $"You were defeated!";
            }
            ffvl.Visible = true;
            Fighting = false;
            ffppl.Visible = false;
            fffb.Visible = false;
            ffcb.Visible = false;
            ffpprogb.Visible = false;
            ffepl.Visible = false;
            ffeprogb.Visible = false;
            ffepb.Visible = false;
        }
    }
}

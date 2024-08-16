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
    public partial class NGNP : Form
    {
        public NGNP()
        {
            InitializeComponent();
            CenterFormToScreen();
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
        private void npb_Click(object sender, EventArgs e)
        {
            if(nptb.TextLength > 0)
            {
                string Errigour = "Errigour";
                string Dopy = "Dopy";

                Program.Playing = new();
                Program.Playing.P.Name = nptb.Text;
                if (nptb.Text == Errigour)
                {
                    Program.Playing.P.Dollars = 1000000000.01;
                    Program.Playing.P.Level = 45;
                }
                if (nptb.Text == Dopy)
                {
                    Program.Playing.P.Dollars = 4000.01;
                }
                Program.Playing.UpdatePlayingFormLabels();
                Program.MF.Hide();
                Program.Playing.Show();
                this.Close();
            }
        }
    }
}

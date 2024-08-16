using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Resources;
using System.Configuration;
using System.Text.Json;
using System.Runtime.Serialization;

namespace Space_Conqueror
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterFormToScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ngb_Click(object sender, EventArgs e)
        {
            NGNP prompt = new();
            prompt.Show();
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

        private void lgb_Click(object sender, EventArgs e)
        {
            Program.Playing = new PlayingForm();
            Program.Playing.P.Name = "Dopy";
            Program.Playing.P.PShip.CopyShip(Program.Ships[0]);
            Program.Playing.P.PShip.EquipWeapon(Program.Weapons[0]);
            Program.Playing.P.PShip.EquipArmor(Program.Armors[0]);
            Program.Playing.P.Exp = 0;
            Program.Playing.P.Level = 0;
            Program.Playing.P.Dollars = 3500.01;
            if (File.Exists("Save.sg"))
            {
                SavedGame Save = ReadFromBinaryFile<SavedGame>("Save.sg");
                if (Save != null)
                {
                    Program.Playing = new PlayingForm();
                    Program.Playing.P.Name = Save.Name;
                    Program.Playing.P.PShip.CopyShip(Program.Ships[Save.ShipId - 1]);
                    Program.Playing.P.PShip.EquipWeapon(Program.Weapons[Save.ArmId - 1]);
                    Program.Playing.P.PShip.EquipArmor(Program.Armors[Save.PlateId - 1]);
                    Program.Playing.P.Exp = Save.Exp;
                    Program.Playing.P.Level = Save.Level;
                    Program.Playing.P.Dollars = Save.Dollars;
                }
            }
            Program.Playing.UpdatePlayingFormLabels();
            Program.MF.Hide();
            Program.Playing.Show();
        }
        // Reads an object from a binary file.
        public static T? ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {
                    return (T)binaryFormatter.Deserialize(stream);
                }
                catch (SerializationException ex)
                {
                    return default; //return default(T); simplified
                }
            }
        }
    }
}

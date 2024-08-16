using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Space_Conqueror
{
    public class Weapon
    {
        public int Id = 1;
        public string Name = "Basic Weapon";
        public Image PNG = Properties.Resources.NoItemWeapon;
        public double Price = 1000;
        public int Dam = 1; //Damage
    }
    public class Armor
    {
        public int Id = 1;
        public string Name = "Basic Armor";
        public Image PNG = Properties.Resources.NoItemArmor;
        public double Price = 1000;
        public int Plating = 5;
    }

    public class Ship
    {
        public int Id = 1;
        public string Name ="Voyager";
        public Image PNG = Properties.Resources.Voyager;
        public int Level = 0;

        public int DamBonus = 1;
        public int PlatingBonus = 5;

        public Weapon Arm = new();
        public Armor Plate = new();
        public void CopyShip(Ship Ship)
        {
            Id = Ship.Id;
            Name = Ship.Name;
            PNG = Ship.PNG;
            Level = Ship.Level;
            DamBonus = Ship.DamBonus;
            PlatingBonus = Ship.PlatingBonus;
            //if (Arm.Id < Ship.Arm.Id)
            //{
            //    Arm.Id = Ship.Arm.Id;
            //    Arm.Name = Ship.Arm.Name;
            //    Arm.Dam = Ship.Arm.Dam;
            //}
            //if (Plate.Id < Ship.Plate.Id)
            //{
            //    Plate.Id = Ship.Plate.Id;
            //    Plate.Name = Ship.Plate.Name;
            //    Plate.Plating = Ship.Plate.Plating;
            //}
        }
        public void EquipWeapon(Weapon Weapon)
        {
            Arm.Id = Weapon.Id;
            Arm.Name= Weapon.Name;
            Arm.Dam= Weapon.Dam;
        }
        public void EquipArmor(Armor Armor)
        {
            Plate.Id=Armor.Id;
            Plate.Name=Armor.Name;
            Plate.Plating=Armor.Plating;
        }
    }

    public class PS // Player Stats
    {
        public string Name = "";

        public Ship PShip = new();

        public int Exp = 0; // Experience
        public int Level = 0;
        public double Dollars = 3800.01;
    }
    [Serializable]
    public class SavedGame
    {
        public string Name;
        public int ShipId;
        public int ArmId;
        public int PlateId;
        public int Exp;
        public int Level;
        public double Dollars;
    }
    internal static class Program
    {
        public static MainForm MF = new();
        public static PlayingForm? Playing;
        public static Ship[] Ships = new Ship[10];
        public static Weapon[] Weapons = new Weapon[10];
        public static Armor[] Armors = new Armor[10];
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InitWeapons();
            InitArmors();
            InitShips();
            Application.Run(MF);
        }
        private static void InitShips()
        {
            int i;
            int j = 3;
            for (i = 0; i < 10; i++) 
            {
                Ships[i] = new Ship();
                Ships[i].Id = i + 1;
                Ships[i].Level = i * 5;
                Ships[i].EquipWeapon(Weapons[i]);
                Ships[i].EquipArmor(Armors[i]);
                if(i>0)
                {
                    Ships[i].DamBonus = Ships[i - 1].DamBonus + j;
                    Ships[i].PlatingBonus = Ships[i].DamBonus * 5;
                    j += 3;
                }
            }
            Ships[1].Name = "Dryad";
            Ships[2].Name = "Polip";
            Ships[3].Name = "Commenter";
            Ships[4].Name = "Stealth Striker";
            Ships[5].Name = "Star Flyer";
            Ships[6].Name = "Battleship";
            Ships[7].Name = "U. F. O.";
            Ships[8].Name = "Wright Flyer";
            Ships[9].Name = "Hexapla";

            Ships[1].PNG = Properties.Resources.Dryad;
            Ships[2].PNG = Properties.Resources.Polip;
            Ships[3].PNG = Properties.Resources.Commenter;
            Ships[4].PNG = Properties.Resources.StealthStriker;
            Ships[5].PNG = Properties.Resources.StarFlyer;
            Ships[6].PNG = Properties.Resources.Battleship;
            Ships[7].PNG = Properties.Resources.UFO;
            Ships[8].PNG = Properties.Resources.WrightFlyer;
            Ships[9].PNG = Properties.Resources.Hexapla;
        }
        private static void InitWeapons()
        {
            int i;
            int j = 300;
            for (i = 0; i < 10; i++)
            {
                Weapons[i] = new Weapon();
                Weapons[i].Id = i + 1;
                if (i > 0)
                {
                    Weapons[i].Price = Weapons[i - 1].Price + j * 3;
                    j += 300;
                }

            }
            Weapons[1].Name = "Laser Rifles";
            Weapons[2].Name = "Laser Canon";
            Weapons[3].Name = "Tesla Coils";
            Weapons[4].Name = "Turrets";
            Weapons[5].Name = "Automatic Turrets";
            Weapons[6].Name = "Missiles";
            Weapons[7].Name = "Photon Torpedos";
            Weapons[8].Name = "Silver Bullet";
            Weapons[9].Name = "Doomsday Device";

            Weapons[1].PNG = Properties.Resources.LaserRifles;
            Weapons[2].PNG = Properties.Resources.LaserCanon;
            Weapons[3].PNG = Properties.Resources.TeslaCoils;
            Weapons[4].PNG = Properties.Resources.Turrets;
            Weapons[5].PNG = Properties.Resources.AutomaticTurrets;
            Weapons[6].PNG = Properties.Resources.Missiles;
            Weapons[7].PNG = Properties.Resources.PhotonTorpedos;
            Weapons[8].PNG = Properties.Resources.SilverBullet;
            Weapons[9].PNG = Properties.Resources.DoomsdayDevice;

            Weapons[1].Dam = 5;
            Weapons[2].Dam = 12;
            Weapons[3].Dam = 22;
            Weapons[4].Dam = 35;
            Weapons[5].Dam = 51;
            Weapons[6].Dam = 70;
            Weapons[7].Dam = 92;
            Weapons[8].Dam = 117;
            Weapons[9].Dam = 145;
        }
        private static void InitArmors()
        {
            int i;
            int j = 300;
            for (i = 0; i < 10; i++)
            {
                Armors[i] = new Armor();
                Armors[i].Id = i + 1;
                if (i > 0)
                {
                    Armors[i].Price = Armors[i - 1].Price + j * 3;
                    j += 300;
                }
            }
            Armors[1].Name = "Insulated Fiber";
            Armors[2].Name = "Aluminum Sheets";
            Armors[3].Name = "Iron Plating";
            Armors[4].Name = "Steel Plating";
            Armors[5].Name = "Reinforced Steel";
            Armors[6].Name = "Titanium Plating";
            Armors[7].Name = "Aft Shields";
            Armors[8].Name = "Invisibility";
            Armors[9].Name = "Divine Protection";

            Armors[1].PNG = Properties.Resources.InsulatedFiber;
            Armors[2].PNG = Properties.Resources.AluminumSheets;
            Armors[3].PNG = Properties.Resources.IronPlating;
            Armors[4].PNG = Properties.Resources.SteelPlating;
            Armors[5].PNG = Properties.Resources.ReinforcedSteel;
            Armors[6].PNG = Properties.Resources.TitaniumPlating;
            Armors[7].PNG = Properties.Resources.AftShields;
            Armors[8].PNG = Properties.Resources.Invisibility;
            Armors[9].PNG = Properties.Resources.DivineProtection;

            Armors[1].Plating = 25;
            Armors[2].Plating = 60;
            Armors[3].Plating = 110;
            Armors[4].Plating = 175;
            Armors[5].Plating = 255;
            Armors[6].Plating = 350;
            Armors[7].Plating = 460;
            Armors[8].Plating = 585;
            Armors[9].Plating = 725;
        }
    }
}
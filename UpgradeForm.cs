using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starfinder_Starship_Hanger
{
    public partial class UpgradeForm : Form
    {
        Form1 Main;
        public UpgradeForm(Form1 Form1)
        {
            InitializeComponent();
            Main = Form1;

        }

        private void UpgradeForm_Load(object sender, EventArgs e)
        {
            upgradeWpnsHide();
            UpgradesVisibleValuesSet();
        }

        private void upgradeWpnsHide()
        {
            forward01cb.Visible = false;
            forward02cb.Visible = false;
            forward03cb.Visible = false;
            forward04cb.Visible = false;
            port01cb.Visible = false;
            port02cb.Visible = false;
            port03cb.Visible = false;
            port04cb.Visible = false;
            starboard01cb.Visible = false;
            starboard02cb.Visible = false;
            starboard03cb.Visible = false;
            starboard04cb.Visible = false;
            aft01cb.Visible = false;
            aft02cb.Visible = false;
            aft03cb.Visible = false;
            aft04cb.Visible = false;
            turret01cb.Visible = false;
            turret02cb.Visible = false;
            turret03cb.Visible = false;
            turret04cb.Visible = false;
        }

        public void UpgradesVisibleValuesSet()
        {
            List<ComboBox> upgradeBoxes = Main.ActiveWeaponsBoxes();
            foreach(var b in upgradeBoxes)
            {
                b.Visible = true;
                b.DataSource = Sizes();
            }
        }



        public List<string> Sizes()
        {
            List<string> sizeCat = new List<string>();
            sizeCat.Add(Light());
            sizeCat.Add(Heavy());
            sizeCat.Add(Capital());
            return sizeCat;
        }

        public string Light()
        {
            return "Light";
        }

        public string Heavy()
        {
            return "Heavy";
        }

        public string Capital()
        {
            return "Capital";
        }
    }
}

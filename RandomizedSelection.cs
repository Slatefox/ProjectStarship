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
    public partial class RandomizedSelection : Form
    {
        public RandomizedSelection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.randShipBalanced = true;
            Form1.randShipSpeed = false;
            Form1.randShipOffense = false;
            Form1.randShipDefense = false;
            Form1.randShipSelected = true;
            Form1.RandomShip.Dispose();
            Form1.RandomShip.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.randShipBalanced = false;
            Form1.randShipSpeed = true;
            Form1.randShipOffense = false;
            Form1.randShipDefense = false;
            Form1.randShipSelected = true;
            Form1.RandomShip.Dispose();
            Form1.RandomShip.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.randShipBalanced = false;
            Form1.randShipSpeed = false;
            Form1.randShipOffense = true;
            Form1.randShipDefense = false;
            Form1.randShipSelected = true;
            Form1.RandomShip.Dispose();
            Form1.RandomShip.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.randShipBalanced = false;
            Form1.randShipSpeed = false;
            Form1.randShipOffense = false;
            Form1.randShipDefense = true;
            Form1.randShipSelected = true;
            Form1.RandomShip.Dispose();
            Form1.RandomShip.Close();
        }
    }
}

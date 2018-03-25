using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;

namespace Starfinder_Starship_Hanger
{

    public partial class Form1 : Form
    {
        // All Global Variables
        #region Global Variables

        public int totalBPCount = 0;            // Count of Total Build Points for a Ship
        public static int BP;
        public int spentBPCount = 0;            // Count of BP spent
        public int totalPCUCount = 0;           // Count of Total Power Core Units Available
        public static int PCU;
        public int spentPCUCount = 0;           // Count of Total Power Core Units Spent
        public string shipTier;                 // Ship Tier
        public string shipSize;                 // Ship Size
        public int shipSizeInt = 0;             // Ship Size Integer Representation
        public int shipSizeMod = 0;             // Ship Size Modifier
        public string shipFrame;                // Ship Frame
        public int expBayNum = 0;               // Number of Expansion Bays
        public int expBPSpent = 0;              // Number of Expansion Bay Build Points Spent
        public int shipPCURating = 0;           // Total Ship Power Core Rating
        public int shipSpeed = 0;               // Ship Speed
        public int pilotingModAdj;              // Piloting Modifer Adjusted
        public int pilotingMod;                 // Piloting Modifer
        public int ac = 10;                     // Base Armor Class
        public int tl = 10;                     // Base Target Lock
        public int hp = 0;                      // Hull Points
        public int dt = 0;                      // Damage Threshold
        public int ct = 0;                      // Critical Threshold
        public int pilotRanks = 0;              // Denotes the amount of training the pilot has.
        public bool core2next = false;          // Boolean to track whether or not the second power core is selected next.
        public bool securitynext = false;       // Boolean to track whether or not Security Options are selected next.
        public int computerTier = 0;            // Integer to note the tier level of the on board computer.
        public int securityBPSpent = 0;         // Integer to track the amount of BP spent on security options
        public bool smugBay = false;            // Boolean to track whether or not the ship has a smuggling bay.
        public bool core2 = false;              // Boolean to track whether or not the ship has a second power core
        public int sensorMod = 0;                           // Not Currently Used
        public int totSP = 0;                               // Not Currently Used
        public bool wpnUpgradeEntered = false;  // Boolean to keep the weapons slot upgrade from resetting.

        // Booleans for weapons slot upgrades
        public bool f1Light = false;
        public bool f2Light = false;
        public bool f3Light = false;
        public bool f4Light = false;
        public bool p1Light = false;
        public bool p2Light = false;
        public bool p3Light = false;
        public bool p4Light = false;
        public bool s1Light = false;
        public bool s2Light = false;
        public bool s3Light = false;
        public bool s4Light = false;
        public bool a1Light = false;
        public bool a2Light = false;
        public bool a3Light = false;
        public bool a4Light = false;
        public bool t1Light = false;
        public bool t2Light = false;
        public bool t3Light = false;
        public bool t4Light = false;

        public bool f1Heavy = false;
        public bool f2Heavy = false;
        public bool f3Heavy = false;
        public bool f4Heavy = false;
        public bool p1Heavy = false;
        public bool p2Heavy = false;
        public bool p3Heavy = false;
        public bool p4Heavy = false;
        public bool s1Heavy = false;
        public bool s2Heavy = false;
        public bool s3Heavy = false;
        public bool s4Heavy = false;
        public bool a1Heavy = false;
        public bool a2Heavy = false;
        public bool a3Heavy = false;
        public bool a4Heavy = false;
        public bool t1Heavy = false;
        public bool t2Heavy = false;
        public bool t3Heavy = false;
        public bool t4Heavy = false;

        public bool f1Cap = false;
        public bool f2Cap = false;
        public bool f3Cap = false;
        public bool f4Cap = false;
        public bool p1Cap = false;
        public bool p2Cap = false;
        public bool p3Cap = false;
        public bool p4Cap = false;
        public bool s1Cap = false;
        public bool s2Cap = false;
        public bool s3Cap = false;
        public bool s4Cap = false;
        public bool a1Cap = false;
        public bool a2Cap = false;
        public bool a3Cap = false;
        public bool a4Cap = false;

        // Integers to track the cost of weapons slot upgrades.

        public int weaponsUpgradeBaseValue = 0;
        public int weaponsUpgradeTotal = 0;

        // These are the public variables that will be used to populate the Starship Sheet.

        public static string sTier;  //Done
        public static string sBuildPointsTotal;  //done
        public static string sBuildPointsUsed;  //done
        public static string sName;  //Done
        public static string sMake;  //done
        public static string sModel;  //done
        public static string sFrame;  //done
        public static string sHPTotal;  //done
        public static string sCT;  //done
        public static string sDT;  //done
        public static string sManuever;  //done
        public static string sSize;  //done
        public static string sSizeNumber;  //done
        public static string sPowerCore1;  //done
        public static string sPowerCore2;  //done
        public static string sPCUTotal;  //done
        public static string sSensors;  //done
        public static string sSensorRange;  //done
        public static string sSensorMod;  //done
        public static string sComputer;  //done
        public static string sCompBonus;  //done
        public static string sCompNodes;  //done
        public static string sQuarters;  //done
        public static string sThrusters;  //done
        public static string sThrusterSpeed;  //done
        public static string sHyperspaceEngine;  //done
        public static string sHyperspaceRating;  //done
        public static string sShields;  //done
        public static string sShieldTotal;  //done
        public static string sShieldRegen;  //done
        public static string sArmor;  //done
        public static string sACTotal;  //done
        public static string sPilotMod;                                             // NOT DONE
        public static string sACBonus;  //done
        public static string sSizeMod;  //done
        public static string sACMiscMod;                    // left blank
        public static string sCountermeasures;  //done
        public static string sTLTotal;  //done
        public static string sTLBonus;  //done
        public static string sTLMiscMod;                    // left blank
        public static string sExpBay01 = "";  //done
        public static string sExpBay02 = "";  //done
        public static string sExpBay03 = "";  //done
        public static string sExpBay04 = "";  //done
        public static string sExpBay05 = "";  //done
        public static string sExpBay06 = "";  //done
        public static string sExpBay07 = "";  //done
        public static string sExpBay08 = "";  //done
        public static string sExpBay09 = "";  //done
        public static string sExpBay10 = "";  //done
        public static string sExpBay11 = "";  //done
        public static string sExpBay12 = "";  //done
        public static string sExpBay13 = "";  //done
        public static string sExpBay14 = "";  //done
        public static string sExpBay15 = "";  //done
        public static string sExpBay16 = "";  //done
        public static string sExpBay17 = "";  //done
        public static string sExpBay18 = "";  //done
        public static string sExpBay19 = "";  //done
        public static string sExpBay20 = "";  //done
        public static string sSmugglingDC;  //done
        public static string sCompCountermeasureNum;  //done
        public static bool sCompAntiHack;  //done
        public static string strCompAntiHack;                                                       // Added
        public static string sCompHackDC;                                           // NOT DONE
        public static bool sBiolocks;  //done
        public static string strBiolocks;                                                           // Added
        public static bool sSelfDestruct;  //done
        public static string strSelfDestruct;                                                       // Added
        public static string sAntipersonnelWPN;             // left blank
        public static string sAntipersonnelDMG;             // left blank
        public static string sFWPNS01;  //done
        public static string sFDMG01;  //done
        public static string sFWPNS02;  //done
        public static string sFDMG02;  //done
        public static string sFWPNS03;  //done
        public static string sFDMG03;  //done
        public static string sFWPNS04;  //done
        public static string sFDMG04;   //done
        public static string sPWPNS01;  //done
        public static string sPDMG01;  //done
        public static string sPWPNS02;  //done
        public static string sPDMG02;  //done
        public static string sPWPNS03;  //done
        public static string sPDMG03;  //done
        public static string sPWPNS04;  //done
        public static string sPDMG04;  //done
        public static string sSWPNS01;  //done
        public static string sSDMG01;  //done
        public static string sSWPNS02;  //done
        public static string sSDMG02;  //done
        public static string sSWPNS03;  //done
        public static string sSDMG03;  //done
        public static string sSWPNS04;  //done
        public static string sSDMG04;  //done
        public static string sTWPNS01;  //done
        public static string sTDMG01;  //done
        public static string sTWPNS02;  //done
        public static string sTDMG02;  //done
        public static string sTWPNS03;  //done
        public static string sTDMG03;  //done
        public static string sTWPNS04;  //done
        public static string sTDMG04;  //done
        public static string sAWPNS01;  //done
        public static string sADMG01;  //done
        public static string sAWPNS02;  //done
        public static string sADMG02;  //done
        public static string sAWPNS03;  //done
        public static string sADMG03;  //done
        public static string sAWPNS04;  //done
        public static string sADMG04;  //done
        public static bool randShipBalanced = false;
        public static bool randShipSpeed = false;
        public static bool randShipOffense = false;
        public static bool randShipDefense = false;
        public static bool randShipSelected = false;
        public static RandomizedSelection RandomShip = new RandomizedSelection();


        public bool tierSelected = false;
        public bool frameSelected = false;
        public bool powerCore1Selected = false;
        public bool thrustersSelected = false;
        public bool armorSelected = false;
        public bool computerSelected = false;
        public bool quartersSelected = false;
        public bool countermeasuresSelected = false;
        public bool hyperspaceEngineSelected = false;
        public bool expBaySelected = false;
        public bool smugglingBaySelected = false;
        public bool powerCore2Selected = false;
        public bool securitySelected = false;
        public bool sensorsSelected = false;
        public bool shieldsSelected = false;
        public bool weaponSlotSelected = false;
        public bool weaponsSelected = false;
        public bool weaponsLinkSelected = false;

        // track if weapons link
        public static bool forwLink1 = false;                              // Added
        public static bool forwLink2 = false;
        public static bool turLink1 = false;
        public static bool turLink2 = false;
        public static bool aftLink1 = false;
        public static bool aftLink2 = false;
        public static bool starbLink1 = false;
        public static bool starbLink2 = false;
        public static bool portLink1 = false;
        public static bool portLink2 = false;                              // Added

        // Tracks the type of linked weapons
        public static string forWpnTypeLink1 = "";                         // Added
        public static string forWpnTypeLink2 = "";
        public static string turWpnTypeLink1 = "";
        public static string turWpnTypeLink2 = "";
        public static string aftWpnTypeLink1 = "";
        public static string aftWpnTypeLink2 = "";
        public static string starbWpnTypeLink1 = "";
        public static string starbWpnTypeLink2 = "";
        public static string portWpnTypeLink1 = "";
        public static string portWpnTypeLink2 = "";                        // Added
        // Holds total linking cost for calculation
        int totalLinkCost = 0;
        public static string forwLinkChkBox1Type = "";
        public static string forwLinkChkBox2Type = "";
        public static string turLinkChkBox1Type = "";
        public static string turLinkChkBox2Type = "";
        public static string aftLinkChkBox1Type = "";
        public static string aftLinkChkBox2Type = "";
        public static string starbLinkChkBox1Type = "";
        public static string starbLinkChkBox2Type = "";
        public static string portLinkChkBox1Type = "";
        public static string portLinkChkBox2Type = "";                      // Added
        // Added for File -> new option to rebuild the form
        private AssemblyBay Bay;
        private List<Tier> BuildTier;
        private List<BaseFrame> BuildFrames;
        private List<PowerCore> BuildCores;
        private List<Thruster> BuildThrusters;
        private List<Armor> BuildArmor;
        private List<Computer> BuildComputers;
        private List<Quarters> BuildQuarters;
        private List<Countermeasures> BuildCM;
        private List<HyperspaceEngine> BuildHyperspaceEngine;
        private List<ExpansionBay> BuildExpBays01;
        private List<ExpansionBay> BuildExpBays02;
        private List<ExpansionBay> BuildExpBays03;
        private List<ExpansionBay> BuildExpBays04;
        private List<ExpansionBay> BuildExpBays05;
        private List<ExpansionBay> BuildExpBays06;
        private List<ExpansionBay> BuildExpBays07;
        private List<ExpansionBay> BuildExpBays08;
        private List<ExpansionBay> BuildExpBays09;
        private List<ExpansionBay> BuildExpBays10;
        private List<ExpansionBay> BuildExpBays11;
        private List<ExpansionBay> BuildExpBays12;
        private List<ExpansionBay> BuildExpBays13;
        private List<ExpansionBay> BuildExpBays14;
        private List<ExpansionBay> BuildExpBays15;
        private List<ExpansionBay> BuildExpBays16;
        private List<ExpansionBay> BuildExpBays17;
        private List<ExpansionBay> BuildExpBays18;
        private List<ExpansionBay> BuildExpBays19;
        private List<ExpansionBay> BuildExpBays20;
        private List<PowerCore> BuildCores2;
        private List<Sensor> BuildSensors;
        private List<Shield> BuildShields;

        #endregion


        public Form1()
        {
            InitializeComponent();
            statusLabel.Text = "Select Starship Tier";
            Bay = new AssemblyBay();
            BuildTier = Bay.ConstructTierLoad();
            BuildFrames = Bay.ConstructFrameLoad();
            BuildCores = Bay.ConstructPowerCoreLoad();
            BuildThrusters = Bay.ConstructThrusterLoad();
            BuildArmor = Bay.ConstructArmorLoad();
            BuildComputers = Bay.ConstructComputerLoad();
            BuildQuarters = Bay.ConstructQuartersLoad();
            BuildCM = Bay.ConstructCountermeasuresLoad();
            BuildHyperspaceEngine = Bay.ConstructHyperspaceEngineLoad();
            BuildExpBays01 = Bay.ConstructExpansionBayLoad01();
            BuildExpBays02 = Bay.ConstructExpansionBayLoad02();
            BuildExpBays03 = Bay.ConstructExpansionBayLoad03();
            BuildExpBays04 = Bay.ConstructExpansionBayLoad04();
            BuildExpBays05 = Bay.ConstructExpansionBayLoad05();
            BuildExpBays06 = Bay.ConstructExpansionBayLoad06();
            BuildExpBays07 = Bay.ConstructExpansionBayLoad07();
            BuildExpBays08 = Bay.ConstructExpansionBayLoad08();
            BuildExpBays09 = Bay.ConstructExpansionBayLoad09();
            BuildExpBays10 = Bay.ConstructExpansionBayLoad10();
            BuildExpBays11 = Bay.ConstructExpansionBayLoad11();
            BuildExpBays12 = Bay.ConstructExpansionBayLoad12();
            BuildExpBays13 = Bay.ConstructExpansionBayLoad13();
            BuildExpBays14 = Bay.ConstructExpansionBayLoad14();
            BuildExpBays15 = Bay.ConstructExpansionBayLoad15();
            BuildExpBays16 = Bay.ConstructExpansionBayLoad16();
            BuildExpBays17 = Bay.ConstructExpansionBayLoad17();
            BuildExpBays18 = Bay.ConstructExpansionBayLoad18();
            BuildExpBays19 = Bay.ConstructExpansionBayLoad19();
            BuildExpBays20 = Bay.ConstructExpansionBayLoad20();
            BuildCores2 = Bay.ConstructPowerCore2Load();
            BuildSensors = Bay.ConstructSensorLoad();
            BuildShields = Bay.ConstructShieldLoad();
            tierComboBox.DataSource = BuildTier;
            tierComboBox.DisplayMember = "Type";
            frameComboBox.DataSource = BuildFrames;
            frameComboBox.DisplayMember = "Type";
            powerCoreComboBox.DataSource = BuildCores;
            powerCoreComboBox.DisplayMember = "Type";
            thrustersComboBox.DataSource = BuildThrusters;
            thrustersComboBox.DisplayMember = "Type";
            armorComboBox.DataSource = BuildArmor;
            armorComboBox.DisplayMember = "Type";
            calcAC();
            ACTextBox.Text = ac.ToString();
            computerComboBox.DataSource = BuildComputers;
            computerComboBox.DisplayMember = "Type";
            quartersComboBox.DataSource = BuildQuarters;
            quartersComboBox.DisplayMember = "Type";
            countermeasuresComboBox.DataSource = BuildCM;
            countermeasuresComboBox.DisplayMember = "Type";
            calcTL();
            TLTextBox.Text = tl.ToString();
            hyperspaceEngineComboBox.DataSource = BuildHyperspaceEngine;
            hyperspaceEngineComboBox.DisplayMember = "Type";
            expBayComboBox1.DataSource = BuildExpBays01;
            expBayComboBox1.DisplayMember = "Type";
            expBayComboBox2.DataSource = BuildExpBays02;
            expBayComboBox2.DisplayMember = "Type";
            expBayComboBox3.DataSource = BuildExpBays03;
            expBayComboBox3.DisplayMember = "Type";
            expBayComboBox4.DataSource = BuildExpBays04;
            expBayComboBox4.DisplayMember = "Type";
            expBayComboBox5.DataSource = BuildExpBays05;
            expBayComboBox5.DisplayMember = "Type";
            expBayComboBox6.DataSource = BuildExpBays06;
            expBayComboBox6.DisplayMember = "Type";
            expBayComboBox7.DataSource = BuildExpBays07;
            expBayComboBox7.DisplayMember = "Type";
            expBayComboBox8.DataSource = BuildExpBays08;
            expBayComboBox8.DisplayMember = "Type";
            expBayComboBox9.DataSource = BuildExpBays09;
            expBayComboBox9.DisplayMember = "Type";
            expBayComboBox10.DataSource = BuildExpBays10;
            expBayComboBox10.DisplayMember = "Type";
            expBayComboBox11.DataSource = BuildExpBays11;
            expBayComboBox11.DisplayMember = "Type";
            expBayComboBox12.DataSource = BuildExpBays12;
            expBayComboBox12.DisplayMember = "Type";
            expBayComboBox13.DataSource = BuildExpBays13;
            expBayComboBox13.DisplayMember = "Type";
            expBayComboBox14.DataSource = BuildExpBays14;
            expBayComboBox14.DisplayMember = "Type";
            expBayComboBox15.DataSource = BuildExpBays15;
            expBayComboBox15.DisplayMember = "Type";
            expBayComboBox16.DataSource = BuildExpBays16;
            expBayComboBox16.DisplayMember = "Type";
            expBayComboBox17.DataSource = BuildExpBays17;
            expBayComboBox17.DisplayMember = "Type";
            expBayComboBox18.DataSource = BuildExpBays18;
            expBayComboBox18.DisplayMember = "Type";
            expBayComboBox19.DataSource = BuildExpBays19;
            expBayComboBox19.DisplayMember = "Type";
            expBayComboBox20.DataSource = BuildExpBays20;
            expBayComboBox20.DisplayMember = "Type";
            powerCore2ComboBox.DataSource = BuildCores2;
            powerCore2ComboBox.DisplayMember = "Type";
            sensorsComboBox.DataSource = BuildSensors;
            sensorsComboBox.DisplayMember = "Type";
            shieldsComboBox.DataSource = BuildShields;
            shieldsComboBox.DisplayMember = "Type";
            tierGB.BackColor = Color.Lime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Buttons

        private void randomizeBTN_Click(object sender, EventArgs e)
        {
            if (tierSelected == true && frameSelected == true && powerCore1Selected == true)
            {
                randomShipGen();
            }
            else
            {
                MessageBox.Show("Please select a Ship Tier, Ship Frame, and Ship Power Core before trying to randomly generate a ship.");
            }
        }


        private void starshipNameSelectButton_Click(object sender, EventArgs e)
        {
            starshipName.Text = starshipNameTextBox.Text;
            sName = starshipName.Text;
        }

        private void starshipMakeSelectButton_Click(object sender, EventArgs e)
        {
            starshipMake.Text = starshipMakeTextBox.Text;
            sMake = starshipMake.Text;
        }

        private void starshipModelSelectButton_Click(object sender, EventArgs e)
        {
            starshipModel.Text = starshipModelTextBox.Text;
            sModel = starshipModel.Text;
        }

        private void tierSelectButton_Click(object sender, EventArgs e)
        {
            if (tierSelected == false)
            {
                Tier tierSelection = confirmTier();

                totalBPCount = tierSelection.Bp;
                totalBuildPoints.Text = totalBPCount.ToString();
                sBuildPointsTotal = totalBuildPoints.Text;
                currentBuildPoints.Text = calcBP().ToString();
                shipTier = tierSelection.Type;
                sTier = shipTier;
                sBuildPointsTotal = totalBuildPoints.Text;

                statusLabel.Text = "Select Starship Frame";
                statusLabel.BackColor = Color.Lime;
                tierGB.BackColor = Color.Khaki;
                tierSelected = true;
                frameGB.BackColor = Color.Lime;
                tierComboBox.Enabled = false;
                tierSelectButton.Text = "Undo";
            }
            else if (tierSelected == true)
            {
                tierGB.BackColor = Color.Red;
                Tier tierSelection = confirmTier();

                totalBPCount -= tierSelection.Bp;
                totalBuildPoints.Text = totalBPCount.ToString();
                currentBuildPoints.Text = calcBP().ToString();

                tierComboBox.Enabled = true;
                tierSelectButton.Text = "Select";
                tierSelected = false;
                statusLabel.Text = "Please Re-Select Tier";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void frameSelectButton_Click(object sender, EventArgs e)
        {
            if (frameSelected == false)
            {
                BaseFrame frameSelection = confirmFrame();

                spentBPCount += frameSelection.BPCost;
                currentBuildPoints.Text = calcBP().ToString();
                shipSize = frameSelection.Size;
                shipFrame = frameSelection.Type;
                shipFrameLabel.Text = shipFrame;
                sFrame = shipFrame;
                starshipSizeLabel.Text = shipSize;
                calcSizeInt();
                calcAC();
                ACTextBox.Text = ac.ToString();
                calcTL();
                TLTextBox.Text = tl.ToString();
                powerCoreComboBox.DataSource = FittedCores();
                powerCore2ComboBox.DataSource = FittedCores2();
                thrustersComboBox.DataSource = FittedThrusters();
                wpnsExpBayApplication(frameSelection);
                assignWeaponsDatasourceByFrame();
                frameInfoApplication();

                HullPointsTextBox.Text = hp.ToString();
                CriticalThresholdTextBox.Text = ct.ToString();
                DamageThresholdTextBox.Text = dt.ToString();

                sSize = shipSize;
                sSizeMod = shipSizeMod.ToString();
                sSizeNumber = shipSizeInt.ToString();
                sManuever = frameSelection.MR;
                sHPTotal = HullPointsTextBox.Text;
                sCT = CriticalThresholdTextBox.Text;
                sDT = DamageThresholdTextBox.Text;

                statusLabel.Text = "Select Starship Power Core";
                statusLabel.BackColor = Color.Lime;
                frameGB.BackColor = Color.Khaki;
                frameSelected = true;
                powercore01GB.BackColor = Color.Lime;
                frameComboBox.Enabled = false;
                frameSelectButton.Text = "Undo";

                AssignUpgradeBoxesByFrame(AllUpgradeBoxes(), TSUpgradeBoxes(), MLUpgradeBoxes(), shipFrame);            // Added
                weaponsUpgradeBaseValue = GetSlotsValue();                                                              // Added

                if (shieldsSelected == true)
                {
                    weaponsMainControl.SelectedIndex = 0;
                    weaponsMainControl.SelectedIndex = 1;
                }

            }
            else if (frameSelected == true)
            {
                frameGB.BackColor = Color.Red;
                BaseFrame frameSelection = confirmFrame();

                spentBPCount -= frameSelection.BPCost;
                currentBuildPoints.Text = calcBP().ToString();
                shipSize = "";
                shipFrame = "";
                shipFrameLabel.Text = "";
                starshipSizeLabel.Text = "";
                ACTextBox.Text = "10";
                TLTextBox.Text = "10";
                HullPointsTextBox.Text = "0";
                CriticalThresholdTextBox.Text = "0";
                DamageThresholdTextBox.Text = "0";
                expBayNum = 0;
                expSlotsLeft.Text = expBayNum.ToString();

                f1Light = false;                                        // Added
                f2Light = false;
                f3Light = false;
                f4Light = false;
                p1Light = false;
                p2Light = false;
                p3Light = false;
                p4Light = false;
                s1Light = false;
                s2Light = false;
                s3Light = false;
                s4Light = false;
                a1Light = false;
                a2Light = false;
                a3Light = false;
                a4Light = false;
                t1Light = false;
                t2Light = false;
                t3Light = false;
                t4Light = false;

                f1Heavy = false;
                f2Heavy = false;
                f3Heavy = false;
                f4Heavy = false;
                p1Heavy = false;
                p2Heavy = false;
                p3Heavy = false;
                p4Heavy = false;
                s1Heavy = false;
                s2Heavy = false;
                s3Heavy = false;
                s4Heavy = false;
                a1Heavy = false;
                a2Heavy = false;
                a3Heavy = false;
                a4Heavy = false;
                t1Heavy = false;
                t2Heavy = false;
                t3Heavy = false;
                t4Heavy = false;

                f1Cap = false;
                f2Cap = false;
                f3Cap = false;
                f4Cap = false;
                p1Cap = false;
                p2Cap = false;
                p3Cap = false;
                p4Cap = false;
                s1Cap = false;
                s2Cap = false;
                s3Cap = false;
                s4Cap = false;
                a1Cap = false;
                a2Cap = false;
                a3Cap = false;
                a4Cap = false;

                fcb1.DataSource = null;
                fcb2.DataSource = null;
                fcb3.DataSource = null;
                fcb4.DataSource = null;
                fcb1.Items.Clear();
                fcb2.Items.Clear();
                fcb3.Items.Clear();
                fcb4.Items.Clear();
                fcb1.Enabled = true;
                fcb2.Enabled = true;
                fcb3.Enabled = true;
                fcb4.Enabled = true;
                forward01.DataSource = null;
                forward02.DataSource = null;
                forward03.DataSource = null;
                forward04.DataSource = null;
                forward01.Items.Clear();
                forward02.Items.Clear();
                forward03.Items.Clear();
                forward04.Items.Clear();
                forward01.Visible = false;
                forward02.Visible = false;
                forward03.Visible = false;
                forward04.Visible = false;

                tcb1.DataSource = null;
                tcb2.DataSource = null;
                tcb3.DataSource = null;
                tcb4.DataSource = null;
                tcb1.Items.Clear();
                tcb2.Items.Clear();
                tcb3.Items.Clear();
                tcb4.Items.Clear();
                tcb1.Enabled = true;
                tcb2.Enabled = true;
                tcb3.Enabled = true;
                tcb4.Enabled = true;
                turret01.DataSource = null;
                turret02.DataSource = null;
                turret03.DataSource = null;
                turret04.DataSource = null;
                turret01.Items.Clear();
                turret02.Items.Clear();
                turret03.Items.Clear();
                turret04.Items.Clear();
                turret01.Visible = false;
                turret02.Visible = false;
                turret03.Visible = false;
                turret04.Visible = false;

                acb1.DataSource = null;
                acb2.DataSource = null;
                acb3.DataSource = null;
                acb4.DataSource = null;
                acb1.Items.Clear();
                acb2.Items.Clear();
                acb3.Items.Clear();
                acb4.Items.Clear();
                acb1.Enabled = true;
                acb2.Enabled = true;
                acb3.Enabled = true;
                acb4.Enabled = true;
                aft01.DataSource = null;
                aft02.DataSource = null;
                aft03.DataSource = null;
                aft04.DataSource = null;
                aft01.Items.Clear();
                aft02.Items.Clear();
                aft03.Items.Clear();
                aft04.Items.Clear();
                aft01.Visible = false;
                aft02.Visible = false;
                aft03.Visible = false;
                aft04.Visible = false;

                scb1.DataSource = null;
                scb2.DataSource = null;
                scb3.DataSource = null;
                scb4.DataSource = null;
                scb1.Items.Clear();
                scb2.Items.Clear();
                scb3.Items.Clear();
                scb4.Items.Clear();
                scb1.Enabled = true;
                scb2.Enabled = true;
                scb3.Enabled = true;
                scb4.Enabled = true;
                starboard01.DataSource = null;
                starboard02.DataSource = null;
                starboard03.DataSource = null;
                starboard04.DataSource = null;
                starboard01.Items.Clear();
                starboard02.Items.Clear();
                starboard03.Items.Clear();
                starboard04.Items.Clear();
                starboard01.Visible = false;
                starboard02.Visible = false;
                starboard03.Visible = false;
                starboard04.Visible = false;

                pcb1.DataSource = null;
                pcb2.DataSource = null;
                pcb3.DataSource = null;
                pcb4.DataSource = null;
                pcb1.Items.Clear();
                pcb2.Items.Clear();
                pcb3.Items.Clear();
                pcb4.Items.Clear();
                pcb1.Enabled = true;
                pcb2.Enabled = true;
                pcb3.Enabled = true;
                pcb4.Enabled = true;
                port01.DataSource = null;
                port02.DataSource = null;
                port03.DataSource = null;
                port04.DataSource = null;
                port01.Items.Clear();
                port02.Items.Clear();
                port03.Items.Clear();
                port04.Items.Clear();
                port01.Visible = false;
                port02.Visible = false;
                port03.Visible = false;
                port04.Visible = false;

                if (shieldsSelected == true)
                {
                    weaponsMainControl.SelectedIndex = 0;
                    weaponsMainControl.SelectedIndex = 1;
                }

                weaponsUpgradePage.BackColor = Color.Empty;
                wpnsUpgradeBtn.Text = "Select";                         // Added

                frameComboBox.Enabled = true;
                frameSelectButton.Text = "Select";
                frameSelected = false;
                statusLabel.Text = "Please Re-Select Frame";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void powerCoreSelectButton_Click(object sender, EventArgs e)
        {
            if (powerCore1Selected == false)
            {
                PowerCore coreSelection = confirmCore();

                spentBPCount += coreSelection.BPCost;
                currentBuildPoints.Text = calcBP().ToString();
                shipPCURating = coreSelection.PCU;
                totalPCUCount = coreSelection.PCU;
                totalPCU.Text = totalPCUCount.ToString();
                remainingPCU.Text = calcPCU().ToString();

                hyperspaceEngineComboBox.DataSource = FittedEngine();
                sPowerCore1 = coreSelection.Type;
                sPCUTotal = totalPCU.Text;
                statusLabel.Text = "Select Starship Thrusters";
                powercore01GB.BackColor = Color.Khaki;
                powerCore1Selected = true;
                thrustersGB.BackColor = Color.Lime;
                powerCoreComboBox.Enabled = false;
                statusLabel.BackColor = Color.Lime;
                powerCoreSelectButton.Text = "Undo";
            }
            else if (powerCore1Selected == true)
            {
                powercore01GB.BackColor = Color.Red;
                PowerCore coreSelection = confirmCore();

                spentBPCount -= coreSelection.BPCost;
                currentBuildPoints.Text = calcBP().ToString();
                shipPCURating = 0;
                totalPCUCount = 0;
                totalPCU.Text = totalPCUCount.ToString();
                remainingPCU.Text = calcPCU().ToString();

                powerCoreComboBox.Enabled = true;
                powerCoreSelectButton.Text = "Select";
                powerCore1Selected = false;
                statusLabel.Text = "Please Re-Select Power Core";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void thrusterSelectButton_Click(object sender, EventArgs e)
        {
            if (thrustersSelected == false)
            {
                Thruster thrusterSelection = confirmThruster();

                spentBPCount += thrusterSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount += thrusterSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                shipSpeed = thrusterSelection.Speed;
                starshipSpeed.Text = shipSpeed.ToString();
                pilotingModAdj = thrusterSelection.Piloting;
                starshipPilotingMod.Text = calcPilotMod().ToString();
                pilotRanks += thrusterSelection.Piloting;
                calcAC();
                calcTL();
                ACTextBox.Text = ac.ToString();
                TLTextBox.Text = tl.ToString();

                sThrusters = thrusterSelection.Type;
                sThrusterSpeed = shipSpeed.ToString();
                statusLabel.Text = "Select Starship Armor";
                thrustersGB.BackColor = Color.Khaki;
                thrustersSelected = true;
                armorGB.BackColor = Color.Lime;
                thrustersComboBox.Enabled = false;
                thrusterSelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }
            else if (thrustersSelected == true)
            {
                thrustersGB.BackColor = Color.Red;
                Thruster thrusterSelection = confirmThruster();

                spentBPCount -= thrusterSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount -= thrusterSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                shipSpeed = 0;
                starshipSpeed.Text = shipSpeed.ToString();
                pilotingModAdj = 0;
                starshipPilotingMod.Text = calcPilotMod().ToString();
                pilotRanks -= thrusterSelection.Piloting;
                calcAC();
                calcTL();
                ACTextBox.Text = ac.ToString();
                TLTextBox.Text = tl.ToString();

                thrustersComboBox.Enabled = true;
                thrusterSelectButton.Text = "Select";
                thrustersSelected = false;
                statusLabel.Text = "Please Re-Select Thrusters";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void armorSelectionButton_Click(object sender, EventArgs e)
        {
            if (armorSelected == false)
            {
                Armor armorSelection = confirmArmor();

                int computedBP = armorSelection.BpCostMulti * shipSizeInt;
                spentBPCount += computedBP;
                currentBuildPoints.Text = calcBP().ToString();
                ac += armorSelection.Ac;
                tl += armorSelection.TargetLock;
                ACTextBox.Text = ac.ToString();
                TLTextBox.Text = tl.ToString();

                sArmor = armorSelection.Type;
                sACTotal = ACTextBox.Text;
                sACBonus = armorSelection.Ac.ToString();
                statusLabel.Text = "Select Starship Computer";
                armorGB.BackColor = Color.Khaki;
                armorSelected = true;
                computerGB.BackColor = Color.Lime;
                armorComboBox.Enabled = false;
                armorSelectionButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }
            else if (armorSelected == true)
            {
                armorGB.BackColor = Color.Red;
                Armor armorSelection = confirmArmor();

                int computedBP = armorSelection.BpCostMulti * shipSizeInt;
                spentBPCount -= computedBP;
                currentBuildPoints.Text = calcBP().ToString();
                ac -= armorSelection.Ac;
                tl -= armorSelection.TargetLock;
                ACTextBox.Text = ac.ToString();
                TLTextBox.Text = tl.ToString();

                armorComboBox.Enabled = true;
                armorSelectionButton.Text = "Select";
                armorSelected = false;
                statusLabel.Text = "Please Re-Select Armor";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void computerSelectButton_Click(object sender, EventArgs e)
        {
            if (computerSelected == false)
            {
                Computer computerSelection = confirmComputer();

                spentBPCount += computerSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount += computerSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                compBonusTextBox.Text = computerSelection.Bonus01.ToString();
                compNodesTextBox.Text = computerSelection.Nodes.ToString();
                computerTypeLabel.Text = computerSelection.Type;
                computerTier = computerSelection.Bonus01;

                sComputer = computerTypeLabel.Text;
                sCompBonus = computerTier.ToString();
                sCompNodes = compNodesTextBox.Text;
                statusLabel.Text = "Select Starship Quarters";
                computerGB.BackColor = Color.Khaki;
                computerSelected = true;
                quartersGB.BackColor = Color.Lime;
                computerComboBox.Enabled = false;
                computerSelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }
            else if (computerSelected == true)
            {
                computerGB.BackColor = Color.Red;
                Computer computerSelection = confirmComputer();

                spentBPCount -= computerSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount -= computerSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();

                computerComboBox.Enabled = true;
                computerSelectButton.Text = "Select";
                computerSelected = false;
                statusLabel.Text = "Please Re-Select Computer";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void quartersSelectButton_Click(object sender, EventArgs e)
        {
            if (quartersSelected == false)
            {
                Quarters quartersSelection = confirmQuarters();

                spentBPCount += quartersSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                quartersTypeLabel.Text = quartersSelection.Type;
                sQuarters = quartersTypeLabel.Text;

                statusLabel.Text = "Select Starship Countermeasures";
                quartersGB.BackColor = Color.Khaki;
                quartersSelected = true;
                countermeasuresGB.BackColor = Color.Lime;
                quartersComboBox.Enabled = false;
                quartersSelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }
            else if (quartersSelected == true)
            {
                quartersComboBox.BackColor = Color.Red;
                Quarters quartersSelection = confirmQuarters();

                spentBPCount -= quartersSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                quartersTypeLabel.Text = "";
                quartersComboBox.Enabled = true;
                quartersSelectButton.Text = "Select";
                quartersSelected = false;
                statusLabel.Text = "Please Re-Select Quarters";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void countermeasuresSelectButton_Click(object sender, EventArgs e)
        {
            if (countermeasuresSelected == false)
            {
                Countermeasures cmSelection = confirmCM();

                spentBPCount += cmSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount += cmSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                tl += cmSelection.TlBonus;
                TLTextBox.Text = tl.ToString();
                countermeasuresLabel.Text = cmSelection.Type;

                sCountermeasures = cmSelection.Type;
                sTLTotal = TLTextBox.Text;
                sTLBonus = cmSelection.TlBonus.ToString();
                statusLabel.Text = "Select Starship Hyperspace Engine";
                countermeasuresGB.BackColor = Color.Khaki;
                countermeasuresSelected = true;
                hyperspaceengineGB.BackColor = Color.Lime;
                countermeasuresComboBox.Enabled = false;
                countermeasuresSelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }
            else if (countermeasuresSelected == true)
            {
                countermeasuresGB.BackColor = Color.Red;
                Countermeasures cmSelection = confirmCM();

                spentBPCount -= cmSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount -= cmSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                tl -= cmSelection.TlBonus;
                TLTextBox.Text = tl.ToString();
                countermeasuresLabel.Text = "";

                countermeasuresComboBox.Enabled = true;
                countermeasuresSelectButton.Text = "Select";
                countermeasuresSelected = false;
                statusLabel.Text = "Please Re-Select Countermeasures";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void hyperspaceEngineSelectButton_Click(object sender, EventArgs e)
        {
            if (hyperspaceEngineSelected == false)
            {
                HyperspaceEngine hsEngineSelection = confirmHyperspaceEngine();

                int computedBP = hsEngineSelection.BpMulti * shipSizeInt;
                spentBPCount += computedBP;
                currentBuildPoints.Text = calcBP().ToString();
                hyperspaceEngineRatingTextBox.Text = hsEngineSelection.Rating.ToString();
                hyperspaceEngineLabel.Text = hsEngineSelection.Type;

                sHyperspaceEngine = hyperspaceEngineLabel.Text;
                sHyperspaceRating = hyperspaceEngineRatingTextBox.Text;
                statusLabel.Text = "Select Starship Expansion Bays";
                hyperspaceengineGB.BackColor = Color.Khaki;
                hyperspaceEngineSelected = true;
                expansionbayGB.BackColor = Color.Lime;
                hyperspaceEngineComboBox.Enabled = false;
                hyperspaceEngineSelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }
            else if (hyperspaceEngineSelected == true)
            {
                hyperspaceengineGB.BackColor = Color.Red;
                HyperspaceEngine hsEngineSelection = confirmHyperspaceEngine();

                int computedBP = hsEngineSelection.BpMulti * shipSizeInt;
                spentBPCount -= computedBP;
                currentBuildPoints.Text = calcBP().ToString();
                hyperspaceEngineRatingTextBox.Text = "";
                hyperspaceEngineLabel.Text = "";

                hyperspaceEngineComboBox.Enabled = true;
                hyperspaceEngineSelectButton.Text = "Select";
                hyperspaceEngineSelected = false;
                statusLabel.Text = "Please Re-Select Hyperspace Engine";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void expBaySelectButton_Click(object sender, EventArgs e)
        {
            int pcuTotal = 0;
            if (expBaySelected == false)
            {
                AssemblyBay assbay = new AssemblyBay();
                List<ComboBox> expBaySelectionBoxes = ExpBays();
                List<ExpansionBay> bay = assbay.ConstructExpansionBayLoad01();
                bool adjustBP = true;
                foreach (var box in expBaySelectionBoxes)
                {
                    if (box.Text == "Hangar Bay" && shipSizeInt < 6)
                    {
                        MessageBox.Show("Your ship is too small for a Hangar Bay.  Please remove it before continuing.");
                        adjustBP = false;
                    }
                    else if (box.Text == "Shuttle Bay" && shipSizeInt < 5)
                    {
                        MessageBox.Show("Your ship is too small for a Shuttle Bay.  Please remove it before continuing.");
                        adjustBP = false;
                    }
                    else
                    {
                        if (box.Text == "Smuggler Compartment")
                        {
                            smugglingGB.Visible = true;
                            smugBay = true;
                        }
                        if (box.Text == "Power Core Housing")
                        {
                            powercore02GB.Visible = true;
                            core2 = true;
                        }
                    }
                    foreach (var b in bay)
                    {
                        if (box.Text == b.Type)
                        {
                            pcuTotal += b.Pcu;
                        }
                    }
                }
                if (adjustBP == true)
                {
                    spentBPCount += Convert.ToInt32(expBPSelected.Text);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += pcuTotal;
                    remainingPCU.Text = calcPCU().ToString();
                    if (smugBay == false && core2 == false)
                    {
                        statusLabel.Text = "Select Starship Security";
                        expansionbayGB.BackColor = Color.Khaki;
                        expBaySelected = true;
                        securityGB.BackColor = Color.Lime;
                    }
                    else if (smugBay == true && core2 == false)
                    {
                        statusLabel.Text = "Select Starship Smuggling Options";
                        expansionbayGB.BackColor = Color.Khaki;
                        expBaySelected = true;
                        smugglingGB.BackColor = Color.Lime;
                    }
                    else if (smugBay == false && core2 == true)
                    {
                        statusLabel.Text = "Select Starship Secondary Power Core";
                        expansionbayGB.BackColor = Color.Khaki;
                        expBaySelected = true;
                        powercore02GB.BackColor = Color.Lime;
                    }
                    else if (smugBay == true && core2 == true)
                    {
                        statusLabel.Text = "Select Starship Smuggling Options";
                        core2next = true;
                        expansionbayGB.BackColor = Color.Khaki;
                        expBaySelected = true;
                        smugglingGB.BackColor = Color.Lime;
                    }
                    foreach (var eb in ExpBays())
                    {
                        eb.Enabled = false;
                    }
                    expBaySelectButton.Text = "Undo";
                    statusLabel.BackColor = Color.Lime;
                }
            }
            else if (expBaySelected == true)
            {
                expansionbayGB.BackColor = Color.Red;

                spentBPCount -= Convert.ToInt32(expBPSelected.Text);
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount -= pcuTotal;
                remainingPCU.Text = calcPCU().ToString();

                foreach (var eb in ExpBays())
                {
                    eb.Enabled = true;
                }
                expBaySelectButton.Text = "Select";
                expBaySelected = false;
                statusLabel.Text = "Please Re-Select Expansion Bays Options";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void smugglingSelectButton_Click(object sender, EventArgs e)
        {
            if (smugglingBaySelected == false)
            {
                if (smugglingComboBox.Text == "DC: 20")
                {
                    spentBPCount += 2;
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += 4;
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = smugglingComboBox.Text;
                }
                else if (smugglingComboBox.Text == "DC: 25")
                {
                    spentBPCount += (2 + 1);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += (4 + 1);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = smugglingComboBox.Text;
                }
                else if (smugglingComboBox.Text == "DC: 30")
                {
                    spentBPCount += (2 + 2);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += (4 + 2);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = smugglingComboBox.Text;
                }
                else if (smugglingComboBox.Text == "DC: 35")
                {
                    spentBPCount += (2 + 3);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += (4 + 3);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = smugglingComboBox.Text;
                }
                else if (smugglingComboBox.Text == "DC: 40")
                {
                    spentBPCount += (2 + 4);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += (4 + 4);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = smugglingComboBox.Text;
                }
                else if (smugglingComboBox.Text == "DC: 45")
                {
                    spentBPCount += (2 + 5);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += (4 + 5);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = smugglingComboBox.Text;
                }
                else if (smugglingComboBox.Text == "DC: 50")
                {
                    spentBPCount += (2 + 6);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount += (4 + 6);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = smugglingComboBox.Text;
                }
                sSmugglingDC = smugglingDCTextBox.Text.Substring(4);
                if (core2 == false)
                {
                    statusLabel.Text = "Select Starship Security";
                    smugglingGB.BackColor = Color.Khaki;
                    smugglingBaySelected = true;
                    securityGB.BackColor = Color.Lime;
                }
                else if (core2 == true)
                {
                    statusLabel.Text = "Select Starship Secondary Power Core";
                    smugglingGB.BackColor = Color.Khaki;
                    smugglingBaySelected = true;
                    powercore02GB.BackColor = Color.Lime;
                }
                smugglingComboBox.Enabled = false;
                smugglingSelectButton.Text = "Undo";
            }
            else if (smugglingBaySelected == true)
            {
                smugglingGB.BackColor = Color.Red;
                if (smugglingComboBox.Text == "DC: 20")
                {
                    spentBPCount -= 2;
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount -= 4;
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = "";
                }
                else if (smugglingComboBox.Text == "DC: 25")
                {
                    spentBPCount -= (2 + 1);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount -= (4 + 1);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = "";
                }
                else if (smugglingComboBox.Text == "DC: 30")
                {
                    spentBPCount -= (2 + 2);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount -= (4 + 2);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = "";
                }
                else if (smugglingComboBox.Text == "DC: 35")
                {
                    spentBPCount -= (2 + 3);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount -= (4 + 3);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = "";
                }
                else if (smugglingComboBox.Text == "DC: 40")
                {
                    spentBPCount -= (2 + 4);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount -= (4 + 4);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = "";
                }
                else if (smugglingComboBox.Text == "DC: 45")
                {
                    spentBPCount -= (2 + 5);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount -= (4 + 5);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = "";
                }
                else if (smugglingComboBox.Text == "DC: 50")
                {
                    spentBPCount -= (2 + 6);
                    currentBuildPoints.Text = calcBP().ToString();
                    spentPCUCount -= (4 + 6);
                    remainingPCU.Text = calcPCU().ToString();
                    smugglingDCTextBox.Text = "";
                }
                smugglingComboBox.Enabled = true;
                smugglingSelectButton.Text = "Select";
                smugglingBaySelected = false;
                statusLabel.Text = "Please Re-Select Smuggling Options";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void powerCore2SelectButton_Click(object sender, EventArgs e)
        {
            if (powerCore2Selected == false)
            {
                PowerCore coreSelection = confirmCore();

                spentBPCount += coreSelection.BPCost;
                currentBuildPoints.Text = calcBP().ToString();
                shipPCURating += coreSelection.PCU;
                totalPCUCount += coreSelection.PCU;
                totalPCU.Text = totalPCUCount.ToString();
                remainingPCU.Text = calcPCU().ToString();

                sPowerCore2 = coreSelection.Type;
                sPCUTotal = totalPCUCount.ToString();
                statusLabel.Text = "Select Starship Security";

                powercore02GB.BackColor = Color.Khaki;
                powerCore2Selected = true;
                securityGB.BackColor = Color.Lime;
                powerCore2ComboBox.Enabled = false;
                powerCore2SelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;

            }
            else if (powerCore2Selected == false)
            {
                powercore02GB.BackColor = Color.Red;
                PowerCore coreSelection = confirmCore();

                spentBPCount -= coreSelection.BPCost;
                currentBuildPoints.Text = calcBP().ToString();
                shipPCURating -= coreSelection.PCU;
                totalPCUCount -= coreSelection.PCU;
                totalPCU.Text = totalPCUCount.ToString();
                remainingPCU.Text = calcPCU().ToString();

                sPowerCore2 = "";
                sPCUTotal = totalPCUCount.ToString();
                powerCore2ComboBox.Enabled = true;
                powerCore2SelectButton.Text = "Select";
                powerCore2Selected = false;
                statusLabel.Text = "Please Re-Select Secondary Power Core";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void securitySelectButton_Click(object sender, EventArgs e)
        {
            if (securitySelected == false)
            {
                spentBPCount += securityBPSpent;
                currentBuildPoints.Text = calcBP().ToString();
                sCompCountermeasureNum = compCountermeasuresListBox.SelectedItems.Count.ToString();
                if (antihackCheckBox.Checked == true)
                {
                    sCompAntiHack = true;
                }
                if (bioLockCheckBox.Checked == true)
                {
                    sBiolocks = true;
                }
                if (sdsCheckBox.Checked == true)
                {
                    sSelfDestruct = true;
                }
                if (antihackCheckBox.Checked == true)
                {

                }
                if (compCMCheckBox.Checked == true)
                {

                }
                statusLabel.BackColor = Color.Lime;
                securityGB.BackColor = Color.Khaki;
                statusLabel.Text = "Select Starship Sensors";
                securitySelectButton.Text = "Undo";
                securitySelected = true;
                sensorsGB.BackColor = Color.Lime;
            }
            else if (securitySelected == true)
            {
                spentBPCount -= securityBPSpent;
                currentBuildPoints.Text = calcBP().ToString();
                securitySelectButton.Text = "Select";
                securityGB.BackColor = Color.Red;
                statusLabel.Text = "Please Re-Select Security";
                statusLabel.BackColor = Color.Red;
                securitySelected = false;
                sensorsGB.BackColor = Color.Empty;
            }
        }

        private void sensorsSelectButton_Click(object sender, EventArgs e)
        {
            if (sensorsSelected == false)
            {
                Sensor sensorSelection = confirmSensor();
                spentBPCount += sensorSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                sensorsModTextBox.Text = sensorSelection.Modifier.ToString();
                sensorRangeText.Text = sensorSelection.Range;
                sensorTypeText.Text = sensorSelection.Type;
                sSensors = sensorTypeText.Text;
                sSensorRange = sensorRangeText.Text;
                sSensorMod = sensorsModTextBox.Text;
                statusLabel.Text = "Select Starship Shields";
                sensorsSelectButton.Text = "Undo";
                sensorsGB.BackColor = Color.Khaki;
                shieldsGB.BackColor = Color.Lime;
                sensorsComboBox.Enabled = false;
                sensorsSelected = true;
                statusLabel.BackColor = Color.Lime;
            }
            else if (sensorsSelected == true)
            {
                sensorsGB.BackColor = Color.Red;
                Sensor sensorSelection = confirmSensor();
                spentBPCount -= sensorSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                statusLabel.Text = "Please Re-Select Sensors";
                sensorsSelectButton.Text = "Select";
                sensorsSelected = false;
                sensorsComboBox.Enabled = true;
                statusLabel.BackColor = Color.Red;
            }
        }

        private void shieldsSelectButton_Click(object sender, EventArgs e)
        {
            if (shieldsSelected == false)
            {
                Shield shieldSelection = confirmShield();
                spentBPCount += shieldSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount += shieldSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                ShieldTotalTextBox.Text = shieldSelection.TotalSP.ToString();
                shieldTypeLabel.Text = shieldSelection.Type;
                shieldRechargeRateLabel.Text = shieldSelection.Regen.ToString() + "/min";
                sShields = shieldTypeLabel.Text;
                sShieldTotal = ShieldTotalTextBox.Text;
                sShieldRegen = shieldRechargeRateLabel.Text;
                statusLabel.Text = "Select Starship Weapons Upgrades";
                shieldsSelectButton.Text = "Undo";
                shieldsGB.BackColor = Color.Khaki;
                statusLabel.BackColor = Color.Lime;
                shieldsComboBox.Enabled = false;                                                // Added
                shieldsSelected = true;
                weaponsMainControl.SelectedIndex = 1;
                AssignUpgradeBoxesByFrame(AllUpgradeBoxes(), TSUpgradeBoxes(), MLUpgradeBoxes(), shipFrame);
                weaponsUpgradeBaseValue = GetSlotsValue();
            }
            else if (shieldsSelected == true)
            {
                Shield shieldSelection = confirmShield();
                spentBPCount -= shieldSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount -= shieldSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                ShieldTotalTextBox.Text = "0";
                shieldTypeLabel.Text = "";
                shieldRechargeRateLabel.Text = "";
                shieldsSelectButton.Text = "Select";
                statusLabel.Text = "Please Re-Select Shields";
                statusLabel.BackColor = Color.Red;
                shieldsGB.BackColor = Color.Red;
                shieldsComboBox.Enabled = true;                                                 // Added
                shieldsSelected = false;
            }
        }

        private void weaponsUpgradePage_Enter(object sender, EventArgs e)
        {
            if (shieldsSelected == false)
            {
                weaponsMainControl.SelectedTab = tabPage1;
                weaponsMainControl.Refresh();
                MessageBox.Show("Please select Shields before accessing Weapons Upgrades", "*Notice*", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                wpnUpgradeBPLabel.Text = "0";
                wpnUpgradeEntered = true;
            }

        }

        private void wpnsUpgradeBtn_Click(object sender, EventArgs e)
        {
            if (weaponSlotSelected == false)                                           // Added
            {
                ActiveWeaponsBoxesVisible(WeaponsBoxes());
                AssignWeaponsToBox();
                spentBPCount += Convert.ToInt32(wpnUpgradeBPLabel.Text);
                currentBuildPoints.Text = calcBP().ToString();
                weaponsUpgradePage.BackColor = Color.Khaki;
                statusLabel.BackColor = Color.Lime;
                statusLabel.Text = "Select Starship Weapons";
                wpnsUpgradeBtn.Text = "Undo";

                fcb1.Enabled = false;
                fcb2.Enabled = false;
                fcb3.Enabled = false;
                fcb4.Enabled = false;

                tcb1.Enabled = false;
                tcb2.Enabled = false;
                tcb3.Enabled = false;
                tcb4.Enabled = false;

                acb1.Enabled = false;
                acb2.Enabled = false;
                acb3.Enabled = false;
                acb4.Enabled = false;

                scb1.Enabled = false;
                scb2.Enabled = false;
                scb3.Enabled = false;
                scb4.Enabled = false;

                pcb1.Enabled = false;
                pcb2.Enabled = false;
                pcb3.Enabled = false;
                pcb4.Enabled = false;

                weaponSlotSelected = true;

                weaponsMainControl.SelectedIndex = 2;
            }
            else if (weaponSlotSelected == true)
            {
                fcb1.Enabled = true;
                fcb2.Enabled = true;
                fcb3.Enabled = true;
                fcb4.Enabled = true;
                forward01.DataSource = null;
                forward02.DataSource = null;
                forward03.DataSource = null;
                forward04.DataSource = null;
                forward01.Items.Clear();
                forward02.Items.Clear();
                forward03.Items.Clear();
                forward04.Items.Clear();
                forward01.Visible = false;
                forward02.Visible = false;
                forward03.Visible = false;
                forward04.Visible = false;

                tcb1.Enabled = true;
                tcb2.Enabled = true;
                tcb3.Enabled = true;
                tcb4.Enabled = true;
                turret01.DataSource = null;
                turret02.DataSource = null;
                turret03.DataSource = null;
                turret04.DataSource = null;
                turret01.Items.Clear();
                turret02.Items.Clear();
                turret03.Items.Clear();
                turret04.Items.Clear();
                turret01.Visible = false;
                turret02.Visible = false;
                turret03.Visible = false;
                turret04.Visible = false;

                acb1.Enabled = true;
                acb2.Enabled = true;
                acb3.Enabled = true;
                acb4.Enabled = true;
                aft01.DataSource = null;
                aft02.DataSource = null;
                aft03.DataSource = null;
                aft04.DataSource = null;
                aft01.Items.Clear();
                aft02.Items.Clear();
                aft03.Items.Clear();
                aft04.Items.Clear();
                aft01.Visible = false;
                aft02.Visible = false;
                aft03.Visible = false;
                aft04.Visible = false;

                scb1.Enabled = true;
                scb2.Enabled = true;
                scb3.Enabled = true;
                scb4.Enabled = true;
                starboard01.DataSource = null;
                starboard02.DataSource = null;
                starboard03.DataSource = null;
                starboard04.DataSource = null;
                starboard01.Items.Clear();
                starboard02.Items.Clear();
                starboard03.Items.Clear();
                starboard04.Items.Clear();
                starboard01.Visible = false;
                starboard02.Visible = false;
                starboard03.Visible = false;
                starboard04.Visible = false;

                pcb1.Enabled = true;
                pcb2.Enabled = true;
                pcb3.Enabled = true;
                pcb4.Enabled = true;
                port01.DataSource = null;
                port02.DataSource = null;
                port03.DataSource = null;
                port04.DataSource = null;
                port01.Items.Clear();
                port02.Items.Clear();
                port03.Items.Clear();
                port04.Items.Clear();
                port01.Visible = false;
                port02.Visible = false;
                port03.Visible = false;
                port04.Visible = false;

                spentBPCount -= Convert.ToInt32(wpnUpgradeBPLabel.Text);
                currentBuildPoints.Text = calcBP().ToString();
                weaponsUpgradePage.BackColor = Color.Empty;
                statusLabel.BackColor = Color.Red;
                statusLabel.Text = "Please Re-select Starship Weapons Upgrades";
                wpnsUpgradeBtn.Text = "Select";
                weaponSlotSelected = false;                                        // Added
            }

        }
        // Added weapons selection button
        private void weaponsSelectButton_Click(object sender, EventArgs e)          // Added
        {
            // Check if weapons have been selected
            if (weaponsSelected == false)
            {
                // Calculate build points and pcu
                spentBPCount += Convert.ToInt32(wpnsBPSelected.Text);
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount += Convert.ToInt32(wpnsPCUUsed.Text);
                remainingPCU.Text = calcPCU().ToString();
                storeWpnsInfo();

                // Check linking for forward arc
                // Make link available if slots 1 and 2 are the same
                if (sFWPNS01 == sFWPNS02 && !(String.IsNullOrEmpty(sFWPNS01)))
                {
                    if (forwLink1 == false)
                    {
                        forwLinkCheckBox1.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox1.Text = sFWPNS01;
                        forWpnTypeLink1 = sFWPNS01;
                        forwLink1 = true;
                    }
                    else if (forwLink1 == true)
                    {
                        forwLinkCheckBox2.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox2.Text = sFWPNS01;
                        forWpnTypeLink2 = sFWPNS01;
                        forwLink2 = true;
                    }
                }
                // Make link available if slots 3 and 4 are the same
                if (sFWPNS03 == sFWPNS04 && !(String.IsNullOrEmpty(sFWPNS03)))
                {
                    if (forwLink1 == false)
                    {
                        forwLinkCheckBox1.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox1.Text = sFWPNS03;
                        forWpnTypeLink1 = sFWPNS03;
                        forwLink1 = true;
                    }
                    else if (forwLink1 == true && forwLink2 == false)
                    {
                        forwLinkCheckBox2.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox2.Text = sFWPNS03;
                        forWpnTypeLink2 = sFWPNS03;
                        forwLink2 = true;
                    }
                }
                // Make link available if slots 1 and 3 are the same
                if (sFWPNS01 == sFWPNS03 && !(String.IsNullOrEmpty(sFWPNS01)))
                {
                    if (forwLink1 == false)
                    {
                        forwLinkCheckBox1.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox1.Text = sFWPNS01;
                        forWpnTypeLink1 = sFWPNS01;
                        forwLink1 = true;
                    }
                    else if (forwLink1 == true && forwLink2 == false && sFWPNS01 != sFWPNS02 && sFWPNS01 != sFWPNS04)
                    {
                        forwLinkCheckBox2.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox2.Text = sFWPNS01;
                        forWpnTypeLink2 = sFWPNS01;
                        forwLink2 = true;
                    }
                }
                // Make link available if slots 2 and 4 are the same
                if (sFWPNS02 == sFWPNS04 && !(String.IsNullOrEmpty(sFWPNS02)))
                {
                    if (forwLink1 == false)
                    {
                        forwLinkCheckBox1.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox1.Text = sFWPNS02;
                        forWpnTypeLink1 = sFWPNS02;
                        forwLink1 = true;
                    }
                    else if (forwLink1 == true && forwLink2 == false && sFWPNS02 != sFWPNS03 && sFWPNS02 != sFWPNS01)
                    {
                        forwLinkCheckBox2.Visible = true;
                        forwLinkLbl.Text = "Forward Linking Available";
                        forwLinkCheckBox2.Text = sFWPNS02;
                        forWpnTypeLink2 = sFWPNS02;
                        forwLink2 = true;
                    }
                }
                // Check linking for turret arc
                // Make link available if slots 1 and 2 are the same
                if (sTWPNS01 == sTWPNS02 && !(String.IsNullOrEmpty(sTWPNS01)))
                {
                    if (turLink1 == false)
                    {
                        turLinkCheckBox1.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox1.Text = sTWPNS01;
                        turWpnTypeLink1 = sTWPNS01;
                        turLink1 = true;
                    }
                    else if (turLink1 == true)
                    {
                        turLinkCheckBox2.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox2.Text = sTWPNS01;
                        turWpnTypeLink2 = sTWPNS01;
                        turLink2 = true;
                    }
                }
                // Make link available if slots 3 and 4 are the same
                if (sTWPNS03 == sTWPNS04 && !(String.IsNullOrEmpty(sTWPNS03)))
                {
                    if (turLink1 == false)
                    {
                        turLinkCheckBox1.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox1.Text = sTWPNS03;
                        turWpnTypeLink1 = sTWPNS03;
                        turLink1 = true;
                    }
                    else if (turLink1 == true)
                    {
                        turLinkCheckBox2.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox2.Text = sTWPNS03;
                        turWpnTypeLink2 = sTWPNS03;
                        turLink2 = true;
                    }
                }
                // Make link available if slots 1 and 3 are the same
                if (sTWPNS01 == sTWPNS03 && !(String.IsNullOrEmpty(sTWPNS01)))
                {
                    if (turLink1 == false)
                    {
                        turLinkCheckBox1.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox1.Text = sTWPNS01;
                        turWpnTypeLink1 = sTWPNS01;
                        turLink1 = true;
                    }
                    else if (turLink1 == true && turLink2 == false && sTWPNS01 != sTWPNS02 && sTWPNS01 != sTWPNS04)
                    {
                        turLinkCheckBox2.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox2.Text = sTWPNS01;
                        turWpnTypeLink2 = sTWPNS01;
                        turLink2 = true;
                    }
                }
                // Make link available if slots 2 and 4 are the same
                if (sTWPNS02 == sTWPNS04 && !(String.IsNullOrEmpty(sTWPNS02)))
                {
                    if (turLink1 == false)
                    {
                        turLinkCheckBox1.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox1.Text = sTWPNS01;
                        turWpnTypeLink1 = sTWPNS01;
                        turLink1 = true;
                    }
                    else if (turLink1 == true && turLink2 == false && sTWPNS02 != sTWPNS03 && sTWPNS02 != sTWPNS01)
                    {
                        turLinkCheckBox2.Visible = true;
                        turLinkLbl.Text = "Turret Linking Available";
                        turLinkCheckBox2.Text = sTWPNS01;
                        turWpnTypeLink2 = sTWPNS01;
                        turLink2 = true;
                    }
                }
                // Check linking for aft arc
                // Make link available if slots 1 and 2 are the same
                if (sAWPNS01 == sAWPNS02 && !(String.IsNullOrEmpty(sAWPNS01)))
                {
                    if (aftLink1 == false)
                    {
                        aftLinkCheckBox1.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox1.Text = sAWPNS01;
                        aftWpnTypeLink1 = sAWPNS01;
                        aftLink1 = true;
                    }
                    else if (aftLink1 == true)
                    {
                        aftLinkCheckBox2.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox2.Text = sAWPNS01;
                        aftWpnTypeLink2 = sAWPNS01;
                        aftLink2 = true;
                    }
                }
                // Make link available if slots 3 and 4 are the same
                if (sAWPNS03 == sAWPNS04 && !(String.IsNullOrEmpty(sAWPNS03)))
                {
                    if (aftLink1 == false)
                    {
                        aftLinkCheckBox1.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox1.Text = sAWPNS03;
                        aftWpnTypeLink1 = sAWPNS03;
                        aftLink1 = true;
                    }
                    else if (aftLink1 == true && aftLink2 == false)
                    {
                        aftLinkCheckBox2.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox2.Text = sAWPNS03;
                        aftWpnTypeLink2 = sAWPNS03;
                        aftLink2 = true;
                    }
                }
                // Make link available if slots 1 and 3 are the same
                if (sAWPNS01 == sAWPNS03 && !(String.IsNullOrEmpty(sAWPNS01)))
                {
                    if (aftLink1 == false)
                    {
                        aftLinkCheckBox1.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox1.Text = sAWPNS01;
                        aftWpnTypeLink1 = sAWPNS01;
                        aftLink1 = true;
                    }
                    else if (aftLink1 == true && aftLink2 == false && sAWPNS01 != sAWPNS02 && sAWPNS01 != sAWPNS04)
                    {
                        aftLinkCheckBox2.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox2.Text = sAWPNS01;
                        aftWpnTypeLink2 = sAWPNS01;
                        aftLink2 = true;
                    }
                }
                // Make link available if slots 2 and 4 are the same
                if (sAWPNS02 == sAWPNS04 && !(String.IsNullOrEmpty(sAWPNS02)))
                {
                    if (aftLink1 == false)
                    {
                        aftLinkCheckBox1.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox1.Text = sAWPNS02;
                        aftWpnTypeLink1 = sAWPNS02;
                        aftLink1 = true;
                    }
                    else if (aftLink1 == true && aftLink2 == false && sAWPNS02 != sAWPNS03 && sAWPNS02 != sAWPNS01)
                    {
                        aftLinkCheckBox2.Visible = true;
                        aftLinkLbl.Text = "Aft Linking Available";
                        aftLinkCheckBox2.Text = sAWPNS02;
                        aftWpnTypeLink2 = sAWPNS02;
                        aftLink2 = true;
                    }
                }
                // Check linking for starboard arc
                // Make link available if slots 1 and 2 are the same
                if (sSWPNS01 == sSWPNS02 && !(String.IsNullOrEmpty(sSWPNS01)))
                {
                    if (starbLink1 == false)
                    {
                        starbLinkCheckBox1.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox1.Text = sSWPNS01;
                        starbWpnTypeLink1 = sSWPNS01;
                        starbLink1 = true;
                    }
                    else if (starbLink1 == true)
                    {
                        starbLinkCheckBox2.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox2.Text = sSWPNS01;
                        starbWpnTypeLink2 = sSWPNS01;
                        starbLink2 = true;
                    }
                }
                // Make link available if slots 3 and 4 are the same
                if (sSWPNS03 == sSWPNS04 && !(String.IsNullOrEmpty(sSWPNS03)))
                {
                    if (starbLink1 == false)
                    {
                        starbLinkCheckBox1.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox1.Text = sSWPNS03;
                        starbWpnTypeLink1 = sSWPNS03;
                        starbLink1 = true;
                    }
                    else if (starbLink1 == true)
                    {
                        starbLinkCheckBox2.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox2.Text = sSWPNS03;
                        starbWpnTypeLink2 = sSWPNS03;
                        starbLink2 = true;
                    }
                }
                // Make link available if slots 1 and 3 are the same
                if (sSWPNS01 == sSWPNS03 && !(String.IsNullOrEmpty(sSWPNS01)))
                {
                    if (starbLink1 == false)
                    {
                        starbLinkCheckBox1.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox1.Text = sSWPNS01;
                        starbWpnTypeLink1 = sSWPNS01;
                        starbLink1 = true;
                    }
                    else if (starbLink1 == true && starbLink2 == false && sSWPNS01 != sSWPNS02 && sSWPNS01 != sSWPNS04)
                    {
                        starbLinkCheckBox2.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox2.Text = sSWPNS01;
                        starbWpnTypeLink2 = sSWPNS01;
                        starbLink2 = true;
                    }
                }
                // Make link available if slots 2 and 4 are the same
                if (sSWPNS02 == sSWPNS04 && !(String.IsNullOrEmpty(sSWPNS02)))
                {
                    if (starbLink1 == false)
                    {
                        starbLinkCheckBox1.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox1.Text = sSWPNS02;
                        starbWpnTypeLink1 = sSWPNS02;
                        starbLink1 = true;
                    }
                    else if (starbLink1 == true && starbLink2 == false && sSWPNS02 != sSWPNS03 && sSWPNS02 != sSWPNS01)
                    {
                        starbLinkCheckBox2.Visible = true;
                        starbLinkLbl.Text = "Starboard Linking Available";
                        starbLinkCheckBox2.Text = sSWPNS02;
                        starbWpnTypeLink2 = sSWPNS02;
                        starbLink2 = true;
                    }
                }
                // Check linking for port arc
                // Make link available if slots 1 and 2 are the same
                if (sPWPNS01 == sPWPNS02 && !(String.IsNullOrEmpty(sPWPNS01)))
                {
                    if (portLink1 == false)
                    {
                        portLinkCheckBox1.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox1.Text = sPWPNS01;
                        portWpnTypeLink1 = sPWPNS01;
                        portLink1 = true;
                    }
                    else if (portLink1 == true)
                    {
                        portLinkCheckBox2.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox2.Text = sPWPNS01;
                        portWpnTypeLink2 = sPWPNS01;
                        portLink2 = true;
                    }
                }
                // Make link available if slots 3 and 4 are the same
                if (sPWPNS03 == sPWPNS04 && !(String.IsNullOrEmpty(sPWPNS03)))
                {
                    if (portLink1 == false)
                    {
                        portLinkCheckBox1.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox1.Text = sPWPNS03;
                        portWpnTypeLink1 = sPWPNS03;
                        portLink1 = true;
                    }
                    else if (portLink1 == true && portLink2 == false)
                    {
                        portLinkCheckBox2.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox2.Text = sPWPNS03;
                        portWpnTypeLink2 = sPWPNS03;
                        portLink2 = true;
                    }
                }
                // Make link available if slots 1 and 3 are the same
                if (sPWPNS01 == sPWPNS03 && !(String.IsNullOrEmpty(sPWPNS01)))
                {
                    if (portLink1 == false)
                    {
                        portLinkCheckBox1.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox1.Text = sPWPNS01;
                        portWpnTypeLink1 = sPWPNS01;
                        portLink1 = true;
                    }
                    else if (portLink1 == true && portLink2 == false && sPWPNS01 != sPWPNS02 && sPWPNS01 != sPWPNS04)
                    {
                        portLinkCheckBox2.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox2.Text = sPWPNS01;
                        portWpnTypeLink2 = sPWPNS01;
                        portLink2 = true;
                    }
                }
                // Make link available if slots 2 and 4 are the same
                if (sPWPNS02 == sPWPNS04 && !(String.IsNullOrEmpty(sPWPNS02)))
                {
                    if (portLink1 == false)
                    {
                        portLinkCheckBox1.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox1.Text = sPWPNS02;
                        portWpnTypeLink1 = sPWPNS02;
                        portLink1 = true;
                    }
                    else if (portLink1 == true && portLink2 == false && sPWPNS02 != sPWPNS03 && sPWPNS02 != sPWPNS01)
                    {
                        portLinkCheckBox2.Visible = true;
                        portLinkLbl.Text = "Port Linking Available";
                        portLinkCheckBox2.Text = sPWPNS02;
                        portWpnTypeLink2 = sPWPNS02;
                        portLink2 = true;
                    }
                }

                weaponsSelectButton.Text = "Undo";
                statusLabel.Text = "Select Weapons Linking";
                statusLabel.BackColor = Color.Lime;
                weaponsSelectPage.BackColor = Color.Khaki;
                weaponsSelected = true;
                weaponsMainControl.SelectedIndex = 3;

                forward01.Enabled = false;
                forward02.Enabled = false;
                forward03.Enabled = false;
                forward04.Enabled = false;
                turret01.Enabled = false;
                turret02.Enabled = false;
                turret03.Enabled = false;
                turret04.Enabled = false;
                aft01.Enabled = false;
                aft02.Enabled = false;
                aft03.Enabled = false;
                aft04.Enabled = false;
                starboard01.Enabled = false;
                starboard02.Enabled = false;
                starboard03.Enabled = false;
                starboard04.Enabled = false;
                port01.Enabled = false;
                port02.Enabled = false;
                port03.Enabled = false;
                port04.Enabled = false;
            }
            else if (weaponsSelected == true)
            {
                forwLink1 = false;
                forwLink2 = false;
                forwLinkLbl.Text = "Forward";
                forwLinkCheckBox1.Visible = false;
                forwLinkCheckBox2.Visible = false;
                forwLinkCheckBox1.Text = "forwLink1";
                forwLinkCheckBox2.Text = "forwLink2";
                forward01.Enabled = true;
                forward02.Enabled = true;
                forward03.Enabled = true;
                forward04.Enabled = true;
                sFWPNS01 = "";
                sFWPNS02 = "";
                sFWPNS03 = "";
                sFWPNS04 = "";
                forWpnTypeLink1 = "";
                forWpnTypeLink2 = "";

                turLink1 = false;
                turLink2 = false;
                turLinkLbl.Text = "Turret";
                turLinkCheckBox1.Visible = false;
                turLinkCheckBox2.Visible = false;
                turLinkCheckBox1.Text = "turLink1";
                turLinkCheckBox2.Text = "turLink2";
                turret01.Enabled = true;
                turret02.Enabled = true;
                turret03.Enabled = true;
                turret04.Enabled = true;
                sTWPNS01 = "";
                sTWPNS02 = "";
                sTWPNS03 = "";
                sTWPNS04 = "";
                turWpnTypeLink1 = "";
                turWpnTypeLink2 = "";

                aftLink1 = false;
                aftLink2 = false;
                aftLinkLbl.Text = "Aft";
                aftLinkCheckBox1.Visible = false;
                aftLinkCheckBox2.Visible = false;
                aftLinkCheckBox1.Text = "aftLink1";
                aftLinkCheckBox2.Text = "aftLink2";
                aft01.Enabled = true;
                aft02.Enabled = true;
                aft03.Enabled = true;
                aft04.Enabled = true;
                sAWPNS01 = "";
                sAWPNS02 = "";
                sAWPNS03 = "";
                sAWPNS04 = "";
                aftWpnTypeLink1 = "";
                aftWpnTypeLink2 = "";

                starbLink1 = false;
                starbLink2 = false;
                starbLinkLbl.Text = "Starboard";
                starbLinkCheckBox1.Visible = false;
                starbLinkCheckBox2.Visible = false;
                starbLinkCheckBox1.Text = "starbLink1";
                starbLinkCheckBox2.Text = "starbLink2";
                starboard01.Enabled = true;
                starboard02.Enabled = true;
                starboard03.Enabled = true;
                starboard04.Enabled = true;
                sSWPNS01 = "";
                sSWPNS02 = "";
                sSWPNS03 = "";
                sSWPNS04 = "";
                starbWpnTypeLink1 = "";
                starbWpnTypeLink2 = "";

                portLink1 = false;
                portLink2 = false;
                portLinkLbl.Text = "Port";
                portLinkCheckBox1.Visible = false;
                portLinkCheckBox2.Visible = false;
                portLinkCheckBox1.Text = "portLink1";
                portLinkCheckBox2.Text = "portLink2";
                port01.Enabled = true;
                port02.Enabled = true;
                port03.Enabled = true;
                port04.Enabled = true;
                sPWPNS01 = "";
                sPWPNS02 = "";
                sPWPNS03 = "";
                sPWPNS04 = "";
                portWpnTypeLink1 = "";
                portWpnTypeLink2 = "";

                weaponsSelectButton.Text = "Select";
                statusLabel.Text = "Please Re-select Weapons";
                statusLabel.BackColor = Color.Red;
                weaponsSelectPage.BackColor = Color.Empty;
                spentBPCount -= Convert.ToInt32(wpnsBPSelected.Text);
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount -= Convert.ToInt32(wpnsPCUUsed.Text);
                remainingPCU.Text = calcPCU().ToString();
                weaponsSelected = false;                                            // Added
            }
        }
        
        

        private void shipSheetOutputButton_Click(object sender, EventArgs e)
        {
            int BPUsed = Convert.ToInt32(totalBuildPoints.Text) - Convert.ToInt32(currentBuildPoints.Text);
            sBuildPointsUsed = BPUsed.ToString();
            ShipSheetOutput StarshipSheet = new ShipSheetOutput();
            StarshipSheet.WindowState = FormWindowState.Maximized;
            StarshipSheet.Show();
        }

        #endregion



        #region Easy Methods

        private Tier confirmTier()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Tier currentTier = new Tier();
            List<Tier> Tiers = LiveBay.ConstructTierLoad();
            List<Tier> oneTier = new List<Tier>();
            IEnumerable<Tier> selectedTier = from t in Tiers where t.Type == tierComboBox.Text select t;
            oneTier = selectedTier.ToList();
            currentTier = oneTier[0];
            return currentTier;
        }

        private BaseFrame confirmFrame()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            BaseFrame currentFrame = new BaseFrame();
            List<BaseFrame> Frames = LiveBay.ConstructFrameLoad();
            List<BaseFrame> oneFrame = new List<BaseFrame>();
            IEnumerable<BaseFrame> selectedFrame = from f in Frames where f.Type.ToString() == frameComboBox.Text select f;
            oneFrame = selectedFrame.ToList();
            currentFrame = oneFrame[0];
            return currentFrame;
        }

        private PowerCore confirmCore()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            PowerCore currentItem = new PowerCore();
            List<PowerCore> items = LiveBay.ConstructPowerCoreLoad();
            List<PowerCore> oneItem = new List<PowerCore>();
            IEnumerable<PowerCore> selectedItem = from c in items where c.Type.ToString() == powerCoreComboBox.Text select c;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private Thruster confirmThruster()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Thruster currentItem = new Thruster();
            List<Thruster> items = LiveBay.ConstructThrusterLoad();
            List<Thruster> oneItem = new List<Thruster>();
            IEnumerable<Thruster> selectedItem = from i in items where i.Type.ToString() == thrustersComboBox.Text select i;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private Thruster randThruster()
        {
            Random randitem = new Random();
            AssemblyBay LiveBay = new AssemblyBay();
            Thruster currentItem = new Thruster();
            List<Thruster> items = FittedThrusters();
            int num = randitem.Next(1, items.Count - 1);
            return items[num];
        }

        private Armor confirmArmor()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Armor currentItem = new Armor();
            List<Armor> items = LiveBay.ConstructArmorLoad();
            List<Armor> oneItem = new List<Armor>();
            IEnumerable<Armor> selectedItem = from i in items where i.Type.ToString() == armorComboBox.Text select i;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private Computer confirmComputer()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Computer currentItem = new Computer();
            List<Computer> items = LiveBay.ConstructComputerLoad();
            List<Computer> oneItem = new List<Computer>();
            IEnumerable<Computer> selectedItem = from i in items where i.Type.ToString() == computerComboBox.Text select i;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private Quarters confirmQuarters()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Quarters currentItem = new Quarters();
            List<Quarters> items = LiveBay.ConstructQuartersLoad();
            List<Quarters> oneItem = new List<Quarters>();
            IEnumerable<Quarters> selectedItem = from i in items where i.Type.ToString() == quartersComboBox.Text select i;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private Countermeasures confirmCM()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Countermeasures currentItem = new Countermeasures();
            List<Countermeasures> items = LiveBay.ConstructCountermeasuresLoad();
            List<Countermeasures> oneItem = new List<Countermeasures>();
            IEnumerable<Countermeasures> selectedItem = from i in items where i.Type.ToString() == countermeasuresComboBox.Text select i;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private HyperspaceEngine confirmHyperspaceEngine()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            HyperspaceEngine currentItem = new HyperspaceEngine();
            List<HyperspaceEngine> items = LiveBay.ConstructHyperspaceEngineLoad();
            List<HyperspaceEngine> oneItem = new List<HyperspaceEngine>();
            IEnumerable<HyperspaceEngine> selectedItem = from i in items where i.Type.ToString() == hyperspaceEngineComboBox.Text select i;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private HyperspaceEngine randHyperspace()
        {
            Random randitem = new Random();
            AssemblyBay LiveBay = new AssemblyBay();
            HyperspaceEngine currentItem = new HyperspaceEngine();
            List<HyperspaceEngine> items = FittedEngine();
            int num = randitem.Next(1, items.Count - 1);
            return items[num];
        }


        private List<ComboBox> ExpBays()
        {
            List<ComboBox> ExpBays = new List<ComboBox>();
            ExpBays.Add(expBayComboBox1);
            ExpBays.Add(expBayComboBox2);
            ExpBays.Add(expBayComboBox3);
            ExpBays.Add(expBayComboBox4);
            ExpBays.Add(expBayComboBox5);
            ExpBays.Add(expBayComboBox6);
            ExpBays.Add(expBayComboBox7);
            ExpBays.Add(expBayComboBox8);
            ExpBays.Add(expBayComboBox9);
            ExpBays.Add(expBayComboBox10);
            ExpBays.Add(expBayComboBox11);
            ExpBays.Add(expBayComboBox12);
            ExpBays.Add(expBayComboBox13);
            ExpBays.Add(expBayComboBox14);
            ExpBays.Add(expBayComboBox15);
            ExpBays.Add(expBayComboBox16);
            ExpBays.Add(expBayComboBox17);
            ExpBays.Add(expBayComboBox18);
            ExpBays.Add(expBayComboBox19);
            ExpBays.Add(expBayComboBox20);
            return ExpBays;
        }

        private void RefreshExpBaysNoShuttleNoHangar()
        {
            List<ComboBox> comboBoxes = ExpBays();
            foreach (var cb in comboBoxes)
            {
                cb.DataSource = NoShuttleOrHangarBay();
            }
        }

        private void RefreshExpBayNoHangar()
        {
            List<ComboBox> comboBoxes = ExpBays();
            foreach (var cb in comboBoxes)
            {
                cb.DataSource = NoHangerBay();
            }
        }

        private List<ExpansionBay> confirmExpBays()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> SelectedBays = new List<ExpansionBay>();
            List<ExpansionBay> bays = LiveBay.ConstructExpansionBayLoad01();
            List<ComboBox> ExpBays = new List<ComboBox>();
            ExpBays.Add(expBayComboBox1);
            ExpBays.Add(expBayComboBox2);
            ExpBays.Add(expBayComboBox3);
            ExpBays.Add(expBayComboBox4);
            ExpBays.Add(expBayComboBox5);
            ExpBays.Add(expBayComboBox6);
            ExpBays.Add(expBayComboBox7);
            ExpBays.Add(expBayComboBox8);
            ExpBays.Add(expBayComboBox9);
            ExpBays.Add(expBayComboBox10);
            ExpBays.Add(expBayComboBox11);
            ExpBays.Add(expBayComboBox12);
            ExpBays.Add(expBayComboBox13);
            ExpBays.Add(expBayComboBox14);
            ExpBays.Add(expBayComboBox15);
            ExpBays.Add(expBayComboBox16);
            ExpBays.Add(expBayComboBox17);
            ExpBays.Add(expBayComboBox18);
            ExpBays.Add(expBayComboBox19);
            ExpBays.Add(expBayComboBox20);

            foreach (var e in ExpBays)
            {
                foreach (var b in bays)
                {
                    if (e.Text == b.Type)
                    {
                        SelectedBays.Add(b);
                    }
                }
            }
            return SelectedBays;
        }

        private PowerCore confirmCore2()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            PowerCore currentItem = new PowerCore();
            List<PowerCore> items = LiveBay.ConstructPowerCore2Load();
            List<PowerCore> oneItem = new List<PowerCore>();
            IEnumerable<PowerCore> selectedItem = from c in items where c.Type.ToString() == powerCore2ComboBox.Text select c;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private Sensor confirmSensor()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Sensor currentItem = new Sensor();
            List<Sensor> items = LiveBay.ConstructSensorLoad();
            List<Sensor> oneItem = new List<Sensor>();
            IEnumerable<Sensor> selectedItem = from c in items where c.Type.ToString() == sensorsComboBox.Text select c;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        private Shield confirmShield()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            Shield currentItem = new Shield();
            List<Shield> items = LiveBay.ConstructShieldLoad();
            List<Shield> oneItem = new List<Shield>();
            IEnumerable<Shield> selectedItem = from c in items where c.Type.ToString() == shieldsComboBox.Text select c;
            oneItem = selectedItem.ToList();
            currentItem = oneItem[0];
            return currentItem;
        }

        #endregion

        #region Security Measures

        private void antihackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (antihackCheckBox.Checked == true)
            {
                shipHackDCTextBox.Text = "+1";
                securityBPSpent += 3;
            }
            else if (antihackCheckBox.Checked == false)
            {
                shipHackDCTextBox.Text = "+0";
                securityBPSpent -= 3;
            }
            securityBPSelected.Text = securityBPSpent.ToString();
        }

        private void antihackLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (antihackLevelComboBox.Text != "-Upgrade-" && antihackCheckBox.Checked == true)
            {
                securityBPSpent = (securityBPSpent - 3) + (3 * ((Convert.ToInt32(antihackLevelComboBox.Text) + 1)));

                if (antihackCheckBox.Checked == true)
                {
                    int blah;
                    blah = Convert.ToInt32(antihackLevelComboBox.Text) + 1;
                    shipHackDCTextBox.Text = "+" + blah.ToString();
                }
                securityBPSelected.Text = securityBPSpent.ToString();
            }
        }

        private void antipersonnelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (antipersonnelCheckBox.Checked == true)
            {
                antipersonnelWeaponTypeComboBox.Visible = true;
            }
            else
            {
                antipersonnelWeaponTypeComboBox.Visible = false;
            }
        }

        private void antipersonnelWeaponTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antipersonnelWeaponLevelComboBox.Visible = true;
        }

        private void antipersonnelWeaponLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (antipersonnelCheckBox.Checked == true)
            {
                if (antipersonnelWeaponTypeComboBox.Text == "Heavy")
                {
                    securityBPSpent += (5 + Convert.ToInt32(antipersonnelWeaponLevelComboBox.Text));
                    securityBPSelected.Text = securityBPSpent.ToString();
                }
                else if (antipersonnelWeaponTypeComboBox.Text == "Longarm")
                {
                    securityBPSpent += Convert.ToInt32(antipersonnelWeaponLevelComboBox.Text);
                    securityBPSelected.Text = securityBPSpent.ToString();
                }
            }
        }

        private void bioLockCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bioLockCheckBox.Checked == true)
            {
                securityBPSpent += 5;
                securityBPSelected.Text = securityBPSpent.ToString();
            }
            else if (bioLockCheckBox.Checked == false)
            {
                securityBPSpent -= 5;
                securityBPSelected.Text = securityBPSpent.ToString();
            }

        }

        private void compCMCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int numSelected = 0;
            int totalVal = 0;
            if (compCMCheckBox.Checked == true)
            {
                foreach (var v in compCountermeasuresListBox.SelectedItems)
                {
                    numSelected += 1;
                }
                totalVal = computerTier * numSelected;
                securityBPSpent += totalVal;
                securityBPSelected.Text = securityBPSpent.ToString();
            }
            else if (compCMCheckBox.Checked == true)
            {
                foreach (var v in compCountermeasuresListBox.SelectedItems)
                {
                    numSelected += 1;
                }
                totalVal = computerTier * numSelected;
                securityBPSpent -= totalVal;
                securityBPSelected.Text = securityBPSpent.ToString();
            }
        }

        private void sdsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sdsCheckBox.Checked == true)
            {
                securityBPSpent += (5 * shipSizeInt);
                securityBPSelected.Text = securityBPSpent.ToString();
            }
            else if (sdsCheckBox.Checked == false)
            {
                securityBPSpent -= (5 * shipSizeInt);
                securityBPSelected.Text = securityBPSpent.ToString();
            }
        }
        #endregion

        #region Calc Stuff

        private int calcBP()
        {
            int currentBPCount;
            currentBPCount = totalBPCount - spentBPCount;
            return currentBPCount;
        }

        private void calcSizeInt()
        {
            if (shipSize == "Tiny")
            {
                shipSizeInt = 1;
                ac += 2;
                tl += 2;
            }
            else if (shipSize == "Small")
            {
                shipSizeInt = 2;
                ac += 1;
                tl += 1;
            }
            else if (shipSize == "Medium")
            {
                shipSizeInt = 3;
            }
            else if (shipSize == "Large")
            {
                shipSizeInt = 4;
                ac += -1;
                tl += -1;
            }
            else if (shipSize == "Huge")
            {
                shipSizeInt = 5;
                ac += -2;
                tl += -2;
            }
            else if (shipSize == "Gargantuan")
            {
                shipSizeInt = 6;
                ac += -4;
                tl += -4;
            }
            else if (shipSize == "Colossal")
            {
                shipSizeInt = 7;
                ac += -8;
                tl += -8;
            }
            shipSizeMod = ac;
        }

        private int calcPCU()
        {
            int currentPCUCount;
            currentPCUCount = totalPCUCount - spentPCUCount;
            return currentPCUCount;
        }

        private int calcPilotMod()
        {
            int currentPilotMod;
            currentPilotMod = pilotingMod + pilotingModAdj;
            pilotingMod = currentPilotMod;
            return currentPilotMod;
        }

        private void calcAC()
        {
            ac += pilotRanks;
        }

        private void calcTL()
        {
            tl += pilotRanks;
        }










        #endregion

        #region Fitted Parts

        private List<PowerCore> FittedCores()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<PowerCore> CoreList = new List<PowerCore>();
            PowerCore None = new PowerCore()
            {
                Type = "-Select Power Core-"
            };
            CoreList.Add(None);
            List<PowerCore> AllCores = LiveBay.ConstructPowerCoreLoad();
            foreach (var c in AllCores)
            {
                if (shipSize == c.Size01)
                {
                    CoreList.Add(c);
                }
                else if (shipSize == c.Size02)
                {
                    CoreList.Add(c);
                }
                else if (shipSize == c.Size03)
                {
                    CoreList.Add(c);
                }
            }
            return CoreList;
        }

        private List<PowerCore> FittedCores2()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<PowerCore> CoreList = new List<PowerCore>();
            PowerCore None = new PowerCore()
            {
                Type = "-Select Power Core-"
            };
            CoreList.Add(None);
            List<PowerCore> AllCores = LiveBay.ConstructPowerCore2Load();
            foreach (var c in AllCores)
            {
                if (shipSize == c.Size01)
                {
                    CoreList.Add(c);
                }
                else if (shipSize == c.Size02)
                {
                    CoreList.Add(c);
                }
                else if (shipSize == c.Size03)
                {
                    CoreList.Add(c);
                }
            }
            return CoreList;
        }

        private List<Thruster> FittedThrusters()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<Thruster> ItemList = new List<Thruster>();
            Thruster None = new Thruster()
            {
                Type = "-Select Thrusters-"
            };
            ItemList.Add(None);
            List<Thruster> AllItems = LiveBay.ConstructThrusterLoad();
            foreach (var i in AllItems)
            {
                if (shipSize == i.Size)
                {
                    ItemList.Add(i);
                }
            }
            return ItemList;
        }

        private List<HyperspaceEngine> FittedEngine()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<HyperspaceEngine> ItemList = new List<HyperspaceEngine>();
            HyperspaceEngine None = new HyperspaceEngine()
            {
                Type = "-Select HS Engine-"
            };
            ItemList.Add(None);
            List<HyperspaceEngine> AllItems = LiveBay.ConstructHyperspaceEngineLoad();
            foreach (var i in AllItems)
            {
                if (shipSizeInt <= i.MaxSizeInt && shipPCURating >= i.MinPCU)
                {
                    ItemList.Add(i);
                }
            }
            return ItemList;
        }

        #endregion

        private List<ExpansionBay> NoHangerBay()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        private List<ExpansionBay> NoShuttleOrHangarBay()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        private void frameInfoApplication()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<Tier> selTier = LiveBay.ConstructTierLoad();
            List<BaseFrame> selFrame = LiveBay.ConstructFrameLoad();
            foreach (var t in selTier)
            {
                if (t.Type == shipTier)
                {
                    foreach (var f in selFrame)
                    {
                        if (f.Type == shipFrame)
                        {
                            dt = f.Dt;
                            if (t.HpInc == true)
                            {
                                hp = (f.Hp + (t.HpIncMulti * f.HpIncriment));
                            }
                            else if (t.HpInc == false)
                            {
                                hp = f.Hp;
                            }
                            ct = f.Hp / 5;
                        }
                    }
                }
            }
        }

        private void storeWpnsInfo()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<Weapon> WeaponList = LiveBay.ConstructWeaponLoadALL();
            foreach (var wpn in WeaponList)
            {
                if (forward01.Text == wpn.Type)
                {
                    sFWPNS01 = wpn.Type;
                    sFDMG01 = WeaponDamage(wpn);
                }
                if (forward02.Text == wpn.Type)
                {
                    sFWPNS02 = wpn.Type;
                    sFDMG02 = WeaponDamage(wpn);
                }
                if (forward03.Text == wpn.Type)
                {
                    sFWPNS03 = wpn.Type;
                    sFDMG03 = WeaponDamage(wpn);
                }
                if (forward04.Text == wpn.Type)
                {
                    sFWPNS04 = wpn.Type;
                    sFDMG04 = WeaponDamage(wpn);
                }
                if (port01.Text == wpn.Type)
                {
                    sPWPNS01 = wpn.Type;
                    sPDMG01 = WeaponDamage(wpn);
                }
                if (port02.Text == wpn.Type)
                {
                    sPWPNS02 = wpn.Type;
                    sPDMG02 = WeaponDamage(wpn);
                }
                if (port03.Text == wpn.Type)
                {
                    sPWPNS03 = wpn.Type;
                    sPDMG03 = WeaponDamage(wpn);
                }
                if (port04.Text == wpn.Type)
                {
                    sPWPNS04 = wpn.Type;
                    sPDMG04 = WeaponDamage(wpn);
                }
                if (starboard01.Text == wpn.Type)
                {
                    sSWPNS01 = wpn.Type;
                    sSDMG01 = WeaponDamage(wpn);
                }
                if (starboard02.Text == wpn.Type)
                {
                    sSWPNS02 = wpn.Type;
                    sSDMG02 = WeaponDamage(wpn);
                }
                if (starboard03.Text == wpn.Type)
                {
                    sSWPNS03 = wpn.Type;
                    sSDMG03 = WeaponDamage(wpn);
                }
                if (starboard04.Text == wpn.Type)
                {
                    sSWPNS04 = wpn.Type;
                    sSDMG04 = WeaponDamage(wpn);
                }
                if (aft01.Text == wpn.Type)
                {
                    sAWPNS01 = wpn.Type;
                    sADMG01 = WeaponDamage(wpn);
                }
                if (aft02.Text == wpn.Type)
                {
                    sAWPNS02 = wpn.Type;
                    sADMG02 = WeaponDamage(wpn);
                }
                if (aft03.Text == wpn.Type)
                {
                    sAWPNS03 = wpn.Type;
                    sADMG03 = WeaponDamage(wpn);
                }
                if (aft04.Text == wpn.Type)
                {
                    sAWPNS04 = wpn.Type;
                    sADMG04 = WeaponDamage(wpn);
                }
                if (turret01.Text == wpn.Type)
                {
                    sTWPNS01 = wpn.Type;
                    sTDMG01 = WeaponDamage(wpn);
                }
                if (turret02.Text == wpn.Type)
                {
                    sTWPNS02 = wpn.Type;
                    sTDMG02 = WeaponDamage(wpn);
                }
                if (turret03.Text == wpn.Type)
                {
                    sTWPNS03 = wpn.Type;
                    sTDMG03 = WeaponDamage(wpn);
                }
                if (turret04.Text == wpn.Type)
                {
                    sTWPNS04 = wpn.Type;
                    sTDMG04 = WeaponDamage(wpn);
                }
            }
        }

        #region Demographic Data

        private void starshipNameTextBox_Click(object sender, EventArgs e)
        {
            starshipNameTextBox.Clear();
        }

        private void starshipModelTextBox_Click(object sender, EventArgs e)
        {
            starshipModelTextBox.Clear();
        }

        private void starshipMakeTextBox_Click(object sender, EventArgs e)
        {
            starshipMakeTextBox.Clear();
        }







        #endregion


        #region Expansion Bays

        private void expBayComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            // Check if default is selected
            if (expBayComboBox1.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay01))
                {
                    // Return if nothing selected
                    return;
                }
                // Checks if user changes from a bay selection to default
                else if (!(String.IsNullOrEmpty(sExpBay01)))
                {
                    // Find the current selection
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay01))
                        {
                            // Adjust expansion bay slots and BP cost
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay01 = null;
                            return;
                        }
                    }
                }
            }
            // Check if user selects an expansion bay
            else if (String.IsNullOrEmpty(sExpBay01))
            {
                // Find the selection
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox1.Text))
                    {
                        // Check if selection goes below allowed expansion slots
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox1.SelectedIndex = 0;
                            return;
                        }
                        // Adjust expansion bay slot total and bp cost and set expansion bay
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay01 = expBayComboBox1.Text;
                        return;
                    }
                }
            }
            // Check if user changes from one expansion bay to another
            else if (!(String.IsNullOrEmpty(sExpBay01)))
            {
                // Find new bay selection
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox1.Text))
                    {
                        // Variables hold current selection
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        // Find current expansion bay slot number and bp cost
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay01))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        // Check if expansion slots go below allowed total
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox1.SelectedIndex = 0;
                            return;
                        }
                        // Adjust expansion bay slots and bp cost based off current selection
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;
                        // Adjust expansion bay slots and bp cost based off new selection
                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay01 = expBayComboBox1.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox2.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay02))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay02)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay02))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay02 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay02))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox2.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox2.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay02 = expBayComboBox2.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay02)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox2.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay02))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox2.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay02 = expBayComboBox2.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox3.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay03))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay03)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay03))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay03 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay03))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox3.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox1.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay03 = expBayComboBox3.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay03)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox3.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay03))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox3.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay03 = expBayComboBox3.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox4.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay04))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay04)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay04))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay04 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay04))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox4.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox4.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay04 = expBayComboBox4.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay04)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox4.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay04))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox4.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay04 = expBayComboBox4.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox5.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay05))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay05)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay05))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay05 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay05))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox5.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox5.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay05 = expBayComboBox5.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay05)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox5.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay05))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox5.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay05 = expBayComboBox5.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox6.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay06))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay06)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay06))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay06 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay06))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox6.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox6.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay06 = expBayComboBox6.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay06)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox6.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay06))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox6.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay06 = expBayComboBox6.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox7.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay07))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay07)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay07))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay07 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay07))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox7.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox7.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay07 = expBayComboBox7.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay07)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox7.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay07))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox7.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay07 = expBayComboBox7.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox8.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay08))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay08)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay08))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay08 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay08))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox8.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox8.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay08 = expBayComboBox8.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay08)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox8.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay08))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox8.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay08 = expBayComboBox8.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox9.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay09))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay09)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay09))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay09 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay09))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox9.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox9.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay09 = expBayComboBox9.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay09)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox9.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay09))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox9.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay09 = expBayComboBox9.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox10.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay10))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay10)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay10))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay10 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay10))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox10.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox10.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay10 = expBayComboBox10.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay10)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox10.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay10))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox10.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay10 = expBayComboBox10.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox11.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay11))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay11)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay11))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay11 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay11))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox11.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox11.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay11 = expBayComboBox11.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay11)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox11.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay11))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox11.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay11 = expBayComboBox11.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox12.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay12))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay12)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay12))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay12 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay12))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox12.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox12.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay12 = expBayComboBox12.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay12)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox12.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay12))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox12.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay12 = expBayComboBox12.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox13.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay13))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay13)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay13))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay13 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay13))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox13.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox13.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay13 = expBayComboBox13.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay13)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox13.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay13))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox13.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay13 = expBayComboBox13.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox14.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay14))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay14)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay14))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay14 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay14))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox14.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox14.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay14 = expBayComboBox14.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay14)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox14.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay14))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox14.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay14 = expBayComboBox14.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox15.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay15))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay15)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay15))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay15 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay15))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox15.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox15.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay15 = expBayComboBox15.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay15)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox15.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay15))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox15.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay15 = expBayComboBox15.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox16.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay16))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay16)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay16))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay16 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay16))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox16.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox16.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay16 = expBayComboBox16.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay16)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox16.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay16))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox16.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay16 = expBayComboBox16.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox17.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay17))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay17)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay17))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay17 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay17))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox17.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox17.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay17 = expBayComboBox17.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay17)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox17.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay17))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox17.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay17 = expBayComboBox17.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox18.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay18))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay18)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay18))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay18 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay18))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox18.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox18.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay18 = expBayComboBox18.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay18)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox18.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay18))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox18.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay18 = expBayComboBox18.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox19.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay19))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay19)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay19))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay19 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay19))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox19.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox19.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay19 = expBayComboBox19.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay19)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox19.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay19))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox19.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay19 = expBayComboBox19.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
        // See expBayComboBox1_SelectedIndexChanged for comments on code
        private void expBayComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ExpansionBay> availableBays = LiveBay.ConstructExpansionBayLoad01();
            if (expBayComboBox20.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(sExpBay20))
                {
                    return;
                }
                else if (!(String.IsNullOrEmpty(sExpBay20)))
                {
                    foreach (var a in availableBays)
                    {
                        if (a.Type.Equals(sExpBay20))
                        {
                            expSlotsLeft.Text = (expBayNum += a.ExpSlotNum).ToString();
                            expBPSelected.Text = (expBPSpent -= a.BpCost).ToString();
                            sExpBay20 = null;
                            return;
                        }
                    }
                }
            }
            else if (String.IsNullOrEmpty(sExpBay20))
            {
                foreach (var b in availableBays)
                {
                    if (b.Type.Equals(expBayComboBox20.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        expBaySlotTotal -= b.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox20.SelectedIndex = 0;
                            return;
                        }
                        expSlotsLeft.Text = (expBayNum -= b.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += b.BpCost).ToString();
                        sExpBay20 = expBayComboBox20.Text;
                        return;
                    }
                }
            }
            else if (!(String.IsNullOrEmpty(sExpBay20)))
            {
                foreach (var d in availableBays)
                {
                    if (d.Type.Equals(expBayComboBox20.Text))
                    {
                        int expBaySlotTotal = expBayNum;
                        int currentExpSlotNum = 0;
                        int currentBpCost = 0;
                        foreach (var x in availableBays)
                        {
                            if (x.Type.Equals(sExpBay20))
                            {
                                expBaySlotTotal += x.ExpSlotNum;
                                currentExpSlotNum = x.ExpSlotNum;
                                currentBpCost = x.BpCost;
                                break;
                            }
                        }
                        expBaySlotTotal -= d.ExpSlotNum;
                        if (expBaySlotTotal < 0)
                        {
                            MessageBox.Show("Not enough Expansion Bay slots. Please review your selections", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            expBayComboBox20.SelectedIndex = 0;
                            return;
                        }
                        expBayNum += currentExpSlotNum;
                        expBPSpent -= currentBpCost;

                        expSlotsLeft.Text = (expBayNum -= d.ExpSlotNum).ToString();
                        expBPSelected.Text = (expBPSpent += d.BpCost).ToString();
                        sExpBay20 = expBayComboBox20.Text;
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }





        #endregion


        #region Weapons

        #region WeaponsBySize

        private List<Weapon> LightDirect()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Light" && w.Tracking == false)
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> LightTracking()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Light" && w.Tracking == true)
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> Light()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Light")
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> HeavyDirect()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Heavy" && w.Tracking == false)
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> HeavyTracking()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Heavy" && w.Tracking == true)
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> Heavy()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Heavy")
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> CapitalDirect()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Capital" && w.Tracking == false)
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> CapitalTracking()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Capital" && w.Tracking == true)
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        private List<Weapon> Capital()
        {
            List<Weapon> wpns = new List<Weapon>();
            List<Weapon> AllWeapons = new List<Weapon>();
            foreach (var w in AllWeapons)
            {
                if (w.Size == "Capital")
                {
                    wpns.Add(w);
                }
            }
            return wpns;
        }

        #endregion



        private void WeaponSelectionCost()
        {
            int BPCount = 0;
            int PCUCount = 0;
            AssemblyBay LiveBay = new AssemblyBay();
            List<Weapon> AllWeapons = LiveBay.ConstructWeaponLoadALL();
            List<ComboBox> SelectedWeapons = WeaponsBoxes();
            foreach (var s in SelectedWeapons)
            {
                foreach (var a in AllWeapons)
                {
                    if (a.Type == s.Text)
                    {
                        BPCount += a.BpCost;
                        PCUCount += a.Pcu;
                    }
                }
            }
            wpnsBPSelected.Text = BPCount.ToString();
            wpnsPCUUsed.Text = PCUCount.ToString();
        }

        private string WeaponDamage(Weapon wpn)
        {
            return wpn.Damage;
        }

        private void AssignWeaponsToBox()
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ComboBox> WeaponToFrame = new List<ComboBox>();

            #region Them Slots Son

            //Forward Slots

            if (fcb1.Text == "Light")
            {
                forward01.DataSource = LiveBay.ConstructWeaponLoadF1L();
            }
            else if (fcb1.Text == "Heavy")
            {
                forward01.DataSource = LiveBay.ConstructWeaponLoadF1H();
            }
            else if (fcb1.Text == "Capital")
            {
                forward01.DataSource = LiveBay.ConstructWeaponLoadF1C();
            }



            if (fcb2.Text == "Light")
            {
                forward02.DataSource = LiveBay.ConstructWeaponLoadF2L();
            }
            else if (fcb2.Text == "Heavy")
            {
                forward02.DataSource = LiveBay.ConstructWeaponLoadF2H();
            }
            else if (fcb2.Text == "Capital")
            {
                forward02.DataSource = LiveBay.ConstructWeaponLoadF2C();
            }



            if (fcb3.Text == "Light")
            {
                forward03.DataSource = LiveBay.ConstructWeaponLoadF3L();
            }
            else if (fcb3.Text == "Heavy")
            {
                forward03.DataSource = LiveBay.ConstructWeaponLoadF3H();
            }
            else if (fcb3.Text == "Capital")
            {
                forward03.DataSource = LiveBay.ConstructWeaponLoadF3C();
            }



            if (fcb4.Text == "Light")
            {
                forward04.DataSource = LiveBay.ConstructWeaponLoadF4L();
            }
            else if (fcb4.Text == "Heavy")
            {
                forward04.DataSource = LiveBay.ConstructWeaponLoadF4H();
            }
            else if (fcb4.Text == "Capital")
            {
                forward04.DataSource = LiveBay.ConstructWeaponLoadF4C();
            }

            // Forward Slots End


            //Port Slots


            if (pcb1.Text == "Light")
            {
                port01.DataSource = LiveBay.ConstructWeaponLoadP1L();
            }
            else if (pcb1.Text == "Heavy")
            {
                port01.DataSource = LiveBay.ConstructWeaponLoadP1H();
            }
            else if (pcb1.Text == "Capital")
            {
                port01.DataSource = LiveBay.ConstructWeaponLoadP1C();
            }


            if (pcb2.Text == "Light")
            {
                port02.DataSource = LiveBay.ConstructWeaponLoadP2L();
            }
            else if (pcb2.Text == "Heavy")
            {
                port02.DataSource = LiveBay.ConstructWeaponLoadP2H();
            }
            else if (pcb2.Text == "Capital")
            {
                port02.DataSource = LiveBay.ConstructWeaponLoadP2C();
            }


            if (pcb3.Text == "Light")
            {
                port03.DataSource = LiveBay.ConstructWeaponLoadP3L();
            }
            else if (pcb3.Text == "Heavy")
            {
                port03.DataSource = LiveBay.ConstructWeaponLoadP3H();
            }
            else if (pcb3.Text == "Capital")
            {
                port03.DataSource = LiveBay.ConstructWeaponLoadP3C();
            }


            if (pcb4.Text == "Light")
            {
                port04.DataSource = LiveBay.ConstructWeaponLoadP4L();
            }
            else if (pcb4.Text == "Heavy")
            {
                port04.DataSource = LiveBay.ConstructWeaponLoadP4H();
            }
            else if (pcb4.Text == "Capital")
            {
                port04.DataSource = LiveBay.ConstructWeaponLoadP4C();
            }

            // Port Slots End



            // Starboard Slots

            if (scb1.Text == "Light")
            {
                starboard01.DataSource = LiveBay.ConstructWeaponLoadS1L();
            }
            else if (scb1.Text == "Heavy")
            {
                starboard01.DataSource = LiveBay.ConstructWeaponLoadS1H();
            }
            else if (scb1.Text == "Capital")
            {
                starboard01.DataSource = LiveBay.ConstructWeaponLoadS1C();
            }

            if (scb2.Text == "Light")
            {
                starboard02.DataSource = LiveBay.ConstructWeaponLoadS2L();
            }
            else if (scb2.Text == "Heavy")
            {
                starboard02.DataSource = LiveBay.ConstructWeaponLoadS2H();
            }
            else if (scb2.Text == "Capital")
            {
                starboard02.DataSource = LiveBay.ConstructWeaponLoadS2C();
            }

            if (scb3.Text == "Light")
            {
                starboard03.DataSource = LiveBay.ConstructWeaponLoadS3L();
            }
            else if (scb3.Text == "Heavy")
            {
                starboard03.DataSource = LiveBay.ConstructWeaponLoadS3H();
            }
            else if (scb3.Text == "Capital")
            {
                starboard03.DataSource = LiveBay.ConstructWeaponLoadS3C();
            }

            if (scb4.Text == "Light")
            {
                starboard04.DataSource = LiveBay.ConstructWeaponLoadS4L();
            }
            else if (scb4.Text == "Heavy")
            {
                starboard04.DataSource = LiveBay.ConstructWeaponLoadS4H();
            }
            else if (scb4.Text == "Capital")
            {
                starboard04.DataSource = LiveBay.ConstructWeaponLoadS4C();
            }

            // Starboard Slots End



            // Aft Slots

            if (acb1.Text == "Light")
            {
                aft01.DataSource = LiveBay.ConstructWeaponLoadA1L();
            }
            else if (acb1.Text == "Heavy")
            {
                aft01.DataSource = LiveBay.ConstructWeaponLoadA1H();
            }
            else if (acb1.Text == "Capital")
            {
                aft01.DataSource = LiveBay.ConstructWeaponLoadA1C();
            }

            if (acb2.Text == "Light")
            {
                aft02.DataSource = LiveBay.ConstructWeaponLoadA2L();
            }
            else if (acb2.Text == "Heavy")
            {
                aft02.DataSource = LiveBay.ConstructWeaponLoadA2H();
            }
            else if (acb2.Text == "Capital")
            {
                aft02.DataSource = LiveBay.ConstructWeaponLoadA2C();
            }

            if (acb3.Text == "Light")
            {
                aft03.DataSource = LiveBay.ConstructWeaponLoadA3L();
            }
            else if (acb3.Text == "Heavy")
            {
                aft03.DataSource = LiveBay.ConstructWeaponLoadA3H();
            }
            else if (acb3.Text == "Capital")
            {
                aft03.DataSource = LiveBay.ConstructWeaponLoadA3C();
            }

            if (acb4.Text == "Light")
            {
                aft04.DataSource = LiveBay.ConstructWeaponLoadA4L();
            }
            else if (acb4.Text == "Heavy")
            {
                aft04.DataSource = LiveBay.ConstructWeaponLoadA4H();
            }
            else if (acb4.Text == "Capital")
            {
                aft04.DataSource = LiveBay.ConstructWeaponLoadA4C();
            }

            // Aft Slots End

            // Turret Slots

            if (tcb1.Text == "Light")
            {
                turret01.DataSource = LiveBay.ConstructWeaponLoadT1L();
            }
            else if (tcb1.Text == "Heavy")
            {
                turret01.DataSource = LiveBay.ConstructWeaponLoadT1H();
            }

            if (tcb2.Text == "Light")
            {
                turret02.DataSource = LiveBay.ConstructWeaponLoadT2L();
            }
            else if (tcb2.Text == "Heavy")
            {
                turret02.DataSource = LiveBay.ConstructWeaponLoadT2H();
            }

            if (tcb3.Text == "Light")
            {
                turret03.DataSource = LiveBay.ConstructWeaponLoadT3L();
            }
            else if (tcb3.Text == "Heavy")
            {
                turret03.DataSource = LiveBay.ConstructWeaponLoadT3H();
            }

            if (tcb4.Text == "Light")
            {
                turret04.DataSource = LiveBay.ConstructWeaponLoadT4L();
            }
            else if (tcb4.Text == "Heavy")
            {
                turret04.DataSource = LiveBay.ConstructWeaponLoadT4H();
            }

            // Turrets Slots End

            #endregion

            forward01.DisplayMember = "Type";
            forward02.DisplayMember = "Type";
            forward03.DisplayMember = "Type";
            forward04.DisplayMember = "Type";
            port01.DisplayMember = "Type";
            port02.DisplayMember = "Type";
            port03.DisplayMember = "Type";
            port04.DisplayMember = "Type";
            starboard01.DisplayMember = "Type";
            starboard02.DisplayMember = "Type";
            starboard03.DisplayMember = "Type";
            starboard04.DisplayMember = "Type";
            aft01.DisplayMember = "Type";
            aft02.DisplayMember = "Type";
            aft03.DisplayMember = "Type";
            aft04.DisplayMember = "Type";
            turret01.DisplayMember = "Type";
            turret02.DisplayMember = "Type";
            turret03.DisplayMember = "Type";
            turret04.DisplayMember = "Type";
        }

        private void ActiveWeaponsBoxesVisible(List<ComboBox> OWB)
        {
            List<ComboBox> AllWeaponsBoxes = OWB;
            List<ComboBox> AWB = new List<ComboBox>();
            List<ComboBox> UpgradeBoxes = new List<ComboBox>();
            UpgradeBoxes.Add(fcb1);
            UpgradeBoxes.Add(fcb2);
            UpgradeBoxes.Add(fcb3);
            UpgradeBoxes.Add(fcb4);
            UpgradeBoxes.Add(pcb1);
            UpgradeBoxes.Add(pcb2);
            UpgradeBoxes.Add(pcb3);
            UpgradeBoxes.Add(pcb4);
            UpgradeBoxes.Add(scb1);
            UpgradeBoxes.Add(scb2);
            UpgradeBoxes.Add(scb3);
            UpgradeBoxes.Add(scb4);
            UpgradeBoxes.Add(acb1);
            UpgradeBoxes.Add(acb2);
            UpgradeBoxes.Add(acb3);
            UpgradeBoxes.Add(acb4);
            UpgradeBoxes.Add(tcb1);
            UpgradeBoxes.Add(tcb2);
            UpgradeBoxes.Add(tcb3);
            UpgradeBoxes.Add(tcb4);

            foreach (var n in UpgradeBoxes)
            {
                foreach (var s in AllWeaponsBoxes)
                {
                    if (n.Text == "-None-")
                    {
                        s.Visible = true;
                    }
                    else if (n.Text != "-None-")
                    {
                        s.Visible = true;
                    }
                }
            }
            foreach (var b in AllWeaponsBoxes)
            {
                if (b.Visible == true)
                {
                    AWB.Add(b);
                }
            }
        }




        private void wpnsExpBayApplication(BaseFrame frame)
        {
            if (frame.Type == "Racer")
            {
                forward01.Visible = true;
                aft01.Visible = true;
            }
            else if (frame.Type == "Interceptor")
            {
                forward01.Visible = true;
                forward02.Visible = true;
            }
            else if (frame.Type == "Fighter")
            {
                forward01.Visible = true;
                forward02.Visible = true;
                aft01.Visible = true;
            }
            else if (frame.Type == "Shuttle")
            {
                forward01.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expSlotsLeft.Text = "3";
                expBayNum = 3;
            }
            else if (frame.Type == "Light Freighter")
            {
                forward01.Visible = true;
                forward02.Visible = true;
                port01.Visible = true;
                starboard01.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expSlotsLeft.Text = "3";
                expBayNum = 3;
            }
            else if (frame.Type == "Explorer")
            {
                forward01.Visible = true;
                port01.Visible = true;
                starboard01.Visible = true;
                turret01.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expSlotsLeft.Text = "4";
                expBayNum = 4;
            }
            else if (frame.Type == "Transport")
            {
                forward01.Visible = true;
                forward02.Visible = true;
                aft01.Visible = true;
                turret01.Visible = true;
                turret02.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expBayComboBox5.Visible = true;
                expSlotsLeft.Text = "5";
                expBayNum = 5;
            }
            else if (frame.Type == "Destroyer")
            {
                forward01.Visible = true;
                forward02.Visible = true;
                port01.Visible = true;
                starboard01.Visible = true;
                aft01.Visible = true;
                turret01.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expSlotsLeft.Text = "4";
                expBayNum = 4;
            }
            else if (frame.Type == "Heavy Freighter")
            {
                forward01.Visible = true;
                forward02.Visible = true;
                forward03.Visible = true;
                port01.Visible = true;
                starboard01.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expBayComboBox5.Visible = true;
                expBayComboBox6.Visible = true;
                expBayComboBox7.Visible = true;
                expBayComboBox8.Visible = true;
                expSlotsLeft.Text = "8";
                expBayNum = 8;
            }
            else if (frame.Type == "Bulk Freighter")
            {
                forward01.Visible = true;
                aft01.Visible = true;
                turret01.Visible = true;
                turret02.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expBayComboBox5.Visible = true;
                expBayComboBox6.Visible = true;
                expBayComboBox7.Visible = true;
                expBayComboBox8.Visible = true;
                expBayComboBox9.Visible = true;
                expBayComboBox10.Visible = true;
                expSlotsLeft.Text = "10";
                expBayNum = 10;
            }
            else if (frame.Type == "Cruiser")
            {
                forward01.Visible = true;
                port01.Visible = true;
                starboard01.Visible = true;
                turret01.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expBayComboBox5.Visible = true;
                expBayComboBox6.Visible = true;
                expSlotsLeft.Text = "6";
                expBayNum = 6;
            }
            else if (frame.Type == "Carrier")
            {
                forward01.Visible = true;
                port01.Visible = true;
                port02.Visible = true;
                port03.Visible = true;
                starboard01.Visible = true;
                starboard02.Visible = true;
                starboard03.Visible = true;
                turret01.Visible = true;
                turret02.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expBayComboBox5.Visible = true;
                expBayComboBox6.Visible = true;
                expBayComboBox7.Visible = true;
                expBayComboBox8.Visible = true;
                expBayComboBox9.Visible = true;
                expBayComboBox10.Visible = true;
                expSlotsLeft.Text = "10";
                expBayNum = 10;
            }
            else if (frame.Type == "Battleship")
            {
                forward01.Visible = true;
                forward02.Visible = true;
                forward03.Visible = true;
                port01.Visible = true;
                port02.Visible = true;
                port03.Visible = true;
                starboard01.Visible = true;
                starboard02.Visible = true;
                starboard03.Visible = true;
                aft01.Visible = true;
                turret01.Visible = true;
                turret02.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expBayComboBox5.Visible = true;
                expBayComboBox6.Visible = true;
                expBayComboBox7.Visible = true;
                expBayComboBox8.Visible = true;
                expSlotsLeft.Text = "8";
                expBayNum = 8;
            }
            else if (frame.Type == "Dreadnought")
            {
                forward01.Visible = true;
                forward02.Visible = true;
                forward03.Visible = true;
                forward04.Visible = true;
                port01.Visible = true;
                port02.Visible = true;
                port03.Visible = true;
                port04.Visible = true;
                starboard01.Visible = true;
                starboard02.Visible = true;
                starboard03.Visible = true;
                starboard04.Visible = true;
                turret01.Visible = true;
                turret02.Visible = true;
                turret03.Visible = true;
                turret04.Visible = true;
                expBayComboBox1.Visible = true;
                expBayComboBox2.Visible = true;
                expBayComboBox3.Visible = true;
                expBayComboBox4.Visible = true;
                expBayComboBox5.Visible = true;
                expBayComboBox6.Visible = true;
                expBayComboBox7.Visible = true;
                expBayComboBox8.Visible = true;
                expBayComboBox9.Visible = true;
                expBayComboBox10.Visible = true;
                expBayComboBox11.Visible = true;
                expBayComboBox12.Visible = true;
                expBayComboBox13.Visible = true;
                expBayComboBox14.Visible = true;
                expBayComboBox15.Visible = true;
                expBayComboBox16.Visible = true;
                expBayComboBox17.Visible = true;
                expBayComboBox18.Visible = true;
                expBayComboBox19.Visible = true;
                expBayComboBox20.Visible = true;
                expSlotsLeft.Text = "20";
                expBayNum = 20;
            }
        }

        private void hideWpnsExp()
        {
            forward01.Visible = false;
            forward02.Visible = false;
            forward03.Visible = false;
            forward04.Visible = false;
            port01.Visible = false;
            port02.Visible = false;
            port03.Visible = false;
            port04.Visible = false;
            starboard01.Visible = false;
            starboard02.Visible = false;
            starboard03.Visible = false;
            starboard04.Visible = false;
            aft01.Visible = false;
            aft02.Visible = false;
            aft03.Visible = false;
            aft04.Visible = false;
            turret01.Visible = false;
            turret02.Visible = false;
            turret03.Visible = false;
            turret04.Visible = false;
        }

        private List<ComboBox> WeaponsBoxes()
        {
            ComboBox box = new ComboBox();
            List<ComboBox> AllBoxes = new List<ComboBox>();
            AllBoxes.Add(forward01);
            AllBoxes.Add(forward02);
            AllBoxes.Add(forward03);
            AllBoxes.Add(forward04);
            AllBoxes.Add(port01);
            AllBoxes.Add(port02);
            AllBoxes.Add(port03);
            AllBoxes.Add(port04);
            AllBoxes.Add(starboard01);
            AllBoxes.Add(starboard02);
            AllBoxes.Add(starboard03);
            AllBoxes.Add(starboard04);
            AllBoxes.Add(aft01);
            AllBoxes.Add(aft02);
            AllBoxes.Add(aft03);
            AllBoxes.Add(aft04);
            AllBoxes.Add(turret01);
            AllBoxes.Add(turret02);
            AllBoxes.Add(turret03);
            AllBoxes.Add(turret04);
            return AllBoxes;
        }

        #region Weapons Upgrade Step 1

        // Used in Upgrade Event Handler -- Passed as Parameters in AssignUpgardeBoxesByFrame -- List of Boxes by Frame Size

        private List<ComboBox> AllUpgradeBoxes()
        {
            ComboBox box = new ComboBox();
            List<ComboBox> AllBoxes = new List<ComboBox>();
            AllBoxes.Add(fcb1);
            AllBoxes.Add(fcb2);
            AllBoxes.Add(fcb3);
            AllBoxes.Add(fcb4);
            AllBoxes.Add(pcb1);
            AllBoxes.Add(pcb2);
            AllBoxes.Add(pcb3);
            AllBoxes.Add(pcb4);
            AllBoxes.Add(scb1);
            AllBoxes.Add(scb2);
            AllBoxes.Add(scb3);
            AllBoxes.Add(scb4);
            AllBoxes.Add(acb1);
            AllBoxes.Add(acb2);
            AllBoxes.Add(acb3);
            AllBoxes.Add(acb4);
            AllBoxes.Add(tcb1);
            AllBoxes.Add(tcb2);
            AllBoxes.Add(tcb3);
            AllBoxes.Add(tcb4);
            return AllBoxes;
        }

        private List<ComboBox> TSUpgradeBoxes()
        {
            ComboBox box = new ComboBox();
            List<ComboBox> AllBoxes = new List<ComboBox>();
            AllBoxes.Add(fcb1);
            AllBoxes.Add(fcb2);
            AllBoxes.Add(pcb1);
            AllBoxes.Add(pcb2);
            AllBoxes.Add(scb1);
            AllBoxes.Add(scb2);
            AllBoxes.Add(acb1);
            AllBoxes.Add(acb2);
            AllBoxes.Add(tcb1);
            AllBoxes.Add(tcb2);
            return AllBoxes;
        }

        private List<ComboBox> MLUpgradeBoxes()
        {
            ComboBox box = new ComboBox();
            List<ComboBox> AllBoxes = new List<ComboBox>();
            AllBoxes.Add(fcb1);
            AllBoxes.Add(fcb2);
            AllBoxes.Add(fcb3);
            AllBoxes.Add(pcb1);
            AllBoxes.Add(pcb2);
            AllBoxes.Add(pcb3);
            AllBoxes.Add(scb1);
            AllBoxes.Add(scb2);
            AllBoxes.Add(scb3);
            AllBoxes.Add(acb1);
            AllBoxes.Add(acb2);
            AllBoxes.Add(acb3);
            AllBoxes.Add(tcb1);
            AllBoxes.Add(tcb2);
            AllBoxes.Add(tcb3);
            return AllBoxes;
        }


        // Called in AssignUpgradeBoxesByFrame -- List will depend on Frame when Called
        public List<ComboBox> UpgradesVisibleLoaded(List<ComboBox> filteredBoxesByFrame)
        {
            List<ComboBox> upgrades = filteredBoxesByFrame;
            foreach (var s in upgrades)
            {
                s.Visible = true;
                s.DisplayMember = "Size";
                s.Text = "-None-";
            };
            return upgrades;
        }


        //  Called in AssignUpgradeBoxesByFrame -- Hides all Boxes so AssignUpgradeBoxesByFrame will reappear the appropriate number based off of Frame
        public void HideUpgradeBoxes(List<ComboBox> boxes)
        {
            foreach (var s in boxes)
            {
                s.Visible = false;
            }
        }

        // Used in Upgrade Event Handler -- Returns a List of ComboBoxes with the appropriate attributes based off of Frame
        public List<ComboBox> AssignUpgradeBoxesByFrame(List<ComboBox> ALL, List<ComboBox> TS, List<ComboBox> ML, string frame)
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<ComboBox> frameSet = new List<ComboBox>();
            HideUpgradeBoxes(AllUpgradeBoxes());
            if (frame == "Racer")
            {
                frameSet = UpgradesVisibleLoaded(TS);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP1();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP2();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT2();

                fcb1.Text = "Light";
                f1Light = true;
                acb1.Text = "Light";
                a1Light = true;
            }
            else if (frame == "Interceptor")
            {
                frameSet = UpgradesVisibleLoaded(TS);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP1();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP2();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT2();

                fcb1.Text = "Light";
                f1Light = true;
                fcb2.Text = "Light";
                f2Light = true;
            }
            else if (frame == "Fighter")
            {
                frameSet = UpgradesVisibleLoaded(TS);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP1();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP2();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT2();

                fcb1.Text = "Light";
                f1Light = true;
                fcb2.Text = "Light";
                f2Light = true;
                acb1.Text = "Light";
                a1Light = true;
            }
            else if (frame == "Shuttle")
            {
                frameSet = UpgradesVisibleLoaded(TS);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP1();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP2();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT2();

                fcb1.Text = "Light";
                f1Light = true;
            }
            else if (frame == "Light Freighter")
            {
                frameSet = UpgradesVisibleLoaded(TS);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP1();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadP2();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadS2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadA2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLightLoadT2();

                fcb1.Text = "Light";
                f1Light = true;
                fcb2.Text = "Light";
                f2Light = true;
                scb1.Text = "Light";
                s1Light = true;
                pcb1.Text = "Light";
                p1Light = true;
            }
            else if (frame == "Explorer")
            {
                frameSet = UpgradesVisibleLoaded(ML);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP1();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP2();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP3();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS3();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA1();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA2();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA3();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT3();

                fcb1.Text = "Light";
                f1Light = true;
                pcb1.Text = "Light";
                p1Light = true;
                scb1.Text = "Light";
                s1Light = true;
                tcb1.Text = "Light";
                t1Light = true;
            }
            else if (frame == "Transport")
            {
                frameSet = UpgradesVisibleLoaded(ML);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP1();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP2();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP3();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS3();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA1();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA2();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA3();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT3();

                fcb1.Text = "Heavy";
                f1Heavy = true;
                fcb2.Text = "Light";
                f1Light = true;
                acb1.Text = "Light";
                a1Light = true;
                tcb1.Text = "Light";
                t1Light = true;
                tcb2.Text = "Light";
                t2Light = true;
            }
            else if (frame == "Destroyer")
            {
                frameSet = UpgradesVisibleLoaded(ML);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP1();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP2();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP3();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS3();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA1();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA2();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA3();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT3();

                fcb1.Text = "Heavy";
                f1Heavy = true;
                fcb2.Text = "Heavy";
                f2Heavy = true;
                pcb1.Text = "Light";
                p1Light = true;
                scb1.Text = "Light";
                s1Light = true;
                acb1.Text = "Light";
                a1Light = true;
                tcb1.Text = "Light";
                t1Light = true;

            }
            else if (frame == "Heavy Freighter")
            {
                frameSet = UpgradesVisibleLoaded(ML);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP1();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP2();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadP3();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS1();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS2();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadS3();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA1();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA2();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadA3();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeLHLoadT3();

                fcb1.Text = "Heavy";
                f1Heavy = true;
                fcb2.Text = "Light";
                f2Light = true;
                fcb3.Text = "Light";
                f3Light = true;
                pcb1.Text = "Heavy";
                p1Heavy = true;
                scb1.Text = "Heavy";
                s1Heavy = true;
            }
            else if (frame == "Bulk Freighter")
            {
                frameSet = UpgradesVisibleLoaded(ALL);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF4();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP3();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP4();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS2();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS3();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS4();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA3();
                frameSet[15].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA4();
                frameSet[16].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT1();
                frameSet[17].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT2();
                frameSet[18].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT3();
                frameSet[19].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT4();

                fcb1.Text = "Heavy";
                f1Heavy = true;
                acb1.Text = "Heavy";
                a1Heavy = true;
                tcb1.Text = "Light";
                t1Light = true;
                tcb2.Text = "Light";
                t2Light = true;
            }
            else if (frame == "Cruiser")
            {
                frameSet = UpgradesVisibleLoaded(ALL);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF4();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP3();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP4();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS2();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS3();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS4();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA3();
                frameSet[15].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA4();
                frameSet[16].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT1();
                frameSet[17].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT2();
                frameSet[18].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT3();
                frameSet[19].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT4();

                fcb1.Text = "Capital";
                f1Cap = true;
                pcb1.Text = "Light";
                p1Light = true;
                scb1.Text = "Light";
                s1Light = true;
                tcb1.Text = "Heavy";
                t1Heavy = true;
            }
            else if (frame == "Carrier")
            {
                frameSet = UpgradesVisibleLoaded(ALL);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF4();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP3();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP4();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS2();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS3();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS4();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA3();
                frameSet[15].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA4();
                frameSet[16].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT1();
                frameSet[17].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT2();
                frameSet[18].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT3();
                frameSet[19].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT4();

                fcb1.Text = "Capital";
                f1Cap = true;
                pcb1.Text = "Heavy";
                p1Heavy = true;
                pcb2.Text = "Heavy";
                p2Heavy = true;
                pcb3.Text = "Heavy";
                p3Heavy = true;
                scb1.Text = "Heavy";
                s1Heavy = true;
                scb2.Text = "Heavy";
                s2Heavy = true;
                scb3.Text = "Heavy";
                s3Heavy = true;
                tcb1.Text = "Light";
                t1Light = true;
                tcb2.Text = "Light";
                t2Light = true;
            }
            else if (frame == "Battleship")
            {
                frameSet = UpgradesVisibleLoaded(ALL);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF4();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP3();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP4();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS2();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS3();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS4();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA3();
                frameSet[15].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA4();
                frameSet[16].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT1();
                frameSet[17].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT2();
                frameSet[18].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT3();
                frameSet[19].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT4();

                fcb1.Text = "Capital";
                f1Cap = true;
                fcb2.Text = "Heavy";
                f2Heavy = true;
                fcb3.Text = "Heavy";
                f3Heavy = true;
                pcb1.Text = "Heavy";
                p1Heavy = true;
                pcb2.Text = "Heavy";
                p2Heavy = true;
                pcb3.Text = "Light";
                p3Light = true;
                scb1.Text = "Heavy";
                s1Heavy = true;
                scb2.Text = "Heavy";
                s2Heavy = true;
                scb3.Text = "Light";
                s3Light = true;
                acb1.Text = "Light";
                a1Light = true;
                tcb1.Text = "Heavy";
                t1Heavy = true;
                tcb2.Text = "Heavy";
                t2Heavy = true;
            }
            else if (frame == "Dreadnought")
            {
                frameSet = UpgradesVisibleLoaded(ALL);
                frameSet[0].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF1();
                frameSet[1].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF2();
                frameSet[2].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF3();
                frameSet[3].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadF4();
                frameSet[4].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP1();
                frameSet[5].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP2();
                frameSet[6].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP3();
                frameSet[7].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadP4();
                frameSet[8].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS1();
                frameSet[9].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS2();
                frameSet[10].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS3();
                frameSet[11].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadS4();
                frameSet[12].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA1();
                frameSet[13].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA2();
                frameSet[14].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA3();
                frameSet[15].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadA4();
                frameSet[16].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT1();
                frameSet[17].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT2();
                frameSet[18].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT3();
                frameSet[19].DataSource = LiveBay.ConstructWeaponSlotSizeAllLoadT4();

                fcb1.Text = "Capital";
                f1Cap = true;
                fcb2.Text = "Capital";
                f2Cap = true;
                fcb3.Text = "Heavy";
                f3Heavy = true;
                fcb4.Text = "Heavy";
                f4Heavy = true;
                pcb1.Text = "Capital";
                p1Cap = true;
                pcb2.Text = "Heavy";
                p2Heavy = true;
                pcb3.Text = "Heavy";
                p3Heavy = true;
                pcb4.Text = "Heavy";
                p4Heavy = true;
                scb1.Text = "Capital";
                s1Cap = true;
                scb2.Text = "Heavy";
                s2Heavy = true;
                scb3.Text = "Heavy";
                s3Heavy = true;
                scb4.Text = "Heavy";
                s4Heavy = true;
                tcb1.Text = "Light";
                t1Light = true;
                tcb2.Text = "Light";
                t2Light = true;
                tcb3.Text = "Light";
                t3Light = true;
                tcb4.Text = "Light";
                t4Light = true;
            }
            wpnUpgradeBPLabel.Text = "0";
            return frameSet;
        }

        #endregion

        #region Weapons Upgrade Step 2

        private int GetSlotsValue()
        {
            int tally = 0;
            List<bool> LSlots = new List<bool>();
            LSlots.Add(f1Light);
            LSlots.Add(f2Light);
            LSlots.Add(f3Light);
            LSlots.Add(f4Light);
            LSlots.Add(p1Light);
            LSlots.Add(p2Light);
            LSlots.Add(p3Light);
            LSlots.Add(p4Light);
            LSlots.Add(s1Light);
            LSlots.Add(s2Light);
            LSlots.Add(s3Light);
            LSlots.Add(s4Light);
            LSlots.Add(a1Light);
            LSlots.Add(a2Light);
            LSlots.Add(a3Light);
            LSlots.Add(a4Light);

            List<bool> LSlotsT = new List<bool>();
            LSlotsT.Add(t1Light);
            LSlotsT.Add(t2Light);
            LSlotsT.Add(t3Light);
            LSlotsT.Add(t4Light);

            List<bool> HSlots = new List<bool>();
            HSlots.Add(f1Heavy);
            HSlots.Add(f2Heavy);
            HSlots.Add(f3Heavy);
            HSlots.Add(f4Heavy);
            HSlots.Add(p1Heavy);
            HSlots.Add(p2Heavy);
            HSlots.Add(p3Heavy);
            HSlots.Add(p4Heavy);
            HSlots.Add(s1Heavy);
            HSlots.Add(s2Heavy);
            HSlots.Add(s3Heavy);
            HSlots.Add(s4Heavy);
            HSlots.Add(a1Heavy);
            HSlots.Add(a2Heavy);
            HSlots.Add(a3Heavy);
            HSlots.Add(a4Heavy);

            List<bool> HSlotsT = new List<bool>();
            HSlotsT.Add(t1Heavy);
            HSlotsT.Add(t2Heavy);
            HSlotsT.Add(t3Heavy);
            HSlotsT.Add(t4Heavy);

            List<bool> CSlots = new List<bool>();
            CSlots.Add(f1Cap);
            CSlots.Add(f2Cap);
            CSlots.Add(f3Cap);
            CSlots.Add(f4Cap);
            CSlots.Add(p1Cap);
            CSlots.Add(p2Cap);
            CSlots.Add(p3Cap);
            CSlots.Add(p4Cap);
            CSlots.Add(s1Cap);
            CSlots.Add(s2Cap);
            CSlots.Add(s3Cap);
            CSlots.Add(s4Cap);
            CSlots.Add(a1Cap);
            CSlots.Add(a2Cap);
            CSlots.Add(a3Cap);
            CSlots.Add(a4Cap);

            foreach (var ls in LSlots)
            {
                if (ls == true)
                {
                    tally += 3;
                }
            }

            foreach (var lst in LSlotsT)
            {
                if (lst == true)
                {
                    tally += 5;
                }
            }

            foreach (var hs in HSlots)
            {
                if (hs == true)
                {
                    tally += 7;
                }
            }

            foreach (var hst in HSlotsT)
            {
                if (hst == true)
                {
                    tally += 11;
                }
            }

            foreach (var cs in CSlots)
            {
                if (cs == true)
                {
                    tally += 12;
                }
            }
            return tally;
        }

        private void UpdateBooleansBasedOffOfText()
        {
            if (fcb1.Text == "Light")
            {
                f1Light = true;
                f1Heavy = false;
                f1Cap = false;
            }
            else if (fcb1.Text == "Heavy")
            {
                f1Light = false;
                f1Heavy = true;
                f1Cap = false;
            }
            else if (fcb1.Text == "Capital")
            {
                f1Light = false;
                f1Heavy = false;
                f1Cap = true;
            }

            if (fcb2.Text == "Light")
            {
                f2Light = true;
                f2Heavy = false;
                f2Cap = false;
            }
            else if (fcb2.Text == "Heavy")
            {
                f2Light = false;
                f2Heavy = true;
                f2Cap = false;
            }
            else if (fcb2.Text == "Capital")
            {
                f2Light = false;
                f2Heavy = false;
                f2Cap = true;
            }

            if (fcb3.Text == "Light")
            {
                f3Light = true;
                f3Heavy = false;
                f3Cap = false;
            }
            else if (fcb3.Text == "Heavy")
            {
                f3Light = false;
                f3Heavy = true;
                f3Cap = false;
            }
            else if (fcb3.Text == "Capital")
            {
                f3Light = false;
                f3Heavy = false;
                f3Cap = true;
            }

            if (fcb4.Text == "Light")
            {
                f4Light = true;
                f4Heavy = false;
                f4Cap = false;
            }
            else if (fcb4.Text == "Heavy")
            {
                f4Light = false;
                f4Heavy = true;
                f4Cap = false;
            }
            else if (fcb4.Text == "Capital")
            {
                f4Light = false;
                f4Heavy = false;
                f4Cap = true;
            }

            if (pcb1.Text == "Light")
            {
                p1Light = true;
                p1Heavy = false;
                p1Cap = false;
            }
            else if (pcb1.Text == "Heavy")
            {
                p1Light = false;
                p1Heavy = true;
                p1Cap = false;
            }
            else if (pcb1.Text == "Capital")
            {
                p1Light = false;
                p1Heavy = false;
                p1Cap = true;
            }

            if (pcb2.Text == "Light")
            {
                p2Light = true;
                p2Heavy = false;
                p2Cap = false;
            }
            else if (pcb2.Text == "Heavy")
            {
                p2Light = false;
                p2Heavy = true;
                p2Cap = false;
            }
            else if (pcb2.Text == "Capital")
            {
                p2Light = false;
                p2Heavy = false;
                p2Cap = true;
            }

            if (pcb3.Text == "Light")
            {
                p3Light = true;
                p3Heavy = false;
                p3Cap = false;
            }
            else if (pcb3.Text == "Heavy")
            {
                p3Light = false;
                p3Heavy = true;
                p3Cap = false;
            }
            else if (pcb3.Text == "Capital")
            {
                p3Light = false;
                p3Heavy = false;
                p3Cap = true;
            }

            if (pcb4.Text == "Light")
            {
                p4Light = true;
                p4Heavy = false;
                p4Cap = false;
            }
            else if (pcb4.Text == "Heavy")
            {
                p4Light = false;
                p4Heavy = true;
                p4Cap = false;
            }
            else if (pcb4.Text == "Capital")
            {
                p4Light = false;
                p4Heavy = false;
                p4Cap = true;
            }

            if (scb1.Text == "Light")
            {
                s1Light = true;
                s1Heavy = false;
                s1Cap = false;
            }
            else if (scb1.Text == "Heavy")
            {
                s1Light = false;
                s1Heavy = true;
                s1Cap = false;
            }
            else if (scb1.Text == "Capital")
            {
                s1Light = false;
                s1Heavy = false;
                s1Cap = true;
            }

            if (scb2.Text == "Light")
            {
                s2Light = true;
                s2Heavy = false;
                s2Cap = false;
            }
            else if (scb2.Text == "Heavy")
            {
                s2Light = false;
                s2Heavy = true;
                s2Cap = false;
            }
            else if (scb2.Text == "Capital")
            {
                s2Light = false;
                s2Heavy = false;
                s2Cap = true;
            }

            if (scb3.Text == "Light")
            {
                s3Light = true;
                s3Heavy = false;
                s3Cap = false;
            }
            else if (scb3.Text == "Heavy")
            {
                s3Light = false;
                s3Heavy = true;
                s3Cap = false;
            }
            else if (scb3.Text == "Capital")
            {
                s3Light = false;
                s3Heavy = false;
                s3Cap = true;
            }

            if (scb4.Text == "Light")
            {
                s4Light = true;
                s4Heavy = false;
                s4Cap = false;
            }
            else if (scb4.Text == "Heavy")
            {
                s4Light = false;
                s4Heavy = true;
                s4Cap = false;
            }
            else if (scb4.Text == "Capital")
            {
                s4Light = false;
                s4Heavy = false;
                s4Cap = true;
            }

            if (acb1.Text == "Light")
            {
                a1Light = true;
                a1Heavy = false;
                a1Cap = false;
            }
            else if (acb1.Text == "Heavy")
            {
                a1Light = false;
                a1Heavy = true;
                a1Cap = false;
            }
            else if (acb1.Text == "Capital")
            {
                a1Light = false;
                a1Heavy = false;
                a1Cap = true;
            }

            if (acb2.Text == "Light")
            {
                a2Light = true;
                a2Heavy = false;
                a2Cap = false;
            }
            else if (acb2.Text == "Heavy")
            {
                a2Light = false;
                a2Heavy = true;
                a2Cap = false;
            }
            else if (acb2.Text == "Capital")
            {
                a2Light = false;
                a2Heavy = false;
                a2Cap = true;
            }

            if (acb3.Text == "Light")
            {
                a3Light = true;
                a3Heavy = false;
                a3Cap = false;
            }
            else if (acb3.Text == "Heavy")
            {
                a3Light = false;
                a3Heavy = true;
                a3Cap = false;
            }
            else if (acb3.Text == "Capital")
            {
                a3Light = false;
                a3Heavy = false;
                a3Cap = true;
            }

            if (acb4.Text == "Light")
            {
                a4Light = true;
                a4Heavy = false;
                a4Cap = false;
            }
            else if (acb4.Text == "Heavy")
            {
                a4Light = false;
                a4Heavy = true;
                a4Cap = false;
            }
            else if (acb4.Text == "Capital")
            {
                a4Light = false;
                a4Heavy = false;
                a4Cap = true;
            }

            if (tcb1.Text == "Light")
            {
                t1Light = true;
                t1Heavy = false;
            }
            else if (tcb1.Text == "Heavy")
            {
                t1Light = false;
                t1Heavy = true;
            }

            if (tcb2.Text == "Light")
            {
                t2Light = true;
                t2Heavy = false;
            }
            else if (tcb2.Text == "Heavy")
            {
                t2Light = false;
                t2Heavy = true;
            }

            if (tcb3.Text == "Light")
            {
                t3Light = true;
                t3Heavy = false;
            }
            else if (tcb3.Text == "Heavy")
            {
                t3Light = false;
                t3Heavy = true;
            }

            if (tcb4.Text == "Light")
            {
                t4Light = true;
                t4Heavy = false;
            }
            else if (tcb4.Text == "Heavy")
            {
                t4Light = false;
                t4Heavy = true;
            }


        }



        #endregion

        #region Unintentional






        #endregion


        #region Drop Down Options for Upgrades

        private void fcb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void fcb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void fcb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void fcb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void pcb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void pcb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void pcb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void pcb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void scb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void scb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void scb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void scb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void acb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void acb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void acb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void acb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void tcb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void tcb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void tcb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        private void tcb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int updatedValue = 0;
            int bp = 0;
            UpdateBooleansBasedOffOfText();
            updatedValue = GetSlotsValue();
            bp = updatedValue - weaponsUpgradeBaseValue;
            wpnUpgradeBPLabel.Text = bp.ToString();
        }

        #endregion


        #region Weapons Selection

        private void assignWeaponsDatasourceByFrame()
        {
            if (shipFrame == "Racer")
            {
                forward01.Visible = true;
                forward01.DataSource = null;
                forward01.DataSource = Light();
                forward01.DisplayMember = "Type";


                aft01.Visible = true;
                aft01.DataSource = Light();
                aft01.DisplayMember = "Type";
            }
            else if (shipFrame == "Interceptor")
            {
                forward01.Visible = true;
                forward01.DataSource = Light();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = Light();
                forward02.DisplayMember = "Type";
            }
            else if (shipFrame == "Fighter")
            {
                forward01.Visible = true;
                forward01.DataSource = Light();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = LightTracking();
                forward02.DisplayMember = "Type";

                aft01.Visible = true;
                aft01.DataSource = Light();
                aft01.DisplayMember = "Type";
            }
            else if (shipFrame == "Shuttle")
            {
                forward01.Visible = true;
                forward01.DataSource = Light();
                forward01.DisplayMember = "Type";
            }
            else if (shipFrame == "Light Freighter")
            {
                forward01.Visible = true;
                forward01.DataSource = Light();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = Light();
                forward02.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Light();
                port01.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Light();
                starboard01.DisplayMember = "Type";
            }
            else if (shipFrame == "Explorer")
            {
                forward01.Visible = true;
                forward01.DataSource = Light();
                forward01.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Light();
                port01.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Light();
                starboard01.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Light();
                turret01.DisplayMember = "Type";
            }
            else if (shipFrame == "Transport")
            {
                forward01.Visible = true;
                forward01.DataSource = Heavy();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = Light();
                forward02.DisplayMember = "Type";

                aft01.Visible = true;
                aft01.DataSource = Light();
                aft01.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Light();
                turret01.DisplayMember = "Type";

                turret02.Visible = true;
                turret02.DataSource = Light();
                turret02.DisplayMember = "Type";
            }
            else if (shipFrame == "Destroyer")
            {
                forward01.Visible = true;
                forward01.DataSource = Heavy();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = Heavy();
                forward02.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Light();
                port01.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Light();
                starboard01.DisplayMember = "Type";

                aft01.Visible = true;
                aft01.DataSource = Light();
                aft01.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Light();
                turret01.DisplayMember = "Type";
            }
            else if (shipFrame == "Heavy Freighter")
            {
                forward01.Visible = true;
                forward01.DataSource = Heavy();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = Light();
                forward02.DisplayMember = "Type";

                forward03.Visible = true;
                forward03.DataSource = Light();
                forward03.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Heavy();
                port01.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Heavy();
                starboard01.DisplayMember = "Type";
            }
            else if (shipFrame == "Bulk Freighter")
            {
                forward01.Visible = true;
                forward01.DataSource = Heavy();
                forward01.DisplayMember = "Type";

                aft01.Visible = true;
                aft01.DataSource = Heavy();
                aft01.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Light();
                turret01.DisplayMember = "Type";

                turret02.Visible = true;
                turret02.DataSource = Light();
                turret02.DisplayMember = "Type";
            }
            else if (shipFrame == "Cruiser")
            {
                forward01.Visible = true;
                forward01.DataSource = Heavy();
                forward01.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Light();
                port01.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Light();
                starboard01.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Heavy();
                turret01.DisplayMember = "Type";
            }
            else if (shipFrame == "Carrier")
            {
                forward01.Visible = true;
                forward01.DataSource = Capital();
                forward01.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Heavy();
                port01.DisplayMember = "Type";

                port02.Visible = true;
                port02.DataSource = Heavy();
                port02.DisplayMember = "Type";

                port03.Visible = true;
                port03.DataSource = Heavy();
                port03.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Heavy();
                starboard01.DisplayMember = "Type";

                starboard02.Visible = true;
                starboard02.DataSource = Heavy();
                starboard02.DisplayMember = "Type";

                starboard03.Visible = true;
                starboard03.DataSource = Heavy();
                starboard03.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Light();
                turret01.DisplayMember = "Type";

                turret02.Visible = true;
                turret02.DataSource = Light();
                turret02.DisplayMember = "Type";
            }
            else if (shipFrame == "Battleship")
            {
                forward01.Visible = true;
                forward01.DataSource = Capital();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = Heavy();
                forward02.DisplayMember = "Type";

                forward03.Visible = true;
                forward03.DataSource = Heavy();
                forward03.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Heavy();
                port01.DisplayMember = "Type";

                port02.Visible = true;
                port02.DataSource = Heavy();
                port02.DisplayMember = "Type";

                port03.Visible = true;
                port03.DataSource = Light();
                port03.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Heavy();
                starboard01.DisplayMember = "Type";

                starboard02.Visible = true;
                starboard02.DataSource = Heavy();
                starboard02.DisplayMember = "Type";

                starboard03.Visible = true;
                starboard03.DataSource = Light();
                starboard03.DisplayMember = "Type";

                aft01.Visible = true;
                aft01.DataSource = Light();
                aft01.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Heavy();
                turret01.DisplayMember = "Type";

                turret02.Visible = true;
                turret02.DataSource = Heavy();
                turret02.DisplayMember = "Type";
            }
            else if (shipFrame == "Dreadnought")
            {
                forward01.Visible = true;
                forward01.DataSource = Capital();
                forward01.DisplayMember = "Type";

                forward02.Visible = true;
                forward02.DataSource = Capital();
                forward02.DisplayMember = "Type";

                forward03.Visible = true;
                forward03.DataSource = Heavy();
                forward03.DisplayMember = "Type";

                forward04.Visible = true;
                forward04.DataSource = Heavy();
                forward04.DisplayMember = "Type";

                port01.Visible = true;
                port01.DataSource = Capital();
                port01.DisplayMember = "Type";

                port02.Visible = true;
                port02.DataSource = Heavy();
                port02.DisplayMember = "Type";

                port03.Visible = true;
                port03.DataSource = Heavy();
                port03.DisplayMember = "Type";

                port04.Visible = true;
                port04.DataSource = Heavy();
                port04.DisplayMember = "Type";

                starboard01.Visible = true;
                starboard01.DataSource = Capital();
                starboard01.DisplayMember = "Type";

                starboard02.Visible = true;
                starboard02.DataSource = Heavy();
                starboard02.DisplayMember = "Type";

                starboard03.Visible = true;
                starboard03.DataSource = Heavy();
                starboard03.DisplayMember = "Type";

                starboard04.Visible = true;
                starboard04.DataSource = Heavy();
                starboard04.DisplayMember = "Type";

                turret01.Visible = true;
                turret01.DataSource = Light();
                turret01.DisplayMember = "Type";

                turret02.Visible = true;
                turret02.DataSource = Light();
                turret02.DisplayMember = "Type";

                turret03.Visible = true;
                turret03.DataSource = Light();
                turret03.DisplayMember = "Type";

                turret04.Visible = true;
                turret04.DataSource = Light();
                turret04.DisplayMember = "Type";
            }
        }

        private void forward01_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void forward02_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void forward03_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void forward04_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void port01_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void port02_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void port03_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void port04_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void starboard01_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void starboard02_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void starboard03_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void starboard04_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void aft01_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void aft02_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void aft03_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void aft04_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void turret01_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void turret02_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void turret03_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        private void turret04_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponSelectionCost();
        }

        #endregion


        #endregion

        #region OGL

        private void openGamingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPEN GAME LICENSE VERSION 1.0A The following text is the property of Wizards of the Coast, Inc.and is Copyright 2000 Wizards of the Coast, Inc. (“Wizards”). All Rights Reserved. \n \n         1.Definitions: (a) “Contributors” means the copyright and / or trademark owners who have contributed Open Game Content; (b) “Derivative Material” means copyrighted material including derivative works and translations (including into other computer languages), potation, modification, correction, addition, extension, upgrade, improvement, compilation, abridgment or other form in which an existing work may be recast, transformed or adapted; (c) “Distribute” means to reproduce, license, rent, lease, sell, broadcast, publicly display, transmit or otherwise distribute; (d) “Open Game Content” means the game mechanic and includes the methods, procedures, processes and routines to the extent such content does not embody the Product Identity and is an enhancement over the prior art and any additional content clearly identified as Open Game Content by the Contributor, and means any work covered by this License, including translations and derivative works under copyright law, but specifically excludes Product Identity. (e) “Product Identity” means product and product line names, logos and identifying marks including trade dress; artifacts, creatures, characters, stories, storylines, plots, thematic elements, dialogue, incidents, language, artwork, symbols, designs, depictions, likenesses, formats, poses, concepts, themes and graphic, photographic and other visual or audio representations; names and descriptions of characters, spells, enchantments, personalities, teams, personas, likenesses and special abilities; places, locations, environments, creatures, equipment, magical or supernatural abilities or effects, logos, symbols, or graphic designs; and any other trademark or registered trademark clearly identified as Product identity by the owner of the Product Identity, and which specifically excludes the Open Game Content; (f) “Trademark” means the logos, names, mark, sign, motto, designs that are used by a Contributor to identify itself or its products or the associated products contributed to the Open Game License by the Contributor (g) “Use”, “Used” or “Using” means to use, Distribute, copy, edit, format, modify, translate and otherwise create Derivative Material of Open Game Content. (h) “You” or “Your” means the licensee in terms of this agreement. \n \n         2.The License: This License applies to any Open Game Content that contains a notice indicating that the Open Game Content may only be Used under and in terms of this License.You must affix such a notice to any Open Game Content that you Use. No terms may be added to or subtracted from this License except as described by the License itself. No other terms or conditions may be applied to any Open Game Content distributed using this License. \n \n         3.Offer and Acceptance: By Using the Open Game Content You indicate Your acceptance of the terms of this License. \n \n         4.Grant and Consideration: In consideration for agreeing to use this License, the Contributors grant You a perpetual, worldwide, royalty - free, non - exclusive license with the exact terms of this License to Use, the Open Game Content. \n \n         5.Representation of Authority to Contribute: If You are contributing original material as Open Game Content, You represent that Your Contributions are Your original creation and / or You have sufficient rights to grant the rights conveyed by this License. \n \n         6.Notice of License Copyright: You must update the COPYRIGHT NOTICE portion of this License to include the exact text of the COPYRIGHT NOTICE of any Open Game Content You are copying, modifying or distributing, and You must add the title, the copyright date, and the copyright holder’s name to the COPYRIGHT NOTICE of any original Open Game Content you Distribute. \n \n         7.Use of Product Identity: You agree not to Use any Product Identity, including as an indication as to compatibility, except as expressly licensed in another, independent Agreement with the owner of each element of that Product Identity. You agree not to indicate compatibility or co - adaptability with any Trademark or Registered Trademark in conjunction with a work containing Open Game Content except as expressly licensed in another, independent Agreement with the owner of such Trademark or Registered Trademark. The use of any Product Identity in Open Game Content does not constitute a challenge to the ownership of that Product Identity. The owner of any Product Identity used in Open Game Content shall retain all rights, title and interest in and to that Product Identity. \n \n         8.Identification: If you distribute Open Game Content You must clearly indicate which portions of the work that you are distributing are Open Game Content. \n \n         9.Updating the License: Wizards or its designated Agents may publish updated versions of this License. You may use any authorized version of this License to copy, modify and distribute any Open Game Content originally distributed under any version of this License. \n \n         10.Copy of this License: You MUST include a copy of this License with every copy of the Open Game Content You distribute. \n \n         11.Use of Contributor Credits: You may not market or advertise the Open Game Content using the name of any Contributor unless You have written permission from the Contributor to do so. \n \n         12.Inability to Comply: If it is impossible for You to comply with any of the terms of this License with respect to some or all of the Open Game Content due to statute, judicial order, or governmental regulation then You may not Use any Open Game Material so affected. \n \n         13.Termination: This License will terminate automatically if You fail to comply with all terms herein and fail to cure such breach within 30 days of becoming aware of the breach. All sublicenses shall survive the termination of this License. \n \n         14.Reformation: If any provision of this License is held to be unenforceable, such provision shall be reformed only to the extent necessary to make it enforceable. \n \n         15.COPYRIGHT NOTICE Open Game License v 1.0a © 2000, Wizards of the Coast, Inc. \n\n\n\n System Reference Document © 2000, Wizards of the Coast, Inc.; Authors: Jonathan Tweet, Monte Cook, Skip Williams, based on material by E. Gary Gygax and Dave Arneson. \n\n Starfinder Core Rulebook © 2017, Paizo Inc.; Authors: Logan Bonner, Jason Bulmahn, Amanda Hamon Kunz, Jason Keeley, Robert G.McCreary, Stephen Radney - MacFarland, Mark Seifter, Owen K.C.Stephens, and James L.Sutter, with Alexander Augunas, Judy Bauer, John Compton, Adam Daigle, Crystal Frasier, Lissa Guillet, Thurston Hillman, Erik Mona, Mark Moreland, Jessica Price, F.Wesley Schneider, Amber E.Scott, and Josh Vogt.");
        }


        #endregion

        private void gunneryDex_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunneryComp_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunneryMisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunneryMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void piloting_TextChanged(object sender, EventArgs e)
        {

        }

        private void quartersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #region New Ship Functionality
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sExpBay01 = "";  //done
            sExpBay02 = "";  //done
            sExpBay03 = "";  //done
            sExpBay04 = "";  //done
            sExpBay05 = "";  //done
            sExpBay06 = "";  //done
            sExpBay07 = "";  //done
            sExpBay08 = "";  //done
            sExpBay09 = "";  //done
            sExpBay10 = "";  //done
            sExpBay11 = "";  //done
            sExpBay12 = "";  //done
            sExpBay13 = "";  //done
            sExpBay14 = "";  //done
            sExpBay15 = "";  //done
            sExpBay16 = "";  //done
            sExpBay17 = "";  //done
            sExpBay18 = "";  //done
            sExpBay19 = "";  //done
            sExpBay20 = "";  //done
            totalBPCount = 0;            // Count of Total Build Points for a Ship
            spentBPCount = 0;            // Count of BP spent
            totalPCUCount = 0;           // Count of Total Power Core Units Available
            spentPCUCount = 0;           // Count of Total Power Core Units Spent
            shipTier = "";                 // Ship Tier
            shipSize = "";                 // Ship Size
            shipSizeInt = 0;             // Ship Size Integer Representation
            shipSizeMod = 0;             // Ship Size Modifier
            shipFrame = "";                // Ship Frame
            expBayNum = 0;               // Number of Expansion Bays
            expBPSpent = 0;              // Number of Expansion Bay Build Points Spent
            shipPCURating = 0;           // Total Ship Power Core Rating
            shipSpeed = 0;               // Ship Speed
            pilotingModAdj = 0;              // Piloting Modifer Adjusted
            pilotingMod = 0;                 // Piloting Modifer
            ac = 10;                     // Base Armor Class
            tl = 10;                     // Base Target Lock
            hp = 0;                      // Hull Points
            dt = 0;                      // Damage Threshold
            ct = 0;                      // Critical Threshold
            pilotRanks = 0;              // Denotes the amount of training the pilot has.
            core2next = false;          // Boolean to track whether or not the second power core is selected next.
            securitynext = false;       // Boolean to track whether or not Security Options are selected next.
            computerTier = 0;            // Integer to note the tier level of the on board computer.
            securityBPSpent = 0;         // Integer to track the amount of BP spent on security options
            smugBay = false;            // Boolean to track whether or not the ship has a smuggling bay.
            core2 = false;              // Boolean to track whether or not the ship has a second power core
            sensorMod = 0;                           // Not Currently Used
            totSP = 0;                               // Not Currently Used
            wpnUpgradeEntered = false;
            statusLabel.Text = "Select Starship Tier";

            Bay = new AssemblyBay();
            BuildTier = Bay.ConstructTierLoad();
            BuildFrames = Bay.ConstructFrameLoad();
            BuildCores = Bay.ConstructPowerCoreLoad();
            BuildThrusters = Bay.ConstructThrusterLoad();
            BuildArmor = Bay.ConstructArmorLoad();
            BuildComputers = Bay.ConstructComputerLoad();
            BuildQuarters = Bay.ConstructQuartersLoad();
            BuildCM = Bay.ConstructCountermeasuresLoad();
            BuildHyperspaceEngine = Bay.ConstructHyperspaceEngineLoad();
            BuildExpBays01 = Bay.ConstructExpansionBayLoad01();
            BuildExpBays02 = Bay.ConstructExpansionBayLoad02();
            BuildExpBays03 = Bay.ConstructExpansionBayLoad03();
            BuildExpBays04 = Bay.ConstructExpansionBayLoad04();
            BuildExpBays05 = Bay.ConstructExpansionBayLoad05();
            BuildExpBays06 = Bay.ConstructExpansionBayLoad06();
            BuildExpBays07 = Bay.ConstructExpansionBayLoad07();
            BuildExpBays08 = Bay.ConstructExpansionBayLoad08();
            BuildExpBays09 = Bay.ConstructExpansionBayLoad09();
            BuildExpBays10 = Bay.ConstructExpansionBayLoad10();
            BuildExpBays11 = Bay.ConstructExpansionBayLoad11();
            BuildExpBays12 = Bay.ConstructExpansionBayLoad12();
            BuildExpBays13 = Bay.ConstructExpansionBayLoad13();
            BuildExpBays14 = Bay.ConstructExpansionBayLoad14();
            BuildExpBays15 = Bay.ConstructExpansionBayLoad15();
            BuildExpBays16 = Bay.ConstructExpansionBayLoad16();
            BuildExpBays17 = Bay.ConstructExpansionBayLoad17();
            BuildExpBays18 = Bay.ConstructExpansionBayLoad18();
            BuildExpBays19 = Bay.ConstructExpansionBayLoad19();
            BuildExpBays20 = Bay.ConstructExpansionBayLoad20();
            BuildCores2 = Bay.ConstructPowerCore2Load();
            BuildSensors = Bay.ConstructSensorLoad();
            BuildShields = Bay.ConstructShieldLoad();
            tierComboBox.DataSource = BuildTier;
            tierComboBox.DisplayMember = "Type";
            frameComboBox.DataSource = BuildFrames;
            frameComboBox.DisplayMember = "Type";
            powerCoreComboBox.DataSource = BuildCores;
            powerCoreComboBox.DisplayMember = "Type";
            thrustersComboBox.DataSource = BuildThrusters;
            thrustersComboBox.DisplayMember = "Type";
            armorComboBox.DataSource = BuildArmor;
            armorComboBox.DisplayMember = "Type";
            calcAC();
            ACTextBox.Text = ac.ToString();
            computerComboBox.DataSource = BuildComputers;
            computerComboBox.DisplayMember = "Type";
            quartersComboBox.DataSource = BuildQuarters;
            quartersComboBox.DisplayMember = "Type";
            countermeasuresComboBox.DataSource = BuildCM;
            countermeasuresComboBox.DisplayMember = "Type";
            calcTL();
            TLTextBox.Text = tl.ToString();
            hyperspaceEngineComboBox.DataSource = BuildHyperspaceEngine;
            hyperspaceEngineComboBox.DisplayMember = "Type";
            expBayComboBox1.DataSource = BuildExpBays01;
            expBayComboBox1.DisplayMember = "Type";
            expBayComboBox2.DataSource = BuildExpBays02;
            expBayComboBox2.DisplayMember = "Type";
            expBayComboBox3.DataSource = BuildExpBays03;
            expBayComboBox3.DisplayMember = "Type";
            expBayComboBox4.DataSource = BuildExpBays04;
            expBayComboBox4.DisplayMember = "Type";
            expBayComboBox5.DataSource = BuildExpBays05;
            expBayComboBox5.DisplayMember = "Type";
            expBayComboBox6.DataSource = BuildExpBays06;
            expBayComboBox6.DisplayMember = "Type";
            expBayComboBox7.DataSource = BuildExpBays07;
            expBayComboBox7.DisplayMember = "Type";
            expBayComboBox8.DataSource = BuildExpBays08;
            expBayComboBox8.DisplayMember = "Type";
            expBayComboBox9.DataSource = BuildExpBays09;
            expBayComboBox9.DisplayMember = "Type";
            expBayComboBox10.DataSource = BuildExpBays10;
            expBayComboBox10.DisplayMember = "Type";
            expBayComboBox11.DataSource = BuildExpBays11;
            expBayComboBox11.DisplayMember = "Type";
            expBayComboBox12.DataSource = BuildExpBays12;
            expBayComboBox12.DisplayMember = "Type";
            expBayComboBox13.DataSource = BuildExpBays13;
            expBayComboBox13.DisplayMember = "Type";
            expBayComboBox14.DataSource = BuildExpBays14;
            expBayComboBox14.DisplayMember = "Type";
            expBayComboBox15.DataSource = BuildExpBays15;
            expBayComboBox15.DisplayMember = "Type";
            expBayComboBox16.DataSource = BuildExpBays16;
            expBayComboBox16.DisplayMember = "Type";
            expBayComboBox17.DataSource = BuildExpBays17;
            expBayComboBox17.DisplayMember = "Type";
            expBayComboBox18.DataSource = BuildExpBays18;
            expBayComboBox18.DisplayMember = "Type";
            expBayComboBox19.DataSource = BuildExpBays19;
            expBayComboBox19.DisplayMember = "Type";
            expBayComboBox20.DataSource = BuildExpBays20;
            expBayComboBox20.DisplayMember = "Type";
            powerCore2ComboBox.DataSource = BuildCores2;
            powerCore2ComboBox.DisplayMember = "Type";
            sensorsComboBox.DataSource = BuildSensors;
            sensorsComboBox.DisplayMember = "Type";
            shieldsComboBox.DataSource = BuildShields;
            shieldsComboBox.DisplayMember = "Type";

            //Tier select reset
            tierComboBox.SelectedIndex = 0;
            tierComboBox.Enabled = true;
            tierSelectButton.Text = "Select";
            tierGB.BackColor = Color.Lime;

            //Frame select reset
            frameComboBox.SelectedIndex = 0;
            frameComboBox.Enabled = true;
            frameGB.BackColor = Color.Empty;
            frameSelectButton.Text = "Select";

            //Powercore select reset
            powerCoreComboBox.SelectedIndex = 0;
            powerCoreComboBox.Enabled = true;
            powerCoreSelectButton.Text = "Select";
            powercore01GB.BackColor = Color.Empty;

            //Powercore2 select reset
            powerCore2ComboBox.SelectedIndex = 0;
            powerCore2ComboBox.Enabled = true;
            powerCore2ComboBox.Visible = false;
            powerCore2SelectButton.Text = "Select";
            powerCore2SelectButton.Visible = false;
            powercore02GB.BackColor = Color.Empty;

            //Thruster select reset
            thrustersComboBox.SelectedIndex = 0;
            thrustersComboBox.Enabled = true;
            thrusterSelectButton.Text = "Select";
            thrustersGB.BackColor = Color.Empty;

            //Armor select reset
            armorComboBox.SelectedIndex = 0;
            armorComboBox.Enabled = true;
            armorSelectionButton.Text = "Select";
            armorGB.BackColor = Color.Empty;

            //Computer select reset
            computerComboBox.SelectedIndex = 0;
            computerComboBox.Enabled = true;
            computerSelectButton.Text = "Select";
            computerGB.BackColor = Color.Empty;

            //Quarters select reset
            quartersComboBox.SelectedIndex = 0;
            quartersComboBox.Enabled = true;
            quartersSelectButton.Text = "Select";
            quartersGB.BackColor = Color.Empty;

            //Countermeasures select reset
            countermeasuresComboBox.SelectedIndex = 0;
            countermeasuresComboBox.Enabled = true;
            countermeasuresSelectButton.Text = "Select";
            countermeasuresGB.BackColor = Color.Empty;

            //Hyperspaceengine select reset
            hyperspaceEngineComboBox.SelectedIndex = 0;
            hyperspaceEngineComboBox.Enabled = true;
            hyperspaceEngineSelectButton.Text = "Select";
            hyperspaceengineGB.BackColor = Color.Empty;

            //Sensors select reset
            sensorsComboBox.SelectedIndex = 0;
            sensorsComboBox.Enabled = true;
            sensorsSelectButton.Text = "Text";
            sensorsGB.BackColor = Color.Empty;

            //Shields select reset
            shieldsComboBox.SelectedIndex = 0;
            shieldsComboBox.Enabled = true;
            shieldsSelectButton.Text = "Select";
            shieldsGB.BackColor = Color.Empty;

            //Security select reset
            antihackCheckBox.Checked = false;
            antipersonnelCheckBox.Checked = false;
            compCMCheckBox.Checked = false;
            bioLockCheckBox.Checked = false;
            sdsCheckBox.Checked = false;
            antipersonnelWeaponLevelComboBox.SelectedIndex = 0;
            antipersonnelWeaponLevelComboBox.SelectedIndex = 0;
            antipersonnelWeaponTypeComboBox.SelectedIndex = 0;
            antipersonnelWeaponTypeComboBox.Enabled = true;
            antipersonnelWeaponLevelComboBox.Enabled = true;
            compCountermeasuresListBox.ClearSelected();
            securityBPSelected.Text = "0";
            securitySelectButton.Text = "Select";
            securityGB.BackColor = Color.Empty;

            // Booleans for weapons slot upgrades
            f1Light = false;
            f2Light = false;
            f3Light = false;
            f4Light = false;
            p1Light = false;
            p2Light = false;
            p3Light = false;
            p4Light = false;
            s1Light = false;
            s2Light = false;
            s3Light = false;
            s4Light = false;
            a1Light = false;
            a2Light = false;
            a3Light = false;
            a4Light = false;
            t1Light = false;
            t2Light = false;
            t3Light = false;
            t4Light = false;

            f1Heavy = false;
            f2Heavy = false;
            f3Heavy = false;
            f4Heavy = false;
            p1Heavy = false;
            p2Heavy = false;
            p3Heavy = false;
            p4Heavy = false;
            s1Heavy = false;
            s2Heavy = false;
            s3Heavy = false;
            s4Heavy = false;
            a1Heavy = false;
            a2Heavy = false;
            a3Heavy = false;
            a4Heavy = false;
            t1Heavy = false;
            t2Heavy = false;
            t3Heavy = false;
            t4Heavy = false;

            f1Cap = false;
            f2Cap = false;
            f3Cap = false;
            f4Cap = false;
            p1Cap = false;
            p2Cap = false;
            p3Cap = false;
            p4Cap = false;
            s1Cap = false;
            s2Cap = false;
            s3Cap = false;
            s4Cap = false;
            a1Cap = false;
            a2Cap = false;
            a3Cap = false;
            a4Cap = false;

            // Integers to track the cost of weapons slot upgrades.

            weaponsUpgradeBaseValue = 0;
            weaponsUpgradeTotal = 0;

            // These are the public variables that will be used to populate the Starship Sheet.

            sTier = "";  //Done
            sBuildPointsTotal = "";  //done
            sBuildPointsUsed = "";  //done
            sName = "";  //Done
            sMake = "";  //done
            sModel = "";  //done
            sFrame = "";  //done
            sHPTotal = "";  //done
            sCT = "";  //done
            sDT = "";  //done
            sManuever = "";  //done
            sSize = "";  //done
            sSizeNumber = "";  //done
            sPowerCore1 = "";  //done
            sPowerCore2 = "";  //done
            sPCUTotal = "";  //done
            sSensors = "";  //done
            sSensorRange = "";  //done
            sSensorMod = "";  //done
            sComputer = "";  //done
            sCompBonus = "";  //done
            sCompNodes = "";  //done
            sQuarters = "";  //done
            sThrusters = "";  //done
            sThrusterSpeed = "";  //done
            sHyperspaceEngine = "";  //done
            sHyperspaceRating = "";  //done
            sShields = "";  //done
            sShieldTotal = "";  //done
            sShieldRegen = "";  //done
            sArmor = "";  //done
            sACTotal = "";  //done
            sPilotMod = "";                                             // NOT DONE
            sACBonus = "";  //done
            sSizeMod = "";  //done
            sACMiscMod = "";                    // left blank
            sCountermeasures = "";  //done
            sTLTotal = "";  //done
            sTLBonus = "";  //done
            sTLMiscMod = "";                    // left blank

            sSmugglingDC = "";  //done
            sCompCountermeasureNum = "";  //done
            sCompAntiHack = false;  //done
            strCompAntiHack = "";                                                       // Added
            sCompHackDC = "";                                           // NOT DONE
            sBiolocks = false;  //done
            strBiolocks = "";                                                           // Added
            sSelfDestruct = false;  //done
            strSelfDestruct = "";                                                       // Added
            sAntipersonnelWPN = "";             // left blank
            sAntipersonnelDMG = "";             // left blank
            sFWPNS01 = "";  //done
            sFDMG01 = "";  //done
            sFWPNS02 = "";  //done
            sFDMG02 = "";  //done
            sFWPNS03 = "";  //done
            sFDMG03 = "";  //done
            sFWPNS04 = "";  //done
            sFDMG04 = "";   //done
            sPWPNS01 = "";  //done
            sPDMG01 = "";  //done
            sPWPNS02 = "";  //done
            sPDMG02 = "";  //done
            sPWPNS03 = "";  //done
            sPDMG03 = "";  //done
            sPWPNS04 = "";  //done
            sPDMG04 = "";  //done
            sSWPNS01 = "";  //done
            sSDMG01 = "";  //done
            sSWPNS02 = "";  //done
            sSDMG02 = "";  //done
            sSWPNS03 = "";  //done
            sSDMG03 = "";  //done
            sSWPNS04 = "";  //done
            sSDMG04 = "";  //done
            sTWPNS01 = "";  //done
            sTDMG01 = "";  //done
            sTWPNS02 = "";  //done
            sTDMG02 = "";  //done
            sTWPNS03 = "";  //done
            sTDMG03 = "";  //done
            sTWPNS04 = "";  //done
            sTDMG04 = "";  //done
            sAWPNS01 = "";  //done
            sADMG01 = "";  //done
            sAWPNS02 = "";  //done
            sADMG02 = "";  //done
            sAWPNS03 = "";  //done
            sADMG03 = "";  //done
            sAWPNS04 = "";  //done
            sADMG04 = "";  //done
            weaponsMainControl.SelectedIndex = 0;
            tierSelected = false;
            frameSelected = false;
            powerCore1Selected = false;
            thrustersSelected = false;
            armorSelected = false;
            computerSelected = false;
            quartersSelected = false;
            countermeasuresSelected = false;
            hyperspaceEngineSelected = false;
            expBaySelected = false;
            smugglingBaySelected = false;
            powerCore2Selected = false;
            securitySelected = false;
            sensorsSelected = false;
            shieldsSelected = false;
            weaponSlotSelected = false;
            weaponsSelected = false;
            weaponsLinkSelected = false;

            // track if weapons link
            forwLink1 = false;                              // Added
            forwLink2 = false;
            turLink1 = false;
            turLink2 = false;
            aftLink1 = false;
            aftLink2 = false;
            starbLink1 = false;
            starbLink2 = false;
            portLink1 = false;
            portLink2 = false;                              // Added

            forWpnTypeLink1 = "";
            forWpnTypeLink2 = "";
            turWpnTypeLink1 = "";
            turWpnTypeLink2 = "";
            aftWpnTypeLink1 = "";
            aftWpnTypeLink2 = "";
            starbWpnTypeLink1 = "";
            starbWpnTypeLink2 = "";
            portWpnTypeLink1 = "";
            portWpnTypeLink2 = "";
            totalLinkCost = 0;                              // Added

            
                forwLinkCheckBox1.Checked = false;
                forwLinkCheckBox1.Text = "forwLink1";
                forwLinkCheckBox1.Visible = false;
                forwLinkCheckBox1.Enabled = false;
            
                forwLinkCheckBox2.Checked = false;
                forwLinkCheckBox2.Text = "forwLink2";
                forwLinkCheckBox2.Visible = false;
                forwLinkCheckBox2.Enabled = false;
           
                turLinkCheckBox1.Checked = false;
                turLinkCheckBox1.Text = "turLink1";
                turLinkCheckBox1.Visible = false;
                turLinkCheckBox1.Enabled = false;
            
                turLinkCheckBox2.Checked = false;
                turLinkCheckBox2.Text = "turLink2";
                turLinkCheckBox2.Visible = false;
                turLinkCheckBox2.Enabled = false;
            
                aftLinkCheckBox1.Checked = false;
                aftLinkCheckBox1.Text = "aftLink1";
                aftLinkCheckBox1.Visible = false;
                aftLinkCheckBox1.Enabled = false;
            
                aftLinkCheckBox2.Checked = false;
                aftLinkCheckBox2.Text = "aftLink2";
                aftLinkCheckBox2.Visible = false;
                aftLinkCheckBox2.Enabled = false;
            
                starbLinkCheckBox1.Checked = false;
                starbLinkCheckBox1.Text = "starbLink1";
                starbLinkCheckBox1.Visible = false;
                starbLinkCheckBox1.Enabled = false;
            
                starbLinkCheckBox2.Checked = false;
                starbLinkCheckBox2.Text = "starbLink2";
                starbLinkCheckBox2.Visible = false;
                starbLinkCheckBox2.Enabled = false;
            
                portLinkCheckBox1.Checked = false;
                portLinkCheckBox1.Text = "portLink1";
                portLinkCheckBox1.Visible = false;
                portLinkCheckBox1.Enabled = false;
            
                portLinkCheckBox2.Checked = false;
                portLinkCheckBox2.Text = "portLink2";
                portLinkCheckBox2.Visible = false;
                portLinkCheckBox2.Enabled = false;
            

            wpnsUpgradeBtn.Text = "Select";
            weaponsSelectButton.Text = "Select";
            selectLinksBtn.Text = "Select";                     // Added

            // Labels and textfields
            starshipNameTextBox.Text = "-Name-";
            starshipMakeTextBox.Text = "-Make-";
            starshipModelTextBox.Text = "-Model-";
            totalPCU.Text = "0";
            remainingPCU.Text = "0";
            totalBuildPoints.Text = "0";
            currentBuildPoints.Text = "0";
            starshipSpeed.Text = "";
            ACTextBox.Text = "";
            TLTextBox.Text = "";
            starshipPilotingMod.Text = "";
            HullPointsTextBox.Text = "";
            DamageThresholdTextBox.Text = "";
            CriticalThresholdTextBox.Text = "";
            ShieldTotalTextBox.Text = "";
            compBonusTextBox.Text = "";
            compNodesTextBox.Text = "";
            hyperspaceEngineRatingTextBox.Text = "";
            smugglingDCTextBox.Text = "";
            shipHackDCTextBox.Text = "";
            sensorsModTextBox.Text = "";
            spTotalTextBox.Text = "";
            gunnerBAB.Text = "";
            gunnerDex.Text = "";
            gunnerComp.Text = "";
            gunneryMisc.Text = "";
            cptBAB.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            cptBluff.Text = "";
            cptComputing.Text = "";
            cptIntimidate.Text = "";
            cptPiloting.Text = "";
            cptEngineering.Text = "";
            cptDiplomacy.Text = "";
            pilotingRanks.Text = "";
            piloting.Text = "";
            engineering.Text = "";
            engineeringRanks.Text = "";
            computingRanks.Text = "";
            computing.Text = "";
            starshipName.Text = "";
            starshipMake.Text = "";
            starshipModel.Text = "";
            shipFrameLabel.Text = "";
            starshipSizeLabel.Text = "";
            computerTypeLabel.Text = "";
            quartersTypeLabel.Text = "";
            countermeasuresLabel.Text = "";
            hyperspaceEngineLabel.Text = "";
            sensorTypeText.Text = "";
            sensorRangeText.Text = "";
            shieldTypeLabel.Text = "";
            shieldRechargeRateLabel.Text = "";

            // Check boxes
            antihackCheckBox.Checked = false;
            bioLockCheckBox.Checked = false;
            sdsCheckBox.Checked = false;
            antihackCheckBox.Checked = false;
            compCMCheckBox.Checked = false;

            // Security Combo boxes and list box
            if (antipersonnelWeaponTypeComboBox.Visible)
            {
                antipersonnelWeaponTypeComboBox.SelectedIndex = 0;
                antipersonnelWeaponTypeComboBox.Visible = false;
            }

            if (antipersonnelWeaponLevelComboBox.Visible)
            {
                antipersonnelWeaponLevelComboBox.SelectedIndex = 0;
                antipersonnelWeaponLevelComboBox.Visible = false;
            }

            antihackLevelComboBox.SelectedIndex = 0;
            compCountermeasuresListBox.Enabled = true;
            compCountermeasuresListBox.ClearSelected();
            smugglingComboBox.SelectedIndex = 0;

            //Expansion bay select reset
            expBayComboBox1.SelectedIndex = 0;
            expBayComboBox2.SelectedIndex = 0;
            expBayComboBox3.SelectedIndex = 0;
            expBayComboBox4.SelectedIndex = 0;
            expBayComboBox5.SelectedIndex = 0;
            expBayComboBox6.SelectedIndex = 0;
            expBayComboBox7.SelectedIndex = 0;
            expBayComboBox8.SelectedIndex = 0;
            expBayComboBox9.SelectedIndex = 0;
            expBayComboBox10.SelectedIndex = 0;
            expBayComboBox11.SelectedIndex = 0;
            expBayComboBox12.SelectedIndex = 0;
            expBayComboBox13.SelectedIndex = 0;
            expBayComboBox14.SelectedIndex = 0;
            expBayComboBox15.SelectedIndex = 0;
            expBayComboBox16.SelectedIndex = 0;
            expBayComboBox17.SelectedIndex = 0;
            expBayComboBox18.SelectedIndex = 0;
            expBayComboBox19.SelectedIndex = 0;
            expBayComboBox20.SelectedIndex = 0;

            expBayComboBox1.Visible = false;
            expBayComboBox2.Visible = false;
            expBayComboBox3.Visible = false;
            expBayComboBox4.Visible = false;
            expBayComboBox5.Visible = false;
            expBayComboBox6.Visible = false;
            expBayComboBox7.Visible = false;
            expBayComboBox8.Visible = false;
            expBayComboBox9.Visible = false;
            expBayComboBox10.Visible = false;
            expBayComboBox11.Visible = false;
            expBayComboBox12.Visible = false;
            expBayComboBox13.Visible = false;
            expBayComboBox14.Visible = false;
            expBayComboBox15.Visible = false;
            expBayComboBox16.Visible = false;
            expBayComboBox17.Visible = false;
            expBayComboBox18.Visible = false;
            expBayComboBox19.Visible = false;
            expBayComboBox20.Visible = false;

            expBayComboBox1.Enabled = true;
            expBayComboBox2.Enabled = true;
            expBayComboBox3.Enabled = true;
            expBayComboBox4.Enabled = true;
            expBayComboBox5.Enabled = true;
            expBayComboBox6.Enabled = true;
            expBayComboBox7.Enabled = true;
            expBayComboBox8.Enabled = true;
            expBayComboBox9.Enabled = true;
            expBayComboBox10.Enabled = true;
            expBayComboBox11.Enabled = true;
            expBayComboBox12.Enabled = true;
            expBayComboBox13.Enabled = true;
            expBayComboBox14.Enabled = true;
            expBayComboBox15.Enabled = true;
            expBayComboBox16.Enabled = true;
            expBayComboBox17.Enabled = true;
            expBayComboBox18.Enabled = true;
            expBayComboBox19.Enabled = true;
            expBayComboBox20.Enabled = true;

            expansionbayGB.BackColor = Color.Empty;
            expSlotsLeft.Text = "0";
            expBPSelected.Text = "0";
            expBaySelectButton.Text = "Select";

            //Weapons select reset                                  // Added
            fcb1.Enabled = true;
            fcb1.Visible = false;
            fcb2.Enabled = true;
            fcb2.Visible = false;
            fcb3.Enabled = true;
            fcb3.Visible = false;
            fcb4.Enabled = true;
            fcb4.Visible = false;

            pcb1.Enabled = true;
            pcb1.Visible = false;
            pcb2.Enabled = true;
            pcb2.Visible = false;
            pcb3.Enabled = true;
            pcb3.Visible = false;
            pcb4.Enabled = true;
            pcb4.Visible = false;

            tcb1.Enabled = true;
            tcb1.Visible = false;
            tcb2.Enabled = true;
            tcb2.Visible = false;
            tcb3.Enabled = true;
            tcb3.Visible = false;
            tcb4.Enabled = true;
            tcb4.Visible = false;

            acb1.Enabled = true;
            acb1.Visible = false;
            acb2.Enabled = true;
            acb2.Visible = false;
            acb3.Enabled = true;
            acb3.Visible = false;
            acb4.Enabled = true;
            acb4.Visible = false;

            scb1.Enabled = true;
            scb1.Visible = false;
            scb2.Enabled = true;
            scb2.Visible = false;
            scb3.Enabled = true;
            scb3.Visible = false;
            scb4.Enabled = true;
            scb4.Visible = false;

            forward01.Enabled = true;
            forward01.Visible = false;
            forward02.Enabled = true;
            forward02.Visible = false;
            forward03.Enabled = true;
            forward03.Visible = false;
            forward04.Enabled = true;
            forward04.Visible = false;

            port01.Enabled = true;
            port01.Visible = false;
            port02.Enabled = true;
            port02.Visible = false;
            port03.Enabled = true;
            port03.Visible = false;
            port04.Enabled = true;
            port04.Visible = false;

            turret01.Enabled = true;
            turret01.Visible = false;
            turret02.Enabled = true;
            turret02.Visible = false;
            turret03.Enabled = true;
            turret03.Visible = false;
            turret04.Enabled = true;
            turret04.Visible = false;

            starboard01.Enabled = true;
            starboard01.Visible = false;
            starboard02.Enabled = true;
            starboard02.Visible = false;
            starboard03.Enabled = true;
            starboard03.Visible = false;
            starboard04.Enabled = true;
            starboard04.Visible = false;

            aft01.Enabled = true;
            aft01.Visible = false;
            aft02.Enabled = true;
            aft02.Visible = false;
            aft03.Enabled = true;
            aft03.Visible = false;
            aft04.Enabled = true;
            aft04.Visible = false;

            forwLinkChkBox1Type = "";
            forwLinkChkBox2Type = "";
            turLinkChkBox1Type = "";
            turLinkChkBox2Type = "";
            aftLinkChkBox1Type = "";
            aftLinkChkBox2Type = "";
            starbLinkChkBox1Type = "";
            starbLinkChkBox2Type = "";
            portLinkChkBox1Type = "";
            portLinkChkBox2Type = "";                                  // Added

            weaponsSelectPage.BackColor = Color.Empty;
            weaponsUpgradePage.BackColor = Color.Empty;
            wpnsLinkingTab.BackColor = Color.Empty;

            statusLabel.BackColor = Color.Lime;

            wpnUpgradeBPLabel.Text = "0";
            
        }

        #endregion

        #region Random Ship Functionality

        private void randomShipGen()
        {
            BP = totalBPCount - spentBPCount;
            PCU = totalPCUCount - spentPCUCount;
            int firstBP = BP / 3;
            int secondBP = firstBP;
            int thirdBP = firstBP;

            //Now RandThruster
            Thruster thrusterSelection = randThruster();
            int thrusterCost = firstBP - thrusterSelection.BpCost;
            if (thrusterCost > 0)
            {
                firstBP -= thrusterSelection.BpCost;
                spentBPCount += thrusterSelection.BpCost;
                currentBuildPoints.Text = calcBP().ToString();
                spentPCUCount += thrusterSelection.Pcu;
                remainingPCU.Text = calcPCU().ToString();
                shipSpeed = thrusterSelection.Speed;
                starshipSpeed.Text = shipSpeed.ToString();
                pilotingModAdj = thrusterSelection.Piloting;
                starshipPilotingMod.Text = calcPilotMod().ToString();
                pilotRanks += thrusterSelection.Piloting;
                calcAC();
                calcTL();
                ACTextBox.Text = ac.ToString();
                TLTextBox.Text = tl.ToString();
                thrustersComboBox.Text = thrusterSelection.Type;
                sThrusters = thrusterSelection.Type;
                sThrusterSpeed = shipSpeed.ToString();

                thrustersGB.BackColor = Color.Khaki;
                thrustersSelected = true;
                armorGB.BackColor = Color.Lime;
                thrustersComboBox.Enabled = false;
                thrusterSelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }

            HyperspaceEngine hsEngineSelection = randHyperspace();
            int computedBP = hsEngineSelection.BpMulti * shipSizeInt;
            int hyperCost = firstBP - computedBP;
            if (hyperCost > 0)
            {
                firstBP -= computedBP;
                spentBPCount += computedBP;
                currentBuildPoints.Text = calcBP().ToString();
                hyperspaceEngineRatingTextBox.Text = hsEngineSelection.Rating.ToString();
                hyperspaceEngineLabel.Text = hsEngineSelection.Type;
                hyperspaceEngineComboBox.Text = hsEngineSelection.Type;
                sHyperspaceEngine = hyperspaceEngineLabel.Text;
                sHyperspaceRating = hyperspaceEngineRatingTextBox.Text;
                hyperspaceengineGB.BackColor = Color.Khaki;
                hyperspaceEngineSelected = true;
                expansionbayGB.BackColor = Color.Lime;
                hyperspaceEngineComboBox.Enabled = false;
                hyperspaceEngineSelectButton.Text = "Undo";
                statusLabel.BackColor = Color.Lime;
            }
            statusLabel.Text = "Random Generation Complete";
        }

        public void getBPandPCU()
        {
            BP = totalBPCount - spentBPCount;
            PCU = totalPCUCount - spentPCUCount;
        }


        #endregion

        private void compCountermeasuresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void weaponsSelectPage_Enter(object sender, EventArgs e)
        {
            if (shieldsSelected == false)
            {
                weaponsMainControl.SelectedTab = tabPage1;
                weaponsMainControl.Refresh();
                MessageBox.Show("Please select Shields before accessing Weapons Upgrades", "*Notice*", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                wpnUpgradeBPLabel.Text = "0";
                wpnUpgradeEntered = true;
            }
        }

        private void wpnsLinkingTab_Enter(object sender, EventArgs e)
        {
            if (shieldsSelected == false)
            {
                weaponsMainControl.SelectedTab = tabPage1;
                weaponsMainControl.Refresh();
                MessageBox.Show("Please select Shields before accessing Weapons Upgrades", "*Notice*", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                wpnUpgradeBPLabel.Text = "0";
                wpnUpgradeEntered = true;
            }
        }

        private void selectLinksBtn_Click(object sender, EventArgs e)               // Added
        {
            AssemblyBay LiveBay = new AssemblyBay();
            List<Weapon> AllWeapons = LiveBay.ConstructWeaponLoadALL();

            if (weaponsLinkSelected == false)
            {
                // Check if first forward link checked
                if (forwLinkCheckBox1.Checked == true)
                {
                    foreach (var f1 in AllWeapons)
                    {
                        if (f1.Type == forWpnTypeLink1)
                        {
                            totalLinkCost += (f1.BpCost / 2);
                            forwLinkChkBox1Type = forWpnTypeLink1;
                            break;
                        }
                    }
                }
                // Check if second forward link checked
                if (forwLinkCheckBox2.Checked == true)
                {
                    foreach (var f2 in AllWeapons)
                    {
                        if (f2.Type == forWpnTypeLink2)
                        {
                            totalLinkCost += (f2.BpCost / 2);
                            forwLinkChkBox2Type = forWpnTypeLink2;
                            break;
                        }
                    }
                }
                // Check if first turret link checked
                if (turLinkCheckBox1.Checked == true)
                {
                    foreach (var t1 in AllWeapons)
                    {
                        if (t1.Type == turWpnTypeLink1)
                        {
                            totalLinkCost += (t1.BpCost / 2);
                            turLinkChkBox1Type = turWpnTypeLink1;
                            break;
                        }
                    }
                }
                // Check if second turret link checked
                if (turLinkCheckBox2.Checked == true)
                {
                    foreach (var t2 in AllWeapons)
                    {
                        if (t2.Type == turWpnTypeLink2)
                        {
                            totalLinkCost += (t2.BpCost / 2);
                            turLinkChkBox2Type = turWpnTypeLink2;
                            break;
                        }
                    }
                }
                // Check if first aft link checked
                if (aftLinkCheckBox1.Checked == true)
                {
                    foreach (var a1 in AllWeapons)
                    {
                        if (a1.Type == aftWpnTypeLink1)
                        {
                            totalLinkCost += (a1.BpCost / 2);
                            aftLinkChkBox1Type = aftWpnTypeLink1;
                            break;
                        }
                    }
                }
                // Check if second  aft link checked
                if (aftLinkCheckBox2.Checked == true)
                {
                    foreach (var a2 in AllWeapons)
                    {
                        if (a2.Type == aftWpnTypeLink2)
                        {
                            totalLinkCost += (a2.BpCost / 2);
                            aftLinkChkBox2Type = aftWpnTypeLink2;
                            break;
                        }
                    }
                }
                // Check if first starboard link checked
                if (starbLinkCheckBox1.Checked == true)
                {
                    foreach (var s1 in AllWeapons)
                    {
                        if (s1.Type == starbWpnTypeLink1)
                        {
                            totalLinkCost += (s1.BpCost / 2);
                            starbLinkChkBox1Type = starbWpnTypeLink1;
                            break;
                        }
                    }
                }
                // Check if second starboard link checked
                if (starbLinkCheckBox2.Checked == true)
                {
                    foreach (var s2 in AllWeapons)
                    {
                        if (s2.Type == starbWpnTypeLink2)
                        {
                            totalLinkCost += (s2.BpCost / 2);
                            starbLinkChkBox2Type = starbWpnTypeLink2;
                            break;
                        }
                    }
                }
                // Check if first port link checked
                if (portLinkCheckBox1.Checked == true)
                {
                    foreach (var p1 in AllWeapons)
                    {
                        if (p1.Type == portWpnTypeLink1)
                        {
                            totalLinkCost += (p1.BpCost / 2);
                            portLinkChkBox1Type = portWpnTypeLink1;
                            break;
                        }
                    }
                }
                // Check if second port link checked
                if (portLinkCheckBox2.Checked == true)
                {
                    foreach (var p2 in AllWeapons)
                    {
                        if (p2.Type == portWpnTypeLink2)
                        {
                            totalLinkCost += (p2.BpCost / 2);
                            portLinkChkBox2Type = portWpnTypeLink2;
                            break;
                        }
                    }
                }

                if (totalLinkCost != 0)
                {
                    spentBPCount += totalLinkCost;
                    currentBuildPoints.Text = calcBP().ToString();
                    selectLinksBtn.Text = "Undo";
                    wpnsLinkingTab.BackColor = Color.Khaki;
                    statusLabel.Text = "Weapons Linked";
                    statusLabel.BackColor = Color.Lime;
                    weaponsLinkSelected = true;
                    forwLinkCheckBox1.Enabled = false;
                    forwLinkCheckBox2.Enabled = false;
                    turLinkCheckBox1.Enabled = false;
                    turLinkCheckBox2.Enabled = false;
                    aftLinkCheckBox1.Enabled = false;
                    aftLinkCheckBox2.Enabled = false;
                    starbLinkCheckBox1.Enabled = false;
                    starbLinkCheckBox2.Enabled = false;
                    portLinkCheckBox1.Enabled = false;
                    portLinkCheckBox2.Enabled = false;
                }
            }
            else if (weaponsLinkSelected == true)
            {
                forwLinkChkBox1Type = "";
                forwLinkChkBox2Type = "";
                turLinkChkBox1Type = "";
                turLinkChkBox2Type = "";
                aftLinkChkBox1Type = "";
                aftLinkChkBox2Type = "";
                starbLinkChkBox1Type = "";
                starbLinkChkBox2Type = "";
                portLinkChkBox1Type = "";
                portLinkChkBox2Type = "";
                forwLinkCheckBox1.Enabled = true;
                forwLinkCheckBox2.Enabled = true;
                turLinkCheckBox1.Enabled = true;
                turLinkCheckBox2.Enabled = true;
                aftLinkCheckBox1.Enabled = true;
                aftLinkCheckBox2.Enabled = true;
                starbLinkCheckBox1.Enabled = true;
                starbLinkCheckBox2.Enabled = true;
                portLinkCheckBox1.Enabled = true;
                portLinkCheckBox2.Enabled = true;
                spentBPCount -= totalLinkCost;
                currentBuildPoints.Text = calcBP().ToString();
                selectLinksBtn.Text = "Select";
                wpnsLinkingTab.BackColor = Color.Empty;
                statusLabel.Text = "Please Re-select Link Options";
                statusLabel.BackColor = Color.Red;
                totalLinkCost = 0;
                weaponsLinkSelected = false;                                    // Added
            }
        }

        private void openStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string forWpnLinkCheck1 = "";
                string forWpnLinkCheck2 = "";
                string forWpnLinkCheck3 = "";
                string forWpnLinkCheck4 = "";
                string portWpnLinkCheck1 = "";
                string portWpnLinkCheck2 = "";
                string portWpnLinkCheck3 = "";
                string portWpnLinkCheck4 = "";
                string starbWpnLinkCheck1 = "";
                string starbWpnLinkCheck2 = "";
                string starbWpnLinkCheck3 = "";
                string starbWpnLinkCheck4 = "";
                string turWpnLinkCheck1 = "";
                string turWpnLinkCheck2 = "";
                string turWpnLinkCheck3 = "";
                string turWpnLinkCheck4 = "";
                string aftWpnLinkCheck1 = "";
                string aftWpnLinkCheck2 = "";
                string aftWpnLinkCheck3 = "";
                string aftWpnLinkCheck4 = "";
                OpenFileDialog openFile = new OpenFileDialog();
                string pdfFileName;
                PdfReader pdfReadin;
                AcroFields fields;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // refreshes the application before reading a new pdf
                    newToolStripMenuItem.PerformClick();
                    // open and read the file and fields
                    pdfFileName = openFile.FileName;
                    pdfReadin = new PdfReader(pdfFileName);
                    fields = pdfReadin.AcroFields;
                    sName = fields.GetField("shipNameField").ToString();
                    sMake = fields.GetField("shipMakeField").ToString();
                    sModel = fields.GetField("shipModelField").ToString();
                    sTier = fields.GetField("shipTierField").ToString();
                    sFrame = fields.GetField("shipFrameField").ToString();
                    sPowerCore1 = fields.GetField("shipPowCoreField").ToString();
                    sThrusters = fields.GetField("shipThrusterField").ToString();
                    sArmor = fields.GetField("shipArmorField").ToString();
                    sComputer = fields.GetField("shipCpuField").ToString();
                    sQuarters = fields.GetField("shipQtrsField").ToString();
                    sCountermeasures = fields.GetField("counterMeasureField").ToString();
                    sHyperspaceEngine = fields.GetField("shipHypEngField").ToString();
                    sExpBay01 = fields.GetField("expBay1Field").ToString();
                    sExpBay02 = fields.GetField("expBay2Field").ToString();
                    sExpBay03 = fields.GetField("expBay3Field").ToString();
                    sExpBay04 = fields.GetField("expBay4Field").ToString();
                    sExpBay05 = fields.GetField("expBay5Field").ToString();
                    sExpBay06 = fields.GetField("expBay6Field").ToString();
                    sExpBay07 = fields.GetField("expBay7Field").ToString();
                    sExpBay08 = fields.GetField("expBay8Field").ToString();
                    sExpBay09 = fields.GetField("expBay9Field").ToString();
                    sExpBay10 = fields.GetField("expBay10Field").ToString();
                    sExpBay11 = fields.GetField("expBay11Field").ToString();
                    sExpBay12 = fields.GetField("expBay12Field").ToString();
                    sExpBay13 = fields.GetField("expBay13Field").ToString();
                    sExpBay14 = fields.GetField("expBay14Field").ToString();
                    sExpBay15 = fields.GetField("expBay15Field").ToString();
                    sExpBay16 = fields.GetField("expBay16Field").ToString();
                    sExpBay17 = fields.GetField("expBay17Field").ToString();
                    sExpBay18 = fields.GetField("expBay18Field").ToString();
                    sExpBay19 = fields.GetField("expBay19Field").ToString();
                    sExpBay20 = fields.GetField("expBay20Field").ToString();
                    strCompAntiHack = fields.GetField("antiHackCheckBox").ToString();
                    strBiolocks = fields.GetField("biolockCheckBox").ToString();
                    strSelfDestruct = fields.GetField("selfDestructCheckBox").ToString();
                    sSensors = fields.GetField("shipSensorField").ToString();
                    sShields = fields.GetField("shipShieldField").ToString();
                    sFWPNS01 = fields.GetField("forWpn1Field").ToString();
                    sFWPNS02 = fields.GetField("forWpn2Field").ToString();
                    sFWPNS03 = fields.GetField("forWpn3Field").ToString();
                    sFWPNS04 = fields.GetField("forWpn4Field").ToString();
                    sPWPNS01 = fields.GetField("porWpn1Field").ToString();
                    sPWPNS02 = fields.GetField("porWpn2Field").ToString();
                    sPWPNS03 = fields.GetField("porWpn3Field").ToString();
                    sPWPNS04 = fields.GetField("porWpn4Field").ToString();
                    sSWPNS01 = fields.GetField("starWpn1Field").ToString();
                    sSWPNS02 = fields.GetField("starWpn2Field").ToString();
                    sSWPNS03 = fields.GetField("starWpn3Field").ToString();
                    sSWPNS04 = fields.GetField("starWpn4Field").ToString();
                    sTWPNS01 = fields.GetField("turWpn1Field").ToString();
                    sTWPNS02 = fields.GetField("turWpn2Field").ToString();
                    sTWPNS03 = fields.GetField("turWpn3Field").ToString();
                    sTWPNS04 = fields.GetField("turWpn4Field").ToString();
                    sAWPNS01 = fields.GetField("aftWpn1Field").ToString();
                    sAWPNS02 = fields.GetField("aftWpn2Field").ToString();
                    sAWPNS03 = fields.GetField("aftWpn3Field").ToString();
                    sAWPNS04 = fields.GetField("aftWpn4Field").ToString();
                    forWpnLinkCheck1 = fields.GetField("forwLink1Field").ToString();
                    forWpnLinkCheck2 = fields.GetField("forwLink2Field").ToString();
                    forWpnLinkCheck3 = fields.GetField("forwLink3Field").ToString();
                    forWpnLinkCheck4 = fields.GetField("forwLink4Field").ToString();
                    portWpnLinkCheck1 = fields.GetField("portLink1Field").ToString();
                    portWpnLinkCheck2 = fields.GetField("portLink2Field").ToString();
                    portWpnLinkCheck3 = fields.GetField("portLink3Field").ToString();
                    portWpnLinkCheck4 = fields.GetField("portLink4Field").ToString();
                    starbWpnLinkCheck1 = fields.GetField("starbLink1Field").ToString();
                    starbWpnLinkCheck2 = fields.GetField("starbLink2Field").ToString();
                    starbWpnLinkCheck3 = fields.GetField("starbLink3Field").ToString();
                    starbWpnLinkCheck4 = fields.GetField("starbLink4Field").ToString();
                    turWpnLinkCheck1 = fields.GetField("turLink1Field").ToString();
                    turWpnLinkCheck2 = fields.GetField("turLink2Field").ToString();
                    turWpnLinkCheck3 = fields.GetField("turLink3Field").ToString();
                    turWpnLinkCheck4 = fields.GetField("turLink4Field").ToString();
                    aftWpnLinkCheck1 = fields.GetField("aftLink1Field").ToString();
                    aftWpnLinkCheck2 = fields.GetField("aftLink2Field").ToString();
                    aftWpnLinkCheck3 = fields.GetField("aftLink3Field").ToString();
                    aftWpnLinkCheck4 = fields.GetField("aftLink4Field").ToString();
                    pdfReadin.Close();
                }
                else
                {
                    return;
                }
                AssemblyBay bay = new AssemblyBay();
                
                if (String.IsNullOrEmpty(sName))
                {
                    starshipNameTextBox.Text = "";
                }
                else
                {
                    starshipNameTextBox.Text = sName;
                    starshipNameSelectButton.PerformClick();
                }
                if (String.IsNullOrEmpty(sMake))
                {
                    starshipMakeTextBox.Text = "";
                }
                else
                {
                    starshipMakeTextBox.Text = sMake;
                    starshipMakeSelectButton.PerformClick();
                }
                if (String.IsNullOrEmpty(sModel))
                {
                    starshipModelTextBox.Text = "";
                }
                else
                {
                    starshipModelTextBox.Text = sModel;
                    starshipModelSelectButton.PerformClick();
                }
                if (String.IsNullOrEmpty(sTier))
                {
                    tierComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var t in bay.ConstructTierLoad())
                    {
                        if (t.Type == sTier)
                        {
                            tierComboBox.SelectedIndex = count;
                            tierSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sFrame))
                {
                    frameComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var f in bay.ConstructFrameLoad())
                    {
                        if (f.Type == sFrame)
                        {
                            frameComboBox.SelectedIndex = count;
                            frameSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sPowerCore1))
                {
                    powerCoreComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var p in FittedCores())
                    {
                        if (p.Type == sPowerCore1)
                        {
                            powerCoreComboBox.SelectedIndex = count;
                            powerCoreSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sThrusters))
                {
                    thrustersComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var t in FittedThrusters())
                    {
                        if (t.Type == sThrusters)
                        {
                            thrustersComboBox.SelectedIndex = count;
                            thrusterSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sArmor))
                {
                    armorComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var ar in bay.ConstructArmorLoad())
                    {
                        if (ar.Type == sArmor)
                        {
                            armorComboBox.SelectedIndex = count;
                            armorSelectionButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sComputer))
                {
                    computerComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var c in bay.ConstructComputerLoad())
                    {
                        if (c.Type == sComputer)
                        {
                            computerComboBox.SelectedIndex = count;
                            computerSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sQuarters))
                {
                    quartersComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var q in bay.ConstructQuartersLoad())
                    {
                        if (q.Type == sQuarters)
                        {
                            quartersComboBox.SelectedIndex = count;
                            quartersSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sCountermeasures))
                {
                    countermeasuresComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var c in bay.ConstructCountermeasuresLoad())
                    {
                        if (c.Type == sCountermeasures)
                        {
                            countermeasuresComboBox.SelectedIndex = count;
                            countermeasuresSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sHyperspaceEngine))
                {
                    hyperspaceEngineComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 1;
                    foreach (var h in bay.ConstructHyperspaceEngineLoad())
                    {
                        if (h.Type == sHyperspaceEngine)
                        {
                            hyperspaceEngineComboBox.SelectedIndex = count;
                            hyperspaceEngineSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay01))
                {
                    if (expBayComboBox1.Visible == true)
                    {
                        expBayComboBox1.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex1 in bay.ConstructExpansionBayLoad01())
                    {
                        if (ex1.Type == sExpBay01)
                        {
                            expBayComboBox1.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay02))
                {
                    if (expBayComboBox2.Visible == true)
                    {
                        expBayComboBox2.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex2 in bay.ConstructExpansionBayLoad02())
                    {
                        if (ex2.Type == sExpBay02)
                        {
                            expBayComboBox2.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay03))
                {
                    if (expBayComboBox3.Visible == true)
                    {
                        expBayComboBox3.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex3 in bay.ConstructExpansionBayLoad03())
                    {
                        if (ex3.Type == sExpBay03)
                        {
                            expBayComboBox3.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay04))
                {
                    if (expBayComboBox4.Visible == true)
                    {
                        expBayComboBox4.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex4 in bay.ConstructExpansionBayLoad04())
                    {
                        if (ex4.Type == sExpBay04)
                        {
                            expBayComboBox4.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay05))
                {
                    if (expBayComboBox5.Visible == true)
                    {
                        expBayComboBox5.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex5 in bay.ConstructExpansionBayLoad05())
                    {
                        if (ex5.Type == sExpBay05)
                        {
                            expBayComboBox5.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay06))
                {
                    if (expBayComboBox6.Visible == true)
                    {
                        expBayComboBox6.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex6 in bay.ConstructExpansionBayLoad06())
                    {
                        if (ex6.Type == sExpBay01)
                        {
                            expBayComboBox6.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay07))
                {
                    if (expBayComboBox7.Visible == true)
                    {
                        expBayComboBox7.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex7 in bay.ConstructExpansionBayLoad07())
                    {
                        if (ex7.Type == sExpBay07)
                        {
                            expBayComboBox7.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay08))
                {
                    if (expBayComboBox8.Visible == true)
                    {
                        expBayComboBox8.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex8 in bay.ConstructExpansionBayLoad08())
                    {
                        if (ex8.Type == sExpBay08)
                        {
                            expBayComboBox8.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay09))
                {
                    if (expBayComboBox9.Visible == true)
                    {
                        expBayComboBox9.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex9 in bay.ConstructExpansionBayLoad09())
                    {
                        if (ex9.Type == sExpBay09)
                        {
                            expBayComboBox9.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay10))
                {
                    if (expBayComboBox10.Visible == true)
                    {
                        expBayComboBox10.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex10 in bay.ConstructExpansionBayLoad10())
                    {
                        if (ex10.Type == sExpBay10)
                        {
                            expBayComboBox10.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay11))
                {
                    if (expBayComboBox11.Visible == true)
                    {
                        expBayComboBox11.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex11 in bay.ConstructExpansionBayLoad11())
                    {
                        if (ex11.Type == sExpBay11)
                        {
                            expBayComboBox11.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay12))
                {
                    if (expBayComboBox12.Visible == true)
                    {
                        expBayComboBox12.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex12 in bay.ConstructExpansionBayLoad12())
                    {
                        if (ex12.Type == sExpBay12)
                        {
                            expBayComboBox12.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay13))
                {
                    if (expBayComboBox13.Visible == true)
                    {
                        expBayComboBox13.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex13 in bay.ConstructExpansionBayLoad13())
                    {
                        if (ex13.Type == sExpBay13)
                        {
                            expBayComboBox13.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay14))
                {
                    if (expBayComboBox14.Visible == true)
                    {
                        expBayComboBox14.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex14 in bay.ConstructExpansionBayLoad14())
                    {
                        if (ex14.Type == sExpBay14)
                        {
                            expBayComboBox14.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay15))
                {
                    if (expBayComboBox15.Visible == true)
                    {
                        expBayComboBox15.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex15 in bay.ConstructExpansionBayLoad15())
                    {
                        if (ex15.Type == sExpBay15)
                        {
                            expBayComboBox15.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay16))
                {
                    if (expBayComboBox16.Visible == true)
                    {
                        expBayComboBox16.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex16 in bay.ConstructExpansionBayLoad16())
                    {
                        if (ex16.Type == sExpBay16)
                        {
                            expBayComboBox16.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay17))
                {
                    if (expBayComboBox17.Visible == true)
                    {
                        expBayComboBox17.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex17 in bay.ConstructExpansionBayLoad17())
                    {
                        if (ex17.Type == sExpBay17)
                        {
                            expBayComboBox17.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay18))
                {
                    if (expBayComboBox18.Visible == true)
                    {
                        expBayComboBox18.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex18 in bay.ConstructExpansionBayLoad18())
                    {
                        if (ex18.Type == sExpBay18)
                        {
                            expBayComboBox18.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay19))
                {
                    if (expBayComboBox19.Visible == true)
                    {
                        expBayComboBox19.SelectedIndex = 0;
                    }
                }
                else
                {
                    int count = 0;
                    foreach (var ex19 in bay.ConstructExpansionBayLoad19())
                    {
                        if (ex19.Type == sExpBay19)
                        {
                            expBayComboBox19.SelectedIndex = count;
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sExpBay20))
                {
                    if (expBayComboBox20.Visible == true)
                    {
                        expBayComboBox20.SelectedIndex = 0;
                    }
                    expBaySelectButton.PerformClick();
                }
                else
                {
                    int count = 0;
                    foreach (var ex20 in bay.ConstructExpansionBayLoad20())
                    {
                        if (ex20.Type == sExpBay20)
                        {
                            expBayComboBox20.SelectedIndex = count;
                            expBaySelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(strCompAntiHack)))
                {
                    if (strCompAntiHack == "Yes")
                    {
                        antihackCheckBox.Checked = true;
                    }
                }
                if (!(String.IsNullOrEmpty(strBiolocks)))
                {
                    if (strBiolocks == "Yes")
                    {
                        bioLockCheckBox.Checked = true;
                    }
                }
                if (!(String.IsNullOrEmpty(strSelfDestruct)))
                {
                    if (strSelfDestruct == "Yes")
                    {
                        sdsCheckBox.Checked = true;
                    }
                    securitySelectButton.PerformClick();
                }
                else
                {
                    securitySelectButton.PerformClick();
                }
                if (String.IsNullOrEmpty(sSensors))
                {
                    sensorsComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var s in bay.ConstructSensorLoad())
                    {
                        if (s.Type == sSensors)
                        {
                            sensorsComboBox.SelectedIndex = count;
                            sensorsSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sShields))
                {
                    shieldsComboBox.SelectedIndex = 0;
                }
                else
                {
                    int count = 0;
                    foreach (var s in bay.ConstructShieldLoad())
                    {
                        if (s.Type == sShields)
                        {
                            shieldsComboBox.SelectedIndex = count;
                            shieldsSelectButton.PerformClick();
                            break;
                        }
                        count++;
                    }
                }
                if(!(String.IsNullOrEmpty(sFWPNS01)))
                { 
                    int count = 0;
                    foreach (var f1 in bay.ConstructWeaponLoadALL())
                    {
                        if (f1.Type == sFWPNS01)
                        {
                            if (f1.Size == "Light")
                            {
                                fcb1.SelectedIndex = 1;
                            }
                            else if (f1.Size == "Heavy")
                            {
                                fcb1.SelectedIndex = 2;
                            }
                            else if (f1.Size == "Capital")
                            {
                                fcb1.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sFWPNS02)))
                {
                    int count = 0;
                    foreach (var f2 in bay.ConstructWeaponLoadALL())
                    {
                        if (f2.Type == sFWPNS02)
                        {
                            if (f2.Size == "Light")
                            {
                                fcb2.SelectedIndex = 1;
                            }
                            else if (f2.Size == "Heavy")
                            {
                                fcb2.SelectedIndex = 2;
                            }
                            else if (f2.Size == "Capital")
                            {
                                fcb2.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sFWPNS03)))
                { 
                    int count = 0;
                    foreach (var f3 in bay.ConstructWeaponLoadALL())
                    {
                        if (f3.Type == sFWPNS03)
                        {
                            if (f3.Size == "Light")
                            {
                                fcb3.SelectedIndex = 1;
                            }
                            else if (f3.Size == "Heavy")
                            {
                                fcb3.SelectedIndex = 2;
                            }
                            else if (f3.Size == "Capital")
                            {
                                fcb3.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sFWPNS04)))
                { 
                    int count = 0;
                    foreach (var f4 in bay.ConstructWeaponLoadALL())
                    {
                        if (f4.Type == sFWPNS04)
                        {
                            if (f4.Size == "Light")
                            {
                                fcb4.SelectedIndex = 1;
                            }
                            else if (f4.Size == "Heavy")
                            {
                                fcb4.SelectedIndex = 2;
                            }
                            else if (f4.Size == "Capital")
                            {
                                fcb4.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sPWPNS01)))
                { 
                    int count = 0;
                    foreach (var p1 in bay.ConstructWeaponLoadALL())
                    {
                        if (p1.Type == sPWPNS01)
                        {
                            if (p1.Size == "Light")
                            {
                                pcb1.SelectedIndex = 1;
                            }
                            else if (p1.Size == "Heavy")
                            {
                                pcb1.SelectedIndex = 2;
                            }
                            else if (p1.Size == "Capital")
                            {
                                pcb1.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sPWPNS02)))
                {
                    int count = 0;
                    foreach (var p2 in bay.ConstructWeaponLoadALL())
                    {
                        if (p2.Type == sPWPNS02)
                        {
                            if (p2.Size == "Light")
                            {
                                pcb2.SelectedIndex = 1;
                            }
                            else if (p2.Size == "Heavy")
                            {
                                pcb2.SelectedIndex = 2;
                            }
                            else if (p2.Size == "Capital")
                            {
                                pcb2.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sPWPNS03)))
                { 
                    int count = 0;
                    foreach (var p3 in bay.ConstructWeaponLoadALL())
                    {
                        if (p3.Type == sPWPNS03)
                        {
                            if (p3.Size == "Light")
                            {
                                pcb3.SelectedIndex = 1;
                            }
                            else if (p3.Size == "Heavy")
                            {
                                pcb3.SelectedIndex = 2;
                            }
                            else if (p3.Size == "Capital")
                            {
                                pcb3.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sPWPNS04)))
                { 
                    int count = 0;
                    foreach (var p4 in bay.ConstructWeaponLoadALL())
                    {
                        if (p4.Type == sPWPNS04)
                        {
                            if (p4.Size == "Light")
                            {
                                pcb4.SelectedIndex = 1;
                            }
                            else if (p4.Size == "Heavy")
                            {
                                pcb4.SelectedIndex = 2;
                            }
                            else if (p4.Size == "Capital")
                            {
                                pcb4.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sSWPNS01)))
                { 
                    int count = 0;
                    foreach (var s1 in bay.ConstructWeaponLoadALL())
                    {
                        if (s1.Type == sSWPNS01)
                        {
                            if (s1.Size == "Light")
                            {
                                scb1.SelectedIndex = 1;
                            }
                            else if (s1.Size == "Heavy")
                            {
                                scb1.SelectedIndex = 2;
                            }
                            else if (s1.Size == "Capital")
                            {
                                scb1.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sSWPNS02)))
                { 
                    int count = 0;
                    foreach (var s2 in bay.ConstructWeaponLoadALL())
                    {
                        if (s2.Type == sSWPNS02)
                        {
                            if (s2.Size == "Light")
                            {
                                scb2.SelectedIndex = 1;
                            }
                            else if (s2.Size == "Heavy")
                            {
                                scb2.SelectedIndex = 2;
                            }
                            else if (s2.Size == "Capital")
                            {
                                scb2.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sSWPNS03)))
                { 
                    int count = 0;
                    foreach (var s3 in bay.ConstructWeaponLoadALL())
                    {
                        if (s3.Type == sSWPNS03)
                        {
                            if (s3.Size == "Light")
                            {
                                scb3.SelectedIndex = 1;
                            }
                            else if (s3.Size == "Heavy")
                            {
                                scb3.SelectedIndex = 2;
                            }
                            else if (s3.Size == "Capital")
                            {
                                scb3.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sSWPNS04)))
                { 
                    int count = 0;
                    foreach (var s4 in bay.ConstructWeaponLoadALL())
                    {
                        if (s4.Type == sSWPNS04)
                        {
                            if (s4.Size == "Light")
                            {
                                scb4.SelectedIndex = 1;
                            }
                            else if (s4.Size == "Heavy")
                            {
                                scb4.SelectedIndex = 2;
                            }
                            else if (s4.Size == "Capital")
                            {
                                scb4.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sTWPNS01)))
                { 
                    int count = 0;
                    foreach (var t1 in bay.ConstructWeaponLoadALL())
                    {
                        if (t1.Type == sTWPNS01)
                        {
                            if (t1.Size == "Light")
                            {
                                tcb1.SelectedIndex = 1;
                            }
                            else if (t1.Size == "Heavy")
                            {
                                tcb1.SelectedIndex = 2;
                            }
                            else if (t1.Size == "Capital")
                            {
                                tcb1.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sTWPNS02)))
                { 
                    int count = 0;
                    foreach (var t2 in bay.ConstructWeaponLoadALL())
                    {
                        if (t2.Type == sTWPNS02)
                        {
                            if (t2.Size == "Light")
                            {
                                tcb2.SelectedIndex = 1;
                            }
                            else if (t2.Size == "Heavy")
                            {
                                tcb2.SelectedIndex = 2;
                            }
                            else if (t2.Size == "Capital")
                            {
                                tcb2.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sTWPNS03)))
                { 
                    int count = 0;
                    foreach (var t3 in bay.ConstructWeaponLoadALL())
                    {
                        if (t3.Type == sTWPNS03)
                        {
                            if (t3.Size == "Light")
                            {
                                tcb3.SelectedIndex = 1;
                            }
                            else if (t3.Size == "Heavy")
                            {
                                tcb3.SelectedIndex = 2;
                            }
                            else if (t3.Size == "Capital")
                            {
                                tcb3.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sTWPNS04)))
                { 
                    int count = 0;
                    foreach (var t4 in bay.ConstructWeaponLoadALL())
                    {
                        if (t4.Type == sTWPNS04)
                        {
                            if (t4.Size == "Light")
                            {
                                tcb4.SelectedIndex = 1;
                            }
                            else if (t4.Size == "Heavy")
                            {
                                tcb4.SelectedIndex = 2;
                            }
                            else if (t4.Size == "Capital")
                            {
                                tcb4.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sAWPNS01)))
                { 
                    int count = 0;
                    foreach (var a1 in bay.ConstructWeaponLoadALL())
                    {
                        if (a1.Type == sAWPNS01)
                        {
                            if (a1.Size == "Light")
                            {
                                acb1.SelectedIndex = 1;
                            }
                            else if (a1.Size == "Heavy")
                            {
                                acb1.SelectedIndex = 2;
                            }
                            else if (a1.Size == "Capital")
                            {
                                acb1.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sAWPNS02)))
                { 
                    int count = 0;
                    foreach (var a2 in bay.ConstructWeaponLoadALL())
                    {
                        if (a2.Type == sAWPNS02)
                        {
                            if (a2.Size == "Light")
                            {
                                acb2.SelectedIndex = 1;
                            }
                            else if (a2.Size == "Heavy")
                            {
                                acb2.SelectedIndex = 2;
                            }
                            else if (a2.Size == "Capital")
                            {
                                acb2.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (!(String.IsNullOrEmpty(sAWPNS03)))
                { 
                    int count = 0;
                    foreach (var a3 in bay.ConstructWeaponLoadALL())
                    {
                        if (a3.Type == sAWPNS03)
                        {
                            if (a3.Size == "Light")
                            {
                                acb3.SelectedIndex = 1;
                            }
                            else if (a3.Size == "Heavy")
                            {
                                acb3.SelectedIndex = 2;
                            }
                            else if (a3.Size == "Capital")
                            {
                                acb3.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                }
                if (String.IsNullOrEmpty(sAWPNS04))
                {
                    wpnsUpgradeBtn.PerformClick();
                    try
                    {
                        int i = forward01.FindStringExact(sFWPNS01);
                        forward01.SelectedIndex = i;
                    }
                    catch(Exception ex)
                    {

                    }
                    try
                    {
                        int i = forward02.FindStringExact(sFWPNS02);
                        forward02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = forward03.FindStringExact(sFWPNS03);
                        forward03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = forward04.FindStringExact(sFWPNS04);
                        forward04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port01.FindStringExact(sPWPNS01);
                        port01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port02.FindStringExact(sPWPNS02);
                        port02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port03.FindStringExact(sPWPNS03);
                        port03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port04.FindStringExact(sPWPNS04);
                        port04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard01.FindStringExact(sSWPNS01);
                        starboard01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard02.FindStringExact(sSWPNS02);
                        starboard02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard03.FindStringExact(sSWPNS03);
                        starboard03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard04.FindStringExact(sSWPNS04);
                        starboard04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret01.FindStringExact(sTWPNS01);
                        turret01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret02.FindStringExact(sTWPNS02);
                        turret02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret03.FindStringExact(sTWPNS03);
                        turret03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret04.FindStringExact(sTWPNS04);
                        turret04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = aft01.FindStringExact(sAWPNS01);
                        aft01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = aft02.FindStringExact(sAWPNS02);
                        aft02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = aft03.FindStringExact(sAWPNS03);
                        aft03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    weaponsSelectButton.PerformClick();
                }
                else
                {
                    int count = 0;
                    foreach (var a4 in bay.ConstructWeaponLoadALL())
                    {
                        if (a4.Type == sAWPNS04)
                        {
                            if (a4.Size == "Light")
                            {
                                acb4.SelectedIndex = 1;
                            }
                            else if (a4.Size == "Heavy")
                            {
                                acb4.SelectedIndex = 2;
                            }
                            else if (a4.Size == "Capital")
                            {
                                acb4.SelectedIndex = 3;
                            }
                            break;
                        }
                        count++;
                    }
                    wpnsUpgradeBtn.PerformClick();
                    try
                    {
                        int i = forward01.FindStringExact(sFWPNS01);
                        forward01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = forward02.FindStringExact(sFWPNS02);
                        forward02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = forward03.FindStringExact(sFWPNS03);
                        forward03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = forward04.FindStringExact(sFWPNS04);
                        forward04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port01.FindStringExact(sPWPNS01);
                        port01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port02.FindStringExact(sPWPNS02);
                        port02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port03.FindStringExact(sPWPNS03);
                        port03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = port04.FindStringExact(sPWPNS04);
                        port04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard01.FindStringExact(sSWPNS01);
                        starboard01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard02.FindStringExact(sSWPNS02);
                        starboard02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard03.FindStringExact(sSWPNS03);
                        starboard03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = starboard04.FindStringExact(sSWPNS04);
                        starboard04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret01.FindStringExact(sTWPNS01);
                        turret01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret02.FindStringExact(sTWPNS02);
                        turret02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret03.FindStringExact(sTWPNS03);
                        turret03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = turret04.FindStringExact(sTWPNS04);
                        turret04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = aft01.FindStringExact(sAWPNS01);
                        aft01.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = aft02.FindStringExact(sAWPNS02);
                        aft02.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = aft03.FindStringExact(sAWPNS03);
                        aft03.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int i = aft04.FindStringExact(sAWPNS04);
                        aft04.SelectedIndex = i;
                    }
                    catch (Exception ex)
                    {

                    }
                    weaponsSelectButton.PerformClick();
                }
                if((sFWPNS01 == forwLinkCheckBox1.Text) && (forWpnLinkCheck1 == "Yes"))
                {
                    forwLinkCheckBox1.Checked = true;
                }
                else if((sFWPNS01 == forwLinkCheckBox2.Text) && (forWpnLinkCheck1 == "Yes"))
                {
                    forwLinkCheckBox2.Checked = true;
                }
                if ((sFWPNS02 == forwLinkCheckBox1.Text) && (forWpnLinkCheck2 == "Yes"))
                {
                    forwLinkCheckBox1.Checked = true;
                }
                else if ((sFWPNS02 == forwLinkCheckBox2.Text) && (forWpnLinkCheck2 == "Yes"))
                {
                    forwLinkCheckBox2.Checked = true;
                }
                if ((sFWPNS03 == forwLinkCheckBox1.Text) && (forWpnLinkCheck3 == "Yes"))
                {
                    forwLinkCheckBox1.Checked = true;
                }
                else if ((sFWPNS03 == forwLinkCheckBox2.Text) && (forWpnLinkCheck3 == "Yes"))
                {
                    forwLinkCheckBox2.Checked = true;
                }
                if ((sFWPNS04 == forwLinkCheckBox1.Text) && (forWpnLinkCheck4 == "Yes"))
                {
                    forwLinkCheckBox1.Checked = true;
                }
                else if ((sFWPNS04 == forwLinkCheckBox2.Text) && (forWpnLinkCheck4 == "Yes"))
                {
                    forwLinkCheckBox2.Checked = true;
                }
                if ((sPWPNS01 == portLinkCheckBox1.Text) && (portWpnLinkCheck1 == "Yes"))
                {
                    portLinkCheckBox1.Checked = true;
                }
                else if ((sPWPNS01 == portLinkCheckBox2.Text) && (portWpnLinkCheck1 == "Yes"))
                {
                    portLinkCheckBox2.Checked = true;
                }
                if ((sPWPNS02 == portLinkCheckBox1.Text) && (portWpnLinkCheck2 == "Yes"))
                {
                    portLinkCheckBox1.Checked = true;
                }
                else if ((sPWPNS02 == portLinkCheckBox2.Text) && (portWpnLinkCheck2 == "Yes"))
                {
                    portLinkCheckBox2.Checked = true;
                }
                if ((sPWPNS03 == portLinkCheckBox1.Text) && (portWpnLinkCheck3 == "Yes"))
                {
                    portLinkCheckBox1.Checked = true;
                }
                else if ((sPWPNS03 == portLinkCheckBox2.Text) && (portWpnLinkCheck3 == "Yes"))
                {
                    portLinkCheckBox2.Checked = true;
                }
                if ((sPWPNS04 == portLinkCheckBox1.Text) && (portWpnLinkCheck4 == "Yes"))
                {
                    portLinkCheckBox1.Checked = true;
                }
                else if ((sPWPNS04 == portLinkCheckBox2.Text) && (portWpnLinkCheck4 == "Yes"))
                {
                    portLinkCheckBox2.Checked = true;
                }
                if ((sSWPNS01 == starbLinkCheckBox1.Text) && (starbWpnLinkCheck1 == "Yes"))
                {
                    starbLinkCheckBox1.Checked = true;
                }
                else if ((sSWPNS01 == starbLinkCheckBox2.Text) && (starbWpnLinkCheck1 == "Yes"))
                {
                    starbLinkCheckBox2.Checked = true;
                }
                if ((sSWPNS02 == starbLinkCheckBox1.Text) && (starbWpnLinkCheck2 == "Yes"))
                {
                    starbLinkCheckBox1.Checked = true;
                }
                else if ((sSWPNS02 == starbLinkCheckBox2.Text) && (starbWpnLinkCheck2 == "Yes"))
                {
                    starbLinkCheckBox2.Checked = true;
                }
                if ((sSWPNS03 == starbLinkCheckBox1.Text) && (starbWpnLinkCheck3 == "Yes"))
                {
                    starbLinkCheckBox1.Checked = true;
                }
                else if ((sSWPNS03 == starbLinkCheckBox2.Text) && (starbWpnLinkCheck3 == "Yes"))
                {
                    starbLinkCheckBox2.Checked = true;
                }
                if ((sSWPNS04 == starbLinkCheckBox1.Text) && (starbWpnLinkCheck4 == "Yes"))
                {
                    starbLinkCheckBox1.Checked = true;
                }
                else if ((sSWPNS04 == starbLinkCheckBox2.Text) && (starbWpnLinkCheck4 == "Yes"))
                {
                    starbLinkCheckBox2.Checked = true;
                }
                if ((sTWPNS01 == turLinkCheckBox1.Text) && (turWpnLinkCheck1 == "Yes"))
                {
                    turLinkCheckBox1.Checked = true;
                }
                else if ((sTWPNS01 == turLinkCheckBox2.Text) && (turWpnLinkCheck1 == "Yes"))
                {
                    turLinkCheckBox2.Checked = true;
                }
                if ((sTWPNS02 == turLinkCheckBox1.Text) && (turWpnLinkCheck2 == "Yes"))
                {
                    turLinkCheckBox1.Checked = true;
                }
                else if ((sTWPNS02 == turLinkCheckBox2.Text) && (turWpnLinkCheck2 == "Yes"))
                {
                    turLinkCheckBox2.Checked = true;
                }
                if ((sTWPNS03 == turLinkCheckBox1.Text) && (turWpnLinkCheck3 == "Yes"))
                {
                    turLinkCheckBox1.Checked = true;
                }
                else if ((sTWPNS03 == turLinkCheckBox2.Text) && (turWpnLinkCheck3 == "Yes"))
                {
                    turLinkCheckBox2.Checked = true;
                }
                if ((sTWPNS04 == turLinkCheckBox1.Text) && (turWpnLinkCheck4 == "Yes"))
                {
                    turLinkCheckBox1.Checked = true;
                }
                else if ((sTWPNS04 == turLinkCheckBox2.Text) && (turWpnLinkCheck4 == "Yes"))
                {
                    turLinkCheckBox2.Checked = true;
                }
                if ((sAWPNS01 == aftLinkCheckBox1.Text) && (aftWpnLinkCheck1 == "Yes"))
                {
                    aftLinkCheckBox1.Checked = true;
                }
                else if ((sAWPNS01 == aftLinkCheckBox2.Text) && (aftWpnLinkCheck1 == "Yes"))
                {
                    aftLinkCheckBox2.Checked = true;
                }
                if ((sAWPNS02 == aftLinkCheckBox1.Text) && (aftWpnLinkCheck2 == "Yes"))
                {
                    aftLinkCheckBox1.Checked = true;
                }
                else if ((sAWPNS02 == aftLinkCheckBox2.Text) && (aftWpnLinkCheck2 == "Yes"))
                {
                    aftLinkCheckBox2.Checked = true;
                }
                if ((sAWPNS03 == aftLinkCheckBox1.Text) && (aftWpnLinkCheck3 == "Yes"))
                {
                    aftLinkCheckBox1.Checked = true;
                }
                else if ((sAWPNS03 == aftLinkCheckBox2.Text) && (aftWpnLinkCheck3 == "Yes"))
                {
                    aftLinkCheckBox2.Checked = true;
                }
                if ((sAWPNS04 == aftLinkCheckBox1.Text) && (aftWpnLinkCheck4 == "Yes"))
                {
                    aftLinkCheckBox1.Checked = true;
                }
                else if ((sAWPNS04 == aftLinkCheckBox2.Text) && (aftWpnLinkCheck4 == "Yes"))
                {
                    aftLinkCheckBox2.Checked = true;
                }
                selectLinksBtn.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Starship File. The file is either corrupted or not a Starship that was created in Starship Hangar. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine(System.Environment.StackTrace);
            }
        }
    }
}

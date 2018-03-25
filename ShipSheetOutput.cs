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


namespace Starfinder_Starship_Hanger
{
    public partial class ShipSheetOutput : Form
    {
        public ShipSheetOutput()
        {
            InitializeComponent();
        }

        private void ShipSheetOutput_Load(object sender, EventArgs e)
        {
            List<Label> data = formData();
            foreach(var v in data)
            {
                v.Text = " ";
            }

            sName.Text = Form1.sName;
            sMake.Text = Form1.sMake;
            sModel.Text = Form1.sModel;
            sTier.Text = Form1.sTier;
            sBuildPointTotal.Text = Form1.sBuildPointsTotal;
            sBuildPointsUsed.Text = Form1.sBuildPointsUsed;
            sFrame.Text = Form1.sFrame;
            sManeuver.Text = Form1.sManuever;
            sSize.Text = Form1.sSize;
            sPowerCore.Text = Form1.sPowerCore1;
            if(Form1.sPowerCore2 != null)
            {
                sPowerCore.Text = Form1.sPowerCore1 + " / " + Form1.sPowerCore2;
            }
            sSensors.Text = Form1.sSensors;
            sSensorRange.Text = Form1.sSensorRange;
            sSensorMod.Text = Form1.sSensorMod;
            sComputer.Text = Form1.sComputer;
            sCompBonus.Text = Form1.sCompBonus;
            sCompNodes.Text = Form1.sCompNodes;
            sThrusters.Text = Form1.sThrusters;
            sThrusterSpeed.Text = Form1.sThrusterSpeed;
            sHyperspaceEngine.Text = Form1.sHyperspaceEngine;
            sHyperspaceRating.Text = Form1.sHyperspaceRating;
            sHPTotal.Text = Form1.sHPTotal;
            sDT.Text = Form1.sDT;
            sCT.Text = Form1.sCT;
            sArmor.Text = Form1.sArmor;
            sACTotal.Text = Form1.sACTotal;
            sACBonus.Text = Form1.sACBonus;
            sACMisc.Text = Form1.sACMiscMod;
            sSizeMod01.Text = Form1.sSizeMod;
            sSizeMod02.Text = Form1.sSizeMod;
            sPilotMod.Text = Form1.sPilotMod;
            sPilotMod01.Text = Form1.sPilotMod;
            sPilotMod02.Text = Form1.sPilotMod;
            sCountermeasures.Text = Form1.sCountermeasures;
            sTLTotal.Text = Form1.sTLTotal;
            sTLBonus.Text = Form1.sTLBonus;
            sTLMiscMod.Text = Form1.sTLMiscMod;
            sShields.Text = Form1.sShields;
            sShieldsRegen.Text = Form1.sShieldRegen;
            sShieldsTotal.Text = Form1.sShieldTotal;
            sSensors.Text = Form1.sSensors;
            sSensorRange.Text = Form1.sSensorRange;
            sSensorMod.Text = Form1.sSensorMod;
            if(Form1.sCompAntiHack == true)
            {
                sAntiHackCheck.Checked = true;
            }
            if(Form1.sBiolocks == true)
            {
                sBiolocksCheck.Checked = true;
            }
            if(Form1.sSelfDestruct == true)
            {
                sSelfDestructCheck.Checked = true;
            }
            sFWPN01.Text = Form1.sFWPNS01;
            sFWPN02.Text = Form1.sFWPNS02;
            sFWPN03.Text = Form1.sFWPNS03;
            sFWPN04.Text = Form1.sFWPNS04;
            sFDMG01.Text = Form1.sFDMG01;
            sFDMG02.Text = Form1.sFDMG02;
            sFDMG03.Text = Form1.sFDMG03;
            sFDMG04.Text = Form1.sFDMG04;
            
            sPWPN01.Text = Form1.sPWPNS01;
            sPWPN02.Text = Form1.sPWPNS02;
            sPWPN03.Text = Form1.sPWPNS03;
            sPWPN04.Text = Form1.sPWPNS04;
            sPDMG01.Text = Form1.sPDMG01;
            sPDMG02.Text = Form1.sPDMG02;
            sPDMG03.Text = Form1.sPDMG03;
            sPDMG04.Text = Form1.sPDMG04;

            sSDMG01.Text = Form1.sSDMG01;
            sSDMG02.Text = Form1.sSDMG02;
            sSDMG03.Text = Form1.sSDMG03;
            sSDMG04.Text = Form1.sSDMG04;
            sSWPN01.Text = Form1.sSWPNS01;
            sSWPN02.Text = Form1.sSWPNS02;
            sSWPN03.Text = Form1.sSWPNS03;
            sSWPN04.Text = Form1.sSWPNS04;

            sTDMG01.Text = Form1.sTDMG01;
            sTDMG02.Text = Form1.sTDMG02;
            sTDMG03.Text = Form1.sTDMG03;
            sTDMG04.Text = Form1.sTDMG04;
            sTWPN01.Text = Form1.sTWPNS01;
            sTWPN02.Text = Form1.sTWPNS02;
            sTWPN03.Text = Form1.sTWPNS03;
            sTWPN04.Text = Form1.sTWPNS04;

            sADMG01.Text = Form1.sADMG01;
            sADMG02.Text = Form1.sADMG02;
            sADMG03.Text = Form1.sADMG03;
            sADMG04.Text = Form1.sADMG04;
            sAWPN01.Text = Form1.sAWPNS01;
            sAWPN02.Text = Form1.sAWPNS02;
            sAWPN03.Text = Form1.sAWPNS03;
            sAWPN04.Text = Form1.sAWPNS04;

            sExpBay01.Text = Form1.sExpBay01;
            sExpBay02.Text = Form1.sExpBay02;
            sExpBay03.Text = Form1.sExpBay03;
            sExpBay04.Text = Form1.sExpBay04;
            sExpBay05.Text = Form1.sExpBay05;
            sExpBay06.Text = Form1.sExpBay06;
            sExpBay07.Text = Form1.sExpBay07;
            sExpBay08.Text = Form1.sExpBay08;
            sExpBay09.Text = Form1.sExpBay09;
            sExpBay10.Text = Form1.sExpBay10;
            sExpBay11.Text = Form1.sExpBay11;
            sExpBay12.Text = Form1.sExpBay12;
            sExpBay13.Text = Form1.sExpBay13;
            sExpBay14.Text = Form1.sExpBay14;
            sExpBay15.Text = Form1.sExpBay15;
            sExpBay16.Text = Form1.sExpBay16;
            sExpBay17.Text = Form1.sExpBay17;
            sExpBay18.Text = Form1.sExpBay18;
            sExpBay19.Text = Form1.sExpBay19;
            sExpBay20.Text = Form1.sExpBay20;

        }

        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Panel grd = mainSheetPanel;
                Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
                grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));

                sAntiHackCheck.DrawToBitmap(bmp, new Rectangle(sAntiHackCheck.Location.X, sAntiHackCheck.Location.Y, grd.Width, grd.Height));
                sBiolocksCheck.DrawToBitmap(bmp, new Rectangle(sBiolocksCheck.Location.X, sBiolocksCheck.Location.Y, grd.Width, grd.Height));
                sSelfDestructCheck.DrawToBitmap(bmp, new Rectangle(sSelfDestructCheck.Location.X, sSelfDestructCheck.Location.Y, grd.Width, grd.Height));
                RectangleF bounds = e.PageSettings.PrintableArea;
                float factor = ((float)bmp.Height / (float)bmp.Width);
                e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
                foreach (var v in formData())
                {
                    e.Graphics.DrawString(v.Text, new Font("Microsoft Sans Serif", 9, FontStyle.Regular), Brushes.Black, v.Location.X, v.Location.Y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex + " // Something went wrong.");
            }
        }

        private List<Label> formData()
        {
            List<Label> data = new List<Label>();
            data.Add(sName);
            data.Add(sMake);
            data.Add(sModel);
            data.Add(sTier);
            data.Add(sBuildPointTotal);
            data.Add(sBuildPointsUsed);
            data.Add(sFrame);
            data.Add(sManeuver);
            data.Add(sSize);
            data.Add(sPowerCore);
            data.Add(sSensors);
            data.Add(sSensorRange);
            data.Add(sSensorMod);
            data.Add(sComputer);
            data.Add(sCompBonus);
            data.Add(sCompNodes);
            data.Add(sThrusters);
            data.Add(sThrusterSpeed);
            data.Add(sHyperspaceEngine);
            data.Add(sHyperspaceRating);
            data.Add(sHPTotal);
            data.Add(sDT);
            data.Add(sCT);
            data.Add(sArmor);
            data.Add(sACTotal);
            data.Add(sACBonus);
            data.Add(sACMisc);
            data.Add(sSizeMod01);
            data.Add(sSizeMod02);
            data.Add(sPilotMod);
            data.Add(sPilotMod01);
            data.Add(sPilotMod02);
            data.Add(sCountermeasures);
            data.Add(sTLTotal);
            data.Add(sTLBonus);
            data.Add(sTLMiscMod);
            data.Add(sShields);
            data.Add(sShieldsRegen);
            data.Add(sShieldsTotal);
            data.Add(sSensors);
            data.Add(sSensorRange);
            data.Add(sSensorMod);
            data.Add(sFWPN01);
            data.Add(sFWPN02);
            data.Add(sFWPN03);
            data.Add(sFWPN04);
            data.Add(sFDMG01);
            data.Add(sFDMG02);
            data.Add(sFDMG03);
            data.Add(sFDMG04);
            data.Add(sPWPN01);
            data.Add(sPWPN02);
            data.Add(sPWPN03);
            data.Add(sPWPN04);
            data.Add(sPDMG01);
            data.Add(sPDMG02);
            data.Add(sPDMG03);
            data.Add(sPDMG04);
            data.Add(sSWPN01);
            data.Add(sSWPN02);
            data.Add(sSWPN03);
            data.Add(sSWPN04);
            data.Add(sSDMG01);
            data.Add(sSDMG02);
            data.Add(sSDMG03);
            data.Add(sSDMG04);
            data.Add(sTWPN01);
            data.Add(sTWPN02);
            data.Add(sTWPN03);
            data.Add(sTWPN04);
            data.Add(sTDMG01);
            data.Add(sTDMG02);
            data.Add(sTDMG03);
            data.Add(sTDMG04);
            data.Add(sAWPN01);
            data.Add(sAWPN02);
            data.Add(sAWPN03);
            data.Add(sAWPN04);
            data.Add(sADMG01);
            data.Add(sADMG02);
            data.Add(sADMG03);
            data.Add(sADMG04);
            data.Add(sExpBay01);
            data.Add(sExpBay02);
            data.Add(sExpBay03);
            data.Add(sExpBay04);
            data.Add(sExpBay05);
            data.Add(sExpBay06);
            data.Add(sExpBay07);
            data.Add(sExpBay08);
            data.Add(sExpBay09);
            data.Add(sExpBay10);
            data.Add(sExpBay11);
            data.Add(sExpBay12);
            data.Add(sExpBay13);
            data.Add(sExpBay14);
            data.Add(sExpBay15);
            data.Add(sExpBay16);
            data.Add(sExpBay17);
            data.Add(sExpBay18);
            data.Add(sExpBay19);
            data.Add(sExpBay20);
            return data;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
        }

        private void exportToBMPButton_Click(object sender, EventArgs e)
        {
            Panel grd = mainSheetPanel;
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            foreach (var v in formData())
            {
                v.DrawToBitmap(bmp, new Rectangle(v.Location.X, v.Location.Y, grd.Width, grd.Height));
            }
            bmp.Save("image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void saveAsPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // string variable for pdf template
                string pathin = "shipSheetTemplate.pdf";
                // Get template from resource
                System.IO.File.WriteAllBytes(pathin, global::Starfinder_Starship_Hanger.Properties.Resources.shipSheetTemplate);
                // string varibale for pdf template
                string pathout = "";
                // instantiate savefile dialog
                SaveFileDialog saveFile = new SaveFileDialog();
                // set pdf save filter
                saveFile.Filter = "PDF Files|*.pdf";
                // set filter index to use pdf
                saveFile.FilterIndex = 0;
                // string to hold filename
                string fileName = string.Empty;
                // open save file dialog
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // save the file
                    fileName = saveFile.FileName;
                    // get the file path and put in pathout
                    pathout = System.IO.Path.GetFullPath(saveFile.FileName);
                }
                else
                {
                    return;
                }
                // Creates a new pdf using template
                PdfReader reader = new PdfReader(pathin);
                // select page 1
                reader.SelectPages("1");
                // stamp writes info to pdf to save
                PdfStamper stamp = new PdfStamper(reader, new FileStream(pathout, FileMode.Create));
                // Set the fields
                AcroFields pdfFields = stamp.AcroFields;
                // format for fields = pdfFields.SetField("form field name", "input");
                pdfFields.SetField("shipNameField", Form1.sName);
                pdfFields.SetField("shipMakeField", Form1.sMake);
                pdfFields.SetField("shipModelField", Form1.sModel);
                pdfFields.SetField("shipFrameField", Form1.sFrame);
                pdfFields.SetField("shipTierField", Form1.sTier);
                pdfFields.SetField("shipManeuvField", Form1.sManuever);
                pdfFields.SetField("shipSizeField", Form1.sSize);
                pdfFields.SetField("armorSizeModField", Form1.sSizeMod);
                pdfFields.SetField("cmSizeModField", Form1.sSizeMod);
                pdfFields.SetField("shipSizeNumField", Form1.sSizeNumber);
                pdfFields.SetField("shipPowCoreField", Form1.sPowerCore1);
                pdfFields.SetField("totalPcuField", Form1.sPCUTotal);
                pdfFields.SetField("shipSensorField", Form1.sSensors);
                pdfFields.SetField("sensorRangeField", Form1.sSensorRange);
                pdfFields.SetField("sensorModField", Form1.sSensorMod);
                pdfFields.SetField("shipCpuField", Form1.sComputer);
                pdfFields.SetField("shipQtrsField", Form1.sQuarters);                           // Added
                pdfFields.SetField("shipNodeField", Form1.sCompNodes);
                pdfFields.SetField("shipCpuBonusField", Form1.sCompBonus);
                pdfFields.SetField("shipThrusterField", Form1.sThrusters);
                pdfFields.SetField("shipThrusterSpdField", Form1.sThrusterSpeed);
                pdfFields.SetField("shipArmorField", Form1.sArmor);
                pdfFields.SetField("totalArmorClassField", Form1.sACTotal);
                pdfFields.SetField("armorClassBonusField", Form1.sACBonus);
                pdfFields.SetField("totalBpField", Form1.sBuildPointsTotal);
                pdfFields.SetField("usedBpField", Form1.sBuildPointsUsed);
                pdfFields.SetField("totalHPField", Form1.sHPTotal);
                pdfFields.SetField("dmgThresholdField", Form1.sDT);
                pdfFields.SetField("critThresholdField", Form1.sCT);
                pdfFields.SetField("counterMeasureField", Form1.sCountermeasures);
                pdfFields.SetField("totalTargetLockField", Form1.sTLTotal);
                pdfFields.SetField("targetLockBonusField", Form1.sTLBonus);
                pdfFields.SetField("shipHypEngField", Form1.sHyperspaceEngine);
                pdfFields.SetField("shipHypEngRateField", Form1.sHyperspaceRating);
                pdfFields.SetField("shipShieldField", Form1.sShields);
                pdfFields.SetField("totalSPField", Form1.sShieldTotal);
                pdfFields.SetField("shieldRegenField", Form1.sShieldRegen);
                pdfFields.SetField("expBay1Field", Form1.sExpBay01);
                pdfFields.SetField("expBay2Field", Form1.sExpBay02);
                pdfFields.SetField("expBay3Field", Form1.sExpBay03);
                pdfFields.SetField("expBay4Field", Form1.sExpBay04);
                pdfFields.SetField("expBay5Field", Form1.sExpBay05);
                pdfFields.SetField("expBay6Field", Form1.sExpBay06);
                pdfFields.SetField("expBay7Field", Form1.sExpBay07);
                pdfFields.SetField("expBay8Field", Form1.sExpBay08);
                pdfFields.SetField("expBay9Field", Form1.sExpBay09);
                pdfFields.SetField("expBay10Field", Form1.sExpBay10);
                pdfFields.SetField("expBay11Field", Form1.sExpBay11);
                pdfFields.SetField("expBay12Field", Form1.sExpBay12);
                pdfFields.SetField("expBay13Field", Form1.sExpBay13);
                pdfFields.SetField("expBay14Field", Form1.sExpBay14);
                pdfFields.SetField("expBay15Field", Form1.sExpBay15);
                pdfFields.SetField("expBay16Field", Form1.sExpBay16);
                pdfFields.SetField("expBay17Field", Form1.sExpBay17);
                pdfFields.SetField("expBay18Field", Form1.sExpBay18);
                pdfFields.SetField("expBay19Field", Form1.sExpBay19);
                pdfFields.SetField("expBay20Field", Form1.sExpBay20);
                // pdfFields.SetField("expBay21Field", ); if needed for future use
                // pdfFields.SetField("expBay22Field", ); if needed for future use
                // Forward weapons
                pdfFields.SetField("forWpn1Field", Form1.sFWPNS01);
                pdfFields.SetField("forWpn2Field", Form1.sFWPNS02);
                pdfFields.SetField("forWpn3Field", Form1.sFWPNS03);
                pdfFields.SetField("forWpn4Field", Form1.sFWPNS04);
                pdfFields.SetField("forDmg1Field", Form1.sFDMG01);
                pdfFields.SetField("forDmg2Field", Form1.sFDMG02);
                pdfFields.SetField("forDmg3Field", Form1.sFDMG03);
                pdfFields.SetField("forDmg4Field", Form1.sFDMG04);
                if(Form1.sFWPNS01 == Form1.forwLinkChkBox1Type)                             // Added
                {
                    pdfFields.SetField("forwLink1Field", "Yes");
                }
                else if (Form1.sFWPNS01 == Form1.forwLinkChkBox2Type)
                {
                    pdfFields.SetField("forwLink1Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("forwLink1Field", "No");
                }
                if (Form1.sFWPNS02 == Form1.forwLinkChkBox1Type)
                {
                    pdfFields.SetField("forwLink2Field", "Yes");
                }
                else if (Form1.sFWPNS02 == Form1.forwLinkChkBox2Type)
                {
                    pdfFields.SetField("forwLink2Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("forwLink2Field", "No");
                }
                if (Form1.sFWPNS03 == Form1.forwLinkChkBox1Type)
                {
                    pdfFields.SetField("forwLink3Field", "Yes");
                }
                else if (Form1.sFWPNS03 == Form1.forwLinkChkBox2Type)
                {
                    pdfFields.SetField("forwLink3Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("forwLink3Field", "No");
                }
                if (Form1.sFWPNS04 == Form1.forwLinkChkBox1Type)
                {
                    pdfFields.SetField("forwLink4Field", "Yes");
                }
                else if (Form1.sFWPNS04 == Form1.forwLinkChkBox2Type)
                {
                    pdfFields.SetField("forwLink4Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("forwLink4Field", "No");
                }
                // Port weapons
                pdfFields.SetField("porWpn1Field", Form1.sPWPNS01);
                pdfFields.SetField("porWpn2Field", Form1.sPWPNS02);
                pdfFields.SetField("porWpn3Field", Form1.sPWPNS03);
                pdfFields.SetField("porWpn4Field", Form1.sPWPNS04);
                pdfFields.SetField("porDmg1Field", Form1.sPDMG01);
                pdfFields.SetField("porDmg2Field", Form1.sPDMG02);
                pdfFields.SetField("porDmg3Field", Form1.sPDMG03);
                pdfFields.SetField("porDmg4Field", Form1.sPDMG04);
                if (Form1.sPWPNS01 == Form1.portLinkChkBox1Type)
                {
                    pdfFields.SetField("portLink1Field", "Yes");
                }
                else if (Form1.sPWPNS01 == Form1.portLinkChkBox2Type)
                {
                    pdfFields.SetField("portLink1Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("portLink1Field", "No");
                }
                if (Form1.sPWPNS02 == Form1.portLinkChkBox1Type)
                {
                    pdfFields.SetField("portLink2Field", "Yes");
                }
                else if (Form1.sPWPNS02 == Form1.portLinkChkBox2Type)
                {
                    pdfFields.SetField("portLink2Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("portLink2Field", "No");
                }
                if (Form1.sPWPNS03 == Form1.portLinkChkBox1Type)
                {
                    pdfFields.SetField("portLink3Field", "Yes");
                }
                else if (Form1.sPWPNS03 == Form1.portLinkChkBox2Type)
                {
                    pdfFields.SetField("portLink3Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("portLink3Field", "No");
                }
                if (Form1.sPWPNS04 == Form1.portLinkChkBox1Type)
                {
                    pdfFields.SetField("portLink4Field", "Yes");
                }
                else if (Form1.sPWPNS04 == Form1.portLinkChkBox2Type)
                {
                    pdfFields.SetField("portLink4Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("portLink4Field", "No");
                }
                // Starboard weapons
                pdfFields.SetField("starWpn1Field", Form1.sSWPNS01);
                pdfFields.SetField("starWpn2Field", Form1.sSWPNS02);
                pdfFields.SetField("starWpn3Field", Form1.sSWPNS03);
                pdfFields.SetField("starWpn4Field", Form1.sSWPNS04);
                pdfFields.SetField("starDmg1Field", Form1.sSDMG01);
                pdfFields.SetField("starDmg2Field", Form1.sSDMG02);
                pdfFields.SetField("starDmg3Field", Form1.sSDMG03);
                pdfFields.SetField("starDmg4Field", Form1.sSDMG04);
                if (Form1.sSWPNS01 == Form1.starbLinkChkBox1Type)
                {
                    pdfFields.SetField("starbLink1Field", "Yes");
                }
                else if (Form1.sSWPNS01 == Form1.starbLinkChkBox2Type)
                {
                    pdfFields.SetField("starbLink1Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("starbLink1Field", "No");
                }
                if (Form1.sSWPNS02 == Form1.starbLinkChkBox1Type)
                {
                    pdfFields.SetField("starbLink2Field", "Yes");
                }
                else if (Form1.sSWPNS02 == Form1.starbLinkChkBox2Type)
                {
                    pdfFields.SetField("starbLink2Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("starbLink2Field", "No");
                }
                if (Form1.sSWPNS03 == Form1.starbLinkChkBox1Type)
                {
                    pdfFields.SetField("starbLink3Field", "Yes");
                }
                else if (Form1.sSWPNS03 == Form1.starbLinkChkBox2Type)
                {
                    pdfFields.SetField("starbLink3Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("starbLink3Field", "No");
                }
                if (Form1.sSWPNS04 == Form1.starbLinkChkBox1Type)
                {
                    pdfFields.SetField("starbLink4Field", "Yes");
                }
                else if (Form1.sSWPNS04 == Form1.starbLinkChkBox2Type)
                {
                    pdfFields.SetField("starbLink4Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("starbLink4Field", "No");
                }
                // Turret weapons
                pdfFields.SetField("turWpn1Field", Form1.sTWPNS01);
                pdfFields.SetField("turWpn2Field", Form1.sTWPNS02);
                pdfFields.SetField("turWpn3Field", Form1.sTWPNS03);
                pdfFields.SetField("turWpn4Field", Form1.sTWPNS04);
                pdfFields.SetField("turDmg1Field", Form1.sTDMG01);
                pdfFields.SetField("turDmg2Field", Form1.sTDMG02);
                pdfFields.SetField("turDmg3Field", Form1.sTDMG03);
                pdfFields.SetField("turDmg4Field", Form1.sTDMG04);
                if (Form1.sTWPNS01 == Form1.turLinkChkBox1Type)
                {
                    pdfFields.SetField("turLink1Field", "Yes");
                }
                else if (Form1.sTWPNS01 == Form1.turLinkChkBox2Type)
                {
                    pdfFields.SetField("turLink1Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("turLink1Field", "No");
                }
                if (Form1.sTWPNS02 == Form1.turLinkChkBox1Type)
                {
                    pdfFields.SetField("turLink2Field", "Yes");
                }
                else if (Form1.sTWPNS02 == Form1.turLinkChkBox2Type)
                {
                    pdfFields.SetField("turLink2Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("turLink2Field", "No");
                }
                if (Form1.sTWPNS03 == Form1.turLinkChkBox1Type)
                {
                    pdfFields.SetField("turLink3Field", "Yes");
                }
                else if (Form1.sTWPNS03 == Form1.turLinkChkBox2Type)
                {
                    pdfFields.SetField("turLink3Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("turLink3Field", "No");
                }
                if (Form1.sTWPNS04 == Form1.turLinkChkBox1Type)
                {
                    pdfFields.SetField("turLink4Field", "Yes");
                }
                else if (Form1.sTWPNS04 == Form1.turLinkChkBox2Type)
                {
                    pdfFields.SetField("turLink4Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("turLink4Field", "No");
                }
                // Aft weapons
                pdfFields.SetField("aftWpn1Field", Form1.sAWPNS01);
                pdfFields.SetField("aftWpn2Field", Form1.sAWPNS02);
                pdfFields.SetField("aftWpn3Field", Form1.sAWPNS03);
                pdfFields.SetField("aftWpn4Field", Form1.sAWPNS04);
                pdfFields.SetField("aftDmg1Field", Form1.sADMG01);
                pdfFields.SetField("aftDmg2Field", Form1.sADMG02);
                pdfFields.SetField("aftDmg3Field", Form1.sADMG03);
                pdfFields.SetField("aftDmg4Field", Form1.sADMG04);
                if (Form1.sAWPNS01 == Form1.aftLinkChkBox1Type)
                {
                    pdfFields.SetField("aftLink1Field", "Yes");
                }
                else if (Form1.sAWPNS01 == Form1.aftLinkChkBox2Type)
                {
                    pdfFields.SetField("aftLink1Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("aftLink1Field", "No");
                }
                if (Form1.sAWPNS02 == Form1.aftLinkChkBox1Type)
                {
                    pdfFields.SetField("aftLink2Field", "Yes");
                }
                else if (Form1.sAWPNS02 == Form1.aftLinkChkBox2Type)
                {
                    pdfFields.SetField("aftLink2Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("aftLink2Field", "No");
                }
                if (Form1.sAWPNS03 == Form1.aftLinkChkBox1Type)
                {
                    pdfFields.SetField("aftLink3Field", "Yes");
                }
                else if (Form1.sAWPNS03 == Form1.aftLinkChkBox2Type)
                {
                    pdfFields.SetField("aftLink3Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("aftLink3Field", "No");
                }
                if (Form1.sAWPNS04 == Form1.aftLinkChkBox1Type)
                {
                    pdfFields.SetField("aftLink4Field", "Yes");
                }
                else if (Form1.sAWPNS04 == Form1.aftLinkChkBox2Type)
                {
                    pdfFields.SetField("aftLink4Field", "Yes");
                }
                else
                {
                    pdfFields.SetField("aftLink4Field", "No");
                }                                                                           // Added
                // Antihack, biolock, selfdestruct check boxes
                if (Form1.sCompAntiHack)
                {
                    pdfFields.SetField("antiHackCheckBox", "Yes");
                }
                else
                {
                    pdfFields.SetField("antiHackCheckBox", "No");
                }
                if (Form1.sBiolocks)
                {
                    pdfFields.SetField("biolockCheckBox", "Yes");
                }
                else
                {
                    pdfFields.SetField("biolockCheckBox", "No");
                }
                if (Form1.sSelfDestruct)
                {
                    pdfFields.SetField("selfDestructCheckBox", "Yes");
                }
                else
                {
                    pdfFields.SetField("selfDestructCheckBox", "No");
                }
                // Makes pdf uneditable
                stamp.FormFlattening = false;
                // Close stamp and reader
                stamp.Close();
                reader.Close();
                // opens saved pdf
                System.Diagnostics.Process.Start(pathout);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

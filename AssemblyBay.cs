using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class AssemblyBay
    {


        #region Construct Elements

        public List<Tier> ConstructTierLoad()       // This Method pulls data from the database and creates a list out of it.
        {
            


            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.Starship_TierTableAdapter TierAdapt = 
                new SFDataBaseDataSetTableAdapters.Starship_TierTableAdapter();             // *** NEW *** Creates the Table Adapter.

            TierAdapt.Fill(Data.Starship_Tier);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable TierTable = TierAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<Tier> TierCatalog = new List<Tier>();                                      // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < TierTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                Tier tier = new Tier();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.


                tier.Type = TierTable.Rows[i]["Tier_Type"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                tier.Bp = Convert.ToInt32(TierTable.Rows[i]["Tier_Bp"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable BP
                tier.HpInc = Convert.ToBoolean(Convert.ToInt32(TierTable.Rows[i]["HpInc"/* PULLED FROM SERVER EXPLORER*/])); // *** NEW *** Assigns Class TIER Variable HPINC
                tier.HpIncMulti = Convert.ToInt32(TierTable.Rows[i]["HpIncMulti"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable HPINCMULTI
                TierCatalog.Add(tier);
            }

            #region OLD CODE
            //TierCatalog.Add(tier.None());                          OLD STUFF THAT PULLS FROM CLASSES
            //TierCatalog.Add(tier.OneFourth());
            //TierCatalog.Add(tier.OneThird());
            //TierCatalog.Add(tier.OneHalf());
            //TierCatalog.Add(tier.One());
            //TierCatalog.Add(tier.Two());
            //TierCatalog.Add(tier.Three());
            //TierCatalog.Add(tier.Four());
            //TierCatalog.Add(tier.Five());
            //TierCatalog.Add(tier.Six());
            //TierCatalog.Add(tier.Seven());
            //TierCatalog.Add(tier.Eight());
            //TierCatalog.Add(tier.Nine());
            //TierCatalog.Add(tier.Ten());
            //TierCatalog.Add(tier.Eleven());
            //TierCatalog.Add(tier.Twelve());
            //TierCatalog.Add(tier.Thirteen());
            //TierCatalog.Add(tier.Fourteen());
            //TierCatalog.Add(tier.Fifteen());
            //TierCatalog.Add(tier.Sixteen());
            //TierCatalog.Add(tier.Seventeen());
            //TierCatalog.Add(tier.Eighteen());
            //TierCatalog.Add(tier.Nineteen());
            //TierCatalog.Add(tier.Twenty());
            #endregion

            return TierCatalog;
        }

        public List<BaseFrame> ConstructFrameLoad()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.Base_FrameTableAdapter bFrame =
                new SFDataBaseDataSetTableAdapters.Base_FrameTableAdapter();             // *** NEW *** Creates the Table Adapter.

            bFrame.Fill(Data.Base_Frame);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable BaseTable = bFrame.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<BaseFrame> FramesCatalog = new List<BaseFrame>();                                     // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < BaseTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                BaseFrame frame = new BaseFrame();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.
                string handle = "Empty";

                frame.Type = BaseTable.Rows[i]["Frame_Type"/* PULLED FROM SERVER EXPLORER*/].ToString();


                frame.Size = BaseTable.Rows[i]["Frame_Size"/* PULLED FROM SERVER EXPLORER*/].ToString();

                #region
                if (frame.MR == null) { frame.MR = handle; } else { frame.MR = BaseTable.Rows[i]["MR"].ToString(); }
                    frame.MRpiloting = Convert.ToInt32(BaseTable.Rows[i]["MRPiloting"]);
                frame.MRturn = Convert.ToInt32(BaseTable.Rows[i]["MRTurn"/* PULLED FROM SERVER EXPLORER*/]);
                frame.Hp = Convert.ToInt32(BaseTable.Rows[i]["Hp"/* PULLED FROM SERVER EXPLORER*/]); 
                frame.HpIncriment = Convert.ToInt32(BaseTable.Rows[i]["HpIncrement"/* PULLED FROM SERVER EXPLORER*/]);
                frame.Dt = Convert.ToInt32(BaseTable.Rows[i]["Dt"/* PULLED FROM SERVER EXPLORER*/]);
                frame.Ct = Convert.ToInt32(BaseTable.Rows[i]["Ct"/* PULLED FROM SERVER EXPLORER*/]);
                frame.ForwardArcSize1 = BaseTable.Rows[i]["ForwardArcSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();
                frame.ForwardArcNum1 = Convert.ToInt32(BaseTable.Rows[i]["ForwardArcNum1"/* PULLED FROM SERVER EXPLORER*/]);
                frame.ForwardArcSize2 = BaseTable.Rows[i]["ForwardArcSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();
                try { frame.ForwardArcNum2 = Convert.ToInt32(BaseTable.Rows[i]["ForwardArcNum2"]); } catch {frame.ForwardArcNum2 = 0; }

                try
                {
                    frame.ForwardArcSize3 = BaseTable.Rows[i]["ForwardArcSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("ForwardArcSize3", typeof(string));
                }

                try
                {
                    frame.ForwardArcNum3 = Convert.ToInt32(BaseTable.Rows[i]["ForwardArcNum2"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.ForwardArcNum3 = 0;
                }

                try
                {
                    frame.ForwardArcSize4 = BaseTable.Rows[i]["ForwardArcSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("ForwardArcSize4", typeof(string));
                }


                //frame.ForwardArcNum4 = Convert.ToInt32(BaseTable.Rows[i]["ForwardArcNum4"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable HPINCMULTI
                try
                {
                    frame.ForwardArcNum4 = Convert.ToInt32(BaseTable.Rows[i]["ForwardArcNum2"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.ForwardArcNum4 = 0;
                }
                  // *** NEW *** Assigns Class TIER Variable TYPE
                //
                try
                {
                    frame.PortArcSize1 = BaseTable.Rows[i]["PortArcSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("PortArcSize1", typeof(string));
                }
                //
                //frame.PortArcNum1 = Convert.ToInt32(BaseTable.Rows[i]["PortArcNum1"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable HPINCMULTI
                try
                {
                    frame.PortArcNum1 = Convert.ToInt32(BaseTable.Rows[i]["PortArcNum1"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.PortArcNum1 = 0;
                }
                //frame.PortArcSize2 = BaseTable.Rows[i]["PortArcSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.PortArcSize2 = BaseTable.Rows[i]["PortArcSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("PortArcSize2", typeof(string));
                }


                try
                {
                    frame.PortArcNum2 = Convert.ToInt32(BaseTable.Rows[i]["PortArcNum2"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.PortArcNum2 = 0;
                }
                //frame.PortArcSize3 = BaseTable.Rows[i]["PortArcSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE

                //
                try
                {
                    frame.PortArcSize3 = BaseTable.Rows[i]["PortArcSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("PortArcSize3", typeof(string));
                }
                //

                try
                {
                    frame.PortArcNum3 = Convert.ToInt32(BaseTable.Rows[i]["PortArcNum3"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.PortArcNum3 = 0;
                }
                //frame.PortArcSize4 = BaseTable.Rows[i]["PortArcSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                                                                                                                    //
                try
                {
                    frame.PortArcSize4 = BaseTable.Rows[i]["PortArcSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("PortArcSize4", typeof(string));
                }
                //

                try
                {
                    frame.PortArcNum4 = Convert.ToInt32(BaseTable.Rows[i]["PortArcNum4"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.PortArcNum4 = 0;
                }
                //frame.StarboardArcSize1 = BaseTable.Rows[i]["StarboardArcSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                                                                                                                              //
                try
                {
                    frame.StarboardArcSize1 = BaseTable.Rows[i]["StarboardArcSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("StarboardArcSize1", typeof(string));
                }
                //

                try
                {
                    frame.StarboardArcNum1 = Convert.ToInt32(BaseTable.Rows[i]["StarboardArcNum1"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.StarboardArcNum1 = 0;
                }
                //frame.StarboardArcSize2 = BaseTable.Rows[i]["StarboardArcSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                //
                try
                {
                    frame.StarboardArcSize2 = BaseTable.Rows[i]["StarboardArcSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("StarboardArcSize2", typeof(string));
                }
                //
                try
                {
                    frame.StarboardArcNum2 = Convert.ToInt32(BaseTable.Rows[i]["StarboardArcNum2"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.StarboardArcNum2 = 0;
                }
                //frame.StarboardArcSize3 = BaseTable.Rows[i]["StarboardArcSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.StarboardArcSize3 = BaseTable.Rows[i]["StarboardArcSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("StarboardArcSize3", typeof(string));
                }

                try
                {
                    frame.StarboardArcNum3 = Convert.ToInt32(BaseTable.Rows[i]["StarboardArcNum3"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.StarboardArcNum3 = 0;
                }
                //frame.StarboardArcSize4 = BaseTable.Rows[i]["StarboardArcSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.StarboardArcSize4 = BaseTable.Rows[i]["StarboardArcSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("StarboardArcSize4", typeof(string));
                }

                try
                {
                    frame.StarboardArcNum4 = Convert.ToInt32(BaseTable.Rows[i]["StarboardArcNum4"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.StarboardArcNum4 = 0;
                }
                //frame.AftArcSize1 = BaseTable.Rows[i]["AftArcSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.AftArcSize1 = BaseTable.Rows[i]["AftArcSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("AftArcSize1", typeof(string));
                }

                try
                {
                    frame.AftArcNum1 = Convert.ToInt32(BaseTable.Rows[i]["AftArcNum1"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.AftArcNum1 = 0;
                }
                //frame.AftArcSize2 = BaseTable.Rows[i]["AftArcSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.AftArcSize2 = BaseTable.Rows[i]["AftArcSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("AftArcSize2", typeof(string));
                }

                try
                {
                    frame.AftArcNum2 = Convert.ToInt32(BaseTable.Rows[i]["AftArcNum2"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.AftArcNum2 = 0;
                }
                //frame.AftArcSize3 = BaseTable.Rows[i]["AftArcSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.AftArcSize3 = BaseTable.Rows[i]["AftArcSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("AftArcSize3", typeof(string));
                }

                try
                {
                    frame.AftArcNum3 = Convert.ToInt32(BaseTable.Rows[i]["AftArcNum3"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.AftArcNum3 = 0;
                }
                //frame.AftArcSize4 = BaseTable.Rows[i]["AftArcSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.AftArcSize4 = BaseTable.Rows[i]["AftArcSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("AftArcSize4", typeof(string));
                }

                try
                {
                    frame.AftArcNum4 = Convert.ToInt32(BaseTable.Rows[i]["AftArcNum4"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.AftArcNum4 = 0;
                }
                //frame.TurretSize1 = BaseTable.Rows[i]["TurretSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.TurretSize1 = BaseTable.Rows[i]["TurretSize1"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("TurretSize1", typeof(string));
                }

                try
                {
                    frame.TurretNum1 = Convert.ToInt32(BaseTable.Rows[i]["TurretNum1"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.TurretNum1 = 0;
                }
                //frame.TurretSize2 = BaseTable.Rows[i]["TurretSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.TurretSize2 = BaseTable.Rows[i]["TurretSize2"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("TurretSize2", typeof(string));
                }


                try
                {
                    frame.TurretNum2 = Convert.ToInt32(BaseTable.Rows[i]["TurretNum2"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.TurretNum2 = 0;
                }
                //frame.TurretSize3 = BaseTable.Rows[i]["TurretSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.TurretSize3 = BaseTable.Rows[i]["TurretSize3"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("TurretSize3", typeof(string));
                }


                try
                {
                    frame.TurretNum3 = Convert.ToInt32(BaseTable.Rows[i]["TurretNum3"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.TurretNum3 = 0;
                }
                //frame.TurretSize4 = BaseTable.Rows[i]["TurretSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();  // *** NEW *** Assigns Class TIER Variable TYPE
                try
                {
                    frame.TurretSize4 = BaseTable.Rows[i]["TurretSize4"/* PULLED FROM SERVER EXPLORER*/].ToString();
                }
                catch
                {
                    BaseTable.Columns.Add("TurretSize4", typeof(string));
                }


                try
                {
                    frame.TurretNum4 = Convert.ToInt32(BaseTable.Rows[i]["TurretNum4"/* PULLED FROM SERVER EXPLORER*/]);
                }
                catch
                {
                    frame.TurretNum4 = 0;
                }
                try
                {
                    frame.ExpansionBaysNum = Convert.ToInt32(BaseTable.Rows[i]["ExpansionBaysNum"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable HPINCMULTI
                }
                catch
                {
                    //BaseTable.Columns.Add("ExpansionBaysNum", typeof(Int32));
                }
                //
                try
                {
                    frame.HangarMust = Convert.ToBoolean(Convert.ToInt32(BaseTable.Rows[i]["HangarMust"/* PULLED FROM SERVER EXPLORER*/])); // *** NEW *** Assigns Class TIER Variable HPINC
                }
                catch
                {
                    //BaseTable.Columns.Add("HangarMust", typeof(bool));
                }
                //
                try
                {
                    frame.MinCrew = Convert.ToInt32(BaseTable.Rows[i]["MinCrew"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable HPINCMULTI
                }
                catch
                {
                    //BaseTable.Columns.Add("MinCrew",typeof(Int32));
                }

                try
                {
                    frame.MaxCrew = Convert.ToInt32(BaseTable.Rows[i]["MaxCrew"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable HPINCMULTI
                }
                catch
                {
                    //BaseTable.Columns.Add("MaxCrew", typeof(Int32));
                }
                //
                try
                {
                    frame.BPCost = Convert.ToInt32(BaseTable.Rows[i]["BPCost"/* PULLED FROM SERVER EXPLORER*/]); // *** NEW *** Assigns Class TIER Variable HPINCMULTI
                }
                catch
                {
                    //BaseTable.Columns.Add("BPCost", typeof(Int32));
                }
                #endregion
                FramesCatalog.Add(frame);
            }

            #region
            //BaseFrame frame = new BaseFrame();
            //List<BaseFrame> FramesCatalog = new List<BaseFrame>();
            //FramesCatalog.Add(frame.None());
            //FramesCatalog.Add(frame.Racer());
            //FramesCatalog.Add(frame.Interceptor());
            //FramesCatalog.Add(frame.Fighter());
            //FramesCatalog.Add(frame.Shuttle());
            //FramesCatalog.Add(frame.LightFreighter());
            //FramesCatalog.Add(frame.Explorer());
            //FramesCatalog.Add(frame.Transport());
            //FramesCatalog.Add(frame.Destroyer());
            //FramesCatalog.Add(frame.HeavyFreighter());
            //FramesCatalog.Add(frame.BulkFreighter());
            //FramesCatalog.Add(frame.Cruiser());
            //FramesCatalog.Add(frame.Carrier());
            //FramesCatalog.Add(frame.Battleship());
            //FramesCatalog.Add(frame.Dreadnought());
            #endregion
            return FramesCatalog;
        }

        public List<PowerCore> ConstructPowerCoreLoad()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.PowerCoreTableAdapter pAdapt =
                new SFDataBaseDataSetTableAdapters.PowerCoreTableAdapter();             // *** NEW *** Creates the Table Adapter.

            pAdapt.Fill(Data.PowerCore);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable PowerTable = pAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<PowerCore> PowerCoreCatalog = new List<PowerCore>();                                     // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < PowerTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                PowerCore core = new PowerCore();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

                try{core.Type = PowerTable.Rows[i]["PowerCore_Type"].ToString(); } catch { }
                try { core.Size01 = PowerTable.Rows[i]["Size01"].ToString(); }catch { }
                core.Size01 = PowerTable.Rows[i]["Size01"].ToString();
                core.Size02 = PowerTable.Rows[i]["Size02"].ToString();
                core.Size03 = PowerTable.Rows[i]["Size03"].ToString();
                try{ core.PCU = Convert.ToInt32(PowerTable.Rows[i]["PowerCore_Pcu"]); }catch { }
                try{core.BPCost = Convert.ToInt32(PowerTable.Rows[i]["PowerCore_BPCost"]); }catch { }
                PowerCoreCatalog.Add(core);
            }
            #region
            //PowerCore core = new PowerCore();
            //List<PowerCore> PowerCoreCatalog = new List<PowerCore>();
            //PowerCoreCatalog.Add(core.None());
            //PowerCoreCatalog.Add(core.MicronLight());
            //PowerCoreCatalog.Add(core.MicronHeavy());
            //PowerCoreCatalog.Add(core.MicronUltra());
            //PowerCoreCatalog.Add(core.ArcusLight());
            //PowerCoreCatalog.Add(core.PulseBrown());
            //PowerCoreCatalog.Add(core.PulseBlack());
            //PowerCoreCatalog.Add(core.PulseWhite());
            //PowerCoreCatalog.Add(core.PulseGrey());
            //PowerCoreCatalog.Add(core.ArcusHeavy());
            //PowerCoreCatalog.Add(core.PulseGreen());
            //PowerCoreCatalog.Add(core.PulseRed());
            //PowerCoreCatalog.Add(core.PulseBlue());
            //PowerCoreCatalog.Add(core.ArcusUltra());
            //PowerCoreCatalog.Add(core.ArcusMaximum());
            //PowerCoreCatalog.Add(core.PulseOrange());
            //PowerCoreCatalog.Add(core.PulsePrismatic());
            //PowerCoreCatalog.Add(core.NovaLight());
            //PowerCoreCatalog.Add(core.NovaHeavy());
            //PowerCoreCatalog.Add(core.NovaUltra());
            //PowerCoreCatalog.Add(core.GatewayLight());
            //PowerCoreCatalog.Add(core.GatewayHeavy());
            //PowerCoreCatalog.Add(core.GatewayUltra());
            #endregion
            return PowerCoreCatalog;
        }

        public List<Thruster> ConstructThrusterLoad()
        {
            Thruster thruster = new Thruster();
            List<Thruster> ThrusterCatalog = new List<Thruster>();
            ThrusterCatalog.Add(thruster.None());
            ThrusterCatalog.Add(thruster.T6());
            ThrusterCatalog.Add(thruster.T8());
            ThrusterCatalog.Add(thruster.T10());
            ThrusterCatalog.Add(thruster.T12());
            ThrusterCatalog.Add(thruster.T14());
            ThrusterCatalog.Add(thruster.S6());
            ThrusterCatalog.Add(thruster.S8());
            ThrusterCatalog.Add(thruster.S10());
            ThrusterCatalog.Add(thruster.S12());
            ThrusterCatalog.Add(thruster.M4());
            ThrusterCatalog.Add(thruster.M8());
            ThrusterCatalog.Add(thruster.M10());
            ThrusterCatalog.Add(thruster.M12());
            ThrusterCatalog.Add(thruster.L4());
            ThrusterCatalog.Add(thruster.L6());
            ThrusterCatalog.Add(thruster.L8());
            ThrusterCatalog.Add(thruster.L10());
            ThrusterCatalog.Add(thruster.H4());
            ThrusterCatalog.Add(thruster.H6());
            ThrusterCatalog.Add(thruster.H8());
            ThrusterCatalog.Add(thruster.H10());
            ThrusterCatalog.Add(thruster.G4());
            ThrusterCatalog.Add(thruster.G6());
            ThrusterCatalog.Add(thruster.G8());
            ThrusterCatalog.Add(thruster.C4());
            ThrusterCatalog.Add(thruster.C6());
            ThrusterCatalog.Add(thruster.C8());
            return ThrusterCatalog;
        }

        public List<Armor> ConstructArmorLoad()
        {
            Armor armor = new Armor();
            List<Armor> ArmorCatalog = new List<Armor>();
            ArmorCatalog.Add(armor.None());
            ArmorCatalog.Add(armor.Mk1());
            ArmorCatalog.Add(armor.Mk2());
            ArmorCatalog.Add(armor.Mk3());
            ArmorCatalog.Add(armor.Mk4());
            ArmorCatalog.Add(armor.Mk5());
            ArmorCatalog.Add(armor.Mk6());
            ArmorCatalog.Add(armor.Mk7());
            ArmorCatalog.Add(armor.Mk8());
            ArmorCatalog.Add(armor.Mk9());
            ArmorCatalog.Add(armor.Mk10());
            ArmorCatalog.Add(armor.Mk11());
            ArmorCatalog.Add(armor.Mk12());
            ArmorCatalog.Add(armor.Mk13());
            ArmorCatalog.Add(armor.Mk14());
            ArmorCatalog.Add(armor.Mk15());
            return ArmorCatalog;
        }

        public List<Computer> ConstructComputerLoad()
        {
            Computer comp = new Computer();
            List<Computer> ComputerCatalog = new List<Computer>();
            ComputerCatalog.Add(comp.None());
            ComputerCatalog.Add(comp.Basic());
            ComputerCatalog.Add(comp.Mk1Mononode());
            ComputerCatalog.Add(comp.Mk1Duonode());
            ComputerCatalog.Add(comp.Mk1Trinode());
            ComputerCatalog.Add(comp.Mk1Tetranode());
            ComputerCatalog.Add(comp.Mk2Mononode());
            ComputerCatalog.Add(comp.Mk2Duonode());
            ComputerCatalog.Add(comp.Mk2Trinode());
            ComputerCatalog.Add(comp.Mk2Tetranode());
            ComputerCatalog.Add(comp.Mk3Mononode());
            ComputerCatalog.Add(comp.Mk3Duonode());
            ComputerCatalog.Add(comp.Mk3Trinode());
            ComputerCatalog.Add(comp.Mk3Tetranode());
            ComputerCatalog.Add(comp.Mk4Mononode());
            ComputerCatalog.Add(comp.Mk4Duonode());
            ComputerCatalog.Add(comp.Mk4Trinode());
            ComputerCatalog.Add(comp.Mk5Mononode());
            ComputerCatalog.Add(comp.Mk5Duonode());
            ComputerCatalog.Add(comp.Mk5Trinode());
            ComputerCatalog.Add(comp.Mk6Mononode());
            ComputerCatalog.Add(comp.Mk6Duonode());
            ComputerCatalog.Add(comp.Mk7Mononode());
            ComputerCatalog.Add(comp.Mk7Duonode());
            ComputerCatalog.Add(comp.Mk8Mononode());
            ComputerCatalog.Add(comp.Mk8Duonode());
            ComputerCatalog.Add(comp.Mk9Mononode());
            ComputerCatalog.Add(comp.Mk9Duonode());
            ComputerCatalog.Add(comp.Mk10Mononode());
            ComputerCatalog.Add(comp.Mk10Duonode());
            return ComputerCatalog;
        }

        public List<Quarters> ConstructQuartersLoad()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.QuartersTableAdapter qAdapt =
                new SFDataBaseDataSetTableAdapters.QuartersTableAdapter();             // *** NEW *** Creates the Table Adapter.

            qAdapt.Fill(Data.Quarters);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable QuartersTable = qAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<Quarters> QuartersCatalog = new List<Quarters>();                                   // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < QuartersTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                Quarters room = new Quarters();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

                try { room.Type = QuartersTable.Rows[i]["Quarters_Type"].ToString(); } catch { }
                try { room.BpCost = Convert.ToInt32(QuartersTable.Rows[i]["Quarters_BpCost"]); } catch { }
                QuartersCatalog.Add(room);
            }
            #region
            //Quarters room = new Quarters();
            //List<Quarters> QuartersCatalog = new List<Quarters>();
            //QuartersCatalog.Add(room.None());
            //QuartersCatalog.Add(room.Common());
            //QuartersCatalog.Add(room.Good());
            //QuartersCatalog.Add(room.Luxurious());
            #endregion
            return QuartersCatalog;
        }

        public List<Countermeasures> ConstructCountermeasuresLoad()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.CountermeasuresTableAdapter countAdapt =
                new SFDataBaseDataSetTableAdapters.CountermeasuresTableAdapter();             // *** NEW *** Creates the Table Adapter.

            countAdapt.Fill(Data.Countermeasures);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable CountTable = countAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<Countermeasures> CMCatalog = new List<Countermeasures>();                                 // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < CountTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                Countermeasures cm = new Countermeasures();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

                try { cm.Type = CountTable.Rows[i]["Countermeasures_Type"].ToString(); } catch { }
                try { cm.TlBonus = Convert.ToInt32(CountTable.Rows[i]["TlBonus"]); } catch { }
                try { cm.Pcu = Convert.ToInt32(CountTable.Rows[i]["Countermeasures_Pcu"]); } catch { }
                try { cm.BpCost = Convert.ToInt32(CountTable.Rows[i]["Countermeasures_BpCost"]); } catch { }
                CMCatalog.Add(cm);
            }
            #region
            //Countermeasures cm = new Countermeasures();
            //List<Countermeasures> CMCatalog = new List<Countermeasures>();
            //CMCatalog.Add(cm.None());
            //CMCatalog.Add(cm.Mk1Defense());
            //CMCatalog.Add(cm.Mk2Defense());
            //CMCatalog.Add(cm.Mk3Defense());
            //CMCatalog.Add(cm.Mk4Defense());
            //CMCatalog.Add(cm.Mk5Defense());
            //CMCatalog.Add(cm.Mk6Defense());
            //CMCatalog.Add(cm.Mk7Defense());
            //CMCatalog.Add(cm.Mk8Defense());
            //CMCatalog.Add(cm.Mk9Defense());
            //CMCatalog.Add(cm.Mk10Defense());
            //CMCatalog.Add(cm.Mk11Defense());
            //CMCatalog.Add(cm.Mk12Defense());
            //CMCatalog.Add(cm.Mk13Defense());
            //CMCatalog.Add(cm.Mk14Defense());
            //CMCatalog.Add(cm.Mk15Defense());
            #endregion
            return CMCatalog;
        }

        public List<HyperspaceEngine> ConstructHyperspaceEngineLoad()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.HyperspaceEngineTableAdapter hAdapt =
                new SFDataBaseDataSetTableAdapters.HyperspaceEngineTableAdapter();             // *** NEW *** Creates the Table Adapter.

            hAdapt.Fill(Data.HyperspaceEngine);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable HyperTable = hAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<HyperspaceEngine> HSEngineCatalog = new List<HyperspaceEngine>();                                // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < HyperTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                HyperspaceEngine engine = new HyperspaceEngine();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

                try { engine.Type = HyperTable.Rows[i]["HyperspaceEngine_Type"].ToString(); } catch { }
                try { engine.Rating = Convert.ToInt32(HyperTable.Rows[i]["Rating"]); } catch { }
                try { engine.MinPCU = Convert.ToInt32(HyperTable.Rows[i]["MinPCU"]); } catch { }
                try { engine.MaxSize = HyperTable.Rows[i]["MaxSize"].ToString(); } catch { }
                try { engine.MaxSizeInt = Convert.ToInt32(HyperTable.Rows[i]["MaxSizeInt"]); } catch { }
                try { engine.BpMulti = Convert.ToInt32(HyperTable.Rows[i]["BpMulti"]); } catch { }
                HSEngineCatalog.Add(engine);
            }
            #region
            //HyperspaceEngine engine = new HyperspaceEngine();
            //List<HyperspaceEngine> HSEngineCatalog = new List<HyperspaceEngine>();
            //HSEngineCatalog.Add(engine.None());
            //HSEngineCatalog.Add(engine.SignalBasic());
            //HSEngineCatalog.Add(engine.SignalBooster());
            //HSEngineCatalog.Add(engine.SignalMajor());
            //HSEngineCatalog.Add(engine.SignalSuperior());
            //HSEngineCatalog.Add(engine.SignalUltra());
            #endregion
            return HSEngineCatalog;
        }

        #region ExpansionBays

        public List<ExpansionBay> ConstructExpansionBayLoad01()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad02()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad03()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad04()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad05()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad06()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad07()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad08()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad09()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad10()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad11()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad12()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad13()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad14()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad15()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad16()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad17()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad18()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad19()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad20()
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
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }
        #endregion

        public List<PowerCore> ConstructPowerCore2Load()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.PowerCoreTableAdapter pAdapt =
                new SFDataBaseDataSetTableAdapters.PowerCoreTableAdapter();             // *** NEW *** Creates the Table Adapter.

            pAdapt.Fill(Data.PowerCore);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable PowerTable = pAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<PowerCore> PowerCoreCatalog = new List<PowerCore>();                                     // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < PowerTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                PowerCore core = new PowerCore();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

                try { core.Type = PowerTable.Rows[i]["PowerCore_Type"].ToString(); } catch { }
                try { core.Size01 = PowerTable.Rows[i]["Size01"].ToString(); } catch { }
                core.Size01 = PowerTable.Rows[i]["Size01"].ToString();
                core.Size02 = PowerTable.Rows[i]["Size02"].ToString();
                core.Size03 = PowerTable.Rows[i]["Size03"].ToString();
                try { core.PCU = Convert.ToInt32(PowerTable.Rows[i]["PowerCore_Pcu"]); } catch { }
                try { core.BPCost = Convert.ToInt32(PowerTable.Rows[i]["PowerCore_BPCost"]); } catch { }
                PowerCoreCatalog.Add(core);
            }
            #region
            //PowerCore core = new PowerCore();
            //List<PowerCore> PowerCoreCatalog = new List<PowerCore>();
            //PowerCoreCatalog.Add(core.None());
            //PowerCoreCatalog.Add(core.MicronLight());
            //PowerCoreCatalog.Add(core.MicronHeavy());
            //PowerCoreCatalog.Add(core.MicronUltra());
            //PowerCoreCatalog.Add(core.ArcusLight());
            //PowerCoreCatalog.Add(core.PulseBrown());
            //PowerCoreCatalog.Add(core.PulseBlack());
            //PowerCoreCatalog.Add(core.PulseWhite());
            //PowerCoreCatalog.Add(core.PulseGrey());
            //PowerCoreCatalog.Add(core.ArcusHeavy());
            //PowerCoreCatalog.Add(core.PulseGreen());
            //PowerCoreCatalog.Add(core.PulseRed());
            //PowerCoreCatalog.Add(core.PulseBlue());
            //PowerCoreCatalog.Add(core.ArcusUltra());
            //PowerCoreCatalog.Add(core.ArcusMaximum());
            //PowerCoreCatalog.Add(core.PulseOrange());
            //PowerCoreCatalog.Add(core.PulsePrismatic());
            //PowerCoreCatalog.Add(core.NovaLight());
            //PowerCoreCatalog.Add(core.NovaHeavy());
            //PowerCoreCatalog.Add(core.NovaUltra());
            //PowerCoreCatalog.Add(core.GatewayLight());
            //PowerCoreCatalog.Add(core.GatewayHeavy());
            //PowerCoreCatalog.Add(core.GatewayUltra());
            #endregion
            return PowerCoreCatalog;
        }

        public List<Sensor> ConstructSensorLoad()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.SensorTableAdapter sAdapt =
                new SFDataBaseDataSetTableAdapters.SensorTableAdapter();             // *** NEW *** Creates the Table Adapter.

            sAdapt.Fill(Data.Sensor);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable SensorTable = sAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<Sensor> SensorsCatalog = new List<Sensor>();                              // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < SensorTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                Sensor sensors = new Sensor();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

                try { sensors.Type = SensorTable.Rows[i]["Sensor_Type"].ToString(); } catch { }
                try { sensors.Range = SensorTable.Rows[i]["Range"].ToString(); } catch { }
                try { sensors.Modifier = Convert.ToInt32(SensorTable.Rows[i]["Modifier"]); } catch { }
                try { sensors.BpCost = Convert.ToInt32(SensorTable.Rows[i]["Sensor_BpCost"]); } catch { }
                SensorsCatalog.Add(sensors);
            }
            #region
            //Sensor sensors = new Sensor();
            //List<Sensor> SensorsCatalog = new List<Sensor>();
            //SensorsCatalog.Add(sensors.None());
            //SensorsCatalog.Add(sensors.Cutrate());
            //SensorsCatalog.Add(sensors.BudgetSR());
            //SensorsCatalog.Add(sensors.BasicSR());
            //SensorsCatalog.Add(sensors.AdvancedSR());
            //SensorsCatalog.Add(sensors.BudgetMR());
            //SensorsCatalog.Add(sensors.BasicMR());
            //SensorsCatalog.Add(sensors.AdvancedMR());
            //SensorsCatalog.Add(sensors.BudgetLR());
            //SensorsCatalog.Add(sensors.BasicLR());
            //SensorsCatalog.Add(sensors.AdvancedLR());
            #endregion
            return SensorsCatalog;
        }

        public List<Shield> ConstructShieldLoad()
        {
            SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            SFDataBaseDataSetTableAdapters.ShieldsTableAdapter shAdapt =
                new SFDataBaseDataSetTableAdapters.ShieldsTableAdapter();             // *** NEW *** Creates the Table Adapter.

            shAdapt.Fill(Data.Shields);                                             // *** NEW *** Fills the DataSet with database information.

            DataTable ShieldTable = shAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            List<Shield> ShieldsCatalog = new List<Shield>();                            // *** NEW *** Creates the List that will be populated.
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            for (int i = 0; i < ShieldTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            {

                Shield shields = new Shield();
                // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
                // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

                try { shields.Type = ShieldTable.Rows[i]["Shield_Type"].ToString(); } catch { }
                try { shields.TotalSP = Convert.ToInt32(ShieldTable.Rows[i]["TotalSP"]); } catch { }
                try { shields.Regen = Convert.ToInt32(ShieldTable.Rows[i]["Regen"]); } catch { }
                try { shields.Pcu = Convert.ToInt32(ShieldTable.Rows[i]["Sensor_Pcu"]); } catch { }
                try { shields.BpCost = Convert.ToInt32(ShieldTable.Rows[i]["Sensor_BpCost"]); } catch { }
                ShieldsCatalog.Add(shields);
            }
            #region
            //Shield shields = new Shield();
            //List<Shield> ShieldsCatalog = new List<Shield>();
            //ShieldsCatalog.Add(shields.None());
            //ShieldsCatalog.Add(shields.Basic10());
            //ShieldsCatalog.Add(shields.Basic20());
            //ShieldsCatalog.Add(shields.Basic30());
            //ShieldsCatalog.Add(shields.Basic40());
            //ShieldsCatalog.Add(shields.Light50());
            //ShieldsCatalog.Add(shields.Light60());
            //ShieldsCatalog.Add(shields.Light70());
            //ShieldsCatalog.Add(shields.Light80());
            //ShieldsCatalog.Add(shields.Medium90());
            //ShieldsCatalog.Add(shields.Medium100());
            //ShieldsCatalog.Add(shields.Medium120());
            //ShieldsCatalog.Add(shields.Medium140());
            //ShieldsCatalog.Add(shields.Medium160());
            //ShieldsCatalog.Add(shields.Medium200());
            //ShieldsCatalog.Add(shields.Heavy240());
            //ShieldsCatalog.Add(shields.Heavy280());
            //ShieldsCatalog.Add(shields.Heavy320());
            //ShieldsCatalog.Add(shields.Heavy360());
            //ShieldsCatalog.Add(shields.Heavy420());
            //ShieldsCatalog.Add(shields.Heavy480());
            //ShieldsCatalog.Add(shields.Heavy540());
            //ShieldsCatalog.Add(shields.Heavy600());
            #endregion
            return ShieldsCatalog;
        }


        public List<Weapon> ConstructWeaponLoadALL()
        {
            #region
            //SFDataBaseDataSet Data = new SFDataBaseDataSet();                               // *** NEW *** Creates the Database DataSet.

            //SFDataBaseDataSetTableAdapters.WeaponsTableAdapter wAdapt =
            //    new SFDataBaseDataSetTableAdapters.WeaponsTableAdapter();             // *** NEW *** Creates the Table Adapter.

            //wAdapt.Fill(Data.Weapons);                                             // *** NEW *** Fills the DataSet with database information.

            //DataTable WeaponsTable = wAdapt.GetData().CopyToDataTable();                    // *** NEW *** Creates a new DataTable Object from the DataSet

            //List<Weapon> WeaponsCatalog = new List<Weapon>();                                    // *** NEW *** Creates the List that will be populated.
            //// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - This is the original list from
            ////^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            //for (int i = 0; i < WeaponsTable.Rows.Count; i++)                                  // *** NEW *** Cycles through the Data Set
            //{

            //    Weapon weapons = new Weapon();
            //    // ^^^^^^^^^^^^^^^^^^^^ - This is the original variable from 
            //    // ^^^^^^^^^^^^^^^^^^^^ - the original method in this class.

            //    try { weapons.Type = WeaponsTable.Rows[i]["Wpn_Type"].ToString(); } catch { }
            //    try { weapons.Size = WeaponsTable.Rows[i]["WpnSize"].ToString(); } catch { }
            //    try { weapons.Tracking = Convert.ToBoolean(Convert.ToInt32(WeaponsTable.Rows[i]["Tracking"])); } catch { }
            //    try { weapons.Range = WeaponsTable.Rows[i]["Range"].ToString(); } catch { }
            //    try { weapons.Speed = Convert.ToInt32(WeaponsTable.Rows[i]["Speed"]); } catch { }
            //    try { weapons.Damage = WeaponsTable.Rows[i]["Damage"].ToString(); } catch { }
            //    try { weapons.SpecialProp1 = WeaponsTable.Rows[i]["SpecialProp1"].ToString(); } catch { }
            //    try { weapons.SpecialProp2 = WeaponsTable.Rows[i]["SpecialProp2"].ToString(); } catch { }
            //    try { weapons.Pcu = Convert.ToInt32(WeaponsTable.Rows[i]["Weapons_Pcu"]); } catch { }
            //    try { weapons.BpCost = Convert.ToInt32(WeaponsTable.Rows[i]["Weapons_BpCost"]); } catch { }
            //    WeaponsCatalog.Add(weapons);
            //}
            #endregion
            #region
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            #endregion
            return WeaponsCatalog;
        }


        #region Light Weapons By Slot

        public List<Weapon> ConstructWeaponLoadF1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;

        }

        public List<Weapon> ConstructWeaponLoadA2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        #endregion

        #region Heavy Weapons By Slot

        public List<Weapon> ConstructWeaponLoadF1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        #endregion

        #region Capital Weapons By Slot

        public List<Weapon> ConstructWeaponLoadF1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        #endregion



        #region AllSlotSizes

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        #endregion


        #region HeavyAndLightSlotSizes

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadF1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadF2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadF3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadP1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadP2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadP3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadS1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadS2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadS3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadA1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadA2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadA3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadT1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadT2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadT3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        #endregion


        #region LightSlotSizes

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadF1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadF2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadP1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadP2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadS1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadS2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadA1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadA2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadT1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadT2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        #endregion







        #endregion



    }
}

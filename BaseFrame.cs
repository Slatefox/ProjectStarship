using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class BaseFrame
    {

        #region PFVs

        private string typeName;
        private string size;
        private string mR;
        private int mRpiloting;
        private int mRturn;
        private int hp;
        private int hpIncriment;
        private int dt;
        private int ct;
        private string forwardArcSize1;
        private string forwardArcSize2;
        private string forwardArcSize3;
        private string forwardArcSize4;
        private string portArcSize1;
        private string portArcSize2;
        private string portArcSize3;
        private string portArcSize4;
        private string starboardArcSize1;
        private string starboardArcSize2;
        private string starboardArcSize3;
        private string starboardArcSize4;
        private string aftArcSize1;
        private string aftArcSize2;
        private string aftArcSize3;
        private string aftArcSize4;
        private string turretSize1;
        private string turretSize2;
        private string turretSize3;
        private string turretSize4;
        private int forwardArcNum1;
        private int forwardArcNum2;
        private int forwardArcNum3;
        private int forwardArcNum4;
        private int portArcNum1;
        private int portArcNum2;
        private int portArcNum3;
        private int portArcNum4;
        private int starboardArcNum1;
        private int starboardArcNum2;
        private int starboardArcNum3;
        private int starboardArcNum4;
        private int aftArcNum1;
        private int aftArcNum2;
        private int aftArcNum3;
        private int aftArcNum4;
        private int turretNum1;
        private int turretNum2;
        private int turretNum3;
        private int turretNum4;
        private int expansionBaysNum;
        private bool hangarMust;
        private int minCrew;
        private int maxCrew;
        private int bPCost;

        #endregion

        #region Properties

        public string Type
        {
            get
            {
                return typeName;
            }

            set
            {
                typeName = value;
            }
        }

        public string Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public string MR
        {
            get
            {
                return mR;
            }

            set
            {
                mR = value;
            }
        }

        public int MRpiloting
        {
            get
            {
                return mRpiloting;
            }

            set
            {
                mRpiloting = value;
            }
        }

        public int MRturn
        {
            get
            {
                return mRturn;
            }

            set
            {
                mRturn = value;
            }
        }

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public int HpIncriment
        {
            get
            {
                return hpIncriment;
            }

            set
            {
                hpIncriment = value;
            }
        }

        public int Dt
        {
            get
            {
                return dt;
            }

            set
            {
                dt = value;
            }
        }

        public int Ct
        {
            get
            {
                return ct;
            }

            set
            {
                ct = value;
            }
        }

        public string ForwardArcSize1
        {
            get
            {
                return forwardArcSize1;
            }

            set
            {
                forwardArcSize1 = value;
            }
        }

        public string ForwardArcSize2
        {
            get
            {
                return forwardArcSize2;
            }

            set
            {
                forwardArcSize2 = value;
            }
        }

        public string ForwardArcSize3
        {
            get
            {
                return forwardArcSize3;
            }

            set
            {
                forwardArcSize3 = value;
            }
        }

        public string ForwardArcSize4
        {
            get
            {
                return forwardArcSize4;
            }

            set
            {
                forwardArcSize4 = value;
            }
        }

        public string PortArcSize1
        {
            get
            {
                return portArcSize1;
            }

            set
            {
                portArcSize1 = value;
            }
        }

        public string PortArcSize2
        {
            get
            {
                return portArcSize2;
            }

            set
            {
                portArcSize2 = value;
            }
        }

        public string PortArcSize3
        {
            get
            {
                return portArcSize3;
            }

            set
            {
                portArcSize3 = value;
            }
        }

        public string PortArcSize4
        {
            get
            {
                return portArcSize4;
            }

            set
            {
                portArcSize4 = value;
            }
        }

        public string StarboardArcSize1
        {
            get
            {
                return starboardArcSize1;
            }

            set
            {
                starboardArcSize1 = value;
            }
        }

        public string StarboardArcSize2
        {
            get
            {
                return starboardArcSize2;
            }

            set
            {
                starboardArcSize2 = value;
            }
        }

        public string StarboardArcSize3
        {
            get
            {
                return starboardArcSize3;
            }

            set
            {
                starboardArcSize3 = value;
            }
        }

        public string StarboardArcSize4
        {
            get
            {
                return starboardArcSize4;
            }

            set
            {
                starboardArcSize4 = value;
            }
        }

        public string AftArcSize1
        {
            get
            {
                return aftArcSize1;
            }

            set
            {
                aftArcSize1 = value;
            }
        }

        public string AftArcSize2
        {
            get
            {
                return aftArcSize2;
            }

            set
            {
                aftArcSize2 = value;
            }
        }

        public string AftArcSize3
        {
            get
            {
                return aftArcSize3;
            }

            set
            {
                aftArcSize3 = value;
            }
        }

        public string AftArcSize4
        {
            get
            {
                return aftArcSize4;
            }

            set
            {
                aftArcSize4 = value;
            }
        }

        public string TurretSize1
        {
            get
            {
                return turretSize1;
            }

            set
            {
                turretSize1 = value;
            }
        }

        public string TurretSize2
        {
            get
            {
                return turretSize2;
            }

            set
            {
                turretSize2 = value;
            }
        }

        public string TurretSize3
        {
            get
            {
                return turretSize3;
            }

            set
            {
                turretSize3 = value;
            }
        }

        public string TurretSize4
        {
            get
            {
                return turretSize4;
            }

            set
            {
                turretSize4 = value;
            }
        }

        public int ForwardArcNum1
        {
            get
            {
                return forwardArcNum1;
            }

            set
            {
                forwardArcNum1 = value;
            }
        }

        public int ForwardArcNum2
        {
            get
            {
                return forwardArcNum2;
            }

            set
            {
                forwardArcNum2 = value;
            }
        }

        public int ForwardArcNum3
        {
            get
            {
                return forwardArcNum3;
            }

            set
            {
                forwardArcNum3 = value;
            }
        }

        public int ForwardArcNum4
        {
            get
            {
                return forwardArcNum4;
            }

            set
            {
                forwardArcNum4 = value;
            }
        }

        public int PortArcNum1
        {
            get
            {
                return portArcNum1;
            }

            set
            {
                portArcNum1 = value;
            }
        }

        public int PortArcNum2
        {
            get
            {
                return portArcNum2;
            }

            set
            {
                portArcNum2 = value;
            }
        }

        public int PortArcNum3
        {
            get
            {
                return portArcNum3;
            }

            set
            {
                portArcNum3 = value;
            }
        }

        public int PortArcNum4
        {
            get
            {
                return portArcNum4;
            }

            set
            {
                portArcNum4 = value;
            }
        }

        public int StarboardArcNum1
        {
            get
            {
                return starboardArcNum1;
            }

            set
            {
                starboardArcNum1 = value;
            }
        }

        public int StarboardArcNum2
        {
            get
            {
                return starboardArcNum2;
            }

            set
            {
                starboardArcNum2 = value;
            }
        }

        public int StarboardArcNum3
        {
            get
            {
                return starboardArcNum3;
            }

            set
            {
                starboardArcNum3 = value;
            }
        }

        public int StarboardArcNum4
        {
            get
            {
                return starboardArcNum4;
            }

            set
            {
                starboardArcNum4 = value;
            }
        }

        public int AftArcNum1
        {
            get
            {
                return aftArcNum1;
            }

            set
            {
                aftArcNum1 = value;
            }
        }

        public int AftArcNum2
        {
            get
            {
                return aftArcNum2;
            }

            set
            {
                aftArcNum2 = value;
            }
        }

        public int AftArcNum3
        {
            get
            {
                return aftArcNum3;
            }

            set
            {
                aftArcNum3 = value;
            }
        }

        public int AftArcNum4
        {
            get
            {
                return aftArcNum4;
            }

            set
            {
                aftArcNum4 = value;
            }
        }

        public int TurretNum1
        {
            get
            {
                return turretNum1;
            }

            set
            {
                turretNum1 = value;
            }
        }

        public int TurretNum2
        {
            get
            {
                return turretNum2;
            }

            set
            {
                turretNum2 = value;
            }
        }

        public int TurretNum3
        {
            get
            {
                return turretNum3;
            }

            set
            {
                turretNum3 = value;
            }
        }

        public int TurretNum4
        {
            get
            {
                return turretNum4;
            }

            set
            {
                turretNum4 = value;
            }
        }

        public int ExpansionBaysNum
        {
            get
            {
                return expansionBaysNum;
            }

            set
            {
                expansionBaysNum = value;
            }
        }

        public bool HangarMust
        {
            get
            {
                return hangarMust;
            }

            set
            {
                hangarMust = value;
            }
        }

        public int MinCrew
        {
            get
            {
                return minCrew;
            }

            set
            {
                minCrew = value;
            }
        }

        public int MaxCrew
        {
            get
            {
                return maxCrew;
            }

            set
            {
                maxCrew = value;
            }
        }

        public int BPCost
        {
            get
            {
                return bPCost;
            }

            set
            {
                bPCost = value;
            }
        }

        #endregion

        #region Constructors

        public BaseFrame None()
        {
            BaseFrame none = new BaseFrame()
            {
                Type = "-Select Frame-",
            };
            return none;
        }

        public BaseFrame Racer()
        {
            BaseFrame RacerFrame = new BaseFrame
            {
                Type = "Racer",
                Size = "Tiny",
                MR = "Perfect",
                MRpiloting = 2,
                MRturn = 0,
                Hp = 20,
                HpIncriment = 5,
                Dt = 0,
                Ct = 4,
                ForwardArcSize1 = "Light",
                ForwardArcNum1 = 1,
                AftArcSize1 = "Light",
                AftArcNum1 = 1,
                ExpansionBaysNum = 0,
                MinCrew = 1,
                MaxCrew = 1,
                BPCost = 4
            };
            return RacerFrame;
        }

        public BaseFrame Interceptor()
        {
            BaseFrame InterceptorFrame = new BaseFrame
            {
                Type = "Interceptor",
                Size = "Tiny",
                MR = "Perfect",
                MRpiloting = 2,
                MRturn = 0,
                Hp = 30,
                HpIncriment = 5,
                Dt = 0,
                Ct = 6,
                ForwardArcSize1 = "Light",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Light",
                ForwardArcNum2 = 1,
                ExpansionBaysNum = 0,
                MinCrew = 1,
                MaxCrew = 1,
                BPCost = 6
            };
            return InterceptorFrame;
        }

        public BaseFrame Fighter()
        {
            BaseFrame FighterFrame = new BaseFrame
            {
                Type = "Fighter",
                Size = "Tiny",
                MR = "Good",
                MRpiloting = 1,
                MRturn = 1,
                Hp = 35,
                HpIncriment = 5,
                Dt = 0,
                Ct = 4,
                ForwardArcSize1 = "Light",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Light - Tracking",
                ForwardArcNum2 = 1,
                AftArcSize1 = "Light",
                AftArcNum1 = 1,
                ExpansionBaysNum = 0,
                MinCrew = 1,
                MaxCrew = 2,
                BPCost = 8
            };
            return FighterFrame;
        }

        public BaseFrame Shuttle()
        {
            BaseFrame ShuttleFrame = new BaseFrame
            {
                Type = "Shuttle",
                Size = "Small",
                MR = "Perfect",
                MRpiloting = 2,
                MRturn = 0,
                Hp = 35,
                HpIncriment = 5,
                Dt = 0,
                Ct = 7,
                ForwardArcSize1 = "Light",
                ForwardArcNum1 = 1,
                ExpansionBaysNum = 3,
                MinCrew = 1,
                MaxCrew = 4,
                BPCost = 6
            };
            return ShuttleFrame;
        }

        public BaseFrame LightFreighter()
        {
            BaseFrame LightFreighterFrame = new BaseFrame
            {
                Type = "Light Freighter",
                Size = "Small",
                MR = "Good",
                MRpiloting = 1,
                MRturn = 1,
                Hp = 40,
                HpIncriment = 10,
                Dt = 0,
                Ct = 8,
                ForwardArcSize1 = "Light",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Light",
                ForwardArcNum2 = 1,
                PortArcSize1 = "Light",
                PortArcNum1 = 1,
                StarboardArcSize1 = "Light",
                StarboardArcNum1 = 1,
                ExpansionBaysNum = 3,
                MinCrew = 1,
                MaxCrew = 6,
                BPCost = 10
            };
            return LightFreighterFrame;
        }

        public BaseFrame Explorer()
        {
            BaseFrame ExplorerFrame = new BaseFrame
            {
                Type = "Explorer",
                Size = "Medium",
                MR = "Good",
                MRpiloting = 1,
                MRturn = 1,
                Hp = 55,
                HpIncriment = 10,
                Dt = 0,
                Ct = 11,
                ForwardArcSize1 = "Light",
                ForwardArcNum1 = 1,
                PortArcSize1 = "Light",
                PortArcNum1 = 1,
                StarboardArcSize1 = "Light",
                StarboardArcNum1 = 1,
                TurretSize1 = "Light",
                TurretNum1 = 1,
                ExpansionBaysNum = 4,
                MinCrew = 1,
                MaxCrew = 6,
                BPCost = 12
            };
            return ExplorerFrame;
        }

        public BaseFrame Transport()
        {
            BaseFrame TransportFrame = new BaseFrame
            {
                Type = "Transport",
                Size = "Medium",
                MR = "Average",
                MRpiloting = 0,
                MRturn = 2,
                Hp = 70,
                HpIncriment = 15,
                Dt = 0,
                Ct = 14,
                ForwardArcSize1 = "Light",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Heavy",
                ForwardArcNum2 = 1,
                AftArcSize1 = "Light",
                AftArcNum1 = 1,
                TurretSize1 = "Light",
                TurretNum1 = 1,
                TurretSize2 = "Light",
                TurretNum2 = 1,
                ExpansionBaysNum = 5,
                MinCrew = 1,
                MaxCrew = 6,
                BPCost = 15
            };
            return TransportFrame;
        }

        public BaseFrame Destroyer()
        {
            BaseFrame DestroyerFrame = new BaseFrame
            {
                Type = "Destroyer",
                Size = "Large",
                MR = "Average",
                MRpiloting = 0,
                MRturn = 2,
                Hp = 150,
                HpIncriment = 20,
                Dt = 0,
                Ct = 30,
                ForwardArcSize1 = "Heavy",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Heavy",
                ForwardArcNum2 = 1,
                PortArcSize1 = "Light",
                PortArcNum1 = 1,
                StarboardArcSize1 = "Light",
                StarboardArcNum1 = 1,
                AftArcSize1 = "Light",
                AftArcNum1 = 1,
                TurretSize1 = "Light",
                TurretNum1 = 1,
                ExpansionBaysNum = 4,
                MinCrew = 6,
                MaxCrew = 20,
                BPCost = 30
            };
            return DestroyerFrame;
        }

        public BaseFrame HeavyFreighter()
        {
            BaseFrame HeavyFreighterFrame = new BaseFrame
            {
                Type = "Heavy Freighter",
                Size = "Large",
                MR = "Average",
                MRpiloting = 0,
                MRturn = 2,
                Hp = 120,
                HpIncriment = 20,
                Dt = 0,
                Ct = 24,
                ForwardArcSize1 = "Heavy",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Light",
                ForwardArcNum2 = 1,
                ForwardArcSize3 = "Light",
                ForwardArcNum3 = 1,
                PortArcSize1 = "Light",
                PortArcNum1 = 1,
                StarboardArcSize1 = "Light",
                StarboardArcNum1 = 1,
                ExpansionBaysNum = 8,
                MinCrew = 6,
                MaxCrew = 20,
                BPCost = 40
            };
            return HeavyFreighterFrame;
        }

        public BaseFrame BulkFreighter()
        {
            BaseFrame BulkFreighterFrame = new BaseFrame
            {
                Type = "Bulk Freighter",
                Size = "Huge",
                MR = "Poor",
                MRpiloting = -1,
                MRturn = 3,
                Hp = 160,
                HpIncriment = 20,
                Dt = 5,
                Ct = 32,
                ForwardArcSize1 = "Heavy",
                ForwardArcNum1 = 1,
                AftArcSize1 = "Heavy",
                AftArcNum1 = 1,
                TurretSize1 = "Light",
                TurretNum1 = 1,
                TurretSize2 = "Light",
                TurretNum2 = 1,
                ExpansionBaysNum = 10,
                MinCrew = 20,
                MaxCrew = 50,
                BPCost = 55
            };
            return BulkFreighterFrame;
        }

        public BaseFrame Cruiser()
        {
            BaseFrame CruiserFrame = new BaseFrame
            {
                Type = "Cruiser",
                Size = "Huge",
                MR = "Average",
                MRpiloting = 0,
                MRturn = 2,
                Hp = 180,
                HpIncriment = 25,
                Dt = 5,
                Ct = 36,
                ForwardArcSize1 = "Capital",
                ForwardArcNum1 = 1,
                PortArcSize1 = "Light",
                PortArcNum1 = 1,
                StarboardArcSize1 = "Light",
                StarboardArcNum1 = 1,
                TurretSize1 = "Heavy",
                TurretNum1 = 1,
                ExpansionBaysNum = 6,
                MinCrew = 20,
                MaxCrew = 100,
                BPCost = 60
            };
            return CruiserFrame;
        }

        public BaseFrame Carrier()
        {
            BaseFrame CarrierFrame = new BaseFrame
            {
                Type = "Carrier",
                Size = "Gargantuan",
                MR = "Poor",
                MRpiloting = -1,
                MRturn = 3,
                Hp = 240,
                HpIncriment = 30,
                Dt = 10,
                Ct = 48,
                ForwardArcSize1 = "Capital",
                ForwardArcNum1 = 1,
                PortArcSize1 = "Heavy",
                PortArcNum1 = 1,
                PortArcSize2 = "Heavy",
                PortArcNum2 = 1,
                PortArcSize3 = "Heavy",
                PortArcNum3 = 1,
                StarboardArcSize1 = "Heavy",
                StarboardArcNum1 = 1,
                StarboardArcSize2 = "Heavy",
                StarboardArcNum2 = 1,
                StarboardArcSize3 = "Heavy",
                StarboardArcNum3 = 1,
                TurretSize1 = "Light",
                TurretNum1 = 1,
                TurretSize2 = "Light",
                TurretNum2 = 1,
                ExpansionBaysNum = 10,
                HangarMust = true,
                MinCrew = 75,
                MaxCrew = 200,
                BPCost = 120
            };
            return CarrierFrame;
        }

        public BaseFrame Battleship()
        {
            BaseFrame BattleshipFrame = new BaseFrame
            {
                Type = "Battleship",
                Size = "Gargantuan",
                MR = "Average",
                MRpiloting = 0,
                MRturn = 2,
                Hp = 280,
                HpIncriment = 40,
                Dt = 10,
                Ct = 56,
                ForwardArcSize1 = "Capital",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Heavy",
                ForwardArcNum2 = 1,
                ForwardArcSize3 = "Heavy",
                ForwardArcNum3 = 1,
                PortArcSize1 = "Heavy",
                PortArcNum1 = 1,
                PortArcSize2 = "Heavy",
                PortArcNum2 = 1,
                PortArcSize3 = "Light",
                PortArcNum3 = 1,
                StarboardArcSize1 = "Heavy",
                StarboardArcNum1 = 1,
                StarboardArcSize2 = "Heavy",
                StarboardArcNum2 = 1,
                StarboardArcSize3 = "Light",
                StarboardArcNum3 = 1,
                AftArcSize1 = "Light",
                AftArcNum1 = 1,
                TurretSize1 = "Heavy",
                TurretNum1 = 1,
                TurretSize2 = "Heavy",
                TurretNum2 = 1,
                ExpansionBaysNum = 8,
                MinCrew = 100,
                MaxCrew = 300,
                BPCost = 150
            };
            return BattleshipFrame;
        }

        public BaseFrame Dreadnought()
        {
            BaseFrame DreadnoughtFrame = new BaseFrame
            {
                Type = "Dreadnought",
                Size = "Colossal",
                MR = "Clumsy",
                MRpiloting = -2,
                MRturn = 4,
                Hp = 400,
                HpIncriment = 50,
                Dt = 15,
                Ct = 80,
                ForwardArcSize1 = "Capital",
                ForwardArcNum1 = 1,
                ForwardArcSize2 = "Capital",
                ForwardArcNum2 = 1,
                ForwardArcSize3 = "Heavy",
                ForwardArcNum3 = 1,
                ForwardArcSize4 = "Heavy",
                ForwardArcNum4 = 1,
                PortArcSize1 = "Capital",
                PortArcNum1 = 1,
                PortArcSize2 = "Heavy",
                PortArcNum2 = 1,
                PortArcSize3 = "Heavy",
                PortArcNum3 = 1,
                PortArcSize4 = "Heavy",
                PortArcNum4 = 1,
                StarboardArcSize1 = "Capital",
                StarboardArcNum1 = 1,
                StarboardArcSize2 = "Heavy",
                StarboardArcNum2 = 1,
                StarboardArcSize3 = "Heavy",
                StarboardArcNum3 = 1,
                StarboardArcSize4 = "Heavy",
                StarboardArcNum4 = 1,
                TurretSize1 = "Light",
                TurretNum1 = 1,
                TurretSize2 = "Light",
                TurretNum2 = 1,
                TurretSize3 = "Light",
                TurretNum3 = 1,
                TurretSize4 = "Light",
                TurretNum4 = 1,
                ExpansionBaysNum = 20,
                MinCrew = 125,
                MaxCrew = 500,
                BPCost = 200
            };
            return DreadnoughtFrame;
        }

        #endregion

    }
}

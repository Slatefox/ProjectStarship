using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class PowerCore
    {
        #region PFVs

        private string type;
        private string size01;
        private string size02;
        private string size03;
        private int pcu;
        private int bpCost;

        #endregion


        #region Properties

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Size01
        {
            get
            {
                return size01;
            }

            set
            {
                size01 = value;
            }
        }

        public string Size02
        {
            get
            {
                return size02;
            }

            set
            {
                size02 = value;
            }
        }

        public string Size03
        {
            get
            {
                return size03;
            }

            set
            {
                size03 = value;
            }
        }

        public int PCU
        {
            get
            {
                return pcu;
            }

            set
            {
                pcu = value;
            }
        }

        public int BPCost
        {
            get
            {
                return bpCost;
            }

            set
            {
                bpCost = value;
            }
        }

        #endregion


        #region Constructors

        public PowerCore None()
        {
            PowerCore none = new PowerCore()
            {
                Type = "-Select Power Core-"
            };
            return none;
        }

        public PowerCore MicronLight()
        {
            PowerCore MicronLightCore = new PowerCore()
            {
                Type = "Micron Light",
                Size01 = "Tiny",
                PCU = 50,
                BPCost = 4
            };
            return MicronLightCore;
        }

        public PowerCore MicronHeavy()
        {
            PowerCore MicronHeavyCore = new PowerCore()
            {
                Type = "Micron Heavy",
                Size01 = "Tiny",
                PCU = 70,
                BPCost = 6
            };
            return MicronHeavyCore;
        }

        public PowerCore MicronUltra()
        {
            PowerCore MicronUltraCore = new PowerCore()
            {
                Type = "Micron Ultra",
                Size01 = "Tiny",
                PCU = 80,
                BPCost = 8
            };
            return MicronUltraCore;
        }

        public PowerCore ArcusLight()
        {
            PowerCore ArcusLightCore = new PowerCore()
            {
                Type = "Arcus Light",
                Size01 = "Tiny",
                Size02 = "Small",
                PCU = 75,
                BPCost = 7
            };
            return ArcusLightCore;
        }

        public PowerCore PulseBrown()
        {
            PowerCore PulseBrownCore = new PowerCore()
            {
                Type = "Pulse Brown",
                Size01 = "Tiny",
                Size02 = "Small",
                PCU = 90,
                BPCost = 9
            };
            return PulseBrownCore;
        }

        public PowerCore PulseBlack()
        {
            PowerCore PulseBlackCore = new PowerCore()
            {
                Type = "Pulse Black",
                Size01 = "Tiny",
                Size02 = "Small",
                PCU = 120,
                BPCost = 12
            };
            return PulseBlackCore;
        }

        public PowerCore PulseWhite()
        {
            PowerCore PulseWhiteCore = new PowerCore()
            {
                Type = "Pulse White",
                Size01 = "Tiny",
                Size02 = "Small",
                PCU = 140,
                BPCost = 14
            };
            return PulseWhiteCore;
        }

        public PowerCore PulseGrey()
        {
            PowerCore PulseGreyCore = new PowerCore()
            {
                Type = "Pulse Grey",
                Size01 = "Tiny",
                Size02 = "Small",
                Size03 = "Medium",
                PCU = 100,
                BPCost = 10
            };
            return PulseGreyCore;
        }

        public PowerCore ArcusHeavy()
        {
            PowerCore ArcusHeavyCore = new PowerCore()
            {
                Type = "Arcus Heavy",
                Size01 = "Tiny",
                Size02 = "Small",
                Size03 = "Medium",
                PCU = 130,
                BPCost = 13
            };
            return ArcusHeavyCore;
        }

        public PowerCore PulseGreen()
        {
            PowerCore PulseGreenCore = new PowerCore()
            {
                Type = "Pulse Green",
                Size01 = "Tiny",
                Size02 = "Small",
                Size03 = "Medium",
                PCU = 150,
                BPCost = 15
            };
            return PulseGreenCore;
        }

        public PowerCore PulseRed()
        {
            PowerCore PulseRedCore = new PowerCore()
            {
                Type = "Pulse Red",
                Size01 = "Tiny",
                Size02 = "Small",
                Size03 = "Medium",
                PCU = 175,
                BPCost = 17
            };
            return PulseRedCore;
        }

        public PowerCore PulseBlue()
        {
            PowerCore PulseBlueCore = new PowerCore()
            {
                Type = "Pulse Blue",
                Size01 = "Tiny",
                Size02 = "Small",
                Size03 = "Medium",
                PCU = 200,
                BPCost = 20
            };
            return PulseBlueCore;
        }

        public PowerCore ArcusUltra()
        {
            PowerCore ArcusUltraCore = new PowerCore()
            {
                Type = "Arcus Ultra",
                Size01 = "Small",
                Size02 = "Medium",
                Size03 = "Large",
                PCU = 150,
                BPCost = 15
            };
            return ArcusUltraCore;
        }

        public PowerCore ArcusMaximum()
        {
            PowerCore ArcusMaximumCore = new PowerCore()
            {
                Type = "Arcus Maximum",
                Size01 = "Small",
                Size02 = "Medium",
                Size03 = "Large",
                PCU = 200,
                BPCost = 20
            };
            return ArcusMaximumCore;
        }

        public PowerCore PulseOrange()
        {
            PowerCore PulseOrangeCore = new PowerCore()
            {
                Type = "Pulse Orange",
                Size01 = "Small",
                Size02 = "Medium",
                Size03 = "Large",
                PCU = 250,
                BPCost = 25
            };
            return PulseOrangeCore;
        }

        public PowerCore PulsePrismatic()
        {
            PowerCore PulsePrismaticCore = new PowerCore()
            {
                Type = "Pulse Prismatic",
                Size01 = "Small",
                Size02 = "Medium",
                Size03 = "Large",
                PCU = 300,
                BPCost = 30
            };
            return PulsePrismaticCore;
        }

        public PowerCore NovaLight()
        {
            PowerCore NovaLightCore = new PowerCore()
            {
                Type = "Nova Light",
                Size01 = "Medium",
                Size02 = "Large",
                Size03 = "Huge",
                PCU = 150,
                BPCost = 15
            };
            return NovaLightCore;
        }

        public PowerCore NovaHeavy()
        {
            PowerCore NovaHeavyCore = new PowerCore()
            {
                Type = "Nova Heavy",
                Size01 = "Medium",
                Size02 = "Large",
                Size03 = "Huge",
                PCU = 200,
                BPCost = 20
            };
            return NovaHeavyCore;
        }

        public PowerCore NovaUltra()
        {
            PowerCore NovaUltraCore = new PowerCore()
            {
                Type = "Nova Ultra",
                Size01 = "Medium",
                Size02 = "Large",
                Size03 = "Huge",
                PCU = 300,
                BPCost = 30
            };
            return NovaUltraCore;
        }

        public PowerCore GatewayLight()
        {
            PowerCore GatewayLightCore = new PowerCore()
            {
                Type = "Gateway Light",
                Size01 = "Large",
                Size02 = "Huge",
                Size03 = "Gargantuan",
                PCU = 300,
                BPCost = 30
            };
            return GatewayLightCore;
        }

        public PowerCore GatewayHeavy()
        {
            PowerCore GatewayHeavyCore = new PowerCore()
            {
                Type = "Gateway Heavy",
                Size01 = "Large",
                Size02 = "Huge",
                Size03 = "Gargantuan",
                PCU = 400,
                BPCost = 40
            };
            return GatewayHeavyCore;
        }

        public PowerCore GatewayUltra()
        {
            PowerCore GatewayUltraCore = new PowerCore()
            {
                Type = "Gateway Ultra",
                Size01 = "Huge",
                Size02 = "Gargantuan",
                Size03 = "Colossal",
                PCU = 500,
                BPCost = 50
            };
            return GatewayUltraCore;
        }

        #endregion
    }
}

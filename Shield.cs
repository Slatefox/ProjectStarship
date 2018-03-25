using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Shield
    {
        private string type;
        private int totalSP;
        private int regen;
        private int pcu;
        private int bpCost;

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

        public int TotalSP
        {
            get
            {
                return totalSP;
            }

            set
            {
                totalSP = value;
            }
        }

        public int Regen
        {
            get
            {
                return regen;
            }

            set
            {
                regen = value;
            }
        }

        public int Pcu
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

        public int BpCost
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

        public Shield None()
        {
            Shield shields = new Shield()
            {
                Type = "-Select Shields-"
            };
            return shields;
        }

        public Shield Basic10()
        {
            Shield shields = new Shield()
            {
                Type = "Basic Shields 10",
                TotalSP = 10,
                Regen = 1,
                Pcu = 5,
                BpCost = 2
            };
            return shields;
        }

        public Shield Basic20()
        {
            Shield shields = new Shield()
            {
                Type = "Basic Shields 20",
                TotalSP = 20,
                Regen = 1,
                Pcu = 10,
                BpCost = 3
            };
            return shields;
        }

        public Shield Basic30()
        {
            Shield shields = new Shield()
            {
                Type = "Basic Shields 30",
                TotalSP = 30,
                Regen = 1,
                Pcu = 15,
                BpCost = 4
            };
            return shields;
        }

        public Shield Basic40()
        {
            Shield shields = new Shield()
            {
                Type = "Basic Shields 40",
                TotalSP = 40,
                Regen = 1,
                Pcu = 15,
                BpCost = 5
            };
            return shields;
        }

        public Shield Light50()
        {
            Shield shields = new Shield()
            {
                Type = "Light Shields 50",
                TotalSP = 50,
                Regen = 2,
                Pcu = 20,
                BpCost = 6
            };
            return shields;
        }

        public Shield Light60()
        {
            Shield shields = new Shield()
            {
                Type = "Light Shields 50",
                TotalSP = 60,
                Regen = 2,
                Pcu = 20,
                BpCost = 8
            };
            return shields;
        }


        public Shield Light70()
        {
            Shield shields = new Shield()
            {
                Type = "Light Shields 70",
                TotalSP = 70,
                Regen = 2,
                Pcu = 25,
                BpCost = 10
            };
            return shields;
        }

        public Shield Light80()
        {
            Shield shields = new Shield()
            {
                Type = "Light Shields 80",
                TotalSP = 80,
                Regen = 2,
                Pcu = 30,
                BpCost = 12
            };
            return shields;
        }

        public Shield Medium90()
        {
            Shield shields = new Shield()
            {
                Type = "Medium Shields 90",
                TotalSP = 90,
                Regen = 4,
                Pcu = 30,
                BpCost = 13
            };
            return shields;
        }

        public Shield Medium100()
        {
            Shield shields = new Shield()
            {
                Type = "Medium Shields 100",
                TotalSP = 100,
                Regen = 4,
                Pcu = 30,
                BpCost = 15
            };
            return shields;
        }

        public Shield Medium120()
        {
            Shield shields = new Shield()
            {
                Type = "Medium Shields 120",
                TotalSP = 120,
                Regen = 4,
                Pcu = 35,
                BpCost = 17
            };
            return shields;
        }

        public Shield Medium140()
        {
            Shield shields = new Shield()
            {
                Type = "Medium Shields 140",
                TotalSP = 140,
                Regen = 8,
                Pcu = 40,
                BpCost = 18
            };
            return shields;
        }

        public Shield Medium160()
        {
            Shield shields = new Shield()
            {
                Type = "Medium Shields 160",
                TotalSP = 160,
                Regen = 8,
                Pcu = 45,
                BpCost = 20
            };
            return shields;
        }

        public Shield Medium200()
        {
            Shield shields = new Shield()
            {
                Type = "Medium Shields 200",
                TotalSP = 200,
                Regen = 8,
                Pcu = 50,
                BpCost = 22
            };
            return shields;
        }

        public Shield Heavy240()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 240",
                TotalSP = 240,
                Regen = 16,
                Pcu = 55,
                BpCost = 23
            };
            return shields;
        }

        public Shield Heavy280()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 280",
                TotalSP = 280,
                Regen = 16,
                Pcu = 60,
                BpCost = 25
            };
            return shields;
        }

        public Shield Heavy320()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 320",
                TotalSP = 320,
                Regen = 16,
                Pcu = 70,
                BpCost = 27
            };
            return shields;
        }

        public Shield Heavy360()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 360",
                TotalSP = 360,
                Regen = 32,
                Pcu = 80,
                BpCost = 28
            };
            return shields;
        }

        public Shield Heavy420()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 420",
                TotalSP = 420,
                Regen = 32,
                Pcu = 90,
                BpCost = 30
            };
            return shields;
        }

        public Shield Heavy480()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 480",
                TotalSP = 480,
                Regen = 32,
                Pcu = 110,
                BpCost = 32
            };
            return shields;
        }

        public Shield Heavy540()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 540",
                TotalSP = 540,
                Regen = 64,
                Pcu = 130,
                BpCost = 35
            };
            return shields;
        }

        public Shield Heavy600()
        {
            Shield shields = new Shield()
            {
                Type = "Heavy Shields 600",
                TotalSP = 600,
                Regen = 64,
                Pcu = 160,
                BpCost = 40
            };
            return shields;
        }



    }
}

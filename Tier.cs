using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Tier
    {
        private string type;
        private int bp;
        private bool hpInc;
        private int hpIncMulti;

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

        public int Bp
        {
            get
            {
                return bp;
            }

            set
            {
                bp = value;
            }
        }

        public bool HpInc
        {
            get
            {
                return hpInc;
            }

            set
            {
                hpInc = value;
            }
        }

        public int HpIncMulti
        {
            get
            {
                return hpIncMulti;
            }

            set
            {
                hpIncMulti = value;
            }
        }

        public Tier None()
        {
            Tier tier = new Tier()
            {
                Type = "-Select Tier-"
            };
            return tier;
        }

        public Tier OneFourth()
        {
            Tier tier = new Tier()
            {
                Type = "1/4",
                Bp = 25,
                HpInc = false,
                HpIncMulti = 0
            };
            return tier;
        }

        public Tier OneThird()
        {
            Tier tier = new Tier()
            {
                Type = "1/3",
                Bp = 30,
                HpInc = false,
                HpIncMulti = 0
            };
            return tier;
        }

        public Tier OneHalf()
        {
            Tier tier = new Tier()
            {
                Type = "1/2",
                Bp = 40,
                HpInc = false,
                HpIncMulti = 0
            };
            return tier;
        }

        public Tier One()
        {
            Tier tier = new Tier()
            {
                Type = "1",
                Bp = 55,
                HpInc = false,
                HpIncMulti = 0
            };
            return tier;
        }

        public Tier Two()
        {
            Tier tier = new Tier()
            {
                Type = "2",
                Bp = 75,
                HpInc = false,
                HpIncMulti = 0
            };
            return tier;
        }

        public Tier Three()
        {
            Tier tier = new Tier()
            {
                Type = "3",
                Bp = 95,
                HpInc = false,
                HpIncMulti = 0
            };
            return tier;
        }

        public Tier Four()
        {
            Tier tier = new Tier()
            {
                Type = "4",
                Bp = 115,
                HpInc = true,
                HpIncMulti = 1
            };
            return tier;
        }

        public Tier Five()
        {
            Tier tier = new Tier()
            {
                Type = "5",
                Bp = 135,
                HpInc = true,
                HpIncMulti = 1
            };
            return tier;
        }

        public Tier Six()
        {
            Tier tier = new Tier()
            {
                Type = "6",
                Bp = 155,
                HpInc = true,
                HpIncMulti = 1
            };
            return tier;
        }

        public Tier Seven()
        {
            Tier tier = new Tier()
            {
                Type = "7",
                Bp = 180,
                HpInc = true,
                HpIncMulti = 1
            };
            return tier;
        }

        public Tier Eight()
        {
            Tier tier = new Tier()
            {
                Type = "8",
                Bp = 205,
                HpInc = true,
                HpIncMulti = 2
            };
            return tier;
        }

        public Tier Nine()
        {
            Tier tier = new Tier()
            {
                Type = "9",
                Bp = 230,
                HpInc = true,
                HpIncMulti = 2
            };
            return tier;
        }

        public Tier Ten()
        {
            Tier tier = new Tier()
            {
                Type = "10",
                Bp = 270,
                HpInc = true,
                HpIncMulti = 2
            };
            return tier;
        }

        public Tier Eleven()
        {
            Tier tier = new Tier()
            {
                Type = "11",
                Bp = 310,
                HpInc = true,
                HpIncMulti = 2
            };
            return tier;
        }

        public Tier Twelve()
        {
            Tier tier = new Tier()
            {
                Type = "12",
                Bp = 350,
                HpInc = true,
                HpIncMulti = 3
            };
            return tier;
        }

        public Tier Thirteen()
        {
            Tier tier = new Tier()
            {
                Type = "13",
                Bp = 400,
                HpInc = true,
                HpIncMulti = 3
            };
            return tier;
        }

        public Tier Fourteen()
        {
            Tier tier = new Tier()
            {
                Type = "14",
                Bp = 450,
                HpInc = true,
                HpIncMulti = 3
            };
            return tier;
        }

        public Tier Fifteen()
        {
            Tier tier = new Tier()
            {
                Type = "15",
                Bp = 500,
                HpInc = true,
                HpIncMulti = 3
            };
            return tier;
        }

        public Tier Sixteen()
        {
            Tier tier = new Tier()
            {
                Type = "16",
                Bp = 600,
                HpInc = true,
                HpIncMulti = 4
            };
            return tier;
        }

        public Tier Seventeen()
        {
            Tier tier = new Tier()
            {
                Type = "17",
                Bp = 700,
                HpInc = true,
                HpIncMulti = 4
            };
            return tier;
        }

        public Tier Eighteen()
        {
            Tier tier = new Tier()
            {
                Type = "18",
                Bp = 800,
                HpInc = true,
                HpIncMulti = 4
            };
            return tier;
        }

        public Tier Nineteen()
        {
            Tier tier = new Tier()
            {
                Type = "19",
                Bp = 900,
                HpInc = true,
                HpIncMulti = 4
            };
            return tier;
        }

        public Tier Twenty()
        {
            Tier tier = new Tier()
            {
                Type = "20",
                Bp = 1000,
                HpInc = true,
                HpIncMulti = 5
            };
            return tier;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class HyperspaceEngine
    {
        private string type;
        private int rating;
        private int minPCU;
        private string maxSize;
        private int maxSizeInt;
        private int bpMulti;


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

        public int Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public int MinPCU
        {
            get
            {
                return minPCU;
            }

            set
            {
                minPCU = value;
            }
        }

        public string MaxSize
        {
            get
            {
                return maxSize;
            }

            set
            {
                maxSize = value;
            }
        }

        public int MaxSizeInt
        {
            get
            {
                return maxSizeInt;
            }

            set
            {
                maxSizeInt = value;
            }
        }

        public int BpMulti
        {
            get
            {
                return bpMulti;
            }

            set
            {
                bpMulti = value;
            }
        }



        public HyperspaceEngine None()
        {
            HyperspaceEngine none = new HyperspaceEngine()
            {
                Type = "-Select HS Engine-"
            };
            return none;
        }

        public HyperspaceEngine SignalBasic()
        {
            HyperspaceEngine basic = new HyperspaceEngine()
            {
                Type = "Signal Basic",
                Rating = 1,
                MinPCU = 75,
                MaxSizeInt = 7,
                BpMulti = 2
            };
            return basic;
        }

        public HyperspaceEngine SignalBooster()
        {
            HyperspaceEngine booster = new HyperspaceEngine()
            {
                Type = "Signal Booster",
                Rating = 2,
                MinPCU = 100,
                MaxSize = "Huge",
                MaxSizeInt = 5,
                BpMulti = 5
            };
            return booster;
        }

        public HyperspaceEngine SignalMajor()
        {
            HyperspaceEngine major = new HyperspaceEngine()
            {
                Type = "Signal Major",
                Rating = 3,
                MinPCU = 150,
                MaxSize = "Large",
                maxSizeInt = 4,
                BpMulti = 10
            };
            return major;
        }

        public HyperspaceEngine SignalSuperior()
        {
            HyperspaceEngine superior = new HyperspaceEngine()
            {
                Type = "Signal Superior",
                Rating = 4,
                MinPCU = 175,
                MaxSize = "Large",
                MaxSizeInt = 4,
                BpMulti = 15
            };
            return superior;
        }

        public HyperspaceEngine SignalUltra()
        {
            HyperspaceEngine ultra = new HyperspaceEngine()
            {
                Type = "Signal Ultra",
                Rating = 5,
                MinPCU = 200,
                MaxSize = "Medium",
                MaxSizeInt = 3,
                BpMulti = 20
            };
            return ultra;
        }

    }
}

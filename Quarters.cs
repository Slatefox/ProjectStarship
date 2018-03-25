using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Quarters
    {
        private string type;
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

        public Quarters None()
        {
            Quarters none = new Quarters
            {
                Type = "-Select Quarters-"
            };
            return none;
        }

        public Quarters Common()
        {
            Quarters common = new Quarters
            {
                Type = "Common",
                BpCost = 0
            };
            return common;
        }

        public Quarters Good()
        {
            Quarters good = new Quarters
            {
                Type = "Good",
                BpCost = 2
            };
            return good;
        }

        public Quarters Luxurious()
        {
            Quarters luxurious = new Quarters
            {
                Type = "Luxurious",
                BpCost = 5
            };
            return luxurious;
        }

    }
}

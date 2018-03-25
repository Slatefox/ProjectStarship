using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Sensor
    {
        private string type;
        private string range;
        private int modifier;
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

        public string Range
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }

        public int Modifier
        {
            get
            {
                return modifier;
            }

            set
            {
                modifier = value;
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

        public Sensor None()
        {
            Sensor none = new Sensor()
            {
                Type = "-Select Sensors-",
            };
            return none;
        }

        public Sensor Cutrate()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Cut-Rate",
                Range = "Short",
                Modifier = -2,
                BpCost = 1
            };
            return sensors;
        }

        public Sensor BudgetSR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Budget Short-Range",
                Range = "Short",
                Modifier = 0,
                BpCost = 2
            };
            return sensors;
        }

        public Sensor BasicSR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Basic Short-Range",
                Range = "Short",
                Modifier = 2,
                BpCost = 3
            };
            return sensors;
        }

        public Sensor AdvancedSR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Advanced Short-Range",
                Range = "Short",
                Modifier = 4,
                BpCost = 4
            };
            return sensors;
        }

        public Sensor BudgetMR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Budget Medium-Range",
                Range = "Medium",
                Modifier = 0,
                BpCost = 4
            };
            return sensors;
        }

        public Sensor BasicMR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Basic Medium-Range",
                Range = "Medium",
                Modifier = 2,
                BpCost = 5
            };
            return sensors;
        }

        public Sensor AdvancedMR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Advanced Medium-Range",
                Range = "Medium",
                Modifier = 4,
                BpCost = 8
            };
            return sensors;
        }

        public Sensor BudgetLR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Budget Long-Range",
                Range = "Long",
                Modifier = 0,
                BpCost = 6
            };
            return sensors;
        }

        public Sensor BasicLR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Basic Long-Range",
                Range = "Long",
                Modifier = 2,
                BpCost = 10
            };
            return sensors;
        }

        public Sensor AdvancedLR()
        {
            Sensor sensors = new Sensor()
            {
                Type = "Advanced Long-Range",
                Range = "Long",
                Modifier = 4,
                BpCost = 14
            };
            return sensors;
        }
    }
}

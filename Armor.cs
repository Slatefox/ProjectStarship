using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Armor
    {
        private string type;
        private int ac;
        private int targetLock;
        private int turnDistance;
        private int bpCostMulti;

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

        public int Ac
        {
            get
            {
                return ac;
            }

            set
            {
                ac = value;
            }
        }

        public int TargetLock
        {
            get
            {
                return targetLock;
            }

            set
            {
                targetLock = value;
            }
        }

        public int TurnDistance
        {
            get
            {
                return turnDistance;
            }

            set
            {
                turnDistance = value;
            }
        }

        public int BpCostMulti
        {
            get
            {
                return bpCostMulti;
            }

            set
            {
                bpCostMulti = value;
            }
        }

        public Armor None()
        {
            Armor none = new Armor()
            {
                Type = "-Select Armor-"
            };
            return none;
        }

        public Armor Mk1()
        {
            Armor armor = new Armor()
            {
                Type = "Mk1",
                Ac = 1,
                BpCostMulti = 1
            };
            return armor;
        }

        public Armor Mk2()
        {
            Armor armor = new Armor()
            {
                Type = "Mk2",
                Ac = 2,
                BpCostMulti = 2
            };
            return armor;
        }

        public Armor Mk3()
        {
            Armor armor = new Armor()
            {
                Type = "Mk3",
                Ac = 3,
                BpCostMulti = 3
            };
            return armor;
        }

        public Armor Mk4()
        {
            Armor armor = new Armor()
            {
                Type = "Mk4",
                Ac = 4,
                BpCostMulti = 5
            };
            return armor;
        }

        public Armor Mk5()
        {
            Armor armor = new Armor()
            {
                Type = "Mk5",
                Ac = 5,
                TargetLock = -1,
                BpCostMulti = 7
            };
            return armor;
        }

        public Armor Mk6()
        {
            Armor armor = new Armor()
            {
                Type = "Mk6",
                Ac = 6,
                TargetLock = -1,
                BpCostMulti = 9
            };
            return armor;
        }

        public Armor Mk7()
        {
            Armor armor = new Armor()
            {
                Type = "Mk7",
                Ac = 7,
                TargetLock = -1,
                BpCostMulti = 12
            };
            return armor;
        }

        public Armor Mk8()
        {
            Armor armor = new Armor()
            {
                Type = "Mk8",
                Ac = 8,
                TargetLock = -1,
                BpCostMulti = 15
            };
            return armor;
        }

        public Armor Mk9()
        {
            Armor armor = new Armor()
            {
                Type = "Mk9",
                Ac = 9,
                TargetLock = -2,
                TurnDistance = 1,
                BpCostMulti = 18
            };
            return armor;
        }

        public Armor Mk10()
        {
            Armor armor = new Armor()
            {
                Type = "Mk10",
                Ac = 10,
                TargetLock = -2,
                TurnDistance = 1,
                BpCostMulti = 21
            };
            return armor;
        }

        public Armor Mk11()
        {
            Armor armor = new Armor()
            {
                Type = "Mk11",
                Ac = 11,
                TargetLock = -2,
                TurnDistance = 1,
                BpCostMulti = 25
            };
            return armor;
        }

        public Armor Mk12()
        {
            Armor armor = new Armor()
            {
                Type = "Mk12",
                Ac = 12,
                TargetLock = -3,
                TurnDistance = 2,
                BpCostMulti = 30
            };
            return armor;
        }

        public Armor Mk13()
        {
            Armor armor = new Armor()
            {
                Type = "Mk13",
                Ac = 13,
                TargetLock = -3,
                TurnDistance = 2,
                BpCostMulti = 35
            };
            return armor;
        }

        public Armor Mk14()
        {
            Armor armor = new Armor()
            {
                Type = "Mk14",
                Ac = 14,
                TargetLock = -3,
                TurnDistance = 2,
                BpCostMulti = 40
            };
            return armor;
        }

        public Armor Mk15()
        {
            Armor armor = new Armor()
            {
                Type = "Mk15",
                Ac = 15,
                TargetLock = -4,
                TurnDistance = 3,
                BpCostMulti = 45
            };
            return armor;
        }

    }
}

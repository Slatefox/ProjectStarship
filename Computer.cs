using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Computer
    {
        private string type;
        private int bonus01;
        private int bonus02;
        private int bonus03;
        private int bonus04;
        private int nodes;
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

        public int Bonus01
        {
            get
            {
                return bonus01;
            }

            set
            {
                bonus01 = value;
            }
        }

        public int Bonus02
        {
            get
            {
                return bonus02;
            }

            set
            {
                bonus02 = value;
            }
        }

        public int Bonus03
        {
            get
            {
                return bonus03;
            }

            set
            {
                bonus03 = value;
            }
        }

        public int Bonus04
        {
            get
            {
                return bonus04;
            }

            set
            {
                bonus04 = value;
            }
        }

        public int Nodes
        {
            get
            {
                return nodes;
            }

            set
            {
                nodes = value;
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

        public Computer None()
        {
            Computer none = new Computer()
            {
                Type = "-Select Computer-",
            };
            return none;
        }

        public Computer Basic()
        {
            Computer Basic = new Computer()
            {
                Type = "Basic",
                Bonus01 = 0,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 0,
                Pcu = 0,
                BpCost = 0
            };
            return Basic;
        }

        public Computer Mk1Mononode()
        {
            Computer Mk1Mononode = new Computer()
            {
                Type = "Mk1 Mononode",
                Bonus01 = 1,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 10,
                BpCost = 1
            };
            return Mk1Mononode;
        }

        public Computer Mk1Duonode()
        {
            Computer Mk1Duonode = new Computer()
            {
                Type = "Mk1 Duonode",
                Bonus01 = 1,
                Bonus02 = 1,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 10,
                BpCost = 2
            };
            return Mk1Duonode;
        }

        public Computer Mk1Trinode()
        {
            Computer Mk1Trinode = new Computer()
            {
                Type = "Mk1 Trinode",
                Bonus01 = 1,
                Bonus02 = 1,
                Bonus03 = 1,
                Bonus04 = 0,
                Nodes = 3,
                Pcu = 10,
                BpCost = 3
            };
            return Mk1Trinode;
        }

        public Computer Mk1Tetranode()
        {
            Computer Mk1Tetranode = new Computer()
            {
                Type = "Mk1 Tetranode",
                Bonus01 = 1,
                Bonus02 = 1,
                Bonus03 = 1,
                Bonus04 = 1,
                Nodes = 4,
                Pcu = 10,
                BpCost = 4
            };
            return Mk1Tetranode;
        }

        public Computer Mk2Mononode()
        {
            Computer Mk2Mononode = new Computer()
            {
                Type = "Mk2 Mononode",
                Bonus01 = 2,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 15,
                BpCost = 4
            };
            return Mk2Mononode;
        }

        public Computer Mk2Duonode()
        {
            Computer Mk2Duonode = new Computer()
            {
                Type = "Mk2 Duonode",
                Bonus01 = 2,
                Bonus02 = 2,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 15,
                BpCost = 8
            };
            return Mk2Duonode;
        }

        public Computer Mk2Trinode()
        {
            Computer Mk2Trinode = new Computer()
            {
                Type = "Mk2 Trinode",
                Bonus01 = 2,
                Bonus02 = 2,
                Bonus03 = 2,
                Bonus04 = 0,
                Nodes = 3,
                Pcu = 15,
                BpCost = 12
            };
            return Mk2Trinode;
        }

        public Computer Mk2Tetranode()
        {
            Computer Mk2Tetranode = new Computer()
            {
                Type = "Mk2 Tetranode",
                Bonus01 = 2,
                Bonus02 = 2,
                Bonus03 = 2,
                Bonus04 = 2,
                Nodes = 4,
                Pcu = 15,
                BpCost = 16
            };
            return Mk2Tetranode;
        }

        public Computer Mk3Mononode()
        {
            Computer Mk3Mononode = new Computer()
            {
                Type = "Mk3 Mononode",
                Bonus01 = 3,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 20,
                BpCost = 9
            };
            return Mk3Mononode;
        }

        public Computer Mk3Duonode()
        {
            Computer Mk3Duonode = new Computer()
            {
                Type = "Mk3 Duonode",
                Bonus01 = 3,
                Bonus02 = 3,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 3,
                Pcu = 20,
                BpCost = 18
            };
            return Mk3Duonode;
        }

        public Computer Mk3Trinode()
        {
            Computer Mk3Trinode = new Computer()
            {
                Type = "Mk3 Trinode",
                Bonus01 = 3,
                Bonus02 = 3,
                Bonus03 = 3,
                Bonus04 = 0,
                Nodes = 3,
                Pcu = 20,
                BpCost = 27
            };
            return Mk3Trinode;
        }

        public Computer Mk3Tetranode()
        {
            Computer Mk3Tetranode = new Computer()
            {
                Type = "Mk3 Tetranode",
                Bonus01 = 3,
                Bonus02 = 3,
                Bonus03 = 3,
                Bonus04 = 3,
                Nodes = 4,
                Pcu = 20,
                BpCost = 36
            };
            return Mk3Tetranode;
        }

        public Computer Mk4Mononode()
        {
            Computer Mk4Mononode = new Computer()
            {
                Type = "Mk4 Mononode",
                Bonus01 = 4,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 25,
                BpCost = 16
            };
            return Mk4Mononode;
        }

        public Computer Mk4Duonode()
        {
            Computer Mk4Duonode = new Computer()
            {
                Type = "Mk4 Duonode",
                Bonus01 = 4,
                Bonus02 = 4,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 25,
                BpCost = 32
            };
            return Mk4Duonode;
        }

        public Computer Mk4Trinode()
        {
            Computer Mk4Trinode = new Computer()
            {
                Type = "Mk4 Trinode",
                Bonus01 = 4,
                Bonus02 = 4,
                Bonus03 = 4,
                Bonus04 = 0,
                Nodes = 3,
                Pcu = 25,
                BpCost = 48
            };
            return Mk4Trinode;
        }

        public Computer Mk5Mononode()
        {
            Computer Mk5Mononode = new Computer()
            {
                Type = "Mk5 Mononode",
                Bonus01 = 5,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 30,
                BpCost = 25
            };
            return Mk5Mononode;
        }

        public Computer Mk5Duonode()
        {
            Computer Mk5Duonode = new Computer()
            {
                Type = "Mk5 Duonode",
                Bonus01 = 5,
                Bonus02 = 5,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 30,
                BpCost = 50
            };
            return Mk5Duonode;
        }

        public Computer Mk5Trinode()
        {
            Computer Mk5Trinode = new Computer()
            {
                Type = "Mk5 Trinode",
                Bonus01 = 5,
                Bonus02 = 5,
                Bonus03 = 5,
                Bonus04 = 0,
                Nodes = 3,
                Pcu = 30,
                BpCost = 75
            };
            return Mk5Trinode;
        }

        public Computer Mk6Mononode()
        {
            Computer Mk6Mononode = new Computer()
            {
                Type = "Mk6 Mononode",
                Bonus01 = 6,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 35,
                BpCost = 36
            };
            return Mk6Mononode;
        }

        public Computer Mk6Duonode()
        {
            Computer Mk6Duonode = new Computer()
            {
                Type = "Mk6 Duonode",
                Bonus01 = 6,
                Bonus02 = 6,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 35,
                BpCost = 72
            };
            return Mk6Duonode;
        }

        public Computer Mk7Mononode()
        {
            Computer Mk7Mononode = new Computer()
            {
                Type = "Mk7 Mononode",
                Bonus01 = 7,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 40,
                BpCost = 49
            };
            return Mk7Mononode;
        }

        public Computer Mk7Duonode()
        {
            Computer Mk7Duonode = new Computer()
            {
                Type = "Mk7 Duonode",
                Bonus01 = 7,
                Bonus02 = 7,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 40,
                BpCost = 98
            };
            return Mk7Duonode;
        }

        public Computer Mk8Mononode()
        {
            Computer Mk8Mononode = new Computer()
            {
                Type = "Mk8 Mononode",
                Bonus01 = 8,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 45,
                BpCost = 64
            };
            return Mk8Mononode;
        }

        public Computer Mk8Duonode()
        {
            Computer Mk8Duonode = new Computer()
            {
                Type = "Mk8 Duonode",
                Bonus01 = 8,
                Bonus02 = 8,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 45,
                BpCost = 128
            };
            return Mk8Duonode;
        }

        public Computer Mk9Mononode()
        {
            Computer Mk9Mononode = new Computer()
            {
                Type = "Mk9 Mononode",
                Bonus01 = 9,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 50,
                BpCost = 81
            };
            return Mk9Mononode;
        }

        public Computer Mk9Duonode()
        {
            Computer Mk9Duonode = new Computer()
            {
                Type = "Mk9 Duonode",
                Bonus01 = 9,
                Bonus02 = 9,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 50,
                BpCost = 162
            };
            return Mk9Duonode;
        }

        public Computer Mk10Mononode()
        {
            Computer Mk10Mononode = new Computer()
            {
                Type = "Mk10 Mononode",
                Bonus01 = 10,
                Bonus02 = 0,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 1,
                Pcu = 55,
                BpCost = 100
            };
            return Mk10Mononode;
        }

        public Computer Mk10Duonode()
        {
            Computer Mk10Duonode = new Computer()
            {
                Type = "Mk10 Duonode",
                Bonus01 = 10,
                Bonus02 = 10,
                Bonus03 = 0,
                Bonus04 = 0,
                Nodes = 2,
                Pcu = 55,
                BpCost = 200
            };
            return Mk10Duonode;
        }

    }

}

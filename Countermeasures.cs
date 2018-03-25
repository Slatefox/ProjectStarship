using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Countermeasures
    {
        private string type;
        private int tlBonus;
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

        public int TlBonus
        {
            get
            {
                return tlBonus;
            }

            set
            {
                tlBonus = value;
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

        public Countermeasures None()
        {
            Countermeasures none = new Countermeasures()
            {
                Type = "-Select Countermeasures-"
            };
            return none;
        }

        public Countermeasures Mk1Defense()
        {
            Countermeasures Mk1 = new Countermeasures()
            {
                Type = "Mk 1 Defense",
                TlBonus = 1,
                Pcu = 1,
                BpCost = 2
            };
            return Mk1;
        }

        public Countermeasures Mk2Defense()
        {
            Countermeasures Mk2 = new Countermeasures()
            {
                Type = "Mk 2 Defense",
                TlBonus = 2,
                Pcu = 1,
                BpCost = 3
            };
            return Mk2;
        }

        public Countermeasures Mk3Defense()
        {
            Countermeasures Mk3 = new Countermeasures()
            {
                Type = "Mk 3 Defense",
                TlBonus = 3,
                Pcu = 2,
                BpCost = 4
            };
            return Mk3;
        }

        public Countermeasures Mk4Defense()
        {
            Countermeasures Mk4 = new Countermeasures()
            {
                Type = "Mk 4 Defense",
                TlBonus = 4,
                Pcu = 3,
                BpCost = 6
            };
            return Mk4;
        }

        public Countermeasures Mk5Defense()
        {
            Countermeasures Mk5 = new Countermeasures()
            {
                Type = "Mk 5 Defense",
                TlBonus = 5,
                Pcu = 4,
                BpCost = 8
            };
            return Mk5;
        }

        public Countermeasures Mk6Defense()
        {
            Countermeasures Mk6 = new Countermeasures()
            {
                Type = "Mk 6 Defense",
                TlBonus = 6,
                Pcu = 5,
                BpCost = 11
            };
            return Mk6;
        }

        public Countermeasures Mk7Defense()
        {
            Countermeasures Mk7 = new Countermeasures()
            {
                Type = "Mk 7 Defense",
                TlBonus = 7,
                Pcu = 7,
                BpCost = 14
            };
            return Mk7;
        }

        public Countermeasures Mk8Defense()
        {
            Countermeasures Mk8 = new Countermeasures()
            {
                Type = "Mk 8 Defense",
                TlBonus = 8,
                Pcu = 9,
                BpCost = 18
            };
            return Mk8;
        }

        public Countermeasures Mk9Defense()
        {
            Countermeasures Mk9 = new Countermeasures()
            {
                Type = "Mk 9 Defense",
                TlBonus = 9,
                Pcu = 11,
                BpCost = 22
            };
            return Mk9;
        }

        public Countermeasures Mk10Defense()
        {
            Countermeasures Mk10 = new Countermeasures()
            {
                Type = "Mk 10 Defense",
                TlBonus = 10,
                Pcu = 13,
                BpCost = 27
            };
            return Mk10;
        }

        public Countermeasures Mk11Defense()
        {
            Countermeasures Mk11 = new Countermeasures()
            {
                Type = "Mk 11 Defense",
                TlBonus = 11,
                Pcu = 16,
                BpCost = 33
            };
            return Mk11;
        }

        public Countermeasures Mk12Defense()
        {
            Countermeasures Mk12 = new Countermeasures()
            {
                Type = "Mk 12 Defense",
                TlBonus = 12,
                Pcu = 20,
                BpCost = 40
            };
            return Mk12;
        }

        public Countermeasures Mk13Defense()
        {
            Countermeasures Mk13 = new Countermeasures()
            {
                Type = "Mk 13 Defense",
                TlBonus = 13,
                Pcu = 25,
                BpCost = 50
            };
            return Mk13;
        }

        public Countermeasures Mk14Defense()
        {
            Countermeasures Mk14 = new Countermeasures()
            {
                Type = "Mk 14 Defense",
                TlBonus = 14,
                Pcu = 32,
                BpCost = 65
            };
            return Mk14;
        }

        public Countermeasures Mk15Defense()
        {
            Countermeasures Mk15 = new Countermeasures()
            {
                Type = "Mk 15 Defense",
                TlBonus = 15,
                Pcu = 45,
                BpCost = 90
            };
            return Mk15;
        }

    }
}

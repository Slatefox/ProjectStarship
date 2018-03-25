using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Thruster
    {
        private string type;
        private string size;
        private int speed;
        private int piloting;
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

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public int Piloting
        {
            get
            {
                return piloting;
            }

            set
            {
                piloting = value;
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

        public Thruster None()
        {
            Thruster none = new Thruster()
            {
                Type = "-Select Thrusters-"
            };
            return none;
        }

        public Thruster T6()
        {
            Thruster T6 = new Thruster()
            {
                Type = "T6",
                Size = "Tiny",
                Speed = 6,
                Piloting = 1,
                Pcu = 20,
                BpCost = 3
            };
            return T6;
        }

        public Thruster T8()
        {
            Thruster T8 = new Thruster()
            {
                Type = "T8",
                Size = "Tiny",
                Speed = 8,
                Piloting = 0,
                Pcu = 25,
                BpCost = 4
            };
            return T8;
        }

        public Thruster T10()
        {
            Thruster T10 = new Thruster()
            {
                Type = "T10",
                Size = "Tiny",
                Speed = 10,
                Piloting = 0,
                Pcu = 30,
                BpCost = 5
            };
            return T10;
        }

        public Thruster T12()
        {
            Thruster T12 = new Thruster()
            {
                Type = "T12",
                Size = "Tiny",
                Speed = 12,
                Piloting = -1,
                Pcu = 35,
                BpCost = 6
            };
            return T12;
        }

        public Thruster T14()
        {
            Thruster T14 = new Thruster()
            {
                Type = "T14",
                Size = "Tiny",
                Speed = 14,
                Piloting = -2,
                Pcu = 40,
                BpCost = 7
            };
            return T14;
        }

        public Thruster S6()
        {
            Thruster S6 = new Thruster()
            {
                Type = "S6",
                Size = "Small",
                Speed = 6,
                Piloting = 1,
                Pcu = 30,
                BpCost = 3
            };
            return S6;
        }

        public Thruster S8()
        {
            Thruster S8 = new Thruster()
            {
                Type = "S8",
                Size = "Small",
                Speed = 8,
                Piloting = 0,
                Pcu = 40,
                BpCost = 4
            };
            return S8;
        }

        public Thruster S10()
        {
            Thruster S10 = new Thruster()
            {
                Type = "S10",
                Size = "Small",
                Speed = 10,
                Piloting = 0,
                Pcu = 50,
                BpCost = 5
            };
            return S10;
        }

        public Thruster S12()
        {
            Thruster S12 = new Thruster()
            {
                Type = "S12",
                Size = "Small",
                Speed = 12,
                Piloting = -1,
                Pcu = 60,
                BpCost = 6
            };
            return S12;
        }

        public Thruster M4()
        {
            Thruster M4 = new Thruster()
            {
                Type = "M4",
                Size = "Medium",
                Speed = 4,
                Piloting = 2,
                Pcu = 40,
                BpCost = 2
            };
            return M4;
        }

        public Thruster M6()
        {
            Thruster M6 = new Thruster()
            {
                Type = "M6",
                Size = "Medium",
                Speed = 6,
                Piloting = 1,
                Pcu = 50,
                BpCost = 3
            };
            return M6;
        }

        public Thruster M8()
        {
            Thruster M8 = new Thruster()
            {
                Type = "M8",
                Size = "Medium",
                Speed = 8,
                Piloting = 0,
                Pcu = 60,
                BpCost = 4
            };
            return M8;
        }

        public Thruster M10()
        {
            Thruster M10 = new Thruster()
            {
                Type = "M10",
                Size = "Medium",
                Speed = 10,
                Piloting = 0,
                Pcu = 70,
                BpCost = 5
            };
            return M10;
        }

        public Thruster M12()
        {
            Thruster M12 = new Thruster()
            {
                Type = "M12",
                Size = "Medium",
                Speed = 12,
                Piloting = -1,
                Pcu = 80,
                BpCost = 6
            };
            return M12;
        }

        public Thruster L4()
        {
            Thruster L4 = new Thruster()
            {
                Type = "L4",
                Size = "Large",
                Speed = 4,
                Piloting = 2,
                Pcu = 60,
                BpCost = 4
            };
            return L4;
        }

        public Thruster L6()
        {
            Thruster L6 = new Thruster()
            {
                Type = "L6",
                Size = "Large",
                Speed = 6,
                Piloting = 1,
                Pcu = 80,
                BpCost = 6
            };
            return L6;
        }

        public Thruster L8()
        {
            Thruster L8 = new Thruster()
            {
                Type = "L8",
                Size = "Large",
                Speed = 8,
                Piloting = 0,
                Pcu = 100,
                BpCost = 8
            };
            return L8;
        }

        public Thruster L10()
        {
            Thruster L10 = new Thruster()
            {
                Type = "L10",
                Size = "Large",
                Speed = 10,
                Piloting = 0,
                Pcu = 120,
                BpCost = 10
            };
            return L10;
        }

        public Thruster H4()
        {
            Thruster H4 = new Thruster()
            {
                Type = "H4",
                Size = "Huge",
                Speed = 4,
                Piloting = 2,
                Pcu = 80,
                BpCost = 4
            };
            return H4;
        }

        public Thruster H6()
        {
            Thruster H6 = new Thruster()
            {
                Type = "H6",
                Size = "Huge",
                Speed = 6,
                Piloting = 1,
                Pcu = 120,
                BpCost = 6
            };
            return H6;
        }

        public Thruster H8()
        {
            Thruster H8 = new Thruster()
            {
                Type = "H8",
                Size = "Huge",
                Speed = 8,
                Piloting = 0,
                Pcu = 140,
                BpCost = 8
            };
            return H8;
        }

        public Thruster H10()
        {
            Thruster H10 = new Thruster()
            {
                Type = "H10",
                Size = "Huge",
                Speed = 10,
                Piloting = 0,
                Pcu = 160,
                BpCost = 10
            };
            return H10;
        }

        public Thruster G4()
        {
            Thruster G4 = new Thruster()
            {
                Type = "G4",
                Size = "Gargantuan",
                Speed = 4,
                Piloting = 2,
                Pcu = 120,
                BpCost = 8
            };
            return G4;
        }

        public Thruster G6()
        {
            Thruster G6 = new Thruster()
            {
                Type = "G6",
                Size = "Gargantuan",
                Speed = 6,
                Piloting = 1,
                Pcu = 180,
                BpCost = 12
            };
            return G6;
        }

        public Thruster G8()
        {
            Thruster G8 = new Thruster()
            {
                Type = "G8",
                Size = "Gargantuan",
                Speed = 8,
                Piloting = 0,
                Pcu = 240,
                BpCost = 16
            };
            return G8;
        }

        public Thruster C4()
        {
            Thruster C4 = new Thruster()
            {
                Type = "C4",
                Size = "Colossal",
                Speed = 4,
                Piloting = 2,
                Pcu = 200,
                BpCost = 8
            };
            return C4;
        }

        public Thruster C6()
        {
            Thruster C6 = new Thruster()
            {
                Type = "C6",
                Size = "Colossal",
                Speed = 6,
                Piloting = 1,
                Pcu = 300,
                BpCost = 12
            };
            return C6;
        }

        public Thruster C8()
        {
            Thruster C8 = new Thruster()
            {
                Type = "C8",
                Size = "Colossal",
                Speed = 8,
                Piloting = 0,
                Pcu = 400,
                BpCost = 16
            };
            return C8;
        }

    }
}

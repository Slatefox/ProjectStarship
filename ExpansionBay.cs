using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class ExpansionBay
    {
        private string type;
        private int pcu;
        private int bpCost;
        private int expSlotNum;

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

        public int ExpSlotNum
        {
            get
            {
                return expSlotNum;
            }

            set
            {
                expSlotNum = value;
            }
        }


        public ExpansionBay None()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "-Select Expansion Bay Type-"
            };
            return bay;
        }

        public ExpansionBay ArcaneLaboratory()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Arcane Laboratory",
                Pcu = 1,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay CargoHold()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Cargo Hold",
                Pcu = 0,
                BpCost = 0,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay EscapePods()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Escape Pods",
                Pcu = 2,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay GuestQuarters()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Guest Quarters",
                Pcu = 1,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay HangarBay()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Hangar Bay",
                Pcu = 30,
                BpCost = 10,
                ExpSlotNum = 4
            };
            return bay;
        }

        public ExpansionBay LifeBoats()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Life Boats",
                Pcu = 30,
                BpCost = 10,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay MedicalBay()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Medical Bay",
                Pcu = 4,
                BpCost = 8,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay PassengerSeating()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Passenger Seating",
                Pcu = 0,
                BpCost = 0,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay PowerCoreHousing()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Power Core Housing",
                Pcu = 0,
                BpCost = 10,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay Gym()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Rec Suite - Gym",
                Pcu = 0,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay TrividDen()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Rec Suite - Trivid Den",
                Pcu = 1,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay HAC()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Rec Suite - HAC",
                Pcu = 3,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay ScienceLab()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Science Lab",
                Pcu = 2,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay SealedEnviroChamber()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Sealed Environment Chamber",
                Pcu = 2,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay ShuttleBay()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Shuttle Bay",
                Pcu = 10,
                BpCost = 4,
                ExpSlotNum = 2
            };
            return bay;
        }

        public ExpansionBay SmugglerCompartment()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Smuggler Compartment",
                Pcu = 4,
                BpCost = 2,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay SynthesisBay()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Synthesis Bay",
                Pcu = 2,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }

        public ExpansionBay TechWorkshop()
        {
            ExpansionBay bay = new ExpansionBay()
            {
                Type = "Tech Workshop",
                Pcu = 3,
                BpCost = 1,
                ExpSlotNum = 1
            };
            return bay;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class WeaponSlotSize
    {
        private string size;

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

        public WeaponSlotSize None()
        {
            WeaponSlotSize slot = new WeaponSlotSize()
            {
                Size = "-None-"
            };
            return slot;
        }

        public WeaponSlotSize Light()
        {
            WeaponSlotSize slot = new WeaponSlotSize()
            {
                Size = "Light"
            };
            return slot;
        }

        public WeaponSlotSize Heavy()
        {
            WeaponSlotSize slot = new WeaponSlotSize()
            {
                Size = "Heavy"
            };
            return slot;
        }

        public WeaponSlotSize Capital()
        {
            WeaponSlotSize slot = new WeaponSlotSize()
            {
                Size = "Capital"
            };
            return slot;
        }
    }
}

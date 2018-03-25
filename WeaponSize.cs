using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    extern class WeaponSize
    {
        private static string size;

        public static string Size
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

        public static string LightWpn();
        {
            return "Light";
        }
    }
}

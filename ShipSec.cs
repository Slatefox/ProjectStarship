using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class ShipSec
    {
        private bool antiHack;
        private int antiHackLvl;
        private bool antiPersonnelWpn;
        private string antiPersonnelWpnType;
        private int antiPersonnelWpnLvl;
        private bool compCountermeasures;
        private bool compAlarm;
        private bool compFakeShell;
        private bool compFeedback;
        private bool compFirewall;
        private bool compLockout;
        private bool compShockGrid;
        private bool compWipe;
        private bool biolocks;
        private bool sds;

        public bool AntiHack
        {
            get
            {
                return antiHack;
            }

            set
            {
                antiHack = value;
            }
        }

        public int AntiHackLvl
        {
            get
            {
                return antiHackLvl;
            }

            set
            {
                antiHackLvl = value;
            }
        }

        public bool AntiPersonnelWpn
        {
            get
            {
                return antiPersonnelWpn;
            }

            set
            {
                antiPersonnelWpn = value;
            }
        }

        public string AntiPersonnelWpnType
        {
            get
            {
                return antiPersonnelWpnType;
            }

            set
            {
                antiPersonnelWpnType = value;
            }
        }

        public int AntiPersonnelWpnLvl
        {
            get
            {
                return antiPersonnelWpnLvl;
            }

            set
            {
                antiPersonnelWpnLvl = value;
            }
        }

        public bool CompCountermeasures
        {
            get
            {
                return compCountermeasures;
            }

            set
            {
                compCountermeasures = value;
            }
        }

        public bool CompAlarm
        {
            get
            {
                return compAlarm;
            }

            set
            {
                compAlarm = value;
            }
        }

        public bool CompFakeShell
        {
            get
            {
                return compFakeShell;
            }

            set
            {
                compFakeShell = value;
            }
        }

        public bool CompFeedback
        {
            get
            {
                return compFeedback;
            }

            set
            {
                compFeedback = value;
            }
        }

        public bool CompFirewall
        {
            get
            {
                return compFirewall;
            }

            set
            {
                compFirewall = value;
            }
        }

        public bool CompLockout
        {
            get
            {
                return compLockout;
            }

            set
            {
                compLockout = value;
            }
        }

        public bool CompShockGrid
        {
            get
            {
                return compShockGrid;
            }

            set
            {
                compShockGrid = value;
            }
        }

        public bool CompWipe
        {
            get
            {
                return compWipe;
            }

            set
            {
                compWipe = value;
            }
        }

        public bool Biolocks
        {
            get
            {
                return biolocks;
            }

            set
            {
                biolocks = value;
            }
        }

        public bool Sds
        {
            get
            {
                return sds;
            }

            set
            {
                sds = value;
            }
        }
    }
}

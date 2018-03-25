using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Starship_Hanger
{
    class Weapon
    {
        private string type;
        private string size;
        private bool tracking;
        private string range;
        private int speed;
        private string damage;
        private string specialProp1;
        private string specialProp2;
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

        public bool Tracking
        {
            get
            {
                return tracking;
            }

            set
            {
                tracking = value;
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

        public string Damage
        {
            get
            {
                return damage;
            }

            set
            {
                damage = value;
            }
        }

        public string SpecialProp1
        {
            get
            {
                return specialProp1;
            }

            set
            {
                specialProp1 = value;
            }
        }

        public string SpecialProp2
        {
            get
            {
                return specialProp2;
            }

            set
            {
                specialProp2 = value;
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

        public Weapon None()
        {
            Weapon wpn = new Weapon()
            {
                Type = "-Select Weapon-"
            };
            return wpn;
        }

        public Weapon ChainCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Chain Cannon",
                Size = "Light",
                Tracking = false,
                Range = "Short",
                Damage = "6d4",
                SpecialProp1 = "Ripper",
                Pcu = 15,
                BpCost = 15
            };
            return wpn;
        }

        public Weapon Coilgun()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Coilgun",
                Size = "Light",
                Tracking = false,
                Range = "Long",
                Damage = "4d4",
                Pcu = 10,
                BpCost = 6
            };
            return wpn;
        }

        public Weapon Flakthrower()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Flak Thrower",
                Size = "Light",
                Tracking = false,
                Range = "Short",
                Damage = "3d4",
                SpecialProp1 = "Point(+8)",
                Pcu = 10,
                BpCost = 5
            };
            return wpn;
        }

        public Weapon Gyrolaser()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Gyrolaser",
                Size = "Light",
                Tracking = false,
                Range = "Short",
                Damage = "1d8",
                SpecialProp1 = "Broad Arc",
                Pcu = 10,
                BpCost = 3
            };
            return wpn;
        }

        public Weapon LaserNet()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Laser Net",
                Size = "Light",
                Tracking = false,
                Range = "Short",
                Damage = "2d6",
                SpecialProp1 = "Point(+10)",
                Pcu = 10,
                BpCost = 9
            };
            return wpn;
        }

        public Weapon LightEMPCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Light EMP Cannon",
                Size = "Light",
                Tracking = false,
                Range = "Short",
                Damage = "Special",
                SpecialProp1 = "EMP",
                Pcu = 10,
                BpCost = 8
            };
            return wpn;
        }

        public Weapon LightLaserCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Light Laser Cannon",
                Size = "Light",
                Tracking = false,
                Range = "Short",
                Damage = "2d4",
                Pcu = 5,
                BpCost = 2
            };
            return wpn;
        }

        public Weapon LightParticleBeam()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Light Particle Beam",
                Size = "Light",
                Tracking = false,
                Range = "Mediium",
                Damage = "3d6",
                Pcu = 10,
                BpCost = 10
            };
            return wpn;
        }

        public Weapon LightPlasmaCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Light Plasma Cannon",
                Size = "Light",
                Tracking = false,
                Range = "Short",
                Damage = "2d12",
                Pcu = 10,
                BpCost = 12
            };
            return wpn;
        }

        public Weapon HEMissileLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "High Explosive Missile Launcher",
                Size = "Light",
                Tracking = true,
                Range = "Long",
                Speed = 12,
                Damage = "4d8",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 10,
                BpCost = 4
            };
            return wpn;
        }

        public Weapon LightPlasmaTorpLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Light Plasma Torpedo Launcher",
                Size = "Light",
                Tracking = true,
                Range = "Long",
                Speed = 14,
                Damage = "3d8",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 5,
                BpCost = 5
            };
            return wpn;
        }

        public Weapon LightTorpedoLaucher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Light Torpedo Laucher",
                Size = "Light",
                Tracking = true,
                Range = "Long",
                Speed = 16,
                Damage = "2d8",
                Pcu = 5,
                BpCost = 4
            };
            return wpn;
        }

        public Weapon MicromissileBattery()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Micromissile Battery",
                Size = "Light",
                Tracking = true,
                Range = "Long",
                Speed = 10,
                Damage = "2d6",
                SpecialProp1 = "Limited Fire 5",
                SpecialProp2 = "Array",
                Pcu = 10,
                BpCost = 3
            };
            return wpn;
        }

        public Weapon TacNukeMissileLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Tactical Nuclear Missile Launcher",
                Size = "Light",
                Tracking = true,
                Range = "Long",
                Speed = 10,
                Damage = "5d8",
                SpecialProp1 = "Limited Fire 5",
                SpecialProp2 = "Irradiate(Low)",
                Pcu = 10,
                BpCost = 5
            };
            return wpn;
        }

        public Weapon Graser()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Graser",
                Size = "Heavy",
                Tracking = false,
                Range = "Short",
                Damage = "7d6",
                SpecialProp1 = "Irradiate(Medium)",
                Pcu = 40,
                BpCost = 35
            };
            return wpn;
        }

        public Weapon GravityGun()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Gravity Gun",
                Size = "Heavy",
                Tracking = false,
                Range = "Medium",
                Damage = "6d6",
                SpecialProp1 = "Tractor Beam",
                Pcu = 40,
                BpCost = 30
            };
            return wpn;
        }

        public Weapon HeavyEMPCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy EMP Cannon",
                Size = "Heavy",
                Tracking = false,
                Range = "Medium",
                Damage = "Special",
                SpecialProp1 = "EMP",
                Pcu = 30,
                BpCost = 24
            };
            return wpn;
        }

        public Weapon HeavyLaserArray()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy Laser Array",
                Size = "Heavy",
                Tracking = false,
                Range = "Short",
                Damage = "6d4",
                SpecialProp1 = "Array",
                Pcu = 15,
                BpCost = 10
            };
            return wpn;
        }

        public Weapon HeavyLaserCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy Laser Cannon",
                Size = "Heavy",
                Tracking = false,
                Range = "Medium",
                Damage = "4d8",
                Pcu = 10,
                BpCost = 8
            };
            return wpn;
        }

        public Weapon HeavyLaserNet()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy Laser Net",
                Size = "Heavy",
                Tracking = false,
                Range = "Short",
                Damage = "5d6",
                SpecialProp1 = "Point(+12)",
                Pcu = 15,
                BpCost = 12
            };
            return wpn;
        }

        public Weapon Maser()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Maser",
                Size = "Heavy",
                Tracking = false,
                Range = "Long",
                Damage = "6d10",
                Pcu = 35,
                BpCost = 22
            };
            return wpn;
        }

        public Weapon ParticleBeam()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Particle Beam",
                Size = "Heavy",
                Tracking = false,
                Range = "Long",
                Damage = "8d6",
                Pcu = 25,
                BpCost = 15
            };
            return wpn;
        }

        public Weapon PersistentParticleBeam()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Persistent Particle Beam",
                Size = "Heavy",
                Tracking = false,
                Range = "Long",
                Damage = "10d6",
                Pcu = 40,
                BpCost = 25
            };
            return wpn;
        }

        public Weapon PlasmaCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Plasma Cannon",
                Size = "Heavy",
                Tracking = false,
                Range = "Medium",
                Damage = "5d12",
                Pcu = 30,
                BpCost = 20
            };
            return wpn;
        }

        public Weapon Railgun()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Railgun",
                Size = "Heavy",
                Tracking = false,
                Range = "Long",
                Damage = "8d4",
                Pcu = 20,
                BpCost = 15
            };
            return wpn;
        }

        public Weapon TwinLaser()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Twin Laser",
                Size = "Heavy",
                Tracking = false,
                Range = "Long",
                Damage = "5d8",
                Pcu = 15,
                BpCost = 12
            };
            return wpn;
        }

        public Weapon XLaserCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "X-Laser Cannon",
                Size = "Heavy",
                Tracking = false,
                Range = "Long",
                Damage = "8d6",
                SpecialProp1 = "Line",
                Pcu = 40,
                BpCost = 35
            };
            return wpn;
        }

        public Weapon HeavyAMMissileLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy Antimatter Missile Launcher",
                Size = "Heavy",
                Tracking = true,
                Range = "Long",
                Speed = 8,
                Damage = "10d10",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 15,
                BpCost = 12
            };
            return wpn;
        }

        public Weapon HeavyNukeMissileLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy Nuclear Missile Launcher",
                Size = "Heavy",
                Tracking = true,
                Range = "Long",
                Speed = 10,
                Damage = "10d8",
                SpecialProp1 = "Limited Fire 5",
                SpecialProp2 = "Irradiate(Medium)",
                Pcu = 15,
                BpCost = 10
            };
            return wpn;
        }

        public Weapon HeavyPlasmaTorpLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy Plasma Torpedo Launcher",
                Size = "Heavy",
                Tracking = true,
                Range = "Long",
                Speed = 12,
                Damage = "5d10",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 10,
                BpCost = 10
            };
            return wpn;
        }

        public Weapon HeavyTorpLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Heavy Torpedo Launcher",
                Size = "Heavy",
                Tracking = true,
                Range = "Long",
                Speed = 14,
                Damage = "5d8",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 10,
                BpCost = 8
            };
            return wpn;
        }

        public Weapon GravityCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Gravity Cannon",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "2d6 x 10",
                SpecialProp1 = "Tractor Beam",
                Pcu = 40,
                BpCost = 50
            };
            return wpn;
        }

        public Weapon MassDriver()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Mass Driver",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "2d6 x 10",
                Pcu = 25,
                BpCost = 25
            };
            return wpn;
        }

        public Weapon ParticleBeamCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Particle Beam Cannon",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "3d4 x 10",
                Pcu = 30,
                BpCost = 30
            };
            return wpn;
        }

        public Weapon PersistentParticleBeamCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Persistent Paricle Beam Cannon",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "2d10 x 10",
                Pcu = 50,
                BpCost = 40
            };
            return wpn;
        }

        public Weapon SuperEMPCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Super EMP Cannon",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "Special",
                SpecialProp1 = "EMP",
                Pcu = 45,
                BpCost = 45
            };
            return wpn;
        }

        public Weapon SuperPlasmaCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Super Plasma Cannon",
                Size = "Capital",
                Tracking = false,
                Range = "Medium",
                Damage = "3d6 x 10",
                Pcu = 45,
                BpCost = 35
            };
            return wpn;
        }

        public Weapon SuperXLaserCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Super X-Laser Cannon",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "3d4 x 10",
                SpecialProp1 = "Line",
                Pcu = 50,
                BpCost = 60
            };
            return wpn;
        }

        public Weapon Supergraser()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Supergraser",
                Size = "Capital",
                Tracking = false,
                Range = "Medium",
                Damage = "2d8 x 10",
                SpecialProp1 = "Irradiate(High)",
                Pcu = 50,
                BpCost = 60
            };
            return wpn;
        }

        public Weapon Superlaser()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Superlaser",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "2d4 x 10",
                Pcu = 20,
                BpCost = 20
            };
            return wpn;
        }

        public Weapon Supermaser()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Supermaser",
                Size = "Capital",
                Tracking = false,
                Range = "Long",
                Damage = "2d8 x 10",
                Pcu = 40,
                BpCost = 35
            };
            return wpn;
        }

        public Weapon VortexCannon()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Vortex Cannon",
                Size = "Capital",
                Tracking = false,
                Range = "Medium",
                Damage = "2d12 x 10",
                SpecialProp1 = "Tractor Beam",
                Pcu = 55,
                BpCost = 75
            };
            return wpn;
        }

        public Weapon AMMegaMissileLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Antimatter Mega-missile Launcher",
                Size = "Capital",
                Tracking = true,
                Range = "Long",
                Speed = 6,
                Damage = "4d10 x 10",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 15,
                BpCost = 25
            };
            return wpn;
        }

        public Weapon HellfireTorpLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Hellfire Torpedo Launcher",
                Size = "Capital",
                Tracking = true,
                Range = "Long",
                Speed = 8,
                Damage = "2d10 x 10",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 10,
                BpCost = 25
            };
            return wpn;
        }

        public Weapon NukeMegaMissileLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Nuclear Mega-missile Launcher",
                Size = "Capital",
                Tracking = true,
                Range = "Long",
                Speed = 8,
                Damage = "4d8 x 10",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 15,
                BpCost = 20
            };
            return wpn;
        }

        public Weapon QuantumMissileLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Quantum Missile Launcher",
                Size = "Capital",
                Tracking = true,
                Range = "Long",
                Speed = 12,
                Damage = "2d8 x 10",
                SpecialProp1 = "Limited Fire 5",
                SpecialProp2 = "Quantum",
                Pcu = 15,
                BpCost = 25
            };
            return wpn;
        }

        public Weapon SolarTorpLauncher()
        {
            Weapon wpn = new Weapon()
            {
                Type = "Solar Torpedo Launcher",
                Size = "Capital",
                Tracking = true,
                Range = "Long",
                Speed = 10,
                Damage = "2d6 x 10",
                SpecialProp1 = "Limited Fire 5",
                Pcu = 10,
                BpCost = 20
            };
            return wpn;
        }
    }
}

using Process.NET;
using Process.NET.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Strike_1._6_API
{
    public class Counter_Strike_1_6_API
    {
        public _Game_ Game;
        public _Console_ Console;
        public Counter_Strike_1_6_API()
        {
            Game = new _Game_();
            Console = new _Console_();
        }
        public class _Console_
        {
            public int TextLenght
            {
                get
                {
                    return 0;
                }
            }
        }
        public class _Game_
        {
            public _LocalPlayer_ LocalPlayer;
            public _Game_()
            {
                LocalPlayer = new _LocalPlayer_();
            }
            public class _LocalPlayer_
            {
                public _Weapons_ Weapons;
                public _LocalPlayer_()
                {
                    Weapons = new _Weapons_();
                }
                public int Health
                {
                    get
                    {
                        var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                        if (process != null)
                        {
                            var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                            var healthadd = clientdll + 0x121738;
                            int health = process.Memory.Read<int>(healthadd);
                            return health;
                        }
                        else { return -1; }
                    }
                }
                public int Armor
                {
                    get
                    {
                        var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                        if (process != null)
                        {
                            var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                            var healthadd = clientdll + 0x12302C;
                            int health = process.Memory.Read<int>(healthadd);
                            return health;
                        } else { return -1; }
                    }
                }
                public int Money
                {
                    get
                    {
                        var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                        if (process != null)
                        {
                            var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                            var healthadd = clientdll + 0x1254E4;
                            int health = process.Memory.Read<int>(healthadd);
                            return health;
                        } else { return -1; }
                    }
                }
                public class _Weapons_
                {
                    public _DesertEagle_ DesertEagle;
                    public _USP_ USP;
                    public _Glock_ Glock;
                    public _M4A4_ M4A4;
                    public _Weapons_()
                    {
                        DesertEagle = new _DesertEagle_();
                        USP = new _USP_();
                        M4A4 = new _M4A4_();
                        Glock = new _Glock_();
                    }
                    public class _M4A4_
                    {
                        public bool Silencer
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x0000C188 + 994040;
                                    var healthadd2 = healthadd + 0xA30 + 0x50;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    if (health == 4)
                                    {
                                        return true;
                                    } else { return false; }
                                }
                                else { return false; }
                            }
                        }
                        public bool Reload
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x0000C188 + 994040;
                                    var healthadd2 = healthadd + 0xA30;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    return Convert.ToBoolean(health);
                                }
                                else { return false; }
                            }
                        }
                        public int Ammo
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x0000C188 + 994040;
                                    var healthadd2 = healthadd + 0xA24;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    return health;
                                }
                                else { return -1; }
                            }
                        }
                    }
                    public class _Glock_
                    {
                        public bool Reload
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0xF8B2C;
                                    var healthadd2 = healthadd + 0xC;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    return Convert.ToBoolean(health);
                                }
                                else { return false; }
                            }
                        }
                        public int Ammo
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0xF8B2C;
                                    int health = process.Memory.Read<int>(healthadd);
                                    return health;
                                }
                                else { return -1; }
                            }
                        }
                    }
                    public class _USP_
                    {
                        public bool Silencer
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x0000D710 + 0xEB154;
                                    var healthadd2 = healthadd + 0x34 + 0x50;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    if (health == 1)
                                    {
                                        return true;
                                    }
                                    else { return false; }
                                }
                                else { return false; }
                            }
                        }
                        public bool Reload
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x0000D710 + 0xEB154;
                                    var healthadd2 = healthadd + 0x34;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    return Convert.ToBoolean(health);
                                }
                                else { return false; }
                            }
                        }
                        public int Ammo
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x0000D710 + 0xEB154;
                                    var healthadd2 = healthadd + 0x34 - 0xC;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    return health;
                                } else { return -1; }
                            }
                        }
                    }
                    public class _DesertEagle_
                    {
                        public bool Reload
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x000FEC74 - 0x60CC;
                                    var healthadd2 = healthadd + 0xD8;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    return Convert.ToBoolean(health);
                                } else { return false; }
                            }
                        }
                        public int Ammo
                        {
                            get
                            {
                                var process = new ProcessSharp(Settings.game, MemoryType.Remote);
                                if (process != null)
                                {
                                    var clientdll = Settings.getModuleAdress("client.dll", Settings.game);
                                    var healthadd = clientdll + 0x000FEC74 - 0x60CC;
                                    var healthadd2 = healthadd + 0xD8 - 0xC;
                                    int health = process.Memory.Read<int>(healthadd2);
                                    return health;
                                } else { return -1; }
                            }
                        }
                    }
                }
            }

            public static class Settings
            {
                public static System.Diagnostics.Process game
                {
                    get
                    {
                        return System.Diagnostics.Process.GetProcessesByName("hl").FirstOrDefault();
                    }
                }
                public static IntPtr getModuleAdress(string modulname, System.Diagnostics.Process proc)
                {
                    IntPtr result = IntPtr.Zero;
                    for (int i = 0; i < proc.Modules.Count; i++)
                    {
                        if (proc.Modules[i].ModuleName == modulname)
                        {
                            result = proc.Modules[i].BaseAddress;
                            break;
                        }
                    }
                    return result;
                }
            }
        }
    }
}

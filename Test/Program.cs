using Counter_Strike_1._6_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter_Strike_1_6_API api = new Counter_Strike_1_6_API();
            var v1 = api.Game.LocalPlayer.Weapons.Glock.Reload;
            Console.WriteLine(v1);
            Console.ReadLine();
        }
    }
}

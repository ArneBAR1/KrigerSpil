using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrigerSpil.Class
{
    public class Sword:Item,IKillable
    {
        public override string Action()
        {
            return "Powerful hit!";
        }

        public void OneShot()
        {
            Console.WriteLine("You kill the human in one shot! Amazing! You win");
        }
    }
}

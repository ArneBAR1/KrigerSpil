using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrigerSpil.Class
{
    public class Staff:Item, ISpellable 
    {
        public override string Action()
        {
            return "The wizards teleports!";
        }

        public void CastSpell()
        {
            Console.WriteLine("You hit the human with a powerful spell!");
        }
    }
}

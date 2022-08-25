using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrigerSpil.Class
{
    public partial class Item
    {

        public void Equip(Person person)
        {
            person.item = this;
            person.health += 5;
        }
        public virtual string Action() { return null; }

        public void Unequip(Person person)
        {
            person.item = null;
            person.health -= 5;
        }

      
    }
}

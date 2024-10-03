using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class Weapon : ICloneable<Weapon>
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public Weapon() { }
        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public Weapon Clone()
        {
            return new Weapon(Name, Damage);
        }
        public override string ToString()
        {
            return $"Weapon: {Name} ({Damage})";
        }
    }
}

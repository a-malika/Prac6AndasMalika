using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class Armor : ICloneable<Armor>
    {
        public string Name { get; set; }
        public int Protection { get; set; }
        public Armor() { }
        public Armor(string name, int protection)
        {
            Name = name;
            Protection = protection;
        }
        public Armor Clone()
        {
            return new Armor(Name, Protection);
        }
        public override string ToString()
        {
            return $"Armor: {Name} ({Protection})";
        }
    }
}

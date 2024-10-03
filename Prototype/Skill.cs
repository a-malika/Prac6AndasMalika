using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    public class Skill : ICloneable<Skill>
    {
        public string Name { get; set; }
        public string SkillType { get; set; }
        public Skill() { }
        public Skill(string name, string skillType)
        {
            Name = name;
            SkillType = skillType;
        }
        public Skill Clone()
        {
            return new Skill(Name, SkillType);
        }
        public override string ToString()
        {
            return $"Skill: {Name} ({SkillType})";
        }
    }
}

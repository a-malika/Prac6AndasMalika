using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Practice6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Character char1 = new Character("Albert", 100, 50, 14, 34, new Weapon("Blade of Darkness", 29), new Armor("Golden Armor", 32));
            char1.SkillList.Add(new Skill("Shadowstrike", "Attack"));
            char1.SkillList.Add(new Skill("Guardian's Shield", "Defense"));
            char1.SkillList.Add(new Skill("Blazing Inferno", "Attack"));
            Character char2 = char1.Clone();
            char2.Name = "Lara";
            char2.Agility = 89;
            char2.Weapon = new Weapon("Sword Divine Punishment", 134);
            char2.Armor.Protection = 55;
            char2.SkillList.Add(new Skill("Healing Breeze", "Support"));
            Console.WriteLine(char1.ToString());
            Console.WriteLine(char2.ToString());
        }
    }

}

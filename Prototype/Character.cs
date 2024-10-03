using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Practice6
{
    public class Character : ICloneable<Character>
    {
        public string Name { get; set; }
        public int Health {  get; set; }
        public int Strength {  get; set; }
        public int Agility {  get; set; }
        public int Intelligence {  get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public List<Skill> SkillList { get; set; } = null;
        public Character() { }
        public Character(string name, int health, int strenght, int agility, int intelligence, Weapon weapon, Armor armor)
        {
            Name = name;
            Health = health;
            Strength = strenght;
            Agility = agility;
            Intelligence = intelligence;
            Weapon = weapon;
            Armor = armor;
            SkillList = new List<Skill>();
        }
        public Character Clone()
        {
            Character clone = new Character(Name, Health, Strength, Agility, Intelligence, Weapon.Clone(), Armor.Clone());
            foreach (Skill skill in SkillList)
            {
                clone.SkillList.Add(skill.Clone());
            }
            return clone;
        }
        public override string ToString()
        {
            string result = $"Character {Name}:\nHealth: {Health}\nStrength: {Strength}\nAgility: {Agility}\nIntelligence: {Intelligence}";
            result += "\n" + Weapon.ToString() + "\n" + Armor.ToString() + "\nSkills:\n";
            foreach (Skill skill in SkillList)
            {
                result += "\t" + skill.ToString() + "\n";
            }
            return result;
        }
    }
}

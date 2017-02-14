using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardFight2
{
    class Spell
    {
        string spellname;
        int power;
        int cost;

        public string Spellname
        {
            get
            {
                return spellname;
            }
        }

        public int Power
        {
            get
            {
                return power;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
        }

        public Spell(string spellname, int power, int cost)
        {
            this.spellname = spellname;
            this.power = power;
            this.cost = cost;
        }

        public Spell(string spellname)
        {
            Random rnd = new Random();

            this.spellname = spellname;
            this.power = rnd.Next(1, 10);
            this.cost = rnd.Next(5, 26);
        }

        public override string ToString()
        {
            string spelldate = string.Empty;
            return "Varázslat neve: " + spellname + ",Ereje: " + power + ", Mana költség:" + cost;

        }

    }
}

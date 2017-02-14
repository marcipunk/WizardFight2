using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WizardFight2
{
    class BaseWizard
    {
        protected Character WizardData;  //változó
        protected List<Spell> spellList = new List<Spell>();
        

        public BaseWizard(Character wizardData)
        {
            this.WizardData = wizardData;
        }

        protected virtual void LoadSpells(int spellCount)
        {
            Random powerrnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            System.Threading.Thread.Sleep(20);
            Random costrnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < spellCount; i++)
            {
                Spell tempspell = new Spell("Varázslat_" + (i + 1), powerrnd.Next(1, 10), costrnd.Next(5, 26));
                spellList.Add(tempspell);
            }
        }
    }
}

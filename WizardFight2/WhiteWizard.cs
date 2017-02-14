using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WizardFight2
{
    class WhiteWizard : GreyWizard
    {
        public WhiteWizard(Character wizarddata) :base(wizarddata)
        {
            this.Color = GoodColor.White;
            this.LoadSpells(10);
        }

        override protected void LoadSpells(int spellCount)
        {
            for (int i = 0; i < spellCount; i++)
            {
                Random powerrnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
                System.Threading.Thread.Sleep(20);
                Random costrnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
                Spell tempspell = new Spell("Varázslat_" + (i + 1), powerrnd.Next(1, 20), costrnd.Next(5, 26));
                spellList.Add(tempspell);
            }
        }

    }
}

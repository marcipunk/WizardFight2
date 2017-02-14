using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WizardFight2
{
    enum GoodColor { Gray, White}

    class GreyWizard : BaseWizard
    {
        private GoodColor color;
        protected GoodColor Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public GreyWizard(Character wizardData) : base(wizardData)
        {
            this.color = GoodColor.Gray;
            this.LoadSpells(10);
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = WizardData.Name + ", Színe: " + Color + ", Élet: " + WizardData.Life + ", Mana: " + WizardData.Mana + ", XP: " + WizardData.Xp;
            return result;
        }

    }
}

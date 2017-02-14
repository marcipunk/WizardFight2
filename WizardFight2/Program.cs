using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardFight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Character wizardData_lvl1 = new Character("Gandalf", 70, 320, false);

            GreyWizard GGandalf = new GreyWizard(wizardData_lvl1);

            Console.WriteLine(GGandalf.ToString());

            Character wizardData_lvl2 = new Character(wizardData_lvl1.Name, wizardData_lvl1.Life+10, wizardData_lvl1.Mana+80, wizardData_lvl1.Evil, wizardData_lvl1.Xp + 100);

            WhiteWizard WGandalf = new WhiteWizard(wizardData_lvl2);

            Console.WriteLine(WGandalf.ToString());


            Console.ReadKey();

        }
    }
}

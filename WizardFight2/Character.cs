using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WizardFight2
{
    class Character
    {
        private string name;
        private int life;
        private int mana;
        private int xp;
        private bool evil;
        private int slife;
        private int smana;
        private int sxp;

        public string Name
        {
            get
            {
                return name;
            }
        }


        public int Mana
        {
            get
            {
                return mana;
            }
        }

        public int Xp
        {
            get
            {
                return xp;
            }
        }

        public bool Evil
        {
            get
            {
                return evil;
            }
        }

        public int Slife
        {
            get
            {
                return slife;
            }
        }

        public int Smana
        {
            get
            {
                return smana;
            }

        }

        public int Sxp
        {
            get
            {
                return sxp;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }
        }

        public Character(string name, int life, int mana, bool evil) //konstruktor
        {
            Random rnd = new Random();
            this.name = name;
            #region life
            if (evil && life >= 40 && life <= 100)
            {
                this.life = life;
                this.slife = life;
            }
            else if (!evil && life >= 40 && life <= 80)
            {
                this.life = life;
                this.slife = life;
            }
            else
            {
                throw new Exception("Valami el van b*szva a life környékén");
            }
            #endregion

            #region mana
            if (evil && mana > 200 && mana <= 320)
            {
                this.mana = mana;
                this.smana = mana;
            }
            else if (!evil && mana > 260 && mana <= 400)
            {
                this.mana = mana;
                this.smana = mana;
            }
            else
            {
                throw new Exception("Valami el van b*szva a mana környékén");
            }
            #endregion


            this.xp = 100;
            this.sxp = xp;

            this.evil = evil;

        }


        public Character(string name, int life, int mana, bool evil, int xp) //konstruktor
        {
            Random rnd = new Random();
            this.name = name;
            #region life
            if (evil && life >= 40 && life <= 100)
            {
                this.life = life;
                this.slife = life;
            }
            else if (!evil && life >= 40 && life <= 80)
            {
                this.life = life;
                this.slife = life;
            }
            else
            {
                throw new Exception("Valami el van b*szva a life környékén");
            }
            #endregion

            #region mana
            if (evil && mana > 200 && mana <= 320)
            {
                this.mana = mana;
                this.smana = mana;
            }
            else if (!evil && mana > 260 && mana <= 400)
            {
                this.mana = mana;
                this.smana = mana;
            }
            else
            {
                throw new Exception("Valami el van b*szva a mana környékén");
            }
            #endregion


            this.xp = xp;
            this.sxp = xp;

            this.evil = evil;

        }
    }
}

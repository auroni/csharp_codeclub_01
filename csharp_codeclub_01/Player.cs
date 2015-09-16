using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_codeclub_01
{
    class Player
    {
        private string name = "";
        private int health = 100;
        private int mana = 100;
        private int stamina = 100;

        public Player()
        {
            name = "Mestari";
            health = 50;
            mana = 20;
            stamina = 14444;
        }

        public Player(string givenName, int givenHealth, int givenMana, int givenStamina)
        {
            name = givenName;
            health = givenHealth;
            mana = givenMana;
            stamina = givenStamina;
        }

        ~Player()
        {
            //mitä tapahtuu kun player poistetaan, esim. "Give points to PointsManager"
        }

        public void getPlayerInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health + "\tMana: " + mana + "\tStamina: " + stamina + "\n");
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public int Mana
        {
            get
            {
                return mana;
            }
            set
            {
                mana = value;
            }
        }
        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;
            }
        }
    }
}

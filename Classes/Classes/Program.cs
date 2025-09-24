using System.ComponentModel.Design;

namespace Classes
{
    class Unit
    {
        private float _health;
        public string Name { get; }
        public float Health => _health;

        public int Damage { get; } = 5;


        public Unit() : this(name: "Unknown Unit")
        {

        }
        public Unit(string name)
        {
            Name = name;
        }
        public float RealHealth()
        {
            return Health * (1 + Armor);
        }

        public float Armor { get; private set; } = 0.6f;
       

        public bool SetDamage()
        {
            _health = Health - Damage * Armor;
            
                if (Health <= 0f) 
                return true;
                else 
                return false;

            
        }
    }
    class Weapon
    {
        private string name;
        public string Name
        {
            get;
        }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }
        public float Durability { get; } = 1f;

        public Weapon()
        {
           name = (Console.ReadLine());

        }
        public int SetDamageParams()
            
        {
            MaxDamage = (Console.ReadLine());
            MinDamage = (Console.ReadLine());
            if (MinDamage > MaxDamage)

                return 0;

            else
                return 0;


        }
    }
    }

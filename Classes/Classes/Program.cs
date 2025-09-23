namespace Classes
{
    class Unit
    {
        private float _health;
        private float _armor;
        public string Name { get; }
        public float Health => _health;

        public int Damage { get; }


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

        public float Armor
        {
            get
            {

                return (float) Math.Round(_armor, 2);
            }
            set
            {
                if (value >= 0 || value <= 1)
                {
                    _armor = value;
                }
                else
                {

                }
            }

        }

        public Unit(int damage)
        {
            Damage = 5;
        }

        public bool SetDamage()
        {
            _health = Health - Damage * Armor;
            {
                if (Health <= 0f) return true;
                else return false;

            }
        }
    }
}

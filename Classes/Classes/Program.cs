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
}

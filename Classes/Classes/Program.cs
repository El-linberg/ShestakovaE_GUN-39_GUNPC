using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Numerics;
using System.Xml.Linq;

namespace Classes
{
    class Unit
    {
        private float _health;
        public string Name { get; }
        public float Health => _health;

        public int Damage { get; }
        public float Armor { get; private set; }

        public Unit() : this(name: "Unknown Unit")
        {

        }
        public Unit(string name)
        {
            Name = name;
            Damage = 5;
            Armor = 0.6f;
        }
        public float RealHealth()
        {
            return Health * (1 + Armor);
        }


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

        public string Name { get; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }
        public float Durability { get; }

        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, int MinDamage, int MaxDamage) : this(name)
        {
            Durability = 1f;
            SetDamageParams();

        }
        public void SetDamageParams()

        {


        }
    }

    public struct Interval()
    {
        public float Min { get; }
        public float Max { get; }
        public float t;
        private Random random;

        public Interval(float minValue, float maxValue)
        {
            random = new Random();
            Min = minValue;
            Max = maxValue;
            if (minValue > maxValue)
            {
                t = minValue;
                minValue = maxValue;
                maxValue = t;
                Console.WriteLine("Некорректные входные данные");
            }

            if (minValue < 0)
            {
                minValue = 0;

                Console.WriteLine("Некорректные входные данные");
            }
            if (maxValue < 0)
            {
                maxValue = 0;

                Console.WriteLine("Некорректные входные данные");

            }
            if (minValue == maxValue)
            {
                t = maxValue + 10;
                maxValue = t;

                Console.WriteLine("Некорректные входные данные");
            }
            Min = minValue;
            Max = maxValue;
        }
    }
    public struct Room()
    {
        Unit unit = new Unit();
        Weapon weapon = new Weapon("Оружие");
        public Room[] rooms { get; private set; }
        Room[] room = new Room[3];
        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++) // поле типа Room[]
            {
                var room = rooms[i]; // Берёте по индексу
                                     //Выводите на экран вот таким образом! Подробнее об этом в уроке про строки.
                Console.WriteLine("unit of room" +room.unit);
                Console.WriteLine("weapon of room" +room.weapon);
                Console.WriteLine("—");
            }

        }
    }

    public class Dangeon()
    {
        Room[] room = new Room[3];
         
        new Room[(new Unit("Юнит 1"), new Weapon("Оружие 1")),
            (new Unit("Юнит 2"), new Weapon("Оружие 2")),
            (new Unit("Юнит 3"), new Weapon("Оружие 3"))
            ];
       

    }


}


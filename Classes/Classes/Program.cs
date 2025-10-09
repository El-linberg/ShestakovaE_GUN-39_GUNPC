using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Classes
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Dungeon dungeon = new();
        }

        public class Unit
        {
            private float _health;
            public string Name { get; }
            public float Health => _health;

            public Interval Damage { get; }
            public float Armor { get; private set; }

            public Unit(string name)
            {
                Name = name;
            }
            public Unit(string name, int MinDamage, int MaxDamage)
            {
                Name = name;
                Armor = 0.6f;
                SetDamage(MinDamage, MaxDamage);
            }
            public float RealHealth()
            {
                return Health * (1 + Armor);
            }


            public bool SetDamage(int MinDamage, int MaxDamage)
            {
                _health = Health - ((MinDamage + MaxDamage) / 2) * Armor;

                if (Health <= 0f)
                    return true;
                else
                    return false;
            }
        }
        public class Weapon
        {

            public string Name { get; }

            public Interval Damage { get; }

            public float Durability { get; }

            public Weapon(string name)
            {
                Name = name;
            }
            public Weapon(string name, int MinDamage, int MaxDamage) : this(name)
            {
                Durability = 1f;
                SetDamageParams(MinDamage, MaxDamage);

            }
            public void SetDamageParams(int MinDamage, int MaxDamage)

            {


            }
        }

        public struct Interval
        {
            public int Min { get; }
            public int Max { get; }
            private Random random;

            public Interval(int minValue, int maxValue) : this()
            {
                if (minValue > maxValue)
                {
                    int t = minValue;
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
                    int t = maxValue + 10;
                    maxValue = t;

                    Console.WriteLine("Некорректные входные данные");
                }
                Min = minValue;
                Max = maxValue;
                random = new Random();
            }
        }
        public struct Room
        {
            public Unit unit;
            public Weapon weapon;
            public Room(Unit unit, Weapon weapon)
            {
            }


        }

        public class Dungeon
        {
            public Room[] rooms { get; private set; }
            Room[] room = new Room[3]

            {   new Room (new Unit("Юнит 1"), new Weapon("Оружие 1")),
                new Room (new Unit("Юнит 2"), new Weapon("Оружие 2")),
                new Room (new Unit("Юнит 3"), new Weapon("Оружие 3"))
            };
            public void ShowRooms()
            {
                for (int i = 0; i < rooms.Length; i++) // поле типа Room[]
                {
                    var room = rooms[i]; // Берёте по индексу
                                         //Выводите на экран вот таким образом! Подробнее об этом в уроке про строки.
                    Console.WriteLine("unit of room" + room.unit);
                    Console.WriteLine("weapon of room" + room.weapon);
                    Console.WriteLine("—");
                }

            }

        }
    }

}


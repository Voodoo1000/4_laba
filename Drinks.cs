using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_laba
{
    public class Drink
    {
        public int volume = 0;
        public static Random rnd = new Random();
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъем: {0}", this.volume);
            return str;
        }
    }

    public enum Fruit { apricot, orange, grape, pomegranate, plum, apple };
    public class Juice : Drink // Сок
    {
        public Fruit fruit = Fruit.apple; // Фрукт
        public int countPulp = 0; // Количество  мякоти

        public override string GetInfo()
        {
            var str = "Сок: ";
            str += base.GetInfo();
            str += String.Format("\nФрукт: {0}", this.fruit);
            str += String.Format("\nКоличество мякоти: {0}", this.countPulp);
            return str;
        }

        public static Juice Generate()
        {
            return new Juice
            {
                volume = rnd.Next() % 500,
                countPulp = 200 + rnd.Next() % 2000,
                fruit = (Fruit)rnd.Next(6)
            };
        }
    }

    public enum TypeSoda { cola, fanta, sprite, pepsi, mirinda }
    public class Soda : Drink // Газировка
    {
        public TypeSoda type = TypeSoda.cola; // Тип
        public int countBubbles = 0; // Количество пузыриков
        public override string GetInfo()
        {
            var str = "Газировка: ";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nКоличество пузыриков: {0}", this.countBubbles);
            return str;
        }
        public static Soda Generate()
        {
            return new Soda
            {
                volume = rnd.Next() % 500,
                countBubbles = 500 + rnd.Next() % 3000,
                type = (TypeSoda)rnd.Next(5)
            };
        }
    }
    
    public enum TypeAlcohol { absinthe, gin, vodka, whiskey, rum, cognac, wine }
    public class Alcohol : Drink // Алкоголь
    {
        public TypeAlcohol type = TypeAlcohol.gin; // Тип
        public int strength = 0; //Крепкость алкоголя
        public override string GetInfo()
        {
            var str = "Алкоголь:";
            str += base.GetInfo();
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nКрепкость: {0}", this.strength);
            return str;
        }
        public static Alcohol Generate()
        {
            return new Alcohol
            {
                volume = rnd.Next() % 500,
                strength = 15 + rnd.Next() % 80,
                type = (TypeAlcohol)rnd.Next(7)
            };
        }
    }
}

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
            var str = "Я сок";
            str += base.GetInfo();
            return str;
        }
    }

    public enum TypeSoda { cola, fanta, sprite, pepsi, mirinda }
    public class Soda : Drink // Газировка
    {
        public TypeSoda type = TypeSoda.cola; // Тип
        public int countBubbles = 0; // Количество пузырьков
        public override string GetInfo()
        {
            var str = "Я газировка";
            str += base.GetInfo();
            return str;
        }
    }
    
    public enum TypeAlcohol { absinthe, gin, vodka, whiskey, rum, cognac, wine, beer }
    public class Alcohol : Drink // Алкоголь
    {
        public TypeAlcohol type = TypeAlcohol.gin; // Тип
        public int strength = 0; //Крепкость алкоголя
        public override string GetInfo()
        {
            var str = "Я алкоголь";
            str += base.GetInfo();
            return str;
        }
    }
}

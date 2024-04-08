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
    }

    public enum Fruit { apricot, orange, grape, pomegranate, plum, apple };
    public class Juice : Drink // Сок
    {
        public Fruit fruit = Fruit.apple; // Фрукт
        public int countPulp = 0; // Количество  мякоти
    }

    public enum TypeSoda { cola, fanta, sprite, pepsi, mirinda }
    public class Soda : Drink // Газировка
    {
        public TypeSoda type = TypeSoda.cola; // Тип
        public int countBubbles = 0; // Количество пузырьков
    }
    
    public enum TypeAlcohol { absinthe, gin, vodka, whiskey, rum, cognac, wine, beer }
    public class Alcohol : Drink // Алкоголь
    {
        public TypeAlcohol type = TypeAlcohol.gin; // Тип
        public int strength = 0; //Крепкость алкоголя
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_laba
{
    // Базовый класс для напитков
    public class Drink
    {
        public int volume = 0; // Объем напитка
        public static Random rnd = new Random(); // Статический генератор случайных чисел

        // Виртуальный метод для получения информации о напитке
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъем: {0}", this.volume); // Форматирование строки с информацией о объеме
            return str;
        }
    }

    // Перечисление для типов фруктов
    public enum Fruit { apricot, orange, grape, pomegranate, plum, apple };

    // Класс для сока, наследуется от Drink
    public class Juice : Drink
    {
        public Fruit fruit = Fruit.apple; // Фрукт
        public int countPulp = 0; // Количество мякоти

        // Переопределение метода GetInfo для вывода информации о соке
        public override string GetInfo()
        {
            var str = "Сок: "; // Заголовок для сока
            str += base.GetInfo(); // Получаем информацию из базового класса
            str += String.Format("\nФрукт: {0}", this.fruit); // Добавляем информацию о фрукте
            str += String.Format("\nКоличество мякоти: {0}", this.countPulp); // Добавляем информацию о мякоти
            return str;
        }

        // Метод для генерации случайного сока
        public static Juice Generate()
        {
            return new Juice
            {
                volume = rnd.Next() % 500, // Случайный объем от 0 до 499
                countPulp = 200 + rnd.Next() % 2001, // Случайное количество мякоти от 200 до 2200
                fruit = (Fruit)rnd.Next(6) // Случайный фрукт из перечисления
            };
        }
    }

    // Перечисление для типов газировок
    public enum TypeSoda { cola, fanta, sprite, pepsi, mirinda }

    // Класс для газировки, наследуется от Drink
    public class Soda : Drink
    {
        public TypeSoda type = TypeSoda.cola; // Тип газировки
        public int countBubbles = 0; // Количество пузыриков

        // Переопределение метода GetInfo для вывода информации о газировке
        public override string GetInfo()
        {
            var str = "Газировка: "; // Заголовок для газировки
            str += base.GetInfo(); // Получаем информацию из базового класса
            str += String.Format("\nТип: {0}", this.type); // Добавляем информацию о типе
            str += String.Format("\nКоличество пузыриков: {0}", this.countBubbles); // Добавляем информацию о пузырьках
            return str;
        }

        // Метод для генерации случайной газировки
        public static Soda Generate()
        {
            return new Soda
            {
                volume = rnd.Next() % 500, // Случайный объем от 0 до 499
                countBubbles = 500 + rnd.Next() % 3001, // Случайное количество пузырьков от 500 до 3500
                type = (TypeSoda)rnd.Next(5) // Случайный тип из перечисления
            };
        }
    }

    // Перечисление для типов алкоголя
    public enum TypeAlcohol { absinthe, gin, vodka, whiskey, rum, cognac, wine }

    // Класс для алкоголя, наследуется от Drink
    public class Alcohol : Drink
    {
        public TypeAlcohol type = TypeAlcohol.gin; // Тип алкоголя
        public int strength = 0; // Крепкость алкоголя

        // Переопределение метода GetInfo для вывода информации об алкоголе
        public override string GetInfo()
        {
            var str = "Алкоголь:"; // Заголовок для алкоголя
            str += base.GetInfo(); // Получаем информацию из базового класса
            str += String.Format("\nТип: {0}", this.type); // Добавляем информацию о типе
            str += String.Format("\nКрепкость: {0}", this.strength); // Добавляем информацию о крепкости
            return str;
        }

        // Метод для генерации случайного алкоголя
        public static Alcohol Generate()
        {
            return new Alcohol
            {
                volume = rnd.Next() % 500, // Случайный объем от 0 до 499
                strength = 15 + rnd.Next() % 66, // Случайная крепкость от 15 до 80
                type = (TypeAlcohol)rnd.Next(7) // Случайный тип из перечисления
            };
        }
    }
}

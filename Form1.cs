using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _4_laba
{
    public partial class Form1 : Form
    {
        // Список напитков
        List<Drink> drinksList = new List<Drink>();

        // Конструктор формы
        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // Отображение информации о напитках
        }

        // Обработчик нажатия кнопки "Перезаполнить"
        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear(); // Очистка списка напитков

            var rnd = new Random();

            // Генерация 10 случайных напитков
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.drinksList.Add(Juice.Generate()); // Добавление случайного сока
                        break;
                    case 1:
                        this.drinksList.Add(Soda.Generate()); // Добавление случайной газировки
                        break;
                    case 2:
                        this.drinksList.Add(Alcohol.Generate()); // Добавление случайного алкоголя
                        break;
                }
            }
            ShowInfo(); // Отображение информации о напитках
        }

        // Метод для отображения информации о напитках
        private void ShowInfo()
        {
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoholCount = 0;

            // Подсчет количества каждого типа напитка
            foreach (var drink in this.drinksList)
            {
                if (drink is Juice)
                {
                    juiceCount += 1;
                }
                else if (drink is Soda)
                {
                    sodaCount += 1;
                }
                else if (drink is Alcohol)
                {
                    alcoholCount += 1;
                }
            }

            // Отображение информации о количестве каждого типа напитка
            txtInfo.Text = "Сок\t\tГазировка\tАлкоголь";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", juiceCount, sodaCount, alcoholCount);
        }

        // Обработчик нажатия кнопки "Взять"
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.drinksList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q"; // Вывод сообщения о пустом списке напитков
                return;
            }
            var drink = this.drinksList[0]; // Получение первого напитка из списка
            this.drinksList.RemoveAt(0); // Удаление первого напитка из списка

            txtOut.Text = drink.GetInfo(); // Отображение информации о напитке

            ShowInfo(); // Отображение информации о напитках
        }
    }
}

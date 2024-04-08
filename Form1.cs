namespace _4_laba
{
    public partial class Form1 : Form
    {
        List<Drink> drinksList = new List<Drink>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();

            var rnd = new Random();

            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.drinksList.Add(Juice.Generate());
                        break;
                    case 1:
                        this.drinksList.Add(Soda.Generate());
                        break;
                    case 2:
                        this.drinksList.Add(Alcohol.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoholCount = 0;

            foreach (var fruit in this.drinksList)
            {
                if (fruit is Juice)
                {
                    juiceCount += 1;
                }
                else if (fruit is Soda)
                {
                    sodaCount += 1;
                }
                else if (fruit is Alcohol)
                {
                    alcoholCount += 1;
                }
            }


            txtInfo.Text = "Сок\t\tГазировка\tАлкоголь";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", juiceCount, sodaCount, alcoholCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.drinksList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }
            var drink = this.drinksList[0];
            this.drinksList.RemoveAt(0);

            txtOut.Text = drink.GetInfo();

            ShowInfo();
        }
    }
}

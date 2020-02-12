namespace Market_Store
{
    public class BronzeCard : ICard
    {
        private string owner;
        private decimal turnover;
        private double discountRate;

        public BronzeCard(decimal turnover)
        {
            this.Turnover = turnover;
            this.DiscountRate = 0d;
        }

        public decimal Turnover
        {
            get => this.turnover;
            set => this.turnover = value;
        }

        public string Owner
        {
            get => this.owner;
            set => this.owner = value;
        }

        public double DiscountRate
        {
            get => this.discountRate;

            set
            {
                if (this.Turnover >= 100 && this.Turnover <= 300)
                {
                    this.discountRate = 1d;
                }
                else if (this.Turnover > 300)
                {
                    this.discountRate = 2.5;
                }
            }
        }
    }
}

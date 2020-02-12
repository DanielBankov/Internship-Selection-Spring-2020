namespace Market_Store
{
    public class GoldCard : ICard
    {
        private string owner;
        private decimal turnover;
        private double discountRate;

        public GoldCard(decimal turnover)
        {
            this.Turnover = turnover;
            this.DiscountRate = 2d;
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
                this.discountRate = value;

                if (this.Turnover >= 100 && this.Turnover <= 800)
                {
                    this.discountRate += (int)this.Turnover / 100;
                }
                else if (this.turnover > 800)
                {
                    this.discountRate = 10d;
                }
            }
        }
    }
}

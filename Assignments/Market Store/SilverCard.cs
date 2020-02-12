namespace Market_Store
{
    public class SilverCard : ICard
    {
        private string owner;
        private decimal turnover;
        private double discountRate;

        public SilverCard(decimal turnover)
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
                if (this.Turnover > 300)
                {
                    this.discountRate = 3.5;
                }
                else
                {
                    this.discountRate = value;
                }
            }
        }
    }
}

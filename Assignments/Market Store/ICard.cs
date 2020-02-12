namespace Market_Store
{
    public interface ICard
    {
        string Owner { get; set; }

        decimal Turnover { get; set; }

        double DiscountRate { get; set; }
    }
}

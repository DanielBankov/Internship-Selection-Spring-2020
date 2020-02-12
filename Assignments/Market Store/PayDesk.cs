namespace Market_Store
{
    using System;

    public static class PayDesk
    {
        public static string CalulateDiscount(decimal purchaseValue, ICard card)
        {
            decimal discount = purchaseValue * (decimal)(card.DiscountRate / 100);
            decimal total = purchaseValue - discount;

            return $"Purchase value: ${purchaseValue:F2}{Environment.NewLine}Discount rate: {card.DiscountRate:F1}%{Environment.NewLine}Discount: ${discount:F2}{Environment.NewLine}Total: ${total:F2}";
        }
    }
}

namespace QuotationMVC.Models
{
    public class Quotation
    {
        public decimal SalesPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount
        {
            get
            {
                return SalesPrice * (DiscountPercent * .01m);
            }
        }
        public decimal Total
        {
            get
            {
                return SalesPrice - DiscountAmount;
            }
        }
    }
}

using System.Globalization;

namespace demo_signalR_2.Shared.func
{
    public class FormatCurrency
    {
        public string FormattedPriceOf(int Price)
        {
            return Price.ToString("#,##0", CultureInfo.GetCultureInfo("vi-VN")) + "₫";
        }
        public int CalcDiscountPrice(int Price, int Discount)
        {
            return (int)(Price * (1 - (double)Discount / 100));
        }
    }
}

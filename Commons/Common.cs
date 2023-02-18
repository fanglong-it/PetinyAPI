using PetinyAPI.Models;
using System.Globalization;

namespace PetinyAPI.Commons
{
    public class Common
    {


        //becareful format (dd-MM-YYYY)
        public static int calculateAge(string date)
        {
            DateTime dateTime = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            return System.DateTime.Now.Year - dateTime.Year;
        }

        public static double calculatePrice(List<OrderDetail> orderDetails)
        {
            double total = 0;
            foreach(OrderDetail orderDetail in orderDetails)
            {
                double price = orderDetail.Price * orderDetail.Qty;
                total+= price;
            }
            return total;
        }
    }
}

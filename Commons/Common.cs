using Microsoft.AspNetCore.DataProtection;
using PetinyAPI.Models;
using System.Globalization;
using System.Text;

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


        public static string calculateHmac(string data, string key)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] keyBytes = encoding.GetBytes(key);
            byte[] messageBytes = encoding.GetBytes(data);
            System.Security.Cryptography.HMACSHA256 cryptographer = new System.Security.Cryptography.HMACSHA256(keyBytes);
            byte[] bytes = cryptographer.ComputeHash(messageBytes);
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }


    }
}

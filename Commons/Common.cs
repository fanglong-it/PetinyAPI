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
    }
}

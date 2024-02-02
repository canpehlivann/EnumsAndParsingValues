using System;
using System.Collections.Generic;
using System.Text;

namespace EnumsAndParsingValues
{
    public class Week
    {
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        public string createDay(string day)
        {
            
            StringBuilder dayBuilder = new StringBuilder();
            
            dayBuilder.Append(day);
            
            dayBuilder[0] = dayBuilder.ToString().ToUpper()[0];
            
            return dayBuilder.ToString();
        }
    }
}

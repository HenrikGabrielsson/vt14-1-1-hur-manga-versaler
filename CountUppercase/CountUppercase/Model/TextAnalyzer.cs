using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountUppercase.Model
{
    public class TextAnalyzer
    {
        //metod som tar emot en sträng och returnerar antalet versaler
        public static int GetNumberOfCapitals(string text)
        {
            //räknare
            int uppercaseCount = 0;

            //loop som hittar versaler och ökar räknaren
            foreach (char character in text)
            {
                
                if (char.IsUpper(character))
                {
                    uppercaseCount++;
                }
            }

            return uppercaseCount;
        }
    }
}
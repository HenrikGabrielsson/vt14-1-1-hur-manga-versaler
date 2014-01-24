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
                int charCode = (int)character;

                if (charCode >= 65 && charCode <= 90 || charCode == 196 || charCode == 197 || charCode == 214)
                {
                    uppercaseCount++;
                }

            }

            return uppercaseCount;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountUppercase.Model;

namespace CountUppercase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            //hämtar input
            String inputString = UpperCaseTextBox.Text.ToString();

            //skickar till funktion som räknar versaler
            int uppercaseCount = TextAnalyzer.GetNumberOfCapitals(inputString);

            //Skriver ut antal versaler och gör textboxen oanvändbar.
            UpperCaseTextBox.Enabled = false;
            Result.Text = uppercaseCount.ToString();
        }
    }
}
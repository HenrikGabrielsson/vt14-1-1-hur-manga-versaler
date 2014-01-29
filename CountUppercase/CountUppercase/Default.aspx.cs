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

        protected void CapitalCountButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(UpperCaseTextBox.Text))
            {
                //skickar till funktion som räknar versaler
                int uppercaseCount = TextAnalyzer.GetNumberOfCapitals(UpperCaseTextBox.Text);

                //ändrar knappen och gör textboxen oanvändbar.
                CapitalCountButton.Text = "Rensa";
                UpperCaseTextBox.Enabled = false;

                //Skriver ut antal versaler
                Result.Text += uppercaseCount.ToString();
            }

            ////Rensa sidan och låt användaren skriva en ny sträng.
            //else
            //{
            //    UpperCaseTextBox.Enabled = true;
            //    UpperCaseTextBox.Text = "";
            //    CapitalCountButton.Text = "Räkna Versaler";
            //    Result.Text = "Antal Versaler: ";
            //}


        }
    }
}
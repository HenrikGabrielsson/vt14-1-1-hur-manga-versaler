using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountUppercase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            String inputString = UpperCaseTextBox.Text.ToString();

            int uppercaseCount = 0;

            foreach(char character in inputString)
            {
                int charCode = (int)character;

                if (charCode >= 65 && charCode <= 90 || charCode == 196 || charCode == 197 || charCode == 214)
                {
                    uppercaseCount++; 
                }
   
            }
            UpperCaseTextBox.Enabled = false;

            Result.Text = uppercaseCount.ToString();
        }
    }
}
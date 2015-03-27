using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Year;

namespace HW0327
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
             protected void count_Click(object sender, EventArgs e)
        {
           year year = new year();
            int inputAge = 0;
            year.YearFormat inputFormat = (year.YearFormat)Enum.Parse(typeof(year.YearFormat), DropDownList1.SelectedValue, false);

            int.TryParse(age.Text, out inputAge);
            if (inputAge > 0)
            {
                ans.Text = year.GetBirthYear(inputAge, inputFormat).ToString();
            }
        
        }
    }
}
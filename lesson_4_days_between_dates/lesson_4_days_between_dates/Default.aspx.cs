using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson_4_days_between_dates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = firstCalendar.SelectedDate;
            DateTime secondDate = secondCalendar.SelectedDate;
            TimeSpan daysBetween;

            if (firstDate.CompareTo(secondDate) < 0)
            {
                daysBetween = secondDate.Subtract(firstDate);
                resultLabel.Text = daysBetween.Days.ToString();
            }
            else if (firstDate.CompareTo(secondDate) > 0)
            {
                daysBetween = firstDate.Subtract(secondDate);
                resultLabel.Text = daysBetween.Days.ToString();
            }
            else
                resultLabel.Text = "0";
        }
    }
}
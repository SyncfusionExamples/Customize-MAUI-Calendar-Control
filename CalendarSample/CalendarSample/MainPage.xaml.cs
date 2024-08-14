using Syncfusion.Maui.Calendar;

namespace CalendarSample
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            calendar.MonthView.SpecialDayPredicate = (date) =>
            {
                if (date.Date == DateTime.Now.AddDays(2).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails();
                    iconDetails.Icon = CalendarIcon.Heart;
                    iconDetails.Fill = Colors.Red;
                    return iconDetails;
                }
                return null;
            };
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            calendar.IsOpen = true;
        }

    }

}

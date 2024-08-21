# Customize-MAUI-Calendar-Control

The .NET MAUI Calendar features a user-friendly interface with month, year, decade, and century views for easy navigation. In the month view, users can highlight special dates and weekends. The calendar supports the selection of a single date, multiple dates, or a range of dates. Additionally, it can display different types of calendars based on various cultures and regions.

This sample demonstrates how to customize the MAUI Calendar Control in a .NET MAUI Application. You'll see how to disable past dates and apply distinct backgrounds for past, present, and future dates. 

You'll also learn how to display the calendar in a pop-up window, customize the appearance of selected dates, and highlight special dates.

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## How to run the sample

1. Clone the sample and open it in Visual Studio 2022.
   
   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
		
			InitializeComponent();
		
			MainPage = new MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/maui/licensing/overview) for more details.
	
3. Clean and build the application.

4. Run the application.

## Sample

```xaml
<Grid>
    <calendar:SfCalendar x:Name="calendar"
                         EnablePastDates="True"
                         Mode="Dialog"
                         SelectionMode="Range"
                         StartRangeSelectionBackground="#bc05f7" 
                         EndRangeSelectionBackground="#bc05f7" 
                         SelectionBackground="#e6a2fc"
                         Identifier="Korean">
        
        <calendar:SfCalendar.HeaderView>
            <calendar:CalendarHeaderView Background="#03516b">
                <calendar:CalendarHeaderView.TextStyle>
                    <calendar:CalendarTextStyle TextColor="White" FontSize="14" />
                </calendar:CalendarHeaderView.TextStyle>
            </calendar:CalendarHeaderView>
        </calendar:SfCalendar.HeaderView>

        <calendar:SfCalendar.MonthView>
            <calendar:CalendarMonthView Background="#beedfa" 
                                        TodayBackground="#54b2cc" 
                                        TrailingLeadingDatesBackground="#A4DDED"
                                        SpecialDatesBackground="LightCyan">
                <calendar:CalendarMonthView.TodayTextStyle>
                    <calendar:CalendarTextStyle TextColor="White" />
                </calendar:CalendarMonthView.TodayTextStyle>
                <calendar:CalendarMonthView.TrailingLeadingDatesTextStyle>
                    <calendar:CalendarTextStyle TextColor="#8c2804" FontSize="12"/>
                </calendar:CalendarMonthView.TrailingLeadingDatesTextStyle>
            </calendar:CalendarMonthView>
        </calendar:SfCalendar.MonthView>

        <calendar:SfCalendar.YearView>
            <calendar:CalendarYearView Background="#beedfa"  
                                       TodayBackground="#54b2cc"
                                       LeadingDatesBackground="#A4DDED">
                <calendar:CalendarYearView.TodayTextStyle>
                    <calendar:CalendarTextStyle TextColor="White"/>
                </calendar:CalendarYearView.TodayTextStyle>
                <calendar:CalendarYearView.LeadingDatesTextStyle>
                    <calendar:CalendarTextStyle TextColor="#8c2804" FontSize="12"/>
                </calendar:CalendarYearView.LeadingDatesTextStyle>
            </calendar:CalendarYearView>
        </calendar:SfCalendar.YearView>
    </calendar:SfCalendar>

    <Button x:Name="calendarButton"
            Text="Open Calendar"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>
```

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
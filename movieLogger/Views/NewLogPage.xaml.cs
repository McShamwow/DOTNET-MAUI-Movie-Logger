using ITS440_JakeStewart_FinalProject;
using System;
using System.Globalization;

namespace movieLogger;

public partial class NewLogPage : ContentPage
{
	public NewLogPage()
	{
		InitializeComponent();
	}

    // add new movie log to database via button click
    private void onInsertNewMovieButtonClicked(object sender, EventArgs e)
    {
        string title = titleEntry.Text.ToString().Trim();
        string genre = genre1Picker.SelectedItem.ToString().Trim() 
                        + "/" + genre2Picker.SelectedItem.ToString().Trim();
        string mpaRating = (string)mpaRatingPicker.SelectedItem;
        DateTime date = datePicker.Date;
        TimeSpan timespan = timePicker.Time;
        int house = (int)housePicker.SelectedItem;
        var cost = Convert.ToDouble(costEntry.Text);
        string day = datePicker.Date.DayOfWeek.ToString();
        string director = directorEntry.Text.ToString();
        int viewings = (int)viewingsStepper.Value;

        //format date
        var date2 = date.ToString("yyyy-MM-dd");
        //format time
        DateTime time = DateTime.Today.Add(timespan);
        string formattedTime = time.ToString("hh:mm tt"); // It will give "XX:XX AM"

        // insert
        var conn = DButils.createConnection();
        try
        {
            conn.Open();
            DButils.insertNewMovie(conn, title, genre, mpaRating, date2, formattedTime, house, cost, day, director, viewings);
            resetAllFields();
        }
        catch (Exception ex)
        {
            DisplayAlert("ALERT", "The following error occured.\n" + ex.Message, "OK");
        }
        finally
        {
            conn.Close();
        }

    }

    public void resetAllFields()
    {
        titleEntry.Text = string.Empty;
        housePicker.SelectedIndex= -1;
        costEntry.Text = string.Empty;
        mpaRatingPicker.SelectedIndex = -1;
        genre1Picker.SelectedIndex = -1;
        genre2Picker.SelectedIndex = -1;
        datePicker.Date = DateTime.Today;
        dayOfWeekEntry.Text = string.Empty;
        timePicker.Time = new TimeSpan(0,0,0);
        directorEntry.Text = string.Empty;
        viewingsStepper.Value = viewingsStepper.Minimum;
    }

    private void onDateSelected(object sender, DateChangedEventArgs e)
    {
        dayOfWeekEntry.Text = datePicker.Date.DayOfWeek.ToString();
    }

    private void viewingsStepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        stepperLabel.Text = e.NewValue.ToString() + " viewings";
        if (stepperLabel.Text.StartsWith("1 ")){
            stepperLabel.Text = "1 viewing";
        }
    }
}

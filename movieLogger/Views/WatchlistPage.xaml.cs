using ITS440_JakeStewart_FinalProject;
using movieLogger.Model;
using movieLogger.ViewModel;
using System.Collections.ObjectModel;

namespace movieLogger.Pages;

public partial class WatchlistPage : ContentPage
{
    
    public ObservableCollection<Movie> titles { get; set; }

    public WatchlistPage()
	{
        InitializeComponent();
        titles = new ObservableCollection<Movie> {};
        var conn = DButils.createConnection();
        conn.Open();
        var rows = DButils.getAll(conn);
        while (rows.Read())
        {
            var id = rows[0].ToString();
            var title = rows[1].ToString();
            var genre = rows[2].ToString();
            var mpa = rows[3].ToString();
            var date = rows[4].ToString();
            var time = rows[5].ToString();
            var house = rows[6].ToString();
            var cost = rows[7].ToString();  
            var day = rows[8].ToString();
            var director = rows[9].ToString();
            var viewings = rows[10].ToString();
            titles.Add(new Movie(id, title, genre, mpa, date, time, house, cost, day, director, viewings));
         
        }
        conn.Close();
        ListView listview = new ListView();
        listview.ItemsSource = titles;
        listview.ItemTemplate = new DataTemplate(typeof(TextCell));
        listview.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
        listview.ItemTemplate.SetBinding(TextCell.DetailProperty, "Date");

        StackLayout stack = new StackLayout
        {
            Children =
            {
                listview,
            }
        };

        Content = stack;
    }

    private void onMovieSelected(object sender, SelectedItemChangedEventArgs e)
    {
        DisplayAlert("Movie Selected", "Title is " + e.ToString(), "OK");
    }
}
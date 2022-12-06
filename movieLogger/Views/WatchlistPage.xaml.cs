using ITS440_JakeStewart_FinalProject;
using movieLogger.ViewModel;
using System.Collections.ObjectModel;

namespace movieLogger.Pages;

public partial class WatchlistPage : ContentPage
{
	public WatchlistPage()
	{
		InitializeComponent();
        var conn = DButils.createConnection();
        conn.Open();
        var rows = DButils.getAll(conn);
        string test = "test";
        ObservableCollection<String> titles = new ObservableCollection<String>() { test };
        while (rows.Read())
        {
            string title = rows[1].ToString();
            titles.Add(title);
         
        }
        conn.Close();
        titlesList.ItemsSource = titles;
    }

}
using ITS440_JakeStewart_FinalProject;
using movieLogger.ViewModel;

namespace movieLogger.Pages;

public partial class WatchlistPage : ContentPage
{
	public WatchlistPage(WatchlistViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void populateColl(object sender, NavigatedToEventArgs e)
    {
        
        var rows = DButils.getAll(DButils.createConnection());
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
            Items.Add(title);
        }
        
    }
}
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ITS440_JakeStewart_FinalProject;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace movieLogger.ViewModel
{
    public partial class WatchlistViewModel : ObservableObject
    {
        public ObservableCollection<string> Items { get; set; }

        public WatchlistViewModel()
        {
            var conn = DButils.createConnection();
            conn.Open();
            var rows = DButils.getAll(conn);
            while (rows.Read())
            {
                var title = rows[1].ToString();
                Items.Add(title);
            }
            conn.Close();

        }

    }
}

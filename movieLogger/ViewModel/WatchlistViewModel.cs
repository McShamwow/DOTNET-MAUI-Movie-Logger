using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ITS440_JakeStewart_FinalProject;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace movieLogger.ViewModel
{
    public partial class WatchlistViewModel : ObservableObject
    {

        public WatchlistViewModel()
        {
            var conn = DButils.createConnection();
            conn.Open();
            Items = new ObservableCollection<string>();
            var rows = DButils.getAll(conn);
            while (rows.Read())
            {
                var title = rows[1].ToString();
                Items.Add(title);
            }
            conn.Close();
        }
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;


        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }
            Items.Add(text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
    }
}

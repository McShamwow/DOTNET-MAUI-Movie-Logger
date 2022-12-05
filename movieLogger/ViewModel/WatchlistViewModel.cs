using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace movieLogger.ViewModel
{
    public partial class WatchlistViewModel : ObservableObject
    {

        public WatchlistViewModel()
        {
            Items = new ObservableCollection<string>();
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

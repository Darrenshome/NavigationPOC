using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace NavigationPOC.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DetailPageViewModel(string note)
        {
            DismissPageCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PopAsync();
            });

            TheNote = note;
        }

        string theNote;

        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;

                var args = new PropertyChangedEventArgs(nameof(TheNote));

                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command DismissPageCommand { get; }
    }
}

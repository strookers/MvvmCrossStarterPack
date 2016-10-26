using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using UCNDemo.Models;
using UCNDemo.Services;

namespace UCNDemo.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private int _count;

        private readonly IJsonPlaceHolderService _placeHolderService;
        public FirstViewModel(IJsonPlaceHolderService placeHolderService)
        {
            _placeHolderService = placeHolderService;
        }

        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

        private MvxAsyncCommand _clickCommand;

        public ICommand ClickCommand
        {
            get
            {
                _clickCommand = _clickCommand ?? new MvxAsyncCommand(DoClickCommandAsync);
                return _clickCommand;
            }
        }

        private async Task DoClickCommandAsync()
        {
            System.Diagnostics.Debug.WriteLine("Hello world");
            _count++;
            Hello = string.Format("Clicks: {0}", _count);

            Albums = await _placeHolderService.GetAlbumsAsync();
        }

        private List<Album> _albums;
        public List<Album> Albums
        {
            get { return _albums; }
            set { _albums = value; RaisePropertyChanged(() => Albums); }
        }

        //private string _hello = "Hello MvvmCross";
        //public string Hello
        //{
        //    get { return _hello; }

        //    set { _hello = value; RaisePropertyChanged(() => Hello); }
        //}
    }
}

using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace UCNDemo.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private int _count;

        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

        private MvxCommand _clickCommand;

        public ICommand ClickCommand
        {
            get
            {
                _clickCommand = _clickCommand ?? new MvxCommand(DoClickCommand);
                return _clickCommand;
            }
        }

        private void DoClickCommand()
        {
            System.Diagnostics.Debug.WriteLine("Hello world");
            _count++;
            Hello = string.Format("Clicks: {0}", _count);
        }

        //private string _hello = "Hello MvvmCross";
        //public string Hello
        //{
        //    get { return _hello; }

        //    set { _hello = value; RaisePropertyChanged(() => Hello); }
        //}
    }
}

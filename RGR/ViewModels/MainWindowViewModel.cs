using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace RGR.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase currentView;

        public ViewModelBase CurrentView
        {
            set => this.RaiseAndSetIfChanged(ref currentView, value);
            get => currentView;
        }

        public TableViewModel mainView
        {
            get;
        }

        public void Change()
        {
            if (CurrentView is TableViewModel)
            {
                CurrentView = new RequestManagerViewModel();
            }
            else if (currentView is RequestManagerViewModel) {
                CurrentView = new TableViewModel();
            } 
        }

        public MainWindowViewModel()
        {
            CurrentView = mainView = new TableViewModel();
        }
    }
}

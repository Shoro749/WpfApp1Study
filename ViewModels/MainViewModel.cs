using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1Study.ViewModels.Base;

namespace WpfApp1Study.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public ObservableCollection<string> Names { get; set; }

        public MainViewModel()
        {
            Names = new ObservableCollection<string>();
        }
    }
}

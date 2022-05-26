using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RGR.ViewModels
{
    public class RequestManagerViewModel : ViewModelBase
    {
        ObservableCollection<string> Test { get; set; }
        private string[] symbols = { "=", "<>", "<", ">", "<=", ">=", "!<", "!>"};
        public string[] Symbols 
        { 
            get => symbols;
        }
        public RequestManagerViewModel()
        {
            Test = new ObservableCollection<string>();
            Test.Add("abobs");
            Test.Add("kekw");
            Test.Add("lmao");
            Test.Add("жмых");
            Test.Add("пипяо");
            Test.Add("bingus");
        }
    }
}

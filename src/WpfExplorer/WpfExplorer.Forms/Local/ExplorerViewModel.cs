using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExplorer.Forms.Local
{
    public class ExplorerViewModel : ObservableBase
    {
        public string TestTitle { get; set; }

        public ExplorerViewModel()
        {
            TestTitle = "WPF INSIE OUT";
        }
    }
}

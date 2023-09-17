using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Main.UI.Units
{
    public class FolderTreeView : TreeView
    {
        static FolderTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderTreeView),
                new FrameworkPropertyMetadata(typeof(FolderTreeView)));
        }
    }
}

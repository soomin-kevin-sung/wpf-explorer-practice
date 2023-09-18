using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Main.Local.ViewModels
{
	public class MainContentViewModel
	{
		public List<FolderInfo> Roots { get; init; }

		public MainContentViewModel(FileService fileService)
		{
			Roots = fileService.GenerateRootNodes();
		}
	}
}

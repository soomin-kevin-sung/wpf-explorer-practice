using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Support.Local.Helpers
{
	public class FileService
	{
		private readonly DirectoryManager _directoryManager;

		public FileService(DirectoryManager directoryManager)
		{
			_directoryManager = directoryManager;
		}

		public List<FolderInfo> GenerateRootNodes()
		{
			// 기본 폴더 추가
			List<FolderInfo> roots = new()
			{
				CreateFolderInfo(1, "Download", IconType.ArrowDownBox, _directoryManager.DownloadDirectory),
				CreateFolderInfo(1, "Documents", IconType.TextBox, _directoryManager.DocumentsDirectory),
				CreateFolderInfo(1, "Pictures", IconType.ArrowDownBox, _directoryManager.PicturesDirectory),
			};

			// 존재하는 드라이브 추가
			foreach (var drive in DriveInfo.GetDrives())
			{
				var name = $"{drive.VolumeLabel}({drive.RootDirectory.FullName.Replace("\\", "")})";
				roots.Add(CreateFolderInfo(1, name, IconType.MicrosoftWindows, drive.Name));
			}

			return roots;
		}

		private static FolderInfo CreateFolderInfo(int depth, string name, IconType iconType, string fullPath)
		{
			return new FolderInfo
			{
				Depth = depth,
				Name = name,
				IconType = iconType,
				FullPath = fullPath,
				Children = new()
			};
		}
	}
}

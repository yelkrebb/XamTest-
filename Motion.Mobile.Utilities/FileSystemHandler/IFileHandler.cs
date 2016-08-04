using System;
using System.Threading.Tasks;

namespace Motion.Mobile.Utilities
{
	public interface IFileHandler
	{
		Task CreateFileAsync (string filename);
//		Task CreateFileASync (string filename, string fileExt);
//
//		Task DeleteFileAsync (string filename);
//		Task RenameFileAsync (string currentFilename, string newFilename);
	}
}


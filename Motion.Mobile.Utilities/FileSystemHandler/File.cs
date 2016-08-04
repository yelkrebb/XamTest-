using System;
using System.Threading.Tasks;
using PCLStorage;
using System.Diagnostics;

namespace Motion.Mobile.Utilities
{
	public class File : IFileHandler
	{
		IFile file;

		public File ()
		{
		}

		public async Task CreateFileAsync(string filename)
		{
			// get the directory of a fileSystem
			IFolder rootFolder = FileSystem.Current.LocalStorage;
			Debug.WriteLine ("Root Folder" + rootFolder.ToString ());

			// create a sub folder inside the root directory of a filesystem
			IFolder customFolder = await rootFolder.CreateFolderAsync("Test Folder", CreationCollisionOption.OpenIfExists);

			//open the file if exist, otherwise create a new one
			file = await customFolder.CreateFileAsync(filename, CreationCollisionOption.OpenIfExists);

			await file.WriteAllTextAsync ("The quick brown fox jump over the lazy dog.");
		}
	}
}


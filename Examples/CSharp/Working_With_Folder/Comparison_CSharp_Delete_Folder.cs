using System;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	// Delete Folder
	class Delete_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new DeleteFolderRequest("Comparisondocs/Comparisondocs1", Common.MyStorage, true);

				apiInstance.DeleteFolder(request);
				Console.WriteLine("Expected response type is Void: 'Comparisondocs/Comparisondocs1' folder deleted recusrsively.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}
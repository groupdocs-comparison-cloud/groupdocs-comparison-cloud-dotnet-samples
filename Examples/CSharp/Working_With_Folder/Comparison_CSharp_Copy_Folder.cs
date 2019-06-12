using System;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	// Copy Folder
	class Copy_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new CopyFolderRequest("Comparisondocs", "Comparisondocs1", Common.MyStorage, Common.MyStorage);

				apiInstance.CopyFolder(request);
				Console.WriteLine("Expected response type is Void: 'Comparisondocs' folder copied as 'Comparisondocs1'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}
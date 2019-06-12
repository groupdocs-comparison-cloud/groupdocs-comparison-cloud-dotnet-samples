using System;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	// Create Folder
	class Create_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new CreateFolderRequest("", Common.MyStorage);

				apiInstance.CreateFolder(request);
				Console.WriteLine("Expected response type is Void: 'Comparisondocs' folder created.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}
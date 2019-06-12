using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	// Move File
	class Move_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FileApi(configuration);

			try
			{
				var request = new MoveFileRequest("Comparisondocs/one-page1.docx", "Comparisondocs1/one-page1.docx", Common.MyStorage, Common.MyStorage);

				apiInstance.MoveFile(request);
				Console.WriteLine("Expected response type is Void: 'Comparisondocs/one-page1.docx' file moved to 'Comparisondocs1/one-page1.docx'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}
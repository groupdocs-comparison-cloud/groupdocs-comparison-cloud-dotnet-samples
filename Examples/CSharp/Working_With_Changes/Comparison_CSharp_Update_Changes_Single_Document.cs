using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	// Accept or reject changes with source & target document and get download link for output document
	class Update_Changes_Single_Document
	{
		public static void Run()
		{
			var apiInstance = new CompareApi(Common.MyAppSid, Common.MyAppKey);

			try
			{
				var options = new UpdatesOptions()
				{
					// Set source file
					SourceFile = new FileInfo()
					{
						FilePath = "Comparisondocs\\source_protected.docx",
						Password = "1231",
						StorageName = Common.MyStorage
					},
					OutputPath = "Comparisondocs\\result_single_protected.docx",
					Settings = new Settings
					{
						GenerateSummaryPage = true,
						ShowDeletedContent = true,
						StyleChangeDetection = true,
						UseFramesForDelInsElements = false,
						MetaData = null,
						DetailLevel = "Low",
						DiagramMasterSetting = null,
						CalculateComponentCoordinates = false,
						CloneMetadata = "Default",
						MarkDeletedInsertedContentDeep = false,
						Password = "1111",
						PasswordSaveOption = "User",
						DeletedItemsStyle = new ItemsStyle
						{
							BeginSeparatorString = "",
							EndSeparatorString = "",
							FontColor = "16711680",
							HighlightColor = "16711680",
							Bold = false,
							Italic = false,
							StrikeThrough = false
						},
						InsertedItemsStyle = new ItemsStyle
						{
							BeginSeparatorString = "",
							EndSeparatorString = "",
							FontColor = "255",
							HighlightColor = "255",
							Bold = false,
							Italic = false,
							StrikeThrough = false
						},
						StyleChangedItemsStyle = new ItemsStyle
						{
							BeginSeparatorString = "",
							EndSeparatorString = "",
							FontColor = "65280",
							HighlightColor = "65280",
							Bold = false,
							Italic = false,
							StrikeThrough = false
						},
					},

				};

				// Set target file
				var targets = new List<FileInfo>();
				FileInfo targetFile = new FileInfo()
				{
					FilePath = "Comparisondocs\\target_protected.docx",
					Password = "5784",
					StorageName = Common.MyStorage
				};

				targets.Add(targetFile);
				options.TargetFiles = targets.ToList();

				// Accept or reject changes.
				var changes = new List<ChangeInfo>
				{
					new ChangeInfo {Id = 0, ComparisonAction = "Accept"},
					new ChangeInfo {Id = 1, ComparisonAction = "Reject"}
				};
				options.Changes = changes.ToList();

				// Create request object.
				var request = new PutChangesDocumentRequest(options);

				// Execute api method.
				var response = apiInstance.PutChangesDocument(request);

				Console.WriteLine("Expected response type is Link: " + response.Href);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Comparison CompareApi: " + e.Message);
			}
		}
	}
}
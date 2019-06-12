using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	// Compare multiple document with source document and get download link for output document
	class Compare_Multiple_Documents
	{
		public static void Run()
		{
			var apiInstance = new CompareApi(Common.MyAppSid, Common.MyAppKey);

			try
			{
				var options = new Options()
				{
					// Set source file
					SourceFile = new FileInfo()
					{
						FilePath = "Comparisondocs\\source_protected.docx",
						Password = "1231",
						StorageName = Common.MyStorage
					},
					OutputPath = "Comparisondocs\\result_multi_protected.docx",
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

				// Set multiple target files
				var targets = new List<FileInfo>();

				// Target file 1
				FileInfo targetFile1 = new FileInfo()
				{
					FilePath = "Comparisondocs\\target_protected.docx",
					Password = "5784",
					StorageName = Common.MyStorage
				};

				targets.Add(targetFile1);

				// Target file 2
				FileInfo targetFile2 = new FileInfo()
				{
					FilePath = "Comparisondocs\\target_2_protected.docx",
					Password = "5784",
					StorageName = Common.MyStorage
				};

				targets.Add(targetFile2);
				options.TargetFiles = targets.ToList();

				// Create request object.
				var request = new ComparisonsRequest(options);

				// Execute api method.
				var response = apiInstance.Comparisons(request);

				Console.WriteLine("Expected response type is Link: " + response.Href);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling Comparison CompareApi: " + e.Message);
			}
		}
	}
}
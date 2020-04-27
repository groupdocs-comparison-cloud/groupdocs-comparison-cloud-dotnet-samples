using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to get changes coordinates
    /// </summary>
    public class GetChangesCoordinates
    {
        public static void Run()
        {
            var apiInstance = new CompareApi(Constants.GetConfig());

            try
            {
                var options = new ComparisonOptions
                {
                    SourceFile = new FileInfo
                    {
                        FilePath = "source_files/word/source.docx"
                    },
                    TargetFiles = new List<FileInfo> {
                        new FileInfo {
                            FilePath = "target_files/word/target.docx"
                        }
                    },
                    Settings = new Settings
                    {
                        CalculateComponentCoordinates = true
                    }
                };

                var request = new PostChangesRequest(options);

                var changes = apiInstance.PostChanges(request);
                foreach (var change in changes.Take(2))
                    Console.WriteLine("Change Type: {0}, X: {1}, Y: {2}, Text: {3}", change.Type, change.Box.X, change.Box.Y, change.Text);

                Console.WriteLine("...");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
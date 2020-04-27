using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to get list of changes of compared documents
    /// </summary>
    public class GetListOfChanges
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
                    }
                };

                var request = new PostChangesRequest(options);

                var changes = apiInstance.PostChanges(request);
                Console.WriteLine("Changes count: " + changes.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
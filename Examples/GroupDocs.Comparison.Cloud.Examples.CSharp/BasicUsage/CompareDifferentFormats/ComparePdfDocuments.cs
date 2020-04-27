using System;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.BasicUsage.CompareDifferentFormats
{
    /// <summary>
    /// This example demonstrates how to compare two pdf documents
    /// </summary>
    public class ComparePdfDocuments
    {
        public static void Run()
        {
            var apiInstance = new CompareApi(Constants.GetConfig());

            try
            {
                var options = new ComparisonOptions
                {
                    SourceFile = new FileInfo {FilePath = "source_files/pdf/source.pdf"},
                    TargetFiles = new List<FileInfo> {new FileInfo {FilePath = "target_files/pdf/target.pdf"}},
                    OutputPath = "output/result.pdf"
                };

                var request = new ComparisonsRequest(options);

                var response = apiInstance.Comparisons(request);
                Console.WriteLine("Output file link: " + response.Href);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to compare documents with comparison sensitivity option
    /// </summary>
    public class CompareSensitivity
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
                    Settings = new Settings { 
                        SensitivityOfComparison = 100
                    },
                    OutputPath = "output/result.docx"
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
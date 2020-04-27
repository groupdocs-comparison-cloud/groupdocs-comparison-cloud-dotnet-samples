using System;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.CompareMultipleDocuments
{
    /// <summary>
    /// This example demonstrates how to compare multiple password-protected documents
    /// </summary>
    public class CompareMultipleProtectedDocuments
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
                        FilePath = "source_files/word/source_protected.docx",
                        Password = "1231"
                    },
                    TargetFiles = new List<FileInfo> {
                        new FileInfo {
                            FilePath = "target_files/word/target_protected.docx",
                            Password = "5784"
                        },
                        new FileInfo {
                            FilePath = "target_files/word/target_1_protected.docx",
                            Password = "5784"
                        },
                        new FileInfo {
                            FilePath = "target_files/word/target_2_protected.docx",
                            Password = "5784"
                        }
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
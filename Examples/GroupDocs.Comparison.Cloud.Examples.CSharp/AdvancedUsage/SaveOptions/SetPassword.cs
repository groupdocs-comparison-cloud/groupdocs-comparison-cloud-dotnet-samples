using System;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.SaveOptions
{
    /// <summary>
    /// This example demonstrates how to set custom password for output document
    /// </summary>
    public class SetPassword
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
                        PasswordSaveOption = Settings.PasswordSaveOptionEnum.User,
                        Password = "3333"
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
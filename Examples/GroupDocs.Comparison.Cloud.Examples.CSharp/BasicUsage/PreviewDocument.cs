using System;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to preview document
    /// </summary>
    public class PreviewDocument
    {
        public static void Run()
        {
            var apiInstance = new PreviewApi(Constants.GetConfig());

            try
            {
                var options = new PreviewOptions
                {
                    FileInfo = new FileInfo {FilePath = "source_files/word/source.docx"},
                    Format = PreviewOptions.FormatEnum.Png,
                    OutputFolder = "output"
                };

                var request = new PreviewRequest(options);

                var response = apiInstance.Preview(request);
                Console.WriteLine("Output pages num: " + response.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
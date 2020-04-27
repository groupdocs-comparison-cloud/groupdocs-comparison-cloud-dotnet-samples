using System;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to get document information
    /// </summary>
    public class GetDocumentInformation
    {
        public static void Run()
        {
            var apiInstance = new InfoApi(Constants.GetConfig());

            try
            {
                var fileInfo = new FileInfo
                {
                    FilePath = "source_files/word/source.docx"
                };
                var request = new GetDocumentInfoRequest(fileInfo);

                var response = apiInstance.GetDocumentInfo(request);
                Console.WriteLine("InfoResult.Pages.Count: " + response.PageCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}
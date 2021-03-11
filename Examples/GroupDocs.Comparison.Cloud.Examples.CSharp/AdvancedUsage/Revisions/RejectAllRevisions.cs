using System;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.Revisions
{
    /// <summary>
    /// This example demonstrates how to reject all revisions of DOCX document
    /// </summary>
    public class RejectAllRevisions
    {
        public static void Run()
        {
            var apiInstance = new ReviewApi(Constants.GetConfig());

            try
            {
                var options = new ApplyRevisionsOptions
                {
                    SourceFile = new FileInfo {FilePath = "source_files/word/source_with_revs.docx" },
                    RejectAll = true,
                    OutputPath = "output/result.docx"
                };

                var response = apiInstance.ApplyRevisions(new ApplyRevisionsRequest(options));

                Console.WriteLine("RejectAllRevisions: Output file link: " + response.Href);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
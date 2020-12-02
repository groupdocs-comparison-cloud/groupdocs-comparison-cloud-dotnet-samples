using System;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.Revisions
{
    /// <summary>
    /// This example demonstrates how to get list of revisions of DOCX document
    /// </summary>
    public class GetListOfRevisions
    {
        public static void Run()
        {
            var apiInstance = new ReviewApi(Constants.GetConfig());

            try
            {
                var sourceFile = new FileInfo
                    {
                        FilePath = "source_files/word/source_with_revs.docx"
                    };

                var request = new GetRevisionsRequest(sourceFile);

                var revisions = apiInstance.GetRevisions(request);
                Console.WriteLine("GetListOfRevisions: Revisions count: " + revisions.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
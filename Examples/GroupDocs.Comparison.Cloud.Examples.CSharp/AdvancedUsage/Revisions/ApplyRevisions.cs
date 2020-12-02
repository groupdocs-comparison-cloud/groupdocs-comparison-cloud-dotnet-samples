using System;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.Revisions
{
    /// <summary>
    /// This example demonstrates how to accept/reject revisions of DOCX document
    /// </summary>
    public class ApplyRevisions
    {
        public static void Run()
        {
            var apiInstance = new ReviewApi(Constants.GetConfig());

            try
            {
                var options = new ApplyRevisionsOptions
                {
                    SourceFile = new FileInfo {FilePath = "source_files/word/source_with_revs.docx" },
                    OutputPath = "output/result.docx"
                };

                var revisions = apiInstance.GetRevisions(new GetRevisionsRequest(options.SourceFile));

                foreach (var revision in revisions)
                    revision.Action = RevisionInfo.ActionEnum.Accept;

                options.Revisions = revisions;

                var response = apiInstance.ApplyRevisions(new ApplyRevisionsRequest(options));

                Console.WriteLine("ApplyRevisions: Output file link: " + response.Href);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
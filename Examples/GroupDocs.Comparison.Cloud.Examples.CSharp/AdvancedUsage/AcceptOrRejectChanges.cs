using System;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to accept/reject changes after documents compare
    /// </summary>
    public class AcceptOrRejectChanges
    {
        public static void Run()
        {
            var apiInstance = new CompareApi(Constants.GetConfig());

            try
            {
                var options = new UpdatesOptions
                {
                    SourceFile = new FileInfo {FilePath = "source_files/word/source.docx"},
                    TargetFiles = new List<FileInfo> {new FileInfo {FilePath = "target_files/word/target.docx"}},
                    OutputPath = "output/result.docx"
                };

                var changes = apiInstance.PostChanges(new PostChangesRequest(options));

                foreach (var change in changes)
                    change.ComparisonAction = ChangeInfo.ComparisonActionEnum.Reject;

                changes[0].ComparisonAction = ChangeInfo.ComparisonActionEnum.Accept;

                options.Changes = changes;

                var response = apiInstance.PutChangesDocument(new PutChangesDocumentRequest(options));

                Console.WriteLine("Output file link: " + response.Href);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}
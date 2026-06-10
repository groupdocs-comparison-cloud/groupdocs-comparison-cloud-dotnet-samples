using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using System.Linq;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to get a list of changes between two documents
    /// by providing the files directly (multipart/form‑data) via the PutChanges method.
    /// </summary>
    public class GetListOfChangesFromLocalFiles
    {
        public static void Run()
        {
            var apiInstance = new CompareApi(Constants.GetConfig());

            try
            {
                // Path to the local source and target files (relative to the project root).
                var sourcePath = Path.Combine("..", "Resources", "source_files", "word", "source.docx");
                var targetPath = Path.Combine("..", "Resources", "target_files", "word", "target.docx");

                var sourceFile = new System.IO.FileInfo(sourcePath);
                var targetFile = new System.IO.FileInfo(targetPath);

                // Optional: you can pass comparison settings as a JSON string or filter by change type.
                // string settingsJson = "{ \"GenerateSummary\": true }";
                // string changeType = "Inserted"; // or Deleted, Modified, etc.

                var request = new PutChangesRequest(sourceFile, targetFile/*, settingsJson, changeType*/);

                // The API returns a list of ChangeInfo objects.
                List<ChangeInfo> changes = apiInstance.PutChanges(request);

                Console.WriteLine($"Changes count: {changes.Count}");
                // Print a few change details as a demonstration.
                foreach (var change in changes.Take(3))
                {
                    Console.WriteLine($"Type: {change.Type}, Text: {change.Text}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception while calling CompareApi.PutChanges: {e.Message}");
            }
        }
    }
}
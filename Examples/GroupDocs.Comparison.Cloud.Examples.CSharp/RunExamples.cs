using System;
using GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage;
using GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.CompareMultipleDocuments;
using GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.Revisions;
using GroupDocs.Comparison.Cloud.Examples.CSharp.AdvancedUsage.SaveOptions;
using GroupDocs.Comparison.Cloud.Examples.CSharp.BasicUsage;
using GroupDocs.Comparison.Cloud.Examples.CSharp.BasicUsage.CompareDifferentFormats;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	public class RunExamples
	{
		public static void Main(string[] args)
		{
            //// ***********************************************************
            ////          GroupDocs.Comparison Cloud API Examples
            //// ***********************************************************

            //TODO: Get your Client Id and Client secret at https://dashboard.groupdocs.cloud (free registration is required).
            Constants.MyClientId = "XXXX-XXXX-XXXX-XXXX";
            Constants.MyClientSecret = "XXXXXXXXXXXXXXXX";
            Constants.MyStorage = "First Storage";


            // Uploading sample test files from local disk to cloud storage
            Constants.UploadSampleTestFiles();

            #region Basic usage
            GetSupportedFormats.Run();
            GetDocumentInformation.Run();
            CompareDocuments.Run();
            ComparePdfDocuments.Run();
            #endregion

            #region Advanced usage
            CompareProtectedDocuments.Run();
            AcceptOrRejectChanges.Run();
            CompareMultipleDocumentsOptions.Run();
            CompareMultipleProtectedDocuments.Run();
            CompareSensitivity.Run();
            CustomizeChangesStyles.Run();
            GetListOfChanges.Run();
            GetChangesCoordinates.Run();
            SetPassword.Run();
            SetMetadata.Run();

            GetListOfRevisions.Run();
            ApplyRevisions.Run();
            AcceptAllRevisions.Run();
            RejectAllRevisions.Run();
            #endregion


            Console.WriteLine("Completed!");
            Console.ReadKey();
        }
	}
}
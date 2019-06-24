using System;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	class RunExamples
	{
		static void Main(string[] args)
		{
			//// ***********************************************************
			////          GroupDocs.Comparison Cloud API Examples
			//// ***********************************************************

			//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
			Common.MyAppSid = "XXXXX-XXXXX-XXXXX-XXXXX";
			Common.MyAppKey = "XXXXXXXXXXXXXXXXXXXX";
			Common.MyStorage = "XXXXX";

			//// Uploading sample test files from local to storage under folder 'Comparisondocs'
			//Common.UploadSampleTestFiles();

			//// ***********************************************************
			///// ***** WORKING WITH STORAGE *****
			//// ***********************************************************

			//// Is Storage Exist
			//Storage_Exist.Run();

			//// Get Get Disc Usage
			//Get_Disc_Usage.Run();

			//// Get File Versions
			//Get_File_Versions.Run();

			//// Is Object Exists
			//Object_Exists.Run();


			//// ***********************************************************
			//// ***** WORKING WITH FOLDER *****
			//// ***********************************************************

			//// Create Folder
			//Create_Folder.Run();

			//// Copy Folder
			//Copy_Folder.Run();

			//// Move Folder
			//Move_Folder.Run();

			//// Delete Folder
			//Delete_Folder.Run();

			//// Get Files List
			//Get_Files_List.Run();


			//// ***********************************************************
			//// ***** WORKING WITH FILES *****
			//// ***********************************************************

			//// Upload File
			//Upload_File.Run();

			//// Copy File
			//Copy_File.Run();

			//// Move File
			//Move_File.Run();

			//// Delete File
			//Delete_File.Run();

			//// Download_File
			//Download_File.Run();


			//// ***********************************************************
			//// ***** WORKING WITH SUPPORTED FORMATS *****
			//// ***********************************************************

			//// Get All Supported Formats
			//Get_All_Supported_Formats.Run();


			//// ***********************************************************
			//// ***** WORKING WITH DOCUMENT COMPARISONS *****
			//// ***********************************************************

			//// Compare single document with source document and get download link for output document
			//Compare_Single_Document.Run();

			//// Compare multiple document with source document and get download link for output document
			//Compare_Multiple_Documents.Run();


			//// ***********************************************************
			//// ***** WORKING WITH CHANGES *****
			//// ***********************************************************

			//// Get changes from single source and terget files
			//Get_Changes_Single_Document.Run();

			//// Get changes from single source and multiple terget files
			//Get_Changes_Multiple_Documents.Run();

		}
	}
}
using System;
using System.Linq;
using GroupDocs.Comparison.Cloud.Sdk.Api;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to obtain all supported document formats
    /// </summary>
    public class GetSupportedFormats
    {
		public static void Run()
		{
            var apiInstance = new InfoApi(Constants.GetConfig());

			try
			{
				// Get supported conversion types
                var response = apiInstance.GetSupportedFileFormats();

				foreach (var entry in response.Formats.Take(2))
				{
					Console.WriteLine($"{entry.Extension}: {entry.FileFormat}");
				}
                Console.WriteLine("...");
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling InfoApi: " + e.Message);
			}
		}
	}
}
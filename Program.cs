namespace Microsoft.Azure.CognitiveServices.Samples.Face
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Add your Azure Computer Vision subscription key and endpoint to your environment variables
            string subscriptionKey = "3e045bf89e9144dbb2725746829dc135";
            string endpoint = "https://biometriafacial.cognitiveservices.azure.com/";

            // Detect sample.
            Detection.Run(endpoint, subscriptionKey).Wait();

            // FindSimilar samples.
            FindSimilarInFaceIds.Run(endpoint, subscriptionKey).Wait();
            FindSimilarInFaceList.Run(endpoint, subscriptionKey).Wait();
            FindSimilarInLargeFaceList.Run(endpoint, subscriptionKey).Wait();

            // Group sample.
            Group.Run(endpoint, subscriptionKey).Wait();

            // Identify sample.
            IdentifyInPersonGroup.Run(endpoint, subscriptionKey).Wait();
            IdentifyInLargePersonGroup.Run(endpoint, subscriptionKey).Wait();

            // Verify samples.
            VerifyFaceToFace.Run(endpoint, subscriptionKey).Wait();
            VerifyInPersonGroup.Run(endpoint, subscriptionKey).Wait();
            VerifyInLargePersonGroup.Run(endpoint, subscriptionKey).Wait();

            Console.WriteLine("\nPress ENTER to exit.");
            Console.ReadLine();
        }
    }
}

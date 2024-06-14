using System;
using System.Threading.Tasks;

class AsyncAwaitExample
{
    static async Task DownloadFile(string url)
    {
        // Simulate downloading a file (replace with actual downloading logic)
        await Task.Delay(2000); // Simulate 2 seconds of download time
        Console.WriteLine($"Downloaded {url}");
    }

    static async Task Main(string[] args)
    {
        // Start downloading two files asynchronously
        Task task1 = DownloadFile("https://example.com/file1.txt");
        Task task2 = DownloadFile("https://example.com/file2.txt");

        // Continue executing other code while downloads are in progress
        Console.WriteLine("Downloading files...");

        // Wait for both downloads to finish asynchronously
        await Task.WhenAll(task1, task2); // Alternative: await task1; await task2;

        Console.WriteLine("Downloads complete!");
    }
}


namespace LanguageFeatures.Models;
public class MyAsyncMethod
{
    public async static Task<long?> GetPageLength()
    {
        HttpClient c = new HttpClient();
        var httpMessage = await c.GetAsync("http://mannig.com");
        return httpMessage.Content.Headers.ContentLength;
    }

    public static async IAsyncEnumerable<long?> GetPageLengths(List<string> output,
                    params string[] urls)
    {
        List<long?> results = new List<long?>();
        HttpClient client = new HttpClient();
        foreach (string url in urls)
        {
            output.Add($"Started request for {url}");
            var httpMessage = await client.GetAsync($"http://{url}");
            output.Add($"Completed request for {url}");
            yield return httpMessage.Content.Headers.ContentLength;
        }
    }
}
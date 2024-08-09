namespace LanguageFeatures.Models;
public class MyAsyncMethod {
public async static Task<long?> GetPageLength(){   
    HttpClient c = new HttpClient();
    var httpMessage = await c.GetAsync("http://mannig.com");
    return httpMessage.Content.Headers.ContentLength;
    }
}

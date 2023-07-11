using static System.Net.WebRequestMethods;

namespace NETDemo.Services;

public class MyHttpClient : HttpClient
{
    public MyHttpClient()
    {
    }

    public async Task<string> Get(string url)
    {
        try
        {
            var result = await SendAsync(new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            });

            var str = await result.Content.ReadAsStringAsync();

            return str;
        }
        catch
        {

        }
        
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System.Net.Http.Headers;
namespace SearhEngineWebUI.Pages;

public class IndexModel : PageModel
{

    private readonly ILogger<IndexModel> _logger;
    public String results = "";

    [BindProperty]
    public String Input { get; set; }

    private static readonly HttpClient client = new HttpClient();

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async Task OnPost()
    {
        results = await ProcessRepositories();


        System.Console.WriteLine(results);

    }

    private async Task<String> ProcessRepositories()
    {
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        var stringTask = client.GetStringAsync($"https://localhost:7286/Search/{Input}");

        var msg = await stringTask;
        Console.Write(msg);

        return msg;
    }
}

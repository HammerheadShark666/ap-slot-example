using Microsoft.AspNetCore.Mvc.RazorPages;

namespace slot_example_mvc.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        ViewData["SlotType"] = Environment.GetEnvironmentVariable("SLOT_TYPE");

    }
}

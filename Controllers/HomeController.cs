namespace LanguageFeatures.Controllers;
public class HomeController : Controller {
    public async Task<ViewResult> Index() {
        long? length = await MyAsyncMethod.GetPageLength();
         return View(new string[] {$"Page Length: {length}"});
}
}
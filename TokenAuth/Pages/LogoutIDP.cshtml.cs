using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TokenAuth.Pages
{
    public class LogoutIDPModel : PageModel
    {
        #region Publics
        public async Task OnGetAsync()
        {
            await this.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await this.HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
        }
        #endregion
    }
}
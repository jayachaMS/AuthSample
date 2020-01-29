using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TokenAuth.Pages
{
    public class LoginIDPModel : PageModel
    {
        #region Publics
        public async Task OnGetAsync()
        {
            if(!this.HttpContext.User.Identity.IsAuthenticated)
            {
                await this.HttpContext.ChallengeAsync(OpenIdConnectDefaults.AuthenticationScheme);
            }
            else
            {
                // redirect to the root
                this.Response.Redirect(this.Url.Content("~/"));
            }
        }
        #endregion
    }
}
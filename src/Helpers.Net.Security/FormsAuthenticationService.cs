using System.Web.Security;

namespace Helpers.Net.Security
{
    public class FormsAuthenticationService : IFormsAuthentication
    {
        #region Implementation of IFormsAuthentication

        public void SignIn(string username, bool createPersistentCookie)
        {
            FormsAuthentication.SetAuthCookie(username, createPersistentCookie);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }

        #endregion
    }
}
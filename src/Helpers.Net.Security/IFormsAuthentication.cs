namespace Helpers.Net.Security
{
    public interface IFormsAuthentication
    {
        void SignIn(string username, bool createPersistentCookie);
        void SignOut();
    }
}
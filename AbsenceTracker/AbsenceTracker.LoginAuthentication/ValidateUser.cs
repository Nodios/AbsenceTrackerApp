using AbsenceTracker.Common;
using System.DirectoryServices.AccountManagement;

namespace AbsenceTracker.LoginAuthentication
{
    public static class ValidateUser
    {
        public static UserPrincipal Validate(UserCredentials credentials)
        {
            // set up domain context
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain))
            {
                //Validate users credentials
                var userValidated = ctx.ValidateCredentials(credentials.UserName, credentials.Password);

                if (userValidated == false)
                    return null;
                // find user by userName name
                UserPrincipal user = UserPrincipal.FindByIdentity(ctx, credentials.UserName);

                if (user != null)
                    return user;
                return null;
            }

        }//End of Validate methode


    }
}

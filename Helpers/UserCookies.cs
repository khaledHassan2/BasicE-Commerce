namespace Helpers
{
    public static class UserCookies
    {
        public static int? CurrentUserId = null;
        public static string? CurrentUserName = null;
        public static string? CurrentPassword = null;
        public static string? Currentemail = null;
        public static string? CurrentRole = null;

        public static void SaveCurrentUser(int? id, string? name , string? email ,string? password,string? role)
        {
            CurrentUserId = id;
            CurrentUserName = name;
            CurrentPassword = email;
            CurrentPassword = password;
            CurrentRole = role;
        }
        
    }
}

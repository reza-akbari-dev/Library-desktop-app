using Core;
using Domain.Entities;

namespace Sec.urityManager
{
    public static class SignManager
    {
        public static User? OnlineUser { get; set; }
        public static void Authenticate(string userName, string passWord)
        {
            passWord = passWord.Hash();
            OnlineUser = Database.Context.Users.SingleOrDefault(p => p.UserName == userName && p.Password == passWord);
            if (OnlineUser == null)
            {
                throw new AuthenticateException();
            }
            else
            {
                OnlineUser.LastOnLogin = DateTime.Now;
                Database.Context.SaveChanges();
            }
        }
    }
}

using Domain.Entities;
using Sec.urityManager;

namespace SecurityManager
{
    public static class AuthorizeManager
    {
        public static void Autorize(UserActivity userActivity)
        {
            var _list = SignManager.OnlineUser.Roles.ToList();
            if (_list.Any(p => p.RoleName == "Administrator"))
            {
                return;
            }
            if (!_list.Any(p => p.Activities.Any(x => x.ActivityName == userActivity)))
            {
                throw new AuthourizeException();
            }
        }
    }
}

using Facebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facebook.ViewModels
{
    public class SearchViewModel
    {
        public List<ApplicationUser> users;
        public List<FriendRequest> FriendRequestsSent;
        public List<FriendRequest> FriendRequestsReciev;
        public List<ApplicationUser> Friends;
        public int count;
    }
}

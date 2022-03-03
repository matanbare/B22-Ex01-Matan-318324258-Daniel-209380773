﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class BestFriendsTracker
    {
        public string Name { get; set; }
        public int TotalLikes { get; set; } = 0;
        public int TotalComments { get; set; } = 0;

        public BestFriendsTracker(string i_FriendName)
        {
            Name = i_FriendName;
        }
    }
}

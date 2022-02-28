using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    class UserBio
    {
        public string From { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }

        public UserBio(string i_From, string i_Birthday, string i_Gender)
        {
            From = i_From;
            Birthday = i_Birthday;
            Gender = i_Gender;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AggregateUserGroups : IEnumerable<Group>
    {
        private readonly ICollection<Group> m_UserGroups;

        public AggregateUserGroups(ICollection<Group> i_Groups)
        {
            m_UserGroups = i_Groups;
        }

        public IEnumerator<Group> GetEnumerator()
        {
            foreach (Group group in m_UserGroups)
            {
                yield return group;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IProgressBarListener
    {
        void UpdateProgressBar(string i_AlbumName, int i_NumberOfAlbums);
    }
}

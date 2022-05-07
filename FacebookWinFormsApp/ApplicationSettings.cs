using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class ApplicationSettings
    {
        private static readonly string sr_FileName;

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".ApplicationSettings20.xml";
        }

        private ApplicationSettings()
        {
        }

        private static ApplicationSettings s_This;

        public static ApplicationSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = ApplicationSettings.FromFileOrDefault();
                }

                return s_This;
            }
        }

        public bool AutoLogin { get; set; }

        public Size LastWindowSize { get; set; }

        public FormWindowState LastWindowState { get; set; }

        public Point LastWindowLocation { get; set; }

        public string AccessToken { get; set; }

        public static ApplicationSettings FromFileOrDefault()
        {
            ApplicationSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadedThis = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                /// C# 3.0 feature: Object Initializer
                loadedThis = new ApplicationSettings()
                {
                    AutoLogin = false,
                    LastWindowSize = new Size(1279, 848),
                    LastWindowState = FormWindowState.Normal
                };
            }

            return loadedThis;
        }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}
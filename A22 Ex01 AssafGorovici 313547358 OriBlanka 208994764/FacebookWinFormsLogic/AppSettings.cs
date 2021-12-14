using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookWinFormsLogic
{
    public class AppSettings
    {
        public bool AutoLogin { get; set; }
        public Size LastWindowSize { get; set; }
        public FormWindowState LastWindowState { get; set; }
        public Point LastWindowLocation { get; set; }
        public string AccessToken { get; set; }

        private static readonly string sr_FileName;

        static AppSettings()
        {
            /*AutoLogin = false;
            LastWindowSize = new Size(2292, 1427);
            LastWindowLocation = new Point(20, 50);
            AccessToken = null;*/
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }
   
        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings FromFileOrDefault()
        {
            AppSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadedThis = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                /// C# 3.0 feature: Object Initializer
                loadedThis = new AppSettings()
                {
                    AutoLogin = false,
                    LastWindowSize = new Size(800, 500),
                    LastWindowState = FormWindowState.Normal
                };
            }

            return loadedThis;
        }
    }
}

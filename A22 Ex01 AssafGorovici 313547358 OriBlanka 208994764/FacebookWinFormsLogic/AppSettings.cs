using System.Xml.Serialization;
using System.IO;
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
            sr_FileName = Directory.GetCurrentDirectory() + "\\appsettings.xml";
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
        public static void DeleteSettingsFile()
        {
            if (File.Exists(sr_FileName))
            {
                File.Delete(sr_FileName);
            }
        }
    }
}

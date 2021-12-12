using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(2292, 1427);
            RememberUser = false;
            LastAccessToken = null;
        }
    }
}

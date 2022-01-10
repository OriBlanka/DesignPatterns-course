using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class PhotoRandomizer : PhotoSelectionAlgorithmBase
    {
        private readonly Random r_Random = new Random();

        protected override Image GetImageFromAlbum(FacebookObjectCollection<Photo> i_Album)
        {
            return i_Album[r_Random.Next(i_Album.Count)].ImageAlbum;
        }
    }
}

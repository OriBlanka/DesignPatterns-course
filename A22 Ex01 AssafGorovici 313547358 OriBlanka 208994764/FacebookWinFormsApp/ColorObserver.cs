using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWinFormsLogic;

namespace BasicFacebookFeatures
{
    public class ColorObserver : IObserver
    {
        private string chosenColor;
        private FormMain formMain;
        public ColorObserver(FormMain formMain)
        {
            this.formMain = formMain;
        }
        public void Update()
        {
            string color = formMain.GetSelectedFavoriteColor();
            chosenColor = color;
            formMain.SetNotifiedColor(chosenColor);

        }
    }
}

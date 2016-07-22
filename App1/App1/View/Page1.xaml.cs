using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.XamForms.SignaturePad;
using Xamarin.Forms;

namespace App1.View
{
    public partial class Page1 : ContentPage
    {
        List<Point[]> points;

        public Page1()
        {
            InitializeComponent();
            btnSave.Clicked += btnButton_Clicked;

        }

        private async void btnButton_Clicked(object sender, EventArgs e)
        {
            if (padView.IsBlank)
            {
//Display the base line for the user to sign on.

            }
            else
            {
                //points = padView.Points;

                // SAVE TO SDCARD
                try
                {
                    string path = "/mnt/sdcard/AsesorMovil/Firmas/";
                    string file = path + "signature" + ".png";
                    var stream = padView.GetImage(ImageFormatType.Png);
                    stream.Position = 0;
                    //MemoryStream stream = new MemoryStream();
                    //using (var ms = new MemoryStream())
                    //{
                    //    stream.CopyTo(ms);
                    //    var test = ms.ToArray();
                    //}
                    testImage.Source=ImageSource.FromStream(()=>stream);
                }
                catch
                {
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ecommerceflyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShootPhotoPage : ContentPage
    {
        private string FullPath = null;
        public ShootPhotoPage()
        {
            InitializeComponent();
        }

        private async void PhotoClick_Pressed(object sender, EventArgs e)
        {
             await Phototask();
            Frame.Source = FullPath;

        }


        private async Task Phototask()
        {
            try
            {

                var Photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(Photo);
            }
            catch(FeatureNotEnabledException fx)
            {

            }
            catch(PermissionException pEx)
            {

            }
            catch (Exception ex)
            {

            }



        }

        async Task LoadPhotoAsync(FileResult Photo)
        {
            if(Photo == null)
            {
                FullPath = null;
            }
            else
            {
                var NewFile = Path.Combine(FileSystem.CacheDirectory, Photo.FileName);
                using (var stream = await Photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(NewFile))
                    await stream.CopyToAsync(newStream);
                FullPath = NewFile;
            }


        }

    }
}
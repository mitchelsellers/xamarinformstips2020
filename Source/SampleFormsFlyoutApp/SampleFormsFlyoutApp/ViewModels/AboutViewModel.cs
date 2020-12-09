using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SampleFormsFlyoutApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            ShareContentCommand = new Command(async () => await OnShare());
        }
        
        public ICommand ShareContentCommand { get; }

        private async Task OnShare()
        {
            // Example writing text to disk and sharing
            var fn = "Attachment.txt";
            var file = Path.Combine(FileSystem.CacheDirectory, fn);
            File.WriteAllText(file, "Hello World");

            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "Look at My File",
                File = new ShareFile(file)
            });
        }
    }
}
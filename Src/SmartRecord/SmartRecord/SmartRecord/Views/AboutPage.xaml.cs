using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.Resources;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace SmartRecord.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            btnClick.Clicked += BtnClick_ClickedAsync;
        }

        private async void  BtnClick_ClickedAsync(object sender, EventArgs e)
        {
            using ( await MaterialDialog.Instance.LoadingDialogAsync(message: $"Something is running...{txti.Text}"))
            {
                 await Task.Delay(5000); // Represents a task that is running.
            }

            var config = new MaterialInputDialogConfiguration()
            {
                InputType = MaterialTextFieldInputType.Password,
                CornerRadius = 8,
                BackgroundColor = Color.FromHex("#2c3e50"),
                InputTextColor = Color.White,
                InputPlaceholderColor = Color.White.MultiplyAlpha(0.6),
                TintColor = Color.White,
                TitleTextColor = Color.White,
                MessageTextColor = Color.FromHex("#DEFFFFFF")
            };

            var input = await MaterialDialog.Instance.InputAsync(title: "Deactivate account",
                                                                 message: "To continue, please enter your current password",
                                                                 inputPlaceholder: "Password",
                                                                 confirmingText: "Deactivate",
                                                                 configuration: config);
            await MaterialDialog.Instance.LoadingDialogAsync(message: $"{input}");

            await Task.Delay(5000);

            var snackbarConfiguration = new MaterialSnackbarConfiguration()
            {
                BackgroundColor = XF.Material.Forms.Material.GetResource<Color>(MaterialConstants.Color.PRIMARY),
                MessageFontFamily = XF.Material.Forms.Material.GetResource<OnPlatform<string>>("FontFamily.OpenSansRegular"),
                ButtonAllCaps = true,
                ButtonFontFamily = XF.Material.Forms.Material.GetResource<OnPlatform<string>>("FontFamily.OpenSansSemiBold"),
                TintColor = Color.White,
                MessageTextColor = XF.Material.Forms.Material.GetResource<Color>(MaterialConstants.Color.ON_PRIMARY).MultiplyAlpha(0.8)
            };

            await Task.Delay(5000);
            await MaterialDialog.Instance.SnackbarAsync(message: "This is a snackbar.", actionButtonText: "Got It",configuration: snackbarConfiguration);

            await Task.Delay(5000);
        }
    }
}
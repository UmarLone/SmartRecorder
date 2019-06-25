using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SmartRecord.Models;
using SmartRecord.ViewModels;
using XF.Material.Forms.UI.Dialogs;
using System.Threading.Tasks;

namespace SmartRecord.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private async System.Threading.Tasks.Task MaterialIconButton_ClickedAsync(object sender, EventArgs e)
        {
            
        }

        private async Task MaterialButton_ClickedAsync(object sender, EventArgs e)
        {
            using (await MaterialDialog.Instance.LoadingDialogAsync(message: "Something is running"))
            {
                await Task.Delay(5000); // Represents a task that is running.
            }
        }
    }
}
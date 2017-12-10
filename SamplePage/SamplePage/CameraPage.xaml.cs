using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace SamplePage
{
    
    public partial class CameraPage : ContentPage
    {
        String sd2;
       // ObservableCollection<string> scanedData;
        public CameraPage()
        {
            InitializeComponent();
          //  scanedData = new ObservableCollection<string>();
           // this.BindingContext = scanedData;
        }

        async void ScanButtonClicked(object sender, EventArgs s)
        {
            var scanPage = new ZXingScannerPage()
            {
                DefaultOverlayTopText = "バーコードを読み取ります",
                DefaultOverlayBottomText = "",
            };

            // スキャナページを表示
            await Navigation.PushAsync(scanPage);

            scanPage.OnScanResult += (result) =>
            {
                // スキャン停止
                scanPage.IsScanning = false;

                // PopAsyncで元のページに戻り、結果をダイアログで表示
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                   // await DisplayAlert("スキャン完了", result.Text, "OK");
                });

               // scanedData.Add(result.Text);
                sd2 = result.Text;
                LOL.Text = sd2;

                var DeleteName = sd2;
                if (DeleteName != null)
                {
                    //UserModel.deleteUser(1);
                    UserModel.deleteUser(int.Parse(DeleteName));
                }
                else
                {
                    //アラート関連で参考になりそう https://dev.classmethod.jp/smartphone/xamarin-forms-alert/
                    DisplayAlert("DeleteIdが選択されていません", "TextBoxに入力してください", "OK");
                }
            };
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SamplePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        private int i = 1;
        public BookPage()
        {
            InitializeComponent();

            var query = UserModel.selectUser(); //中身はSELECT * FROM [User] limit 15
            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center };
            
           
            var query2 = UserModel.countUser(i);

             var s = new List<String>();

            foreach (var user in query2)
             {
                 for (i = 1; i == query.Count; i++)
                 {
                    query2 = UserModel.countUser(i);
                    s[i] = query2.ToString();
                     s.Add(s[i]);
                    this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

                    this.listView.ItemsSource = Enumerable.Range(0, query.Count).Select(n => s);

                }
             }


             /*foreach (var user in query)
             {
                 this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

                 this.listView.ItemsSource = Enumerable.Range(0, query.Count).Select(n =>s);

             }*/


        }

            
    }
}

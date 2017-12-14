using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center };
            var view = new ListView { };
            //var query2 = UserModel.countUser(i);

            //ObservableCollection<Book> s = new ObservableCollection<Book>();
            var s = new List<String>();
            for (i = 1; i == query.Count; i++)
            {
            var query2 = UserModel.countUser(i);
            foreach (var user in query2)
            {
                    s[i] = user.Name.ToString();
                    s.Add(s[i]);
                //s.Add(new Book { Name = user.Name });

            }

            // view.ItemsSource = s;
            }
            view.ItemsSource = s;
            Content = view;


            /*foreach (var user in query)
            {
                this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

                this.listView.ItemsSource = Enumerable.Range(0, query.Count).Select(n =>s);

            }*/


        }
        public class Book
        {
            public string Name { get; set; }
        }


    }
}

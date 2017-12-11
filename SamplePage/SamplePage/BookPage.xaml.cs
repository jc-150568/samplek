﻿using System;
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
        public BookPage()
        {
            InitializeComponent();

            var query = UserModel.selectUser(); //中身はSELECT * FROM [User] limit 15
            var query2 = UserModel.countUser();

            foreach (var user in query)
            {
                
                int aaa=query2.Count;
                this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
                
                this.listView.ItemsSource = Enumerable.Range(0,aaa).Select(n => user.Name);

            }
        }

            
    }
}

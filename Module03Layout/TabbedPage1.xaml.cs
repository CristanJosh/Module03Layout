﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module03Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            PopulateListView();
        }
        private void PopulateListView()
        {
            // Sample data
            List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };

            // Set the ItemsSource
            itemListView.ItemsSource = items;
        }

        // Handle submit button click for user input form
        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string email = emailEntry.Text;

            // Do something with the submitted data
        }
    }
}
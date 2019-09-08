﻿using IntecPract1.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntecPract1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage
    {
        public EditPage()
        {
            InitializeComponent();
            this.BindingContext = new EditPageViewModel();
        }
    }
}
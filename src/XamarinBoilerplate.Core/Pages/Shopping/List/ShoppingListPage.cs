﻿using System;
using Autofac;
using Xamarin.Forms;
using XamarinBoilerplate.Core.Extensions;
using XamarinBoilerplate.Core.Services;
using XamarinBoilerplate.Core.Services.Shopping;

namespace XamarinBoilerplate.Core.Pages.Shopping.List
{
    public class ShoppingListPage : ContentPage, IDisposable
    {
        public ShoppingListPage()
        {
            Title = "Shopping List Sample";

            var shoppingItemService = IoC.Container.Resolve<IShoppingItemService>();
            var navigationService = IoC.Container.Resolve<INavigationService>();

            Content = new ShoppingListView();

            BindingContext = new ShoppingViewModel(shoppingItemService, navigationService);
        }

        public void Dispose()
        {
            this.DisposeContent();
            this.DisposeBindingContext();
        }
    }
}

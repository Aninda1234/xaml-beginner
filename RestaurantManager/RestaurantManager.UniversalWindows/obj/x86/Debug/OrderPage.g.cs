﻿#pragma checksum "H:\GitHub\xaml-beginner\RestaurantManager\RestaurantManager.UniversalWindows\OrderPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D811FDF4CE149AB7F1B0B2E30A8EDFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManager.UniversalWindows
{
    partial class OrderPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.appBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 11 "..\..\..\OrderPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.appBarButton).Click += this.appBarButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.requestsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3:
                {
                    this.itemsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


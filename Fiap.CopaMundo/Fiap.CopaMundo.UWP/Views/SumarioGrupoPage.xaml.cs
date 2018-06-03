using Fiap.CopaMundo.Core.Models;
using Fiap.CopaMundo.EntityFramework.Contexts;
using Fiap.CopaMundo.UWP.ViewModels;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fiap.CopaMundo.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class SumarioGrupoPage : Page
    {
        public SumarioGrupoViewModel ViewModel { get; } = new SumarioGrupoViewModel();

        public SumarioGrupoPage()
        {
            this.InitializeComponent();
            Loaded += SumarioGrupoPage_Loaded;
        }

        private void SumarioGrupoPage_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Initialize();
        }
    }
}

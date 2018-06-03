using Fiap.CopaMundo.UWP.ViewModels;
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
    public sealed partial class TabelaGrupoPage : Page
    {

        public TabelaGrupoViewModel ViewModel { get; } = new TabelaGrupoViewModel();

        public TabelaGrupoPage()
        {
            this.InitializeComponent();
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            object parameter = e.Parameter;

            if (parameter is int)
                await ViewModel.CarregarTabelaAsync((int)parameter);
            else
                throw new ArgumentException();
            
        }
    }
}

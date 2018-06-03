﻿using Fiap.CopaMundo.UWP.ViewModels;
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
    public sealed partial class JogadorPage : Page
    {
        public JogadorViewModel ViewModel { get; } = new JogadorViewModel();

        public JogadorPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            object parameter = e.Parameter;

            if (parameter is int)
                ViewModel.CarregarJogadoresPorSelecao((int)parameter);
            else if(parameter == null)
                ViewModel.CarregarTodos();
            else
                throw new ArgumentException();
        }
    }
}

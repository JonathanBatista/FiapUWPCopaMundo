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
using Microsoft.Toolkit.Uwp.UI.Controls;
using Fiap.CopaMundo.Core.Models;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Fiap.CopaMundo.UWP.UserControls
{
    public sealed partial class JogadorControl : UserControl
    {
        public JogadorControl()
        {
            this.InitializeComponent();
        }

        public Jogador Jogador
        {
            get { return (Jogador)GetValue(JogadorProperty); }
            set { SetValue(JogadorProperty, value); }
        }

        public static readonly DependencyProperty JogadorProperty =
            DependencyProperty.Register("Jogador", typeof(Jogador), typeof(JogadorControl), new PropertyMetadata(null));
    }
}

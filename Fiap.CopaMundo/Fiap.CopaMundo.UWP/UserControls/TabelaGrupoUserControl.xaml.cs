using Fiap.CopaMundo.Core.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Fiap.CopaMundo.UWP.UserControls
{
    public sealed partial class TabelaGrupoUserControl : UserControl
    {
        public TabelaGrupoUserControl()
        {
            this.InitializeComponent();
        }

        public Selecao Selecao
        {
            get { return (Selecao)GetValue(SelecaoProperty); }
            set { SetValue(SelecaoProperty, value); }
        }

        public static readonly DependencyProperty SelecaoProperty =
            DependencyProperty.Register("Selecao", typeof(Selecao), typeof(TabelaGrupoUserControl), new PropertyMetadata(null));
    }
}

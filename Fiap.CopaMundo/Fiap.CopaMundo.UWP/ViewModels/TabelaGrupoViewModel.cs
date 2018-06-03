using Fiap.CopaMundo.Core.Models;
using Fiap.CopaMundo.UWP.Repositories.Repo;
using Fiap.CopaMundo.UWP.Services;
using Fiap.CopaMundo.UWP.Views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI.Popups;
using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Fiap.CopaMundo.UWP.ViewModels
{
    public class TabelaGrupoViewModel
    {
        private readonly GrupoRepository _grupoRepository;

        public string IdentificadorGrupo { get; set; }

        public ObservableCollection<Selecao> Selecoes { get; set; }

        public TabelaGrupoViewModel()
        {
            _grupoRepository = new GrupoRepository();
            Selecoes = new ObservableCollection<Selecao>();
        }

        public async Task CarregarTabelaAsync(int grupoId)
        {
            var grupo = _grupoRepository.Obter(x => x.Id == grupoId);
            
            if (grupo == null)
            {
                var messageDialog = new MessageDialog("Grupo não encontrado!");
                messageDialog.Commands.Add(new UICommand("Retornar", new UICommandInvokedHandler(VoltarParaSumario)));
                
                await messageDialog.ShowAsync();

                return;
            }

            IdentificadorGrupo = grupo.Identificador;                       

            foreach (var selecao in grupo.Selecoes.OrderBy(x => x.Tabela.Pontuacao).ThenBy(x => x.Tabela.SaldoGols).ToList())
                Selecoes.Add(selecao);
        }

        public void VoltarButton_Button_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate<SumarioGrupoPage>();
        }

        public void ListaSelecoes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listView = (ListView)sender;

            if (listView.SelectedItem == null || listView.SelectedItem as Selecao == null)
                return;

            var selecaoId = ((Selecao)listView.SelectedItem).Id;

            NavigationService.Navigate<SelecaoPage>(selecaoId);
        }

        private void VoltarParaSumario(IUICommand command)
        {
            NavigationService.Navigate<SumarioGrupoPage>();
        }
    }
}

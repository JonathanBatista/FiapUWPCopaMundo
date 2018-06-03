using Fiap.CopaMundo.Core.Models;
using Fiap.CopaMundo.UWP.Repositories.Repo;
using Fiap.CopaMundo.UWP.Services;
using Fiap.CopaMundo.UWP.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Fiap.CopaMundo.UWP.ViewModels
{
    public class SelecaoViewModel
    {
        private readonly SelecaoRepository _selecaoRepository;

        public Selecao Selecao { get; set; }

        public ObservableCollection<Selecao> Selecoes { get; set; }

        public bool Notificar { get; set; }

        public SelecaoViewModel()
        {
            _selecaoRepository = new SelecaoRepository();
            Selecoes = new ObservableCollection<Selecao>();
        }


        public void ListaSelecoes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listView = (GridView)sender;

            if (listView.SelectedItem == null || listView.SelectedItem as Selecao == null)
                return;

            var selecaoId = ((Selecao)listView.SelectedItem).Id;

            NavigationService.Navigate<SelecaoPage>(selecaoId);
        }

        public void ExibirSelecao_Click(object sender, RoutedEventArgs e)
        {
            var listView = (GridView)sender;

            if (listView.SelectedItem == null || listView.SelectedItem as Selecao == null)
                return;

            var selecaoId = ((Selecao)listView.SelectedItem).Id;

            NavigationService.Navigate<SelecaoPage>(selecaoId);
        }

        public async Task NotificarToggle_ToggledAsync(object sender, RoutedEventArgs e)
        {
            var toggle = (ToggleSwitch)sender;
            Notificar = toggle.IsOn;
            if (Notificar)
            {
                
                var messageDialog = new MessageDialog($"As notificações para a seleção {Selecao.Pais}, foram ativadas");
                messageDialog.Commands.Add(new UICommand("Ok"));

                await messageDialog.ShowAsync();

                NotificationService.SelecaoNewsNotification(Selecao.Pais);
            }
            else
            {
                var messageDialog = new MessageDialog($"As notificações para a seleção {Selecao.Pais}, foram desativadas");
                messageDialog.Commands.Add(new UICommand("Ok"));
            }           
        }

        public void CarregarSelecao(int id)
        {
            Selecao = _selecaoRepository.Obter(x => x.Id == id);
            Selecoes.Add(Selecao);

            Notificar = Selecao.Configuracoes == null || Selecao.Configuracoes.Count > 0 ? true : false;
        }

        public void CarregarTodasSelecoes()
        {
            var selecoes = _selecaoRepository.ListarTodos();

            foreach (var sel in selecoes.OrderBy(x => x.Pais))
                Selecoes.Add(sel);
        }


        public void VisualizarGrupo() => NavigationService.Navigate<TabelaGrupoPage>(Selecao.GrupoId);
    }
}

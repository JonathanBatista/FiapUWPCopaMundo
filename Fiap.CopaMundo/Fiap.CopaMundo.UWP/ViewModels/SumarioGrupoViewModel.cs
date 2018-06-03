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
using Windows.UI.Xaml.Controls;

namespace Fiap.CopaMundo.UWP.ViewModels
{
    public class SumarioGrupoViewModel
    {
        private readonly GrupoRepository _grupoRepository;

        public ObservableCollection<Grupo> Grupos { get; set; }

        public Grupo GrupoSelecionado { get; set; }


        public SumarioGrupoViewModel()
        {
            _grupoRepository = new GrupoRepository();
            Grupos = new ObservableCollection<Grupo>();            
        }

        public void Initialize()
        {
            var grupos = _grupoRepository
                    .ListarTodos()
                    .OrderBy(x => x.Identificador)
                    .ToList();

            foreach (var grupo in grupos)
                Grupos.Add(grupo);
        }

        public void ListaGrupos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listView = (ListView)sender;

            if (listView.SelectedItem == null || listView.SelectedItem as Grupo == null)
                return;
            
            var grupoId = ((Grupo)listView.SelectedItem).Id;

            NavigationService.Navigate<TabelaGrupoPage>(grupoId);
        }
    }
}

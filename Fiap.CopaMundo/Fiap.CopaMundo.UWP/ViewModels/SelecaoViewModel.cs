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

namespace Fiap.CopaMundo.UWP.ViewModels
{
    public class SelecaoViewModel
    {
        private readonly SelecaoRepository _selecaoRepository;

        public Selecao Selecao { get; set; }

        public ObservableCollection<Jogador> Jogadores { get; set; }

        public Jogador Selecionado { get; set; }

        public SelecaoViewModel()
        {
            _selecaoRepository = new SelecaoRepository();
            Jogadores = new ObservableCollection<Jogador>();
        }

        public void CarregarSelecao(int id)
        {
            Selecao = _selecaoRepository.Obter(x => x.Id == id);

            foreach (var jog in Selecao.Jogadores.OrderBy(x => x.Nome))
                Jogadores.Add(jog);
        }


        public void VisualizarGrupo() => NavigationService.Navigate<TabelaGrupoPage>(Selecao.GrupoId);
    }
}

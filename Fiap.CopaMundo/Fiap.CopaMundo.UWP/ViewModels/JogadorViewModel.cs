using Fiap.CopaMundo.Core.Models;
using Fiap.CopaMundo.UWP.Repositories.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.CopaMundo.UWP.ViewModels
{
    public class JogadorViewModel
    {
        private readonly JogadorRepository _jogadorRepository;

        public ObservableCollection<Jogador> Jogadores { get; set; }

        public Jogador Selecionado { get; set; }

        public JogadorViewModel()
        {
            _jogadorRepository = new JogadorRepository();
            Jogadores = new ObservableCollection<Jogador>();
        }

        public void CarregarJogadoresPorSelecao(int selecaoId)
        {
            var jogadores = _jogadorRepository.ListarTodosCompleto(x => x.SelecaoId == selecaoId);

            foreach (var jog in jogadores.OrderBy(x => x.Nome))
                Jogadores.Add(jog);
        }

        public void CarregarTodos()
        {
            var jogadores = _jogadorRepository.ListarTodosCompleto();

            foreach (var jog in jogadores.OrderBy(x => x.Nome))
                Jogadores.Add(jog);
        }
    }
}

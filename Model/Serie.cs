using System.Collections.Generic;
namespace GerenciadorDeSeries.Model{
    public class Serie{
        public int Id {get;set;}
        public string Titulo { get; set; }
        public int Duracao{get; set;}
        public string Descricao{get;set;}
        public ClassificacaoIndicativa ClassificacaoIndicativa{get; set;}
        public List<Genero> Generos{get;set;}
    }
}
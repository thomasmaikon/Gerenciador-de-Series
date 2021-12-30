using System.Collections.Generic;
using GerenciadorDeSeries.Model;
namespace GerenciadorDeSeries.db{
    public class Repository{
        static List<Serie> series = new List<Serie>()
        {
            new Serie{Id = 1,Titulo = "The Witcher", Descricao = "Série muito FODA" ,Duracao = 50, Generos=new List<Genero>(){Genero.Aventura,Genero.Ação,Genero.Fantasia},ClassificacaoIndicativa = ClassificacaoIndicativa.Adulto},
            new Serie{Id = 5,Titulo = "Rick And Morty", Descricao = "Série que contém varias referencias" ,Duracao = 20, Generos=new List<Genero>{Genero.Comedia,Genero.SciFi} ,ClassificacaoIndicativa = ClassificacaoIndicativa.Maiores16}
        };

        public static Serie FindById(int id){
            return series.Find(serie => serie.Id == id);
        }
        
        public static Serie FindByTitulo(string titulo){
            return series.Find(serie => serie.Titulo == titulo);
        }

        public static bool Contains(Serie s){
            if (FindById(s.Id) == null){
                return false;
            }
            return true;
        }

        public static int FindIndex(Serie s){
            return series.FindIndex(serie=> serie.Titulo == s.Titulo);
        }

        public static void Add(Serie s){
            series.Add(s);
        }

        public static List<Serie> All(){return series;}
    }
}
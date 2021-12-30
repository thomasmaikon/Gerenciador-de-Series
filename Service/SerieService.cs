using GerenciadorDeSeries.Model;
using GerenciadorDeSeries.db;
using System.Collections.Generic;
namespace GerenciadorDeSeries.Service{
    public class SerieService{
        public static bool InsertSerie(Serie s){

            if(Repository.FindById(s.Id) == null){
                Repository.Add(s);
                return true;
            }
            return false;
        }

        public static List<Serie> All(){return Repository.All();}

        public static bool Add(Serie s){
            if(Repository.Contains(s)){
                return false;
            }
            Repository.Add(s);
            return true;
        }

        public static bool Update(Serie s){
            var serie = Repository.FindById(s.Id);
            if(serie != null){
                Repository.All()[Repository.FindIndex(serie)] = s;
                return true;
            }
            return false;
        }

        public static bool Remove(string nome){
            var serie = Repository.FindByTitulo(nome);
            if( serie != null){
                Repository.All().Remove(serie);
                return true;
            }
            return false;
        }
    }
}
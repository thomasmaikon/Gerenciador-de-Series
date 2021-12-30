using Microsoft.AspNetCore.Mvc;
using GerenciadorDeSeries.Model;
using GerenciadorDeSeries.Service;
using System.Collections.Generic;

namespace GerenciadorDeSeries.Controllers{
    
    [ApiController]
    [Route("series")]
    public class SeriesController : ControllerBase{
        
        [HttpGet]
        public ActionResult<List<Serie>> GetListSeries(){
            return Ok(SerieService.All());
        }

        [HttpPost]
        public ActionResult<List<Serie>> AddSerie(Serie serie){
            if(SerieService.Add(serie))
                return Ok(SerieService.All());
            
            return StatusCode(409);
        }

        [HttpPut]
        public ActionResult UpdateSerie(Serie serie){
            SerieService.Update(serie);
            return Ok(SerieService.All());
        }
        
        [HttpDelete]
        public ActionResult RemoveSerie(string nome){
            if (SerieService.Remove(nome)){
                return Ok(SerieService.All());
            }
            return StatusCode(204);
        }


    }

}
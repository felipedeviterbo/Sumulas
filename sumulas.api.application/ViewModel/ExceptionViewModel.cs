using sumulas.api.domain.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace sumulas.api.application.ViewModel
{
    public class ExceptionViewModel
    {
        public LevelException Level { get; set; }
        public string Message { get; set; }

        public HttpStatusCode Code { get; set; }

        public ExceptionViewModel(LevelException _level, string _message, HttpStatusCode _code){
            this.Level = _level;
            this.Message = Message;
            this.Code = _code;
        }
        //public List<FasesCampeonato> Fases { get; set; }

        // public static CampeonatoModel From(Campeonatos item)
        // {
        //     return new CampeonatoModel {
        //         Id = item.Id,
        //         Name = item.Name,
        //         Year = item.Year,
        //         //Fases = item.Fases
        //     }; 
        // }
    }
}

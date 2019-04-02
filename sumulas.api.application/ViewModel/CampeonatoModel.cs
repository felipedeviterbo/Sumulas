using sumulas.api.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace sumulas.api.application.ViewModel
{
    public class CampeonatoModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        //public List<FasesCampeonato> Fases { get; set; }

        public static CampeonatoModel From(Campeonatos item)
        {
            return new CampeonatoModel {
                Id = item.Id,
                Name = item.Name,
                Year = item.Year,
                //Fases = item.Fases
            }; 
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace sumulas.api.domain.Entities
{
    public class Campeonatos: Entity
    {
        // public Campeonatos(){
        //     Fases = new List<FasesCampeonato>();
        // }
        public string Name { get; set; }
        public int Year { get; set; }
        public int FinalClassification { get; set; }
    }

    
}

using System.Xml.Serialization;

public enum FasesCampeonato {
        [XmlEnumAttribute("Classificatoria")]
        Classificatoria = 1,
        [XmlEnumAttribute("Fase de Grupos")]
        Grupos = 2,
        [XmlEnumAttribute("Oitavas de Final")]
        OitavasFinal = 3,
        [XmlEnumAttribute("Quartas de Final")]
        QuartasFinal = 4,
        [XmlEnumAttribute("Semi-Final")]
        SemiFinal = 5,
        [XmlEnumAttribute("Final")]
        Final = 6,
        [XmlEnumAttribute("Eliminatoria")]
        Eliminatoria = 7,
        [XmlEnumAttribute("Hexagonal")]
        Hexagonal = 8
        
    }

public enum FuncaoArbitro {
    //Para descricao usar Nameof
    Principal = 1,
    Auxiliar = 2,
    Assistente = 3,
    Mesario = 4,
}

public enum LevelException{
   // [XmlEnumAttribute("Hexagonal")]
    BusinessRule = 1,
    
    SystemRule = 2,
    
    InfraRule = 3,
    
    ValidationRule = 4
}
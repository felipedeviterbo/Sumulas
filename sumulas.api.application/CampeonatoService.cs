using sumulas.api.application.Interfaces;
using sumulas.api.application.Interfaces.Repositories;
using sumulas.api.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using sumulas.api.application.Validations;
using sumulas.api.domain.Exceptions;

namespace sumulas.api.application
{
    public class CampeonatoService: ICampeonatosService
    {
       private readonly ICampeonatoRepository _campeonatoRepository;

        public CampeonatoService(ICampeonatoRepository campeonatoRepository)
        {
            _campeonatoRepository = campeonatoRepository;
        }

        public IEnumerable<CampeonatoModel> Get()
        {
            var champs = _campeonatoRepository.Get();
            return champs.Select(s => CampeonatoModel.From(s));
        }

        public CampeonatoModel Insert(CampeonatoModel campeonato)
        {
            var validacao = new CampeonatoValidation().Validate(campeonato);
            string mensagemErro = string.Empty;
            string separador = string.Empty;
            if (!validacao.IsValid)
            {
                foreach (var erro in validacao.Errors){
                    mensagemErro += $"{separador}{erro.ErrorCode} - {erro.ErrorMessage}";
                    separador = " => "; 
                }
                //validacao.Errors.Select(a => $"{a.ErrorCode} >> {a.ErrorMessage}");
                throw new BusinessRuleViolatedException($"Campeonato com informações inválidas: {mensagemErro} ");
            }
            return campeonato;
        }

        public CampeonatoModel Update(CampeonatoModel campeonato) { throw new NotImplementedException();}
        public bool Delete(CampeonatoModel campeonato) { throw new NotImplementedException();}
    }
}

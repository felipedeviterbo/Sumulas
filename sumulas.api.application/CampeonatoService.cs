using sumulas.api.application.Interfaces;
using sumulas.api.application.Interfaces.Repositories;
using sumulas.api.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using sumulas.api.application.Validations;
using sumulas.api.domain.Exceptions;
using sumulas.api.domain.Entities;
using System.Threading.Tasks;

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
            return champs.Result.Select(s => CampeonatoModel.From(s));
        }

        public async Task<CampeonatoModel> Insert(CampeonatoModel model)
        {
            if (string.IsNullOrEmpty(model.Id))
            {
                model.Id = Guid.NewGuid().ToString();
            } else
            {
                var campeonato = _campeonatoRepository.GetById(model.Id);
                if (campeonato.Result != null && campeonato.Result.Id.Equals(model.Id))
                    throw new BusinessRuleViolatedException($"Já existe um campeonato com o Id informado.");
            }
            var validacao = new CampeonatoValidation().Validate(model);
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
            // verifica já existe campeonato
            var validExist = _campeonatoRepository.GetByModel(model.Name, model.Year);
            if (validExist.Result != null && !string.IsNullOrEmpty(validExist.Result.Id)) ;
            // insere campeonato
            var newCampeonato = new Campeonatos {
                Id = model.Id,
                Name = model.Name,
                Year = model.Year
            };
            //newCampeonato.FinalClassification = campeonato
            await _campeonatoRepository.Insert(newCampeonato);
            return model;
        }

        public Task<CampeonatoModel> Update(CampeonatoModel campeonato) { throw new NotImplementedException();}
        public Task<bool> Delete(CampeonatoModel campeonato) { throw new NotImplementedException();}
    }
}

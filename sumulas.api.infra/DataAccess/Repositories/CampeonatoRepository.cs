using sumulas.api.domain.Entities.Basicos;
using sumulas.api.application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Text;
using System.Linq;

namespace sumulas.api.infra.DataAccess.Repositories
{
    public class CampeonatoRepository: ICampeonatoRepository
    {
        private readonly MongoContext _context;
        public CampeonatoRepository(MongoContext context)
        {
            _context = context;
        }

        public IEnumerable<Campeonatos> Get()
        {
            var filter = Builders<Campeonatos>.Filter.Empty;
            var results = _context.Campeonatos.Find(filter);
            return results.ToList().OrderBy(c => c.Year);
        }

        Campeonatos ICrudRepository<Campeonatos>.GetById(string Id)
        {
            var campeonatos = _context.Campeonatos.Find<Campeonatos>(c => c.Id.Equals(Id));
            var result = campeonatos.FirstOrDefault();
            return result;
        }

        Campeonatos ICrudRepository<Campeonatos>.Insert(Campeonatos item)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Campeonatos> ICampeonatoRepository.ListByPeriod(int YearIni, int YearEnd)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Campeonatos> ICampeonatoRepository.ListByYear(int Year)
        {
            throw new NotImplementedException();
        }

        bool ICrudRepository<Campeonatos>.Update(Campeonatos item)
        {
            throw new NotImplementedException();
        }
    }
}

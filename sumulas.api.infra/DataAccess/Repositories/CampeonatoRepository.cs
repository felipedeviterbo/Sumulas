using sumulas.api.domain.Entities;
using sumulas.api.application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace sumulas.api.infra.DataAccess.Repositories
{
    public class CampeonatoRepository: ICampeonatoRepository
    {
        private readonly MongoContext _context;
        public CampeonatoRepository(MongoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Campeonatos>> Get()
        {
            var filter = Builders<Campeonatos>.Filter.Empty;
            //var qtd = _context.Campeonatos.Count(filter);
            var results = await _context.Campeonatos.FindAsync(filter);
            return results.ToList().OrderBy(c => c.Year);
        }

        async Task<Campeonatos> ICrudRepository<Campeonatos>.GetById(string Id)
        {
            //var filter = Builders<Campeonatos>.Filter.Empty;
            var campeonatos = await _context.Campeonatos.FindAsync(c => c.Id == Id);
            var result = campeonatos.FirstOrDefault();
            return result;
        }

        async Task<Campeonatos> ICampeonatoRepository.GetByModel(string Nome, int year)
        {
            var result = await _context.Campeonatos.FindAsync(c => c.Name.ToUpperInvariant().Equals(Nome.ToUpperInvariant()) && c.Year == year);
            return result.FirstOrDefault();
        }

        async Task<Campeonatos> ICrudRepository<Campeonatos>.Insert(Campeonatos item)
        {
            await _context.Campeonatos.InsertOneAsync(item);
            return item;
        }

        IEnumerable<Campeonatos> ICampeonatoRepository.ListByPeriod(int YearIni, int YearEnd)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Campeonatos> ICampeonatoRepository.ListByYear(int Year)
        {
            throw new NotImplementedException();
        }

        async Task<bool> ICrudRepository<Campeonatos>.Update(Campeonatos item)
        {
            throw new NotImplementedException();
        }
    }
}
//////////////////////
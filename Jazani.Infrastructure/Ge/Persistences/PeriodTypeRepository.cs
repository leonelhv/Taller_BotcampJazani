﻿using Jazani.Domain.Ge.Models;
using Jazani.Domain.Ge.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Jazani.Infrastructure.Cores.Persistenses;

namespace Jazani.Infrastructure.Ge.Persistences
{
    public class PeriodTypeRepository : CrudRepository<PeriodType, int>, IPeriodTypeRepository
    {
        public PeriodTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

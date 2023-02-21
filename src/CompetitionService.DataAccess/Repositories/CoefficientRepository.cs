﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetitionService.BusinessLogic.Contracts.DataAccess.Repositories;
using CompetitionService.BusinessLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace CompetitionService.DataAccess.Repositories
{
    public class CoefficientRepository : ICoefficientRepository
    {
        private readonly DbSet<Coefficient> _entities;

        public CoefficientRepository(DbSet<Coefficient> entities)
        {
            _entities = entities;
        }

        public Task Create(Coefficient coefficient, CancellationToken token)
        {
            _entities.Add(coefficient);

            return Task.CompletedTask;
        }

        public Task Update(Coefficient coefficient, CancellationToken token)
        {
            _entities.Update(coefficient);

            return Task.CompletedTask;
        }
    }
}

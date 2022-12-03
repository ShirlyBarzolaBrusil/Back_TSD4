﻿using Qhatu.Domain.Models;
using Qhatu.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qhatu.Infrastructure.Repository.Repository
{
    public class VendedorRepository:GenericRepository<Vendedor>,IVendedorRepository
    {
        public VendedorRepository(IDbTransaction transaction):base(transaction)
        {

        }
    }
}

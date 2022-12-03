﻿using Qhatu.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qhatu.Infrastructure.Repository.IRepository
{
    public interface IFacturaRepository:IGenericRepository<Factura>
    {
        public IEnumerable<Factura> GetFacturasById(int usuarioId);
    }
}

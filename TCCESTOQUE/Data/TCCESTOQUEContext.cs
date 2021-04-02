﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TCCESTOQUE.Models;

namespace TCCESTOQUE.Data
{
    public class TCCESTOQUEContext : DbContext
    {
        public TCCESTOQUEContext (DbContextOptions<TCCESTOQUEContext> options)
            : base(options)
        {
        }

        public DbSet<TCCESTOQUE.Models.VendedorModel> VendedorModel { get; set; }
    }
}

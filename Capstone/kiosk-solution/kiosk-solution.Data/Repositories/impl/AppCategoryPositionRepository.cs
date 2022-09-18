﻿using kiosk_solution.Data.Context;
using kiosk_solution.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk_solution.Data.Repositories.impl
{
    public class AppCategoryPositionRepository : BaseRepository<AppCategoryPosition> , IAppCategoryPositionRepository
    {
        public AppCategoryPositionRepository(Kiosk_PlatformContext dbContext) : base(dbContext)
        {
        }
    }
}

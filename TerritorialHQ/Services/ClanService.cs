﻿using TerritorialHQ.Services.Base;

namespace TerritorialHQ.Services
{
    public class ClanService : ApisDtoService
    {
        public ClanService(IHttpContextAccessor contextAccessor, IConfiguration configuration) : base(contextAccessor, configuration)
        {
        }
    }
}

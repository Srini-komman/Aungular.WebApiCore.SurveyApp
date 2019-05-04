﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Angular.WebApiCore.SurveyApp.DataAccess
{
    public interface IDbInitialiser
    {
        void Seed();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Data.Database.Executor
{
    public interface IDatabaseExecutorFactory
    {
        IDatabaseExecutor CreateExecutor();
    }
}

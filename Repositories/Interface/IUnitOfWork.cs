﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interface
{
    public interface IUnitOfWork
    {
        int SaveChange();

        void Commit();
    }
}

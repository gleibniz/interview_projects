﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repository.Interfaces
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
        void Release(IUnitOfWork component);
    }
}

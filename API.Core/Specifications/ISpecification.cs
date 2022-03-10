﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace API.Core.Specifications
{
    public interface ISpecification<T> 
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T,Object>>> Includes { get; }
    }


}

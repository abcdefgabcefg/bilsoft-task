﻿using DAL.Entities;
using System.Collections.Generic;

namespace BAL.ProductServices
{
    public interface IProductService
    {
        public List<Product> Get(int skipCount, int takeCount);
    }
}
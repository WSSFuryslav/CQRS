﻿using System;
using CQRS.Domain.SeedWork;
using CQRS.Domain.SeedWork.Exceptions;

namespace CQRS.Domain.Products
{
    public class Product
    {
        private Product(string name, double cost)
        {
            ID = Guid.NewGuid();
            Name = name;
            Cost = cost;
        }

        public Guid ID { get; }
        public string Name { get; }
        public double Cost { get; }

        public static Product Create(string name, double cost, IProductUniquenessChecker uniquenessChecker)
        {
            var result = new Product(name, cost);
            return result;
        }
    }
}

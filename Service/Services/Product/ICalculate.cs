using Entites.Product;
using System;
namespace Service
{
    public interface ITaxCalculator
    {
        int GetTaxAmount(Product product);
    }
}

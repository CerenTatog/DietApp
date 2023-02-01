using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL;
using Diet.DAL.Entities;

namespace Diet.BLL.Controllers
{
    public class ActiviyController : IController
    {
        public void AddEntity()
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity()
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity()
        {
            throw new NotImplementedException();
        }
    }

    //public bool AddProduct(string productName, int? supplierID, int? categoryID,
    //  string quantityPerUnit, decimal? unitPrice, short? unitsInStock,
    //  short? unitsOnOrder, short? reorderLevel, bool discontinued)
    //{
    //    // Create a new ProductRow instance
    //    Northwind.ProductsDataTable products = new Northwind.ProductsDataTable();
    //    Northwind.ProductsRow product = products.NewProductsRow();

    //    product.ProductName = productName;
    //    if (supplierID == null) product.SetSupplierIDNull();
    //    else product.SupplierID = supplierID.Value;
    //    if (categoryID == null) product.SetCategoryIDNull();
    //    else product.CategoryID = categoryID.Value;
    //    if (quantityPerUnit == null) product.SetQuantityPerUnitNull();
    //    else product.QuantityPerUnit = quantityPerUnit;
    //    if (unitPrice == null) product.SetUnitPriceNull();
    //    else product.UnitPrice = unitPrice.Value;
    //    if (unitsInStock == null) product.SetUnitsInStockNull();
    //    else product.UnitsInStock = unitsInStock.Value;
    //    if (unitsOnOrder == null) product.SetUnitsOnOrderNull();
    //    else product.UnitsOnOrder = unitsOnOrder.Value;
    //    if (reorderLevel == null) product.SetReorderLevelNull();
    //    else product.ReorderLevel = reorderLevel.Value;
    //    product.Discontinued = discontinued;

    //    // Add the new product
    //    products.AddProductsRow(product);
    //    int rowsAffected = Adapter.Update(products);

    //    // Return true if precisely one row was inserted,
    //    // otherwise false
    //    return rowsAffected == 1;
    //}
}

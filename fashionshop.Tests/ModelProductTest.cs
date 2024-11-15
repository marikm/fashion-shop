

using fashionshop.Model.Product;
using fashionshop.Repository;
using fashionshop.Database;
using System.Collections;


namespace fashionshop.Tests
{
    public class ModelProductTest
    {
        [Fact]
        public void testingProductExceptions()
        {
            Exception eBarcode = Assert.Throws<Exception>(() => new Product("", "calça", "casual", "sawary", 100.00m));
            Assert.Equal("BarCode is null or empty.", eBarcode.Message);

            Exception eDescription = Assert.Throws<Exception>(() => new Product("123123", "", "casual", "sawary", 100.00m));
            Assert.Equal("Description is null or empty", eDescription.Message);

            Exception eCategory = Assert.Throws<Exception>(() => new Product("123123", "calça", "", "sawary", 100.00m));
            Assert.Equal("Category is null or empty", eCategory.Message);

            Exception eBrand = Assert.Throws<Exception>(() => new Product("123123", "calça", "casual", "", 100.00m));
            Assert.Equal("Brand is null or empty", eBrand.Message);

            Exception ePrice = Assert.Throws<Exception>(() => new Product("123123", "calça", "casual", "sawary", -1.0m));
            Assert.Equal("Price value invalid: zero or negative", ePrice.Message);

        }

     
}
}
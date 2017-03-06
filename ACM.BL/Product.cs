using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }

        private string _productName;

        public string ProductName
        {
            get {
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }
        

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = !string.IsNullOrWhiteSpace(ProductName);

            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = ProductId + ": " +
                            ProductName + " " +
                            "Detail: " + ProductDescription + " " +
                            "Status: " + EntityState;
            return logString;
        }
    }
}

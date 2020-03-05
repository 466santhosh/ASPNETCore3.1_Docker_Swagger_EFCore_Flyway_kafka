namespace api_mega_sena.Entities
{
    public class Product
    {
        /// <summary>  
        /// Gets or sets the identifier.  
        /// </summary>  
        /// <value>The identifier.</value>  
        public int Id
        {
            get;
            set;
        }

        /// <summary>  
        /// Gets or sets the name.  
        /// </summary>  
        /// <value>The name.</value>  
        public string Name
        {
            get;
            set;
        }

        /// <summary>  
        /// Gets or sets the price.  
        /// </summary>  
        /// <value>The price.</value>  
        public double Price
        {
            get;
            set;
        }

        /// <summary>  
        /// Gets or sets the description.  
        /// </summary>  
        /// <value>The description.</value>  
        public string Description
        {
            get;
            set;
        }
    }
}

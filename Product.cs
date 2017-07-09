using System; namespace VendingMachineTechTest {
	public class Product
	{
		public string name;
		public double price;

		public Product(string productName, double productPrice)
		{
			name = productName;
			price = productPrice;
		}

		public string Name
		{
			get
			{
				return name;
			}
		}

		public double Price
		{
			get
			{
				return price;
			}
		}

	} } 
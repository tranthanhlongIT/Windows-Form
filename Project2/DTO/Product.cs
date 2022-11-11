using System.ComponentModel.DataAnnotations;
using Project2.Ultils;

namespace Project2.DTO
{
    public class Product : ObjectValidator
    {
		public int id { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[StringLength(50, ErrorMessage = "Name cannot exceed 250 characters")]
		public string name { get; set; }

		public string description { get; set; }

		[Required(ErrorMessage = "Price is required")]
		[Range(0, 999999)]
		public double price { get; set; }
		[Range(0, 999999)]
		public double discount { get; set; }

		[Required(ErrorMessage = "Quantity is required")]
		[Range(0, 999999)]
		public int quantity { get; set; }

		public bool available { get; set; }

		public System.Data.Linq.Binary image { get; set; }

		public System.Nullable<System.DateTime> created_at { get; set; }

		public System.Nullable<System.DateTime> updated_at { get; set; }

		[Required(ErrorMessage = "Type is required")]
		public int type_id { get; set; }

		[Required(ErrorMessage = "Brand is required")]
		public int brand_id { get; set; }
	}
}

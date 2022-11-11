using System.ComponentModel.DataAnnotations;
using Project2.Ultils;

namespace Project2.DTO
{
    public class Customer : ObjectValidator
    {
        int id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        string fname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        string lname { get; set; }

        System.Nullable<bool> gender { get; set; }

        string address { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        string phone { get; set; }

        string zipcode { get; set; }

        System.Nullable<bool> is_active { get; set; }

        System.Nullable<System.DateTime> created_at { get; set; }

        System.Nullable<System.DateTime> updated_at { get; set; }

        System.Nullable<int> city_id { get; set; }
    }
}

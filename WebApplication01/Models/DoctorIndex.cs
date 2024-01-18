namespace WebApplication01.Models
{
    public class DoctorIndex
    {
        public string SearchKey { get; set; }

        public ICollection<DoctorListItem> DoctorList { get; set; } 
    }


    //public string SearchKey { get; set; }

    //public ICollection<ProductListItem> ProductList { get; set; }
}

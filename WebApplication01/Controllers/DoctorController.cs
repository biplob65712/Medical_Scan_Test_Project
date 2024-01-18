using MedicalScan.DATABASE;
using MedicalScan.MODELS.EntityModels;
using MedicalScan.MODELS.UtilitiesModels;
using Microsoft.AspNetCore.Mvc;
using WebApplication01.Models;

namespace WebApplication01.Controllers
{
    public class DoctorController : Controller
    {
        ApplicationDbContext db;

        public DoctorController()
        {
            db = new ApplicationDbContext();
        }

        public IActionResult Index(DoctorIndex model)
        {
            ICollection<Doctor> doctors = new List<Doctor>();  

            if (model.SearchKey != null)
            {
                var doctorSearchCriteria = new DoctorSearchCriteria() 
                {
                    SearchKey = model.SearchKey
                };

                doctors = SearchDoctor(doctorSearchCriteria);
            }
            else
            {
                doctors = GetAll();
            }

            model.DoctorList = doctors.Select(c => new DoctorListItem()
            {
                ID = c.ID,
                Name = c.Name,
                Description = c.Description
            }
            ).ToList();

            return View(model);
        }

       
            
        




        public Doctor GetById(int id)
        {
            var existingDoctor = db.DoctorTB.FirstOrDefault(c => c.ID == id);

            return existingDoctor;
        }

        public ICollection<Doctor> SearchDoctor(DoctorSearchCriteria searchCriteria)
        {
            var searchKey = searchCriteria.SearchKey;

            var doctors = db.DoctorTB.AsQueryable();                                                           //

            if (!string.IsNullOrEmpty(searchKey))
            {
                doctors = doctors.Where(c => c.Name.ToLower().Contains(searchKey.ToLower())
                || c.Description.ToLower().Contains(searchKey.ToLower())
                );
            }

            return doctors.ToList();

        }

        public ICollection<Doctor> GetAll()
        {
            return db.DoctorTB.ToList();
        }
    }
}

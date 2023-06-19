using System.Reflection;

namespace Patient.Data
{
    public static class PatientMockDataService
    {
        public static List<Models.Patient> Patients = new List<Models.Patient>()
        {
            new Models.Patient { Id = 1, Name = "Sandali", Gender = "Female", Address = "452/Main St Ratnapura", Age = 22, PhoneNumber = 772568945 },
            new Models.Patient { Id = 2, Name = "Kasun", Gender = "Male", Address = "Lotus Road/ Matara", Age = 25, PhoneNumber = 762357413 },
            new Models.Patient { Id = 3, Name = "Shan", Gender = "Male", Address = "New St Kegalle", Age = 19, PhoneNumber = 712014583 },
            new Models.Patient { Id = 4, Name = "Amali", Gender = "Female", Address = "Middle Lane Colombo", Age = 24, PhoneNumber = 772351426 },
            new Models.Patient { Id = 5, Name = "Kamal",  Gender = "Male", Address = "Main St Negambo", Age = 28, PhoneNumber = 782103625 },
        };

    }
}

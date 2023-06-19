namespace Doctor.Data
{
    public static class DoctorMockDataService
    {
        public static List<Models.Doctor> Doctors = new List<Models.Doctor>()
        {
            new Models.Doctor { Id = 1, Name = "Fernando", Specialization = "Dermatologist", WardNumber = 05, PhoneNumber = 765214789 },
            new Models.Doctor { Id = 2, Name = "De Silva", Specialization = "Orthopedist", WardNumber = 01, PhoneNumber = 713365214 },
            new Models.Doctor { Id = 3, Name = "Perera", Specialization = "Cardiologist", WardNumber = 03, PhoneNumber = 770012548 },
            new Models.Doctor { Id = 4, Name = "Samantha", Specialization = "Endocrinologist", WardNumber = 08, PhoneNumber = 782599850 },
            new Models.Doctor { Id = 5, Name = "Anula", Specialization = "Dentist", WardNumber = 06, PhoneNumber = 712114537 },
        };

    }
}


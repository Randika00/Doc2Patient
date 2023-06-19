using Doctor.Data;
using Doctor.Models;

namespace Doctor.Services
{
    public class DoctorService : IDoctorService
    {
        public List<Models.Doctor> GetDoctors()
        {
            return DoctorMockDataService.Doctors;
        }

        public Models.Doctor? GetDoctor(int id)
        {
            return DoctorMockDataService.Doctors.FirstOrDefault(x => x.Id == id);
        }

        public Models.Doctor? AddDoctor(Models.Doctor doctor)
        {
            DoctorMockDataService.Doctors.Add(doctor);
            return doctor;
        }

        public Models.Doctor? UpdateDoctor(Models.Doctor doctor)
        {
            Models.Doctor selectedDoctor = DoctorMockDataService.Doctors.FirstOrDefault(x => x.Id == doctor.Id);
            if (selectedDoctor != null)
            {
                selectedDoctor.WardNumber = doctor.WardNumber;
                selectedDoctor.Specialization = doctor.Specialization;
                selectedDoctor.Name = doctor.Name;
                selectedDoctor.PhoneNumber = doctor.PhoneNumber;

                return selectedDoctor;
            }

            return selectedDoctor;
        }

        public bool? DeleteDoctor(int id)
        {
            Models.Doctor selectedDoctor = DoctorMockDataService.Doctors.FirstOrDefault(x => x.Id == id);
            if (selectedDoctor != null)
            {
                DoctorMockDataService.Doctors.Remove(selectedDoctor);
                return true;
            }
            return false;
        }
    }
}

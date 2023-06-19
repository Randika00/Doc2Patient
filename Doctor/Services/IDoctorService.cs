namespace Doctor.Services
{
    public interface IDoctorService
    {
    List<Models.Doctor> GetDoctors();
    Models.Doctor? GetDoctor(int id);
    Models.Doctor? AddDoctor(Models.Doctor Doctor);
    Models.Doctor? UpdateDoctor(Models.Doctor Doctor);
    bool? DeleteDoctor(int id);
    }
}
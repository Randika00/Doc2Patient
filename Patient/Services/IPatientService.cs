namespace Patient.Services
{
    public interface IPatientService
    {
        List<Models.Patient> GetPatients();
        Models.Patient? GetPatient(int id);
        Models.Patient? AddPatient(Models.Patient Patient);
        Models.Patient? UpdatePatient(Models.Patient Patient);
        bool? DeletePatient(int id);

    }
}


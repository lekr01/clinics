using clinics.Entities;

namespace clinics.Interfaces
{
    public interface IClinicRepository
    {
        public Task<IEnumerable<Clinic>> GetClinics();
    }
}

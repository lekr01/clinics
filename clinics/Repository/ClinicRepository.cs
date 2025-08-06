using clinics.context;
using clinics.Entities;
using clinics.Interfaces;
using Dapper;
using System.Net.WebSockets;

namespace clinics.Repository
{
    public class ClinicRepository : IClinicRepository
    {
        private readonly DapperContext _context;

        public ClinicRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Clinic>> GetClinics()
        {
            var query = "SELECT * FROM clinics";

            using (var connection = _context.CreateConnection())
            {
                var clinics = await connection.QueryAsync<Clinic>(query);
                return clinics.ToList();
            }
        }
    }
}

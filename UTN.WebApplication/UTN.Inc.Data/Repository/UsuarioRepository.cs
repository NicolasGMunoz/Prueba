using UTN.Inc.Entities;
using System.Data;
using System.Data.SqlClient;
using UTN.Inc.Data.DBContext;

namespace UTN.Inc.Data.Repository
{
    public class UsuarioRepository
    {
        private readonly UtnincContext _userRepo;


        public UsuarioRepository(UtnincContext context)
        {
            _userRepo = context;
        }

        public List<Usuario> GetAll()
        {
            return _userRepo.Usuarios.ToList();
        }

        public Usuario GetUser(string username)
        {
            return _userRepo.Usuarios.SingleOrDefault(u => u.Nombre == username);
        }
    }
}

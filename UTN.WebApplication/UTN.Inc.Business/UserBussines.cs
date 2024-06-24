using UTN.Inc.Entities;
using UTN.Inc.Data.Repository;

namespace UTN.Inc.Business
{
    public class UserBussines
    {
        private readonly UsuarioRepository _usuarioRepo;

        public UserBussines(UsuarioRepository context)
        {
            _usuarioRepo = context;
        }

        public List<Usuario> ObtenerUsuario()
        {
          return _usuarioRepo.GetAll();
        }
    }
}

using UTN.Inc.Entities;
using UTN.Inc.Data;
using UTN.Inc.Data.Repository;

namespace UTN.Inc.Business
{
    public class UserBussines
    {
        private UsuarioRepository objCapaDato = new UsuarioRepository();

        public List<Usuario> GetUsuarios()
        {
            return objCapaDato.GetAll();
        }
    }
}

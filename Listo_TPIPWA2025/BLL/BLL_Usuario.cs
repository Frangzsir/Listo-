using Listo_TPIPWA2025.Models;
namespace Listo_TPIPWA2025.BLL
{
    public class BLL_Usuario
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public BLL_Usuario() { }

        public void AgregarUsuario(Usuario pU)
        {
            if (usuarios.Find(x => x.Id == pU.Id) == null)
            {
                usuarios.Add(pU);
            }
        }


        public Usuario? RetornaUsuario(string email, string pwd)
        {
            return usuarios.Find(u => u.Email == email && u.Password == pwd);
        }

        public bool ValidarEmail(string email)
        {
            bool resultado = false;
            if(usuarios.Find(x=>x.Email==email)!=null)
            {
                resultado = true;
            }
            return resultado;
        }

        public bool ValidarPwd(string pwd)
        {
            bool resultado = false;
            if(usuarios.Find(x => x.Password == pwd) != null)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}

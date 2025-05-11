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
    }
}

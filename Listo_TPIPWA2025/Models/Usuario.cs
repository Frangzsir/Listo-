namespace Listo_TPIPWA2025.Models
{
    public class Usuario
    {
        public Usuario() { }

        public Usuario(Usuario pUsuario)
        {
            Id = pUsuario.Id;
            Nombre = pUsuario.Nombre;
            Apellido = pUsuario.Apellido;
            Email = pUsuario.Email;
        }

        public Usuario(int pId, string pNom, string pA, string pE, string pwd) { Id = pId; Nombre = pNom; Apellido = pA; Email = pE; Password = pwd; }
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}

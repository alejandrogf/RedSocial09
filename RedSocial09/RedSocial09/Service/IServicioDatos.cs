using System;
using System.Threading.Tasks;
using RedSocial09.Model;

namespace RedSocial09.Service
{
    public interface IServicioDatos
    {
        #region Usuario
        //En tareas asyncronas siempre devuelven un objeto TASK. Si no se indica un tipo, devuelve un void.
        //Devuelven un TASK y un RESULT, el task puede ser de un tipo concreto o vacio (void)
        Task<Usuario> Validar(Usuario usuario);
        Task<Usuario> AddUsuario(Usuario usuario);
        Task<Usuario> UpdateUsuario(Usuario usuario, String id);
        Task DeleteUsuario(String id);

        #endregion

        #region Mensaje

        Task<Mensaje> EnviarMensjar(Mensaje mensaje, String idUsuario);

        #endregion


    }
}
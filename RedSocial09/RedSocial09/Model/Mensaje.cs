using System;

namespace RedSocial09.Model
{
    public class Mensaje
    {
        public String Id { get; set; }
        public String IdUsuario { get; set; }
        public Boolean EoR { get; set; }//Enviado (true) Recibido (false)
        public String IdUsReceptor { get; set; }
        public DateTime FechaHora { get; set; }
        public String Texto { get; set; }
    }
}

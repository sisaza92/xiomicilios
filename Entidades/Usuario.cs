using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        private long idUsuario;
        [DataMember]
        private string nombreUsuario;
        [DataMember]
        private string apellido;
        [DataMember]
        private string usuario;
        [DataMember]
        private string ciudad;
        [DataMember]
        private string correo;
        [DataMember]
        private string contrasena;
        [DataMember]
        private string direccion;
        [DataMember]
        private bool activoUsuario;
        [DataMember]
        private string telefono;
        [DataMember]
        private DateTime fechaUsuario;

        public long IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool ActivoUsuario { get => activoUsuario; set => activoUsuario = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaUsuario { get => fechaUsuario; set => fechaUsuario = value; }

        public Cliente()
        {


        }

        public Cliente(long idUsurio, string nombreUsuario, string apellido, string usuario, string ciudad, string correo, string contrasena, string direccion, bool activoUsuario, string telefono, DateTime fechaUsuario)
        {
            IdUsuario = idUsurio;
            NombreUsuario = nombreUsuario;
            Apellido = apellido;
            Usuario = usuario;
            Ciudad = ciudad;
            Correo = correo;
            Contrasena = contrasena;
            Direccion = direccion;
            ActivoUsuario = activoUsuario;
            Telefono = telefono;
            FechaUsuario = fechaUsuario;
        }


    }
}

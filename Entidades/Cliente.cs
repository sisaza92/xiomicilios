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
        private long idCliente;
        [DataMember]
        private string nombreCliente;
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
        private bool activoCliente;
        [DataMember]
        private string telefono;
        [DataMember]
        private DateTime fechaCliente;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool ActivoCliente { get => activoCliente; set => activoCliente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaCliente { get => fechaCliente; set => fechaCliente = value; }

        public Cliente()
        {


        }

        public Cliente(long idUsurio, string nombreCliente, string apellido, string usuario, string ciudad, string correo, string contrasena, string direccion, bool activoCliente, string telefono, DateTime fechaCliente)
        {
            IdCliente = idUsurio;
            NombreCliente = nombreCliente;
            Apellido = apellido;
            Usuario = usuario;
            Ciudad = ciudad;
            Correo = correo;
            Contrasena = contrasena;
            Direccion = direccion;
            ActivoCliente = activoCliente;
            Telefono = telefono;
            FechaCliente = fechaCliente;
        }


    }
}

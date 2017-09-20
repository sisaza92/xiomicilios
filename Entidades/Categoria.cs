using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    [DataContract]
    public class Categoria
    {
        [DataMember]
        private long idCategoria;
        [DataMember]
        private string nombreCategoria;
        [DataMember]
        private byte[] imagenCategoria;
        [DataMember]
        private DateTime fechaCategoria;
        [DataMember]
        private bool activoCategoria;

        public Categoria()
        {
            
        }

        public Categoria(long idCategoria, string nombreCategoria, byte[] imagenCategoria, DateTime fechaCategoria, bool activoCategoria)
        {
            this.IdCategoria = idCategoria;
            this.NombreCategoria = nombreCategoria;
            this.ImagenCategoria = imagenCategoria;
            this.FechaCategoria = fechaCategoria;
            this.ActivoCategoria = activoCategoria;
        }

        public long IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public byte[] ImagenCategoria { get => imagenCategoria; set => imagenCategoria = value; }
        public DateTime FechaCategoria { get => fechaCategoria; set => fechaCategoria = value; }
        public bool ActivoCategoria { get => activoCategoria; set => activoCategoria = value; }
    }    
}
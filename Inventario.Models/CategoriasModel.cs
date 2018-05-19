using System.Runtime.Serialization;

namespace Inventario.Models
{
    [DataContract]
    public class CategoriasModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreCategoria { get; set; }
    }
}

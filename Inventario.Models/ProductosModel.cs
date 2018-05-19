using System.Runtime.Serialization;


namespace Inventario.Models
{
    [DataContract]    
    public class ProductosModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdCategoria { get; set; }
        [DataMember]
        string NombreValue;        
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public decimal Costo { get; set; }
        
        string descripcionValue;

        public string Nombre
        {
            get { return NombreValue; }
            set { NombreValue = value; }
        }

        public string DescripcionValue
        {
            get { return descripcionValue; }
            set { descripcionValue = value; }
        }
    }
}

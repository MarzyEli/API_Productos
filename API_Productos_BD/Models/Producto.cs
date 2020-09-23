namespace Entities
{
    public class Producto
    {
        public long IdProducto { get; set; }
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public string Imagen { get; set; }
        public long IdProveedor { get; set; }
        public long IdCategoria { get; set; }
        public long IdMarca { get; set; }
        public long IdUnidadMedida { get; set; }
        public bool Activo { get; set; }
    }


    public class ProductoCustom
    {
        public long IdProducto { get; set; }
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public string Imagen { get; set; }
        public long IdProveedor { get; set; }
        public string Proveedor { get; set; }
        public long IdCategoria { get; set; }
        public string Categoria { get; set; }
        public long IdMarca { get; set; }
        public string Marca { get; set; }
        public long IdUnidadMedida { get; set; }
        public string UnidadMedida { get; set; }
        public bool Activo { get; set; }
    }
}

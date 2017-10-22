using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.AccesoDatosBodega.Modelos;
using System.Data.Entity;

namespace Repositorio.AccesoDatosBodega.Contextos
{
    /// <summary>
    /// DbContext y remover pluralizacion de tablas
    /// </summary>
    public class BodegaContextos:DbContext
    {
        public BodegaContextos() : base("BodegaDB") { }

        public DbSet<Proveedor_> Proveedor { get; set; }
        public DbSet<OrdenDeCompra_> OrdenDeCompra { get; set; }
        public DbSet<Documento_> Documento { get; set; }
        public DbSet<DocumentoDeCompra_> DocumentoDeCompra { get; set; }
        public DbSet<Categoria_> Categoria { get; set; }
        public DbSet<Producto_> Producto { get; set; }
        public DbSet<DetalleDeProducto_> DetalleDeProducto { get; set; }
        public DbSet<DetalleDeCompra_> DetalleDeCompra { get; set; }
        public DbSet<Kardex_> Kardex { get; set; }
        public DbSet<Cliente_> Cliente { get; set; }
        public DbSet<BoletaElectronica_> BoletaElectronica { get; set; }
        public DbSet<OrdenDeVenta_> OrdenDeVenta { get; set; }
        public DbSet<DetalleDeVenta_> DetalleDeVenta { get; set; }
        public DbSet<BoletaDeVenta_> BoletaDeVenta { get; set; }
        public DbSet<Concepto_> Concepto { get; set; }
        public DbSet<Caja_> Caja { get; set; }
        public DbSet<Igv_> Igv { get; set; }
        public DbSet<Usuario_> Usuario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NProveedor
    {
        // Metodo insertar que llama al metodo Insertar de la clase DProveedor de la CapaDatos
        public static string Insertar(string razon_social, string sector_comercial, string tipo_documento, string numero_documento, string direccion, string telefono, string email, string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Razon_social = razon_social;
            Obj.Sector_comercial = sector_comercial;
            Obj.Tipo_documento = tipo_documento;
            Obj.Numero_documento = numero_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Insertar(Obj);
        }
        // Metodo editar que llama al metodo Editar de la clase DProveedor de la CapaDatos
        public static string Editar(int idproveedor, string razon_social, string sector_comercial, string tipo_documento, string numero_documento, string direccion, string telefono, string email, string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            Obj.Razon_social = razon_social;
            Obj.Sector_comercial = sector_comercial;
            Obj.Tipo_documento = tipo_documento;
            Obj.Numero_documento = numero_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Editar(Obj);
        }
        // Metodo eliminar que llama al metodo Eliminar de la clase DProveedor de la CapaDatos
        public static string Eliminar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            return Obj.Eliminar(Obj);
        }
        // Metodo mostrar que llama al metodo Mostrar de la clase DProveedor de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }
        // Metodo BuscarRazonSocial que llama al metodo BuscarRazonSocial de la clase DProveedor de la CapaDatos
        public static DataTable BuscarRazonSocial(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarRazonSocial(Obj);
        }
        // Metodo BuscarSectorComercial que llama al metodo BuscarSectorComercial de la clase DProveedor de la CapaDatos
        public static DataTable BuscarSectorComercial(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarSectorComercial(Obj);
        }
        // Metodo BuscarTipoDocumento que llama al metodo BuscarTipoDocumento de la clase DProveedor de la CapaDatos
        public static DataTable BuscarTipoDocumento(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarTipoDocumento(Obj);
        }
        // Metodo BuscarNumeroDocumento que llama al metodo BuscarNumeroDocumento de la clase DProveedor de la CapaDatos
        public static DataTable BuscarNumeroDocumento(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNumeroDocumento(Obj);
        }
        // Metodo BuscarDireccion que llama al metodo BuscarDireccion de la clase DProveedor de la CapaDatos
        public static DataTable BuscarDireccion(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarDireccion(Obj);
        }
        // Metodo BuscarTelefono que llama al metodo BuscarTelefono de la clase DProveedor de la CapaDatos
        public static DataTable BuscarTelefono(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarTelefono(Obj);
        }
        // Metodo BuscarEmail que llama al metodo BuscarEmail de la clase DProveedor de la CapaDatos
        public static DataTable BuscarEmail(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarEmail(Obj);
        }
        // Metodo BuscarUrl que llama al metodo BuscarUrl de la clase DProveedor de la CapaDatos
        public static DataTable BuscarUrl(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarUrl(Obj);
        }
    }
}

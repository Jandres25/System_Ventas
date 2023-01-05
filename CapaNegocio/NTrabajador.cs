using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NTrabajador
    {
        public static string Insertar(string nombre, string apellidos, char genero, DateTime fecha_nacimiento, string numero_documento,
            string direccion, string telefono, string email, string acceso, string usuario, string clave)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Genero = genero;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Numero_documento = numero_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Clave = clave;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idtrabajador,string nombre, string apellidos, char genero, DateTime fecha_nacimiento, string numero_documento,
            string direccion, string telefono, string email, string acceso, string usuario, string clave)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Genero = genero;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Numero_documento = numero_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Clave = clave;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idtrabajador)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();
        }
        public static DataTable BuscarTrabajadorApellidos(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarTrabajadorApellidos(Obj);
        }
        public static DataTable BuscarTrabajadorNumDocumento(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarTrabajadorNumDocumento(Obj);
        }
    }
}

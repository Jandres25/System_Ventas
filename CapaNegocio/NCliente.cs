using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCliente
    {
        public static string Insertar(string nombre, string apellidos, char genero, DateTime fecha_nacimiento
            , string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Genero = genero;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Tipo_documento = tipo_documento;
            Obj.Num_documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idcliente, string nombre, string apellidos, char genero, DateTime fecha_nacimiento
            , string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente(idcliente, nombre, apellidos, genero, fecha_nacimiento, tipo_documento
                , num_documento, direccion, telefono, email);
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idcliente)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            DataTable dt= new DCliente().Mostrar();
            Console.WriteLine("===== f="+dt.Rows.Count+", c="+dt.Columns.Count);
            return dt;
        }
        public static DataTable BuscarApellidos(string textobuscar)
        {
            DCliente Obj = new DCliente();
            return Obj.Buscar_Apellidos(textobuscar);
        }
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            return Obj.Buscar_Num_Documento(textobuscar);
        }
    }
}

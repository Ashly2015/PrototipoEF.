﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloMVentasCC
{
        class Conexion
        {
            public OdbcConnection conexion()
            {
                //creacion de la conexion via ODBC
                OdbcConnection conn = new OdbcConnection("Dsn=conexionVentas");
                try
                {
                    conn.Open();
                    Console.WriteLine("Conectó");
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
                return conn;
            }
            //metodo para cerrar la conexion
            public void desconexion(OdbcConnection conn)
            {
                try
                {
                    conn.Close();
                }
                catch (OdbcException)
                {
                    Console.WriteLine("No Conectó");
                }
            }
        }

    }
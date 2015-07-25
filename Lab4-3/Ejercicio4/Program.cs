using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable("Empresas");
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = @"Data Source = PC-EMA\SQLSERVER; Initial Catalog = Northwind; Integrated Security = True";

            /*SqlCommand mycomando = new SqlCommand();
            mycomando.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            mycomando.Connection = myConn;
            
            myConn.Open();
            SqlDataReader mydr = mycomando.ExecuteReader();
            dtEmpresas.Load(mydr);
            myConn.Close();
            */

            SqlDataAdapter myadap = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myConn);
            myConn.Open();
            myadap.Fill(dtEmpresas);
            myConn.Close();

            Console.WriteLine("Listado de empresas:");
            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string idempresa = rowEmpresa["CustomerID"].ToString();
                string nombreempresa = rowEmpresa["CompanyName"].ToString();
                Console.WriteLine(idempresa + " - " + nombreempresa);
            }
            Console.ReadLine();

            Console.Write("Escriba el CustomerID que desea modificar:");
            string custid = Console.ReadLine();
            DataRow[] rwempresas = dtEmpresas.Select("CustomerID = '" + custid + "'");
            if (rwempresas.Length!=1)
            {
                Console.WriteLine("CustomerID no encontrado.");
                Console.ReadLine();
                return;
            }
            DataRow rowMiEmpresa = rwempresas[0];
            string nombreactual = rowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine("Nombre actual de la empresa: " + nombreactual);
            Console.Write("Escriba el nuevo nombre: ");
            string nuevonombre = Console.ReadLine();
            rowMiEmpresa.BeginEdit();
            rowMiEmpresa["CompanyName"] = nuevonombre;
            rowMiEmpresa.EndEdit();
            SqlCommand updcommand = new SqlCommand();
            updcommand.Connection = myConn;
            updcommand.CommandText = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID";
            updcommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updcommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");
            myadap.UpdateCommand = updcommand;
            myadap.Update(dtEmpresas);
            Console.ReadKey();
        }
    }
}

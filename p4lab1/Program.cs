﻿using Microsoft.Data.SqlClient;
using System;

namespace p4lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            crud.Create(conn);
            crud.Read(conn);
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBanking
{
    public class DataBaseService 
    {        
        private static IConfiguration _configuration;

        public static void Configure(IServiceProvider serviceProvider)
        {
            _configuration = serviceProvider.GetService<IConfiguration>();
        }

        public static void Init()
        {
            CleanUp();
            CreateDataBase();
            CreateTable();
            RunSeed();
        }

        private static void CleanUp()
        {
            using (var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                using (var cmd = new SqlCommand("drop database if exists internetbanking", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                };
            }
        }
     
        private static void CreateDataBase()
        {
            using(var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                using (var cmd = new SqlCommand("create database internetbanking", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                };
            }
        }

        private static void CreateTable()
        {
            using (var conn = new SqlConnection($"{_configuration.GetConnectionString("DefaultConnection")}; Initial Catalog=internetbanking"))
            {
                using (var cmd = new SqlCommand(@" create table contacorrente (
                                                    numero char(5),
                                                    saldo decimal(10,2)
                                                   );", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                };
            }
        }

        private static void RunSeed()
        {
            using (var conn = new SqlConnection($"{_configuration.GetConnectionString("DefaultConnection")}; Initial Catalog=internetbanking"))
            {
                using (var cmd = new SqlCommand(@" insert into contacorrente (numero, saldo) values ('11111', 1000);
                                                   insert into contacorrente (numero, saldo) values ('22222', 2000);
                                                   insert into contacorrente (numero, saldo) values ('33333', 3000); ", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                };
            }
        }

        public static IEnumerable<ContaCorrente> All()
        {
            using (var conn = new SqlConnection($"{_configuration.GetConnectionString("DefaultConnection")}; Initial Catalog=internetbanking"))
            {
                using (var cmd = new SqlCommand(@" select numero, saldo from contacorrente ", conn))
                {                    
                    conn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        yield return new ContaCorrente { Numero = reader.GetString(0), Saldo = reader.GetDecimal(1) };
                    }
                };
            }
        }
    }
}

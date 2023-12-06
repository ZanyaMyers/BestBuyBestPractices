﻿


using BestBuyBestPractices;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http.Headers;

//var config = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory())
//                .AddJsonFile("appsettings.json")
//                .Build();

//string connString = config.GetConnectionString("DefaultConnection");

//IDbConnection conn = new MySqlConnection(connString);

#region Departments
var departmentRepo = new DapperDepartmentRepository(conn);
departmentRepo.InsertDepartment("Nya's New Department");
var departments = departmentRepo.GetAllDepartments();


foreach (var department in departments)
{
    Console.WriteLine(department.DepartmentID);
    Console.WriteLine(department.Name);
    Console.WriteLine();
    Console.WriteLine();
}

#endregion

#region Products 
var productRepository = new DapperProductRepository(conn);
var products = productRepository.GetAllProducts(); 

foreach (var product in products)
{
    Console.WriteLine(product.ProductID); 
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.CategoryID);
    Console.WriteLine(product.OnSale);
    Console.WriteLine(product.StockLevel); 
    Console.WriteLine();
    Console.WriteLine(); 
}

#endregion
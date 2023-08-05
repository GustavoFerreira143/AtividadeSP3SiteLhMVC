using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPets.Models;
using System.Data.SqlClient;

namespace LhPets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    { List<Usuarios> usuarios=new List<Usuarios>();
        Usuarios usuarios1=new Usuarios(1,"Gustavo","132.312.456-54","gustavo@gmail.com","Theo");
        Usuarios usuarios2=new Usuarios(2,"Andreia","123.458.756-52","Adreia@gmail.com","Luck");
        Usuarios usuarios3=new Usuarios(3,"Joelton","786.542.486-57","Joelton@gmail.com","Nina");
        Usuarios usuarios4=new Usuarios(4,"Joaquim","124.456.547-51","joaquim@gmail.com","Zeus");
       
        usuarios.Add(usuarios1);
        usuarios.Add(usuarios2);
        usuarios.Add(usuarios3);
        usuarios.Add(usuarios4);
    ViewBag.usuarios=usuarios;

     List<Fornecedor> fornecedor=new List<Fornecedor>();
        Fornecedor fornecedor1=new Fornecedor(1,"Industrias pet","11.012.855/0001-59","industriaspet@gmail.com");
         Fornecedor fornecedor2=new Fornecedor(2,"Meu pet store","06.353.053/0001-72","MeupetSotre@gmail.com");
         Fornecedor fornecedor3=new Fornecedor(3,"Amor Pet","10.410.708/0001-74	","AmorPet@gmail.com");
         Fornecedor fornecedor4=new Fornecedor(4,"4 patas pet shop","45.386.216/0001-75	","4PATAS@gmail.com");
         fornecedor.Add(fornecedor1);
         fornecedor.Add(fornecedor2);
         fornecedor.Add(fornecedor3);
         fornecedor.Add(fornecedor4);
         ViewBag.fornecedor=fornecedor;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

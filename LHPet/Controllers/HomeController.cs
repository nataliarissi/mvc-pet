using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo Cliente
        Cliente primeiroCliente = new Cliente(01, "Luke Lindo", "857.032.950-41", "lukelindao@gmail.com", "Lukezinho");
        Cliente segundoCliente = new Cliente(02, "Itachi O. Melhor", "111.222.333-44", "itachi.o.melhor@gmail.com", "Itachizinho");
        Cliente terceiroCliente = new Cliente(03, "Gasai Yuno", "001.002.003-04", "gasai.yuno@gmail.com", "Yuki");
        Cliente quartoCliente = new Cliente(04, "Kurisu Makise", "112.223.334-556", "kurisu.makise@gmail.com", "Okabe");
        Cliente quintoCliente = new Cliente(05, "Sakura Uchiha", "010.020.030-04", "sakurauchiha@gmail.com", "Sasuke");

        //lista de Clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(primeiroCliente);
        listaClientes.Add(segundoCliente);
        listaClientes.Add(terceiroCliente);
        listaClientes.Add(quartoCliente);
        listaClientes.Add(quintoCliente);
        
        ViewBag.listaClientes = listaClientes;

        //instancias do tipo Fornecedor e atribui os fornecedores
        Fornecedor primeiroFornecedor = new Fornecedor(01, "Tiktok Pets", "14.182.102/0001-80", "tiktok.pets@pet.org");
        Fornecedor segundoFornecedor = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor terceiroFornecedor = new Fornecedor(03, "Golfinho Forever", "40.810.224/0001-83", "golfinhoforever@pets.br");
        Fornecedor quartoFornecedor = new Fornecedor(04, "C# PET S/A", "87.945.350/0001-09", "charp@pet.com.br");
        Fornecedor quintoFornecedor = new Fornecedor(05, "Pets Now", "18.760.614/0001-37", "contato@pets.us");                       

        //lista de Fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(primeiroFornecedor);
        listaFornecedores.Add(segundoFornecedor);
        listaFornecedores.Add(terceiroFornecedor);
        listaFornecedores.Add(quartoFornecedor);
        listaFornecedores.Add(quintoFornecedor);
        
        ViewBag.listaFornecedores = listaFornecedores;

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

using Exchange.Data;
using Exchange.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace Exchange.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly MyDbContext _context;
        public HomeController(ILogger<HomeController> logger,MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<double> Suma(int a, int b)
        {
            Menjacnica menjacnica = new Menjacnica();
            Rates rates = new Rates();
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response =  await client.GetAsync("https://openexchangerates.org/api/historical/2022-07-25.json?app_id=2c53c9573019464190043c690db8fa55");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);
                    menjacnica = JsonConvert.DeserializeObject<Menjacnica>(responseBody);
                    double dinar = menjacnica.rates.RSD;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
            double kursEvro = menjacnica.rates.EUR;
            double kursFunta = menjacnica.rates.GBP;

            double evro = kursFunta / kursEvro;/*1Evro=0.848131Funte*//*Ovo mi terba */
            double funta = kursEvro / kursFunta;/*1Funta je 1.179056 Evra*/
            return a * evro;
        }
        public async Task<double> Funta(int a, int b)
        {
            Menjacnica menjacnica = new Menjacnica();
            Rates rates = new Rates();
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://openexchangerates.org/api/historical/2022-07-25.json?app_id=2c53c9573019464190043c690db8fa55");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);
                    menjacnica = JsonConvert.DeserializeObject<Menjacnica>(responseBody);
                    double dinar = menjacnica.rates.RSD;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
            double kursEvro = menjacnica.rates.EUR;
            double kursFunta = menjacnica.rates.GBP;

            double evro = kursFunta / kursEvro;/*1Evro=0.848131Funte*//*Ovo mi terba */
            double funta = kursEvro / kursFunta;/*1Funta je 1.179056 Evra*/
            return a * funta;
        }
        public async Task<IActionResult> Index()
        {
            
            return View();
        }
       
        public ActionResult Create(Menjacnica menjacnica)
        {
            menjacnica.rates = new Rates();
            menjacnica.timestamp = 2021;
            menjacnica.disclaimer = "Agree";
            menjacnica.Base = "USD";
            _context.Menjacnica.Add(menjacnica);
            _context.SaveChanges();
            //return (IActionResult)_context.Menjacnica.Add(menjacnica);
            return View("Index", menjacnica);
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
}
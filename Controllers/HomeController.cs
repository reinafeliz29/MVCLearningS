using Microsoft.AspNetCore.Mvc;
using MVCDemoS.Data;
using MVCDemoS.Interface;
using MVCDemoS.Models;
using System.Diagnostics;

namespace MVCDemoS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationConnectDb _context;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, ApplicationConnectDb context, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var siteInfo = _unitOfWork.SiteInfoRepository.GetSiteInfo();
            return View(siteInfo.Result);
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
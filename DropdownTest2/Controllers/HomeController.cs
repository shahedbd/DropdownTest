using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DropdownTest2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using DropdownTest2.Data;
using DropdownTest.Service;

namespace DropdownTest2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ApplicationDbContext _context;
    private readonly ICommon _iCommon;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ICommon iCommon)
    {
        _logger = logger;
        _context = context;
        _iCommon = iCommon;
    }

    public IActionResult Index()
    {
        ViewBag.ddlDepartment = new SelectList(_iCommon.GetCommonddlData("Department"), "Id", "Name");
        ViewBag.ddlSubDepartment = new SelectList(_iCommon.GetCommonddlData("SubDepartment"), "Id", "Name");

        var result = _context.Department.Count();
        if(result == 0)
        {
            DataPrep();
        }
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


    private void DataPrep()
    {
        SeedData _SeedData = new SeedData();
        var _GetDepartmentList = _SeedData.GetDepartmentList();
        foreach (var item in _GetDepartmentList)
        {
            item.CreatedDate = DateTime.Now;
            item.ModifiedDate = DateTime.Now;
            item.CreatedBy = "Admin";
            item.ModifiedBy = "Admin";
            _context.Department.Add(item);
            _context.SaveChanges();
        }
        var _GetSubDepartmentList = _SeedData.GetSubDepartmentList();
        foreach (var item in _GetSubDepartmentList)
        {
            item.CreatedDate = DateTime.Now;
            item.ModifiedDate = DateTime.Now;
            item.CreatedBy = "Admin";
            item.ModifiedBy = "Admin";
            _context.SubDepartment.Add(item);
            _context.SaveChanges();
        }
    }
}

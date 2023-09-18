using Microsoft.AspNetCore.Mvc;
using Resume.Peresentation.Models.Contexts;
using Resume.Peresentation.Models.Entities.Education;

namespace Resume.Peresentation.Controllers;

public class EducationController : Controller
{

    private readonly DataBaseContext _context;
    
    public EducationController(DataBaseContext context)
    {
        _context = context;
    }
    // GET
    public IActionResult Index()
    {
        // var listOfEducation = _context.Educations.ToList();
        // var List = _context.Educations.OrderBy(p => p.Id).Last();
        // Console.WriteLine(List.EducationDuration);
        // Education education2 = _context.Educations.OrderByDescending(p => p.Id).First();
        Education education = new Education()
        {
            Id = 15,
            EducationTitle = "Master",
            EducationDuration = "2012",
            EducationDecription = "ftgyhuji",
        
        };
        
        _context.Educations.Add(education);
        _context.SaveChanges();
        return View();
    }

    public IActionResult AddEducation()
    {
        Education education = new Education()
        {
            Id = 1,
            EducationTitle = "Master",
            EducationDuration = "2012",
        
        };
        
        _context.Educations.Add(education);
        return View();
    }
    
    
}
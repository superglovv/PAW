using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.ContextModels;

public class IndexModel : PageModel
{
    private readonly StiriContext _stiriContext;

    public IndexModel(StiriContext stiriContext)
    {
        _stiriContext = stiriContext;
    }

    public List<Stire> Stiri { get; set; }

    public void OnGet()
    {
        Stiri = _stiriContext.Stiri.Include(s => s.Categorie).ToList();
    }
}

public class Stire
{
    public int Id { get; set; }
    public string Titlu { get; set; }
    public string Lead { get; set; }
    public string Autor { get; set; }
    public DateTime DataAdaugarii { get; set; }
    public int CategorieId { get; set; }
    public Categorie Categorie { get; set; }
}

public class Categorie
{
    public int Id { get; set; }
    public string Nume { get; set; }

    public List<Stire> Stiri { get; set; }
}

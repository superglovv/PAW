using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace WebApplication1.Pages
{
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
}

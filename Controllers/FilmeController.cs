using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Models;
using System.Collections.Generic;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {
        private static List<Filme> filmes = new List<Filme>();

        public void AdicionaFilme(Filme filme)
        {
            filmes.Add(filme);
        }
    }
}

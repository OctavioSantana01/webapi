using webapi.Models;

namespace webapi.DTOs.Filmes;


public class FilmeDTOOutputGetByAll
{
    public int Id { get; set; }
    public string Titulo { get; set; }

    public DateTime Ano { get; set; }

    public string Genero { get; set; }

    public long DiretorId { get; set; }

    public string NomeDiretor { get; set; }

    public FilmeDTOOutputGetByAll(int id, string titulo, DateTime ano, string genero, long diretorId, string nomeDiretor)
    {
        Id = id;
        Titulo = titulo;
        Ano = ano;
        Genero = genero;
        DiretorId = diretorId;
        NomeDiretor = nomeDiretor;
    }
}
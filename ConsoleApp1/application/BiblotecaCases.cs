using Biblioteca.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Application
{
    public class BibliotecaUseCases
    {
        private List<Libro> libros;

        public BibliotecaUseCases(List<Libro> libros)
        {
            this.libros = libros;
        }

        public List<Libro> ConsultarTodos()
        {
            return libros;
        }

        public List<Libro> CienciaFiccion()
        {
            return libros.Where(l => l.Genero.ToLower() == "ciencia ficción").ToList();
        }

        public List<Libro> LibrosAlgebra()
        {
            return libros.Where(l => l.Nombre.ToLower().Contains("álgebra")).ToList();
        }

        public List<Libro> AutoresFranceses()
        {
            return libros.Where(l => l.Autores.Any(a => a.Pais.ToLower() == "francia")).ToList();
        }

        public List<Autor> AutoresRomance()
        {
            return libros
                .Where(l => l.Genero.ToLower() == "romance")
                .SelectMany(l => l.Autores)
                .Distinct()
                .ToList();
        }
    }
}


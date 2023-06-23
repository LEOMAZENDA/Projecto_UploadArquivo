using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositorios
{
    public class FicheiroRepository : IFicheiro
    {
        private readonly FicheiroContext _context;

        public FicheiroRepository(FicheiroContext context)
        {
            _context = context;
        }

       
        public List<Ficheiro> Listar()
        {
            return _context.Ficheiros.ToList();
        }

        public Ficheiro BuscarPorId(int id)
        {
            return _context.Ficheiros.FirstOrDefault(a => a.Id == id);
        }
               

        public void Adicionar(Ficheiro ficheiro)
        {
            _context.Ficheiros.Add(ficheiro);
            _context.SaveChanges();
        }
    }
}

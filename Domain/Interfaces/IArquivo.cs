using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IFicheiro
    {
        List<Ficheiro> Listar();
        void Adicionar(Ficheiro ficheiro);
        Ficheiro BuscarPorId(int id);
    }
}

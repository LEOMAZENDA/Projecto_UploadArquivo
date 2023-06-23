using Application.ViewsModels;
using System.Collections.Generic;

namespace Application.InterfaceApp
{
    public interface IFicheiroApp
    {
        List<FicheiroVM> Listar();
        void Adicionar(FicheiroVM viweModel);
        FicheiroVM BuscarPorId(int id);
    }
}

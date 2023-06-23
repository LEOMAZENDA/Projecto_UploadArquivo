using Application.InterfaceApp;
using Application.ViewsModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Application.Services
{
    public class FicheiroService : IFicheiroApp
    {

        private readonly IFicheiro _IFicheiro;
        private readonly IMapper _mapper;

        public FicheiroService(IFicheiro IFicheiro, IMapper mapper)
        {
            _IFicheiro = IFicheiro;
            _mapper = mapper;
        }

        public List<FicheiroVM> Listar()
        {
            var ficheiros = _IFicheiro.Listar();
            return _mapper.Map<List<FicheiroVM>>(ficheiros);
        }

        public FicheiroVM BuscarPorId(int id)
        {
            var ficheiro = _IFicheiro.BuscarPorId(id);
            return _mapper.Map<FicheiroVM>(ficheiro);
        }


        public void Adicionar(FicheiroVM viweModel)
        {
            var mapArquivo = _mapper.Map<Ficheiro>(viweModel);
            _IFicheiro.Adicionar(mapArquivo);
        }
    }
}

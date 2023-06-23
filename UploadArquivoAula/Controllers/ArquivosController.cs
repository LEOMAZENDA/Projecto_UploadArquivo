using Application.InterfaceApp;
using Application.ViewsModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadArquivoAula.Helper;

namespace UploadArquivoAula.Controllers
{
    public class ArquivosController : Controller
    {
        IFicheiroApp _IFicheiroApp;

        public ArquivosController(IFicheiroApp IFicheiroApp)
        {
            _IFicheiroApp = IFicheiroApp;
        }


        public IActionResult Index()
        {
            var arquivos = _IFicheiroApp.Listar();
            return View(arquivos);
        }

        [HttpPost]
        public IActionResult Upload(IFormFile arquivos)
        {
            var fileBytes = ConvertFileToByteArray.Convert(arquivos);

            if (fileBytes != null)
            {
                _IFicheiroApp.Adicionar(new FicheiroVM()
                {
                    Descricao = fileBytes.Description,
                    Arquivo = fileBytes.File,
                    ContentType = fileBytes.ContentType,
                });
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Visualizar(int id)
        {
            var arquivo = _IFicheiroApp.BuscarPorId(id);
            return File(arquivo.Arquivo, arquivo.ContentType);
        }
    }
}

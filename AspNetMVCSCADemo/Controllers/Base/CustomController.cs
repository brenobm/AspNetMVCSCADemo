using CEB.SCA.Services.Spec.Services;
using CEB.SCA.WebControls.Mvc;

namespace AspNetMVCSCADemo.Controllers.Base
{
    public class CustomController : SCAController
    {
        public override IAutenticacaoService GetAutenticacaoService()
        {
            return serviceLocator.GetService<IAutenticacaoService>("ceb.servicos/AutenticacaoService", SCAApplicationContext.ObterParametrosServico(), "userinfo");
        }
    }
}
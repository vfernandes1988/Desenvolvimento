using System.Collections.Generic;
using BPNFE.Dominio.Entidades;

namespace BPNFE.Dominio.Interfaces.Servicos
{
    interface IUsuarioServico : IBaseServico<Usuario>
    {
        IEnumerable<Usuario> BuscarAdministrador(IEnumerable<Usuario> usuarios);
    }
}

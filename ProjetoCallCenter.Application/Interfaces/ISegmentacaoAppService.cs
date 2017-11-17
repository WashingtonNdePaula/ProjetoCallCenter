using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Application.Interfaces
{
    public interface ISegmentacaoAppService : IAppServiceBase<Segmentacao>
    {
        IEnumerable<Segmentacao> GetAll(int usuario, int credor);
    }
}

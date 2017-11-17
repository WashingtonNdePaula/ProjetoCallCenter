using ProjetoCallCenter.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Interfaces.Services
{
    public interface ISegmentacaoService : IServiceBase<Segmentacao>
    {
        IEnumerable<Segmentacao> GetAll(int usuario, int credor);
    }
}

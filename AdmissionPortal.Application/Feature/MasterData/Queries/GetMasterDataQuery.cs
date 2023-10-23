using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.MasterData.Queries
{
    public class GetMasterDataQuery : IRequest<List<MasterDataModel>>
    {
        public string FieldName { get; set; }
    }
}

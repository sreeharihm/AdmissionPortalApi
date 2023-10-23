using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.MasterData.Queries
{
    public class GetMasterDataQueryHandler : IRequestHandler<GetMasterDataQuery, List<MasterDataModel>>
    {
        private readonly ICountryMasterRepository _countryMasterRepository;
        public GetMasterDataQueryHandler(ICountryMasterRepository countryMasterRepository)
        {
            _countryMasterRepository = countryMasterRepository;
        }
        public async Task<List<MasterDataModel>> Handle(GetMasterDataQuery request, CancellationToken cancellationToken)
        {
            var result = new List<MasterDataModel>();
            var data =await _countryMasterRepository.GetCountryMaster();
            MasterDataModel masterDataModel = new MasterDataModel();
            masterDataModel.FieldName = "Countries";            
            masterDataModel.FieldValues = new List<ListItem>();
            masterDataModel.FieldValues.AddRange(data.Select(n => new ListItem
            {
                Key = n.CountryCode,
                Value = n.CountryName
            }).ToList());
            result.Add(masterDataModel);
            return result;
        }
    }
}

using AdmissionPortal.Domain.Dto;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface IMasterRepository
    {
        Task<EducationData> GetLocalData();
    }
}

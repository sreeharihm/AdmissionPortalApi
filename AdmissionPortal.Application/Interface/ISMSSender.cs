using AdmissionPortal.Domain.Dto;

namespace AdmissionPortal.Application.Interface
{
    public interface ISMSSender
    {
        Task<bool> SendSmsAsync();
    }
}

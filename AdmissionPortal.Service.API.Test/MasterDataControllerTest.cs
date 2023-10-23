using AdmissionPortal.Application.Feature.MasterData.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Service.API.Controllers;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdmissionPortal.Service.API.Test
{
    public class MasterDataControllerTest
    {
        private readonly MasterDataController sut;
        private readonly Mock<IMediator> mediatorMoq;


        public MasterDataControllerTest()
        {
            mediatorMoq = new Mock<IMediator>();

            sut = new MasterDataController(mediatorMoq.Object);
        }

        [Fact]
        public void GetMasterData_Return_Sucess()
        {
            //Arrange;
            //mediatorMoq.Setup(x => x.Send(It.IsAny<GetMasterDataQuery>(), It.IsAny<CancellationToken>())).Returns(new List<MasterDataModel>());

        }
    }
}

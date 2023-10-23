using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmByTermAdmissionSchedule
{
    public int AdmissionScheduleRecId { get; set; }

    public int? DegreeTypeRecId { get; set; }

    public int TermId { get; set; }

    public int AcademicYearRecId { get; set; }

    public int AdmissionTypeRecId { get; set; }

    public int ProgramRecId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public DateTime? ExtenssionEndDateTime { get; set; }

    public int? AdmissionTotalCapacity { get; set; }

    public int? NonCitizenCapacity { get; set; }

    public int? CitizenCapacity { get; set; }

    public decimal? NonCitizenAdmissionFee { get; set; }

    public decimal? NonCitizenAdmissionFeeVat { get; set; }

    public decimal? CitizenAdmissionFee { get; set; }

    public decimal? CitizenAdmissionFeeVat { get; set; }

    public decimal? FirstTuitionFeePayment { get; set; }

    public int? MaleCapacity { get; set; }

    public int? FemaleCapacity { get; set; }

    public bool? AdmissionStatus { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual TblRegAcademicYear AcademicYearRec { get; set; } = null!;

    public virtual TblMstAdmissionTypeMaster AdmissionTypeRec { get; set; } = null!;

    public virtual TblMstDegreeTypeMaster? DegreeTypeRec { get; set; }

    public virtual TblRegTermMaster Term { get; set; } = null!;
}

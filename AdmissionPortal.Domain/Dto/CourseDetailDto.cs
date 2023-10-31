namespace AdmissionPortal.Domain.Dto
{
    public class CourseDetailDto
    {
        public List<CourseYear> courseYears { get; set; }
        public List<CourseType> courseTypes { get; set; }
        public List<AdmissionType> admissionTypes { get; set; }
        public CourseTenure courseTenure { get; set; }
    }
}

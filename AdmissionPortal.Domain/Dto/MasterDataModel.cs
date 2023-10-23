namespace AdmissionPortal.Domain.Dto
{
    public class MasterDataModel
    {
        public string FieldName { get; set; }
        public List<ListItem> FieldValues { get; set; }
    }

    public class ListItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}

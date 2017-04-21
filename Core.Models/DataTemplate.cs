namespace Core.Models
{
    public class DataTemplate
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DataType DataType { get; set; }
    }

    public enum DataType
    {
        String,
        Int,
        Double,
        Date
    }
}
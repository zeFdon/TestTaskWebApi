namespace TestTaskWebApi.Domain
{
    public class Origin
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dimension { get; set; }
        public Origin(string name,string type,string dimension)
        {
            Name = name;
            Type = type;
            Dimension = dimension;
        }
    }
}

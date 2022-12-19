

namespace TestTaskWebApi.Domain
{
	//Каждый объект от сюда взять и закинуть в папку Domain создав для каждого объекта отдельный клас (файл)
	public class Person
	{
		public string Name { get; set; }
		
		public string Status { get; set; }
		
		public string Species { get; set; }
		
		public string Type { get; set; }
		
		public string Gender { get; set; }
		
		public Origin Origin { get; set; }
	}
}

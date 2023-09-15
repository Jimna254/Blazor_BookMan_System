namespace Week8_Assesment.Models
{
	public class Book
	{
		public string Title { get; set; } = string.Empty;

		public string Description { get; set; }= string.Empty;
		public List<String>? Authors { get; set; }
	}
}

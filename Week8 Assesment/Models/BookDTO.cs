namespace Week8_Assesment.Models
{
	public class BookDTO
	{
		public Guid Id { get; set; }	
		public string Title { get; set; } = string.Empty;

		public string Description { get; set; }= string.Empty;
		public List<AuthorDTO> Authors { get; set; } = new List<AuthorDTO> ();
	}
}

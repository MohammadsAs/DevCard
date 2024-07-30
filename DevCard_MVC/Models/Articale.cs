namespace DevCard_MVC.Models
{
	public record Articale
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }

		public Articale(int id, string title, string description, string image)
		{
			Id = id;
			Title = title;
			Description = description;
			Image = image;
		}
	}
}

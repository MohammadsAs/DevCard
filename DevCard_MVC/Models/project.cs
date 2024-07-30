namespace DevCard_MVC.Models
{
	public class project
	{
		internal int id;
		internal string description;
		internal string name;
		internal string client;

		public long Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public string Client { get; set; }

		public project(long id, string name, string description, string image, string client)
		{
			Id = id;
			Name = name;
			Description = description;
			Image = image;
			Client = client;
		}
	};
}

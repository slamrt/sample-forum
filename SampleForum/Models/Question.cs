namespace SampleForum.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public DateTime Date { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
    }
}

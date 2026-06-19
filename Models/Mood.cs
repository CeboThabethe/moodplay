namespace MoodPlay.Models
{
    public class Mood
    {
        public string Name { get; set; } = string.Empty;
        public string Emoji {  get; set; }  = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}

namespace BlazorApp.Models
{
    public class Music
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Composer { get; set; }
        public string Album { get; set; }
        
        public Music(string name, string artist, string composer, string album)
        {
            Name = name;
            Artist = artist;
            Composer = composer;
            Album = album;
        }
    }
}
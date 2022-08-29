namespace OOPSpotiflixV2
{
    internal class Album : Media
    {
        public List<Song> Songs { get; set; } = new();
        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
    }

    internal class Song : Media
    {
        public string GetLength()
        {
            return Length.ToString("mm:ss");
        }
    }
}

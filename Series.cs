namespace OOPSpotiflixV2
{
    internal class Series
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? WWW { get; set; }
        public List<Episode> Episodes { get; set; } = new();
    }
    internal class Episode
    {
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Season { get; set; }
        public int EpisodeNum { get; set; }
        public DateTime Length { get; set; }

    }
}

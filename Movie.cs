namespace OOPSpotiflixV2
{
    internal class Movie : Media
    {
        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
    }
}

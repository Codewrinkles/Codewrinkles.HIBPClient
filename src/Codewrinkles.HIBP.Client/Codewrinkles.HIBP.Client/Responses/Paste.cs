namespace Codewrinkles.HIBP.Client.Responses
{
    internal class Paste
    {
        public string    Source { get; set; }
        public string    Id { get; set; }
        public string?   Title { get; set; }
        public DateTime? Date { get; set; }
        public int       EmailCount { get; set; }

        public Paste(string source, string id)
        {
            Source = source;
            Id     = id;
        }
    }
}

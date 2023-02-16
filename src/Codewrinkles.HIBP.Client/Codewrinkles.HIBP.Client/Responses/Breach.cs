namespace Codewrinkles.HIBP.Client.Responses
{
    internal class Breach
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Domain { get; private set; }
        public DateTime BreachDate { get; private set; }
        public DateTime AddedDate { get; private set; }
        public DateTime ModifiedDate { get; private set; }
        public int PwnCount { get; private set; }
        public string Description { get; private set; }
        public string[] DataClasses { get; private set; }
        public bool IsVerified { get; private set; }
        public bool IsFabricated { get; private set; }
        public bool IsSensitive { get; private set; }
        public bool IsSpamList { get; private set; }
        public bool IsMalware { get; private set; }
        public string LogoPath { get; private set; }

        public Breach(string name, string title, string domain, DateTime breachDate, DateTime addedDate, DateTime modifiedDate, int pwnCount, string description, string[] dataClasses, bool isVerified, bool isFabricated, bool isSensitive, bool isSpamList, bool isMalware, string logoPath)
        {
            Name = name;
            Title = title;
            Domain = domain;
            BreachDate = breachDate;
            AddedDate = addedDate;
            ModifiedDate = modifiedDate;
            PwnCount = pwnCount;
            Description = description;
            DataClasses = dataClasses;
            IsVerified = isVerified;
            IsFabricated = isFabricated;
            IsSensitive = isSensitive;
            IsSpamList = isSpamList;
            IsMalware = isMalware;
            LogoPath = logoPath;
        }
    }
}

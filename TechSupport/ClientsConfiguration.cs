namespace StatisticsG
{
    public enum Groups
    {
        FirstYearStudent,
        EarlyYearStudent,
        HighYearStudent,
        ExStudent,
        Worker,
        Guest
    }
    public class ClientsConfiguration
    {
        public string ClientFIO { get; set; }
        public string ClientPhone { get; set; }
        public Groups ClientGroup { get; set; }
    }
}

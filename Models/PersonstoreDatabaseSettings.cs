namespace PersonsApi.Models
{
    public interface IPersonstoreDatabaseSettings
    {
        string PersonsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    public class PersonstoreDatabaseSettings : IPersonstoreDatabaseSettings
    {
        public string PersonsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

}

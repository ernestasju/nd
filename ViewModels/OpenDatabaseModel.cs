namespace nd
{
    public class OpenDatabaseModel
    {
        public OpenDatabaseModel()
        {
            DatabaseServer = "SQL01\\SQL2014";
            DatabaseName = "SLO Lithiania";
        }

        public string DatabaseServer {get;set;}
        public string DatabaseName {get;set;}
    }
}
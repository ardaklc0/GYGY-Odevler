using Dependency_Inversion;

IDataAccess SqlDataAccess = new SqlDataAccess();
IDataAccess MongoDbDataAccess = new MongoDbDataAccess();

DataService SqlService = new DataService(SqlDataAccess);
DataService MongoService = new DataService(MongoDbDataAccess);

SqlService.SaveData("Lorem ipsum dolor sit amet.");
MongoService.SaveData("Lorem ipsum dolor sit amet.");
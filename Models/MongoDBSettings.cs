namespace MongoDB.CRUD;

public class MongoDBSettings {

    public string ConnectionURI { get; set; } = "mongodb://admin:password@localhost:27017/";
    public string DatabaseName { get; set; } = "Demo";
}

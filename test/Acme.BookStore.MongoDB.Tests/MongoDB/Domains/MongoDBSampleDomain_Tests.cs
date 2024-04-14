using Acme.BookStore.Samples;
using Xunit;

namespace Acme.BookStore.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<BookStoreMongoDbTestModule>
{

}

using Acme.BookStore.MongoDB;
using Acme.BookStore.Samples;
using Xunit;

namespace Acme.BookStore.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<BookStoreMongoDbTestModule>
{

}

using StorageChallenge.Models;
using System;

namespace StorageChallenge.Testing
{
    public class TestProcessor
    {
        public bool Passed { get; set; }

        public TestProcessor()
        {
        }

        public NoSQLTestResult TestCosmos(CosmosTestData cosmosTestData)
        {

            throw new NotImplementedException();
        }

        public DataTestResult TestMySQL(SQLTestData sqlTestData)
        {
            throw new NotImplementedException();
        }

        public BlobTestResult TestPrivateBlob(FileTestData fileTestData)
        {
            throw new NotImplementedException();
        }

        public BlobTestResult TestPublicBlob(FileTestData fileTestData)
        {
            throw new NotImplementedException();
        }

        public NoSQLTestResult TestSearch(CosmosTestData cosmosTestData)
        {
            throw new NotImplementedException();
        }

        public DataTestResult TestSQLServer(SQLTestData sqlTestData)
        {
            throw new NotImplementedException();
        }
    }
}
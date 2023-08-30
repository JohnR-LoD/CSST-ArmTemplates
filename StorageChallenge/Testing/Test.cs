using StorageChallenge.Models;
using System;

namespace StorageChallenge.Testing
{
    public class TestProcessor
    {
        public NoSQLTestResult TestCosmos(CosmosTestData cosmosTestData) => new();

        public DataTestResult TestMySQL(SQLTestData sqlTestData) => new();

        public BlobTestResult TestPrivateBlob(FileTestData fileTestData) => new();

        public BlobTestResult TestPublicBlob(FileTestData fileTestData) => new();

        public NoSQLTestResult TestSearch(CosmosTestData cosmosTestData) => new();

        public DataTestResult TestSQLServer(SQLTestData sqlTestData) => new();
    }
}
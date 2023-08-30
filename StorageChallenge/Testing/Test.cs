using StorageChallenge.Models;
using System;

namespace StorageChallenge.Testing
{
    public class TestProcessor
    {
        public NoSQLTestResult TestCosmos(CosmosTestData cosmosTestData)
        {
            return new NoSQLTestResult()
            {
                Passed = true
            };
        }

        public DataTestResult TestMySQL(SQLTestData sqlTestData)
        {
            return new DataTestResult()
            {
                Passed = true
            };
        }

        public BlobTestResult TestPrivateBlob(FileTestData fileTestData)
        {
            return new BlobTestResult()
            {
                Passed = true
            };
        }

        public BlobTestResult TestPublicBlob(FileTestData fileTestData)
        {
            return new BlobTestResult()
            {
                Passed = true
            };
        }

        public NoSQLTestResult TestSearch(CosmosTestData cosmosTestData)
        {
            return new NoSQLTestResult()
            {
                Passed = true
            };
        }

        public DataTestResult TestSQLServer(SQLTestData sqlTestData)
        {
            return new DataTestResult()
            {
                Passed = true
            };
        }
    }
}
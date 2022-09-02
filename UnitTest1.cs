namespace VerifyTest
{
    public class Person { public string Name { get; set; } }

    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var element = new Person { Name = "Heinz" };
            Verify(element);
        }
    }
}
using System;
using Moq;
using NUnit.Framework;
using OtusInterfaceTask01;


namespace UnitTestInterface
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var mock = new Mock<IRepository<Account>>();
            mock.Setup(r => r.Add(It.IsAny<Account>()));
            IAccountService accServ = new AccountService(mock.Object);
            accServ.AddAccount(new Account()
            {
                FirstName = "Ivan"
                , LastName ="Sidoroff"
                , BirthDate = DateTime.Now
            });
            mock.Verify(rep=> rep.Add(It.IsAny<Account>()));

        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace OtusInterfaceTask01
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestAddAcc()
        {
            var mock = new Mock<IRepository<Account>>();
            mock.Setup(r => r.Add(It.IsAny<Account>()));
            IAccountService accServ = new AccountService((Repository) mock.Object);
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
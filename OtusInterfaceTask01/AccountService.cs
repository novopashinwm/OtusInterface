using System;

namespace OtusInterfaceTask01
{
    public class AccountService : IAccountService
    {
        private readonly Repository _repository;

        public AccountService(Repository repository)
        {
            _repository = repository;
        }

        public void AddAccount(Account account)
        {
            if (string.IsNullOrEmpty(account.FirstName))
            {
                throw new Exception("Не заполнено имя");
            }

            if (string.IsNullOrEmpty(account.LastName))
            {
                throw new Exception("Не заполнена фамилия");
            }

            TimeSpan age = DateTime.Today - account.BirthDate;
            int year = age.Days / 365;
            if (year > 18)
                _repository.Add(account);
            else
            {
                throw new Exception("Вам меньше 18 лет.");
            }
        }
    }
}
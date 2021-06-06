using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain;
using MicroRabbit.Banking.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _dbContext;


        public AccountRepository(BankingDbContext ctx)
        {
            _dbContext = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _dbContext.Accounts;
        }
    }
}

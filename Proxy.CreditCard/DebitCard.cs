namespace Proxy.CreditCard
{
    ///
    /// Proxy class for Account that handles Debit transacations.
    ///
    class DebitCard : IAccount
    {
        private readonly Account _account;
        public decimal Balance { get; set; }

        ///
        /// Instantiate DebitCard proxy class while also creating new Account instance.
        ///
        public DebitCard()
        {
            _account = new Account();
        }

        ///
        /// Instantiate DebitCard proxy class with passed Account instance.
        ///
        ///Underlying Account instance to use.
        public DebitCard(Account account)
        {
            _account = account;
        }

        ///
        /// Charge passed amount to underlying account.
        ///
        ///Amount of charge. /// Succes or failure of charge.
        public bool ChargeAccount(decimal amount)
        { 
            // Check if balance meets or exceeds charge amount.
            if (_account.Balance >= amount)
            { 
                // Log successful charge message.
                Logging.Log($"{this.GetType().Name} charge of {amount:C2} succeeded."); 
                // Modify balance.
                _account.Balance -= amount; 
                // Charge was successful.
                return true;
            } 
            // Log that charge failed due to insufficient funds.
            Logging.Log($"{this.GetType().Name} charge of {amount:C2} failed due to insufficient funds. Current balance: {_account.Balance:C2}."); 
            // Charge failed.
            return false;
        }
    }
}
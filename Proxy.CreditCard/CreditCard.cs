namespace Proxy.CreditCard
{
    ///
    /// Proxy class for Account handles Credit transacations.
    ///
    class CreditCard : IAccount
    {
        private readonly Account _account;
        public decimal Balance { get; set; }

        ///
        /// Instantiate CreditCard proxy class while also creating new Account instance.
        ///
        public CreditCard()
        {
            _account = new Account();
        }

        ///
        /// Instantiate CreditCard proxy class with passed Account instance.
        ///
        ///Underlying Account instance to use.
        public CreditCard(Account account)
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
            }
            else
            { 
                // Log successful charge message, indicating overcharge occurred.
                Logging.Log($"{this.GetType().Name} charge of {amount:C2} succeeded, as overcharge.");
            }

            // Modify balance.
            _account.Balance -= amount; 
            // Charge was successful.
            return true;
        }
    }
}
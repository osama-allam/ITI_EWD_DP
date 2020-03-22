namespace Proxy.CreditCard
{
    ///
    /// RealSubject class that handles account management.
    ///
    class Account : IAccount
    { 
        // Set default balance to $1000.
        private decimal _balance = 1000;

        public decimal Balance
        {
            get => _balance;
            set
            { 
                // Log output when balance is changed.
                if (value == _balance) return;
                Logging.Log($"Balance changed from {_balance:C2} to {value:C2}.");
                _balance = value;
            }
        }

        ///
        /// Attempt to charge account the passed amount.
        ///
        ///Amount to charge. /// Success or failure of charge.
        public bool ChargeAccount(decimal amount)
        { 
            // Check if balance meets or exceeds charge amount.
            if (Balance >= amount)
            { 
                // Modify balance.
                Balance -= amount; 
                // Log successful charge message.
                Logging.Log($"{this.GetType().Name} charge of {amount:C2} succeeded."); 
                // Charge was successful.
                return true;
            } 
            // Log that charge failed due to insufficient funds.
            Logging.Log($"{this.GetType().Name} charge of {amount:C2} failed due to insufficient funds."); 
            // Charge failed.
            return false;
        }
    }
}
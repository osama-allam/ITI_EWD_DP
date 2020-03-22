namespace Proxy.CreditCard
{
    ///
    /// Subject class that defines account info.
    ///
    interface IAccount
    {
        decimal Balance { get; set; }
        bool ChargeAccount(decimal amount);
    }
}
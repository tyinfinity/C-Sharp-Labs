namespace Task2
{
    public static class WalletExtensions
    {
        public static Wallet Add(Wallet wallet1, Wallet wallet2)
        {
            return new Wallet(wallet1.Pound + wallet2.Pound, wallet1.Shilling + wallet2.Shilling,
                wallet1.Penny + wallet2.Penny);

        }
    }
}

using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet(1, 2, 3);
            Wallet wallet2 = new Wallet(1, 19, 11);
            Console.WriteLine(wallet.ToString());
            Console.WriteLine(WalletExtensions.Add(wallet, wallet2).ToString());
        }
    }
}
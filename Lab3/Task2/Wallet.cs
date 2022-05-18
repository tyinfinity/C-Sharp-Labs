using System;

namespace Task2
{
    public class Wallet : IComparable<Wallet>
    {
        private int pound;
        private int shilling;
        private int penny;

        public int Pound { 
            get => pound;
            set
            {
                if (value > 1000000000)
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Shilling
        {
            get => shilling;
            set
            {
                if (value > 20)
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Penny
        {
            get => penny;
            set
            {
                if (value > 12)
                {
                    throw new ArgumentException();
                }
            }
        }

        public long SumInPenny => (Pound * 240) + (Shilling * 12) + penny;

        public Wallet()
        {
            pound = 0;
            shilling = 0;
            penny = 0;
        }

        public Wallet(int pound, int shilling, int penny)
        {
            while (penny > 12)
            {
                penny -= 12;
                shilling++;
            }

            while (shilling > 20)
            {
                shilling -= 20;
                pound++;
            }

            if (shilling > 20 || penny > 12 || pound > 1000000000 || 
                shilling < 0 || penny < 0 || pound < 0)
            {
                throw new InvalidOperationException();
            }

            this.pound = pound;
            this.shilling = shilling;
            this.penny = penny;
        }

        public static Wallet operator +(Wallet wallet1, Wallet wallet2)
        {
            return Convert(wallet1.pound + wallet2.pound, wallet1.shilling + wallet2.shilling, wallet1.penny + wallet2.penny);
        }

        public static Wallet operator -(Wallet wallet1, Wallet wallet2)
        {
            return Convert(wallet1.pound - wallet2.pound, wallet1.shilling - wallet2.shilling, wallet1.penny - wallet2.penny);
        }

        public static bool operator ==(Wallet wallet1, Wallet wallet2)
        {
            if (wallet1.pound == wallet2.pound && wallet1.shilling == wallet2.shilling && wallet1.penny == wallet2.penny)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Wallet wallet1, Wallet wallet2)
        {
            if (wallet1.pound != wallet2.pound || wallet1.shilling != wallet2.shilling || wallet1.penny != wallet2.penny)
            {
                return true;
            }

            return false;
        }

        public static bool operator >(Wallet wallet1, Wallet wallet2)
        {
            if (wallet1.pound > wallet2.pound)
            {
                return true;
            }

            if (wallet1.pound == wallet2.pound)
            {
                if (wallet1.shilling > wallet2.shilling)
                {
                    return true;
                }
            }

            if (wallet1.pound == wallet2.pound)
            {
                if (wallet1.shilling == wallet2.shilling)
                {
                    if (wallet1.penny > wallet2.penny)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator <(Wallet wallet1, Wallet wallet2)
        {
            if (wallet1.pound < wallet2.pound)
            {
                return true;
            }

            if (wallet1.pound == wallet2.pound)
            {
                if (wallet1.shilling < wallet2.shilling)
                {
                    return true;
                }
            }

            if (wallet1.pound == wallet2.pound)
            {
                if (wallet1.shilling == wallet2.shilling)
                {
                    if (wallet1.penny < wallet2.penny)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator >=(Wallet wallet1, Wallet wallet2)
        {
            if (wallet1 > wallet2 || wallet1 == wallet2)
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(Wallet wallet1, Wallet wallet2)
        {
            if (wallet1 < wallet2 || wallet1 == wallet2)
            {
                return true;
            }

            return false;
        }

        public static Wallet operator -(Wallet wallet1)
        {
            Wallet wallet = new Wallet();
            wallet.pound = - wallet1.pound;
            wallet.shilling = - wallet1.shilling;
            wallet.penny = - wallet1.penny;
            return wallet;
        }

        public static Wallet Convert(int pound, int shilling, int penny)
        {
            while (penny > 12)
            {
                penny -= 12;
                shilling++;
            }

            while (shilling > 20)
            {
                shilling -= 20;
                pound++;
            }
            return new Wallet(pound, shilling, penny);
        }

        public int CompareTo(Wallet other)
        {
            if (this.SumInPenny > other.SumInPenny)
            {
                return 1;
            }
            else if (this.SumInPenny < other.SumInPenny)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"{Pound}pd. {Shilling}sh. {Penny}p.";
        }
    }
}
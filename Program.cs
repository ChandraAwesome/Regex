using Regexx;

namespace Regexx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pincode check= new pincode();
            Console.WriteLine(check.checkPincode("400088"));
            Console.WriteLine(check.checkPincode("A400088"));
        }
    }
}
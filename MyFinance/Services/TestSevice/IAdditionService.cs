using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFinance.Services.TestSevice
{
    public interface IAdditionService
    {
        int AddNumbers(int numberOne, int numberTwo);
        int MultiplyNumbers(int numberOne, int numberTwo);
    }

    public class AdditionService : IAdditionService
    {
        private readonly Ixxx xxx;

        public AdditionService(Ixxx xxx)
        {
            this.xxx = xxx;
        }

        public int AddNumbers(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public int MultiplyNumbers(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
    }

    public interface Ixxx
    {
        void test();
    }

    public class Xxx : Ixxx
    {
        public void test()
        {
            throw new NotImplementedException();
        }
    }
}
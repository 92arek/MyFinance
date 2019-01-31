using System;
using System.Web.DynamicData;

namespace MyFinance.Services.TestSevice
{
    public interface IDependencyInversion<TClass> where TClass : class
    {
        string ReturnLetter();

    }

    public class A
    {

    }

    public class B
    {

    }

    public class DependencyInversionA : IDependencyInversion<A>
    {
        public string ReturnLetter()
        {
            return this.GetType().Name;
        }
    }

    public class DependencyInversionB : IDependencyInversion<B>
    {
        public string ReturnLetter()
        {
            return this.GetType().Name;
        }
    }
}
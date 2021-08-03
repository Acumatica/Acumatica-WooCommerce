using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace WooCommerce.Tests.TestData
{
    public abstract class GeneralTestData
    {
        public virtual string Prefix { get; set; }
        protected Random Rand { get; set; }
        protected Faker Faker { get; set; }

        protected GeneralTestData()
        {
            Rand = new Random();
            Faker = new Faker();
        }
        protected virtual string GetRandomName()
        {
            return Rand.Next(10000).ToString();
        }
    }
}

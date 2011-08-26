using System;
using NUnit.Framework;
using Should;

namespace CastAs.Tests
{
    [TestFixture]
    public class CastAsTests
    {
        [Test]
        public void Returns_the_object_passed_in()
        {
            var fruit = new Fruit();
            fruit.CastAs<Fruit>().ShouldBeSameAs(fruit);

            var apple = new Apple();
            apple.CastAs<Fruit>().ShouldBeSameAs(apple);
        }

        [Test]
        public void Returns_null_if_the_object_is_of_a_different_type()
        {
            var fruit = new Fruit();
            fruit.CastAs<Vegetable>().ShouldBeNull();
        }
    }

}
using System;
using NUnit.Framework;
using Should;

namespace CastAs.Tests
{
    [TestFixture]
    public class CastToTests
    {
        [Test]
        public void Returns_the_object_passed_in()
        {
            var fruit = new Fruit();
            fruit.CastTo<Fruit>().ShouldBeSameAs(fruit);

            var apple = new Apple();
            apple.CastTo<Fruit>().ShouldBeSameAs(apple);
        }

        [Test]
        public void Throws_exception_if_type_does_not_match()
        {
            var fruit = new Fruit();
            var exceptionHit = false;
            try
            {
                fruit.CastTo<Vegetable>();
            }
            catch
            {
                exceptionHit = true;
            }
            exceptionHit.ShouldBeTrue();
        }
    }
}
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void Test1()
        {

        }
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");
        }
        [Test]
        public void AxeAttackWithZeroDurability()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
        [Test]
        public void AxeAttackWithNegativeDurability()
        {
            Axe axe = new Axe(10, -1);
            Dummy dummy = new Dummy(10, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }

        [Test]
        public void AxeConstructorTest()
        {
            Axe axe = new Axe(10, 10);
            Assert.That(axe.AttackPoints, Is.EqualTo(10), "Axe AttackPoints are not set correctly.");
            Assert.That(axe.DurabilityPoints, Is.EqualTo(10), "Axe DurabilityPoints are not set correctly.");
        }
        [Test]
        public void AxeAttackMethodTest()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            Assert.That(dummy.Health, Is.EqualTo(0), "Dummy Health doesn't change after attack.");
        }
        [Test]
        public void AxeAttackMethodWithZeroDurability()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
        [Test]
        public void AxeAttackMethodWithNegativeDurability()
        {
            Axe axe = new Axe(10, -1);
            Dummy dummy = new Dummy(10, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
        [Test]
        public void AxeAttackMethodWithZeroHealth()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(0, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }
        [Test]
        public void AxeAttackMethodWithNegativeHealth()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(-1, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }
        [Test]
        public void AxeAttackMethodWithNegativeHealthAndZeroDurability()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(-1, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
        [Test]
        public void AxeAttackMethodWithZeroHealthAndZeroDurability()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(0, 10);
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
        [Test]
        public void PropetiesGettersWorkCorrectly()
        {
            Axe axe = new Axe(10, 10);
            Assert.That(axe.AttackPoints, Is.EqualTo(10), "Axe AttackPoints are not set correctly.");
            Assert.That(axe.DurabilityPoints, Is.EqualTo(10), "Axe DurabilityPoints are not set correctly.");
        }
        [Test]
        public void PropetiesSettersWorkCorrectly()
        {
            Axe axe = new Axe(10, 10);
            Assert.That(axe.AttackPoints, Is.EqualTo(10), "Axe AttackPoints are not set correctly.");
            Assert.That(axe.DurabilityPoints, Is.EqualTo(10), "Axe DurabilityPoints are not set correctly.");
        }




    }
}
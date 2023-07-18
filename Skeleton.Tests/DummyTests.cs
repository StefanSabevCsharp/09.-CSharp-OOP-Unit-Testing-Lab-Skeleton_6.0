using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void Test1()
        {

        }
        //make tests for Dummy class
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            dummy.TakeAttack(5);

            //Assert
            Assert.That(dummy.Health, Is.EqualTo(5));
        }
        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            //Assert
            Assert.That(() => dummy.TakeAttack(5), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }
        [Test]
        public void DeadDummyCanGiveXP()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            int xp = dummy.GiveExperience();

            //Assert
            Assert.That(xp, Is.EqualTo(10));
        }
        [Test]
        public void AliveDummyCantGiveXP()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            //Assert
            Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }
        [Test]
        public void DummyLosesHealthIfAttackedWithAxe()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(5, 5);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.That(dummy.Health, Is.EqualTo(5));
        }
        [Test]
        public void DummyThrowsExceptionIfAttackedWithBrokenAxe()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(5, 0);

            //Act
            //Assert
            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
        
    
        //test dummy constructor
        [Test]
        public void DummyConstructorShouldSetHealthCorrectly()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            //Assert
            Assert.That(dummy.Health, Is.EqualTo(10));
        }
        [Test]
     //test dummy experience
     public void DummyConstructorShouldSetExperienceCorrectly()
        {
            //Arrange
            Dummy dummy = new Dummy(0,10);

            //Act
            //Assert
            Assert.That(dummy.GiveExperience(), Is.EqualTo(10));
        }
        [Test]
        public void DummyShouldBeAliveIfHealthIsPositive()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            //Assert
            Assert.That(dummy.IsDead(), Is.EqualTo(false));
        }
        [Test]
        public void DummyShouldBeDeadIfHealthIsZero()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            //Assert
            Assert.That(dummy.IsDead(), Is.EqualTo(true));
        }
        [Test]
        public void DummyShouldBeDeadIfHealthIsNegative()
        {
            //Arrange
            Dummy dummy = new Dummy(-10, 10);

            //Act
            //Assert
            Assert.That(dummy.IsDead(), Is.EqualTo(true));
        }
        //test dummy.isdead
        [Test]
        public void DummyShouldBeDeadIfHealthIsZeroOrNegative()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            //Assert
            Assert.That(dummy.IsDead(), Is.EqualTo(true));
        }
        //test dummy.giveexperience
        [Test]
        public void DummyShouldGiveXPIfDead()
        {
            //Arrange
            Dummy dummy = new Dummy(0, 10);

            //Act
            //Assert
            Assert.That(dummy.GiveExperience(), Is.EqualTo(10));
        }
        [Test]
        public void DummyShouldNotGiveXPIfAlive()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            //Assert
            Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
        }
        [Test]
        public void DummyShouldLoseHealthIfAttacked()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);

            //Act
            dummy.TakeAttack(5);

            //Assert
            Assert.That(dummy.Health, Is.EqualTo(5));
        }

    }
}
using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        private Dummy deadDummy;
        private int health;
        private int experience;

        [SetUp]
        public void SetUp()
        {
            health = 20;
            experience = 50;
            dummy = new Dummy(health, experience);
            deadDummy = new Dummy(health, experience);
            deadDummy.TakeAttack(health + 5);
        }

        [Test]
        public void DummyConstructorSettingDataProperly()
        {
            Assert.AreEqual(health, dummy.Health);
        }

        [Test]
        public void DummyLoosesHealth_WhenAttacked()
        {
            dummy.TakeAttack(10);
            Assert.AreEqual(health - 10, dummy.Health);
        }

        [Test]
        public void DummyTrowException_WhenHealthIsZero()
        {
            dummy.TakeAttack(health);

            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(5);
            });
        }

        [Test]
        public void DummyTrowException_WhenHealthIsNeggative()
        {
           
            Assert.Throws<InvalidOperationException>(() =>
            {
                deadDummy.TakeAttack(5);
            });
        }

        [Test]
        public void DummyGiveExperience_WhenIsDead()
        {
            var dummyExperience = deadDummy.GiveExperience();

            Assert.AreEqual(experience, dummyExperience);
        }

        [Test]
        public void DummyTrowException_WhenHealthIsAlive()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }

    }
}
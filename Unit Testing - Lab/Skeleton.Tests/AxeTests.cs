using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Dummy dummy;
        private Axe axe;
        private int attackPoints;
        private int durabilityPoints;

        [SetUp]
        public void SetUp()
        {
            attackPoints = 20;
            durabilityPoints = 30;
            axe = new Axe(attackPoints, durabilityPoints);
            dummy = new Dummy(100, 100);
        }

        [Test]
        public void AxeConstructorSettingDataProperly ()
        {
            Assert.AreEqual(attackPoints, axe.AttackPoints);
            Assert.AreEqual(durabilityPoints, axe.DurabilityPoints);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            for (int i = 0; i < 5; i++)
            {
                axe.Attack(dummy);
            }

            Assert.AreEqual(durabilityPoints - 5, axe.DurabilityPoints);
        }

        [Test]
        public void AxeShouldTrowException_WhenDurabilityIsZero()
        {
            Axe axe = new Axe(50, 0);
            Assert.Throws<InvalidOperationException>((()=>
            {
                axe.Attack(dummy);
            }));
        }

        [Test]
        public void AxeShouldTrowException_WhenDurabilityIsNeggative()
        {
            Axe axe = new Axe(10, -15);
            Assert.Throws<InvalidOperationException>((() =>
            {
                axe.Attack(dummy);
            }));
        }
    }
}
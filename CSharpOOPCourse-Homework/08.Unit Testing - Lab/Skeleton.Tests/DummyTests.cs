using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int axeAttackPoints = 13;
        private const int axeDurability = 5;

        private const int dummyHealth = 18;
        private const int dummyExperience = 20;

        private const int zeroValue = 0;

        private int initialDummyHealth;
        private int currentDummyHealth;
        private TestDelegate testDelegate;
        private Axe axe;
        private Dummy dummyTarget;

        [SetUp]
        public void Initialize()
        {
            axe = new Axe(axeAttackPoints, axeDurability);
            dummyTarget = new Dummy(dummyHealth, dummyExperience);
            initialDummyHealth = dummyTarget.Health;
        }

        [Test]
        public void When_DummyIsAttacked_ShouldLoseHealth()
        {
            AttackDummy();
            currentDummyHealth = dummyTarget.Health;

            Assert.AreNotEqual(currentDummyHealth, initialDummyHealth);
        }

        [Test]
        public void When_DummyIsDead_ExceptionShouldBeThrown()
        {
            KillDummy();

            testDelegate = () =>
            {
                AttackDummy();
            };

            CatchAssertion();
        }

        [Test]
        public void When_DummyIsDead_ExperienceShouldBeGiven()
        {
            KillDummy();

            int xp = dummyTarget.GiveExperience();

            Assert.That(() => xp > zeroValue);
        }

        [Test]
        public void When_DummyIsAlive_ExperienceShouldNotBeGiven()
        {
            testDelegate = () =>
            {
                dummyTarget.GiveExperience();
            };

            CatchAssertion();
        }

        private void AttackDummy()
        {
            axe.Attack(dummyTarget);
        }

        private void KillDummy()
        {
            while (!dummyTarget.IsDead())
            {
                AttackDummy();
            }
        }

        private void CatchAssertion()
        {
            Assert.Catch(testDelegate);
        }
    }
}
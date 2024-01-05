using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int axeAttackPoints = 1;
        private const int axeDurability = 5;
        private const int brokenAxeValue = 0;

        private const int dummyHealth = 18;
        private const int dummyExperience = 20;

        private int initialDurabilityPoints;
        private int currentDurabilityPoints;
        private Axe axe;
        private Dummy dummyTarget;

        [SetUp]
        public void Initialize()
        {
            axe = new Axe(axeAttackPoints, axeDurability);
            initialDurabilityPoints = axe.DurabilityPoints;
            dummyTarget = new Dummy(dummyHealth, dummyExperience);
        }

        [Test]
        public void When_AttackWithAxe_Weapon_ShouldLoseDurability()
        {
            AttackDummy();
            currentDurabilityPoints = axe.DurabilityPoints;

            Assert.AreNotEqual(initialDurabilityPoints, currentDurabilityPoints);
        }

        [Test]
        public void When_AttackingWithBroken_Weapon_ExceptionShouldBeThrown()
        {
            while (axe.DurabilityPoints != brokenAxeValue)
            {
                AttackDummy();
            }

            TestDelegate testDelegate = () => 
            {
                AttackDummy();
            };

            Assert.Catch(testDelegate);
        }

        private void AttackDummy()
        {
            axe.Attack(dummyTarget);
        }
    }
}
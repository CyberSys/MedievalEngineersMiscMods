using System;
using Equinox76561198048419394.Core.Modifiers.Data;
using NUnit.Framework;
using VRageMath;

namespace EquinoxCoreTests
{
    [TestFixture]
    public class TestModifierDataSerialization
    {
        [Test]
        public void TestDataColor()
        {
            foreach (var color in Color.AllNamedColors)
            {
                var data = new ModifierDataColor(color);
                var compared = new ModifierDataColor(data.Serialize());
                Assert.AreEqual(data.Raw, compared.Raw);
            }
        }
    }
}
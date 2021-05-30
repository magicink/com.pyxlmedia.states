using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.PlayMode.States.Factories
{
    public class StateControllerFactoryTests
    {
        [UnityTest]
        public IEnumerator StateControllerFactoryInitializes()
        {
            var gameObject = new GameObject();
            gameObject.AddComponent<TestFactory>();
            Assert.That(TestFactory.Instance, Is.InstanceOf<TestStateController>());
            yield return null;
        }
    }
}
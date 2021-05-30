using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.PlayMode.States.Controllers
{
    public class StateControllerTests
    {
        [UnityTest]
        public IEnumerator SetState()
        {
            var gameObject = new GameObject();
            gameObject.AddComponent<TestStateController>();
            var testStateController = gameObject.GetComponent<TestStateController>();
            Assert.That(testStateController.CurrentState, Is.InstanceOf<TestState>());
            Assert.That(testStateController.GameObject, Is.InstanceOf<GameObject>());
            yield return null;
        }
    }
}
using PyxlMedia.States.Factories;

namespace Tests.PlayMode.States.Controllers
{
    public class TestStateController : PyxlMedia.States.Controllers.StateController
    {
        private readonly TestState _testState = StateFactory<TestState>.Instance;

        private void Awake()
        {
            SetState(_testState);
        }
    }
}
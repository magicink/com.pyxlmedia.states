using com.pyxlmedia.core.States;
using UnityEngine;

namespace com.pyxlmedia.core.Controllers
{
    public interface IStateController
    {
        GameObject GameObject { get; }
        State CurrentState { get; set; }
        void SetState(State state);
    }
}
using UnityEngine;

namespace PyxlMedia.States.Controllers
{
    public interface IStateController
    {
        GameObject GameObject { get; }
        State CurrentState { get; set; }
        void SetState(State state);
    }
}
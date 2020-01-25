using PyxlMedia.States;
using UnityEngine;

namespace PyxlMedia.Controllers
{
    public interface IStateController
    {
        GameObject GameObject { get; }
        State CurrentState { get; set; }
        void SetState(State state);
    }
}
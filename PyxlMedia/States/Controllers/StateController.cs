using UnityEngine;

namespace PyxlMedia.States.Controllers
{
    public abstract class StateController : MonoBehaviour, IStateController
    {
        public GameObject GameObject => gameObject;
        public State CurrentState { get; set; }
        
        public virtual void SetState(State state)
        {
            if (CurrentState == state) return;
            CurrentState?.Exit(this);
            CurrentState = state;
            CurrentState?.Enter(this);
        }
        
        private void FixedUpdate()
        {
            CurrentState?.FixedUpdate(this);
        }

        private void LateUpdate()
        {
            CurrentState?.LateUpdate(this);
        }

        private void Update()
        {
            CurrentState?.Update(this);
        }

        private void OnDestroy()
        {
            CurrentState?.OnDestroy(this);
        }

        private void OnEnable()
        {
            CurrentState?.OnEnable(this);
        }
    }
}
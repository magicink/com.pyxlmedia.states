using PyxlMedia.States.Controllers;
using UnityEngine;

namespace PyxlMedia.States
{
    public abstract class State<T> : IState<T> where T : IStateController
    {
        public virtual void Enter(T controller) {}

        public virtual void Exit(T controller) {}

        public virtual void FixedUpdate(T controller) {}

        public virtual void LateUpdate(T controller) {}

        public virtual void Update(T controller) {}

        public virtual void OnCollisionEnter(T controller, Collision other) {}

        public virtual void OnCollisionExit(T controller, Collision other) {}

        public virtual void OnCollisionStay(T controller, Collision other) {}

        public virtual void OnCollisionEnter2D(T controller, Collision2D other) {}

        public virtual void OnCollisionExit2D(T controller, Collision2D other) {}

        public virtual void OnCollisionStay2D(T controller, Collision2D other) {}

        public virtual void OnTriggerEnter(T controller, Collider other) {}

        public virtual void OnTriggerExit(T controller, Collider other) {}

        public virtual void OnTriggerStay(T controller, Collider other) {}

        public virtual void OnTriggerEnter2D(T controller, Collider2D other) {}

        public virtual void OnTriggerExit2D(T controller, Collider2D other) {}

        public virtual void OnTriggerStay2D(T controller, Collider2D other) {}
    }
    
    public abstract class State : State<IStateController>
    {
        public static T Get<T>(IStateController controller)
        {
            return controller.GameObject.GetComponent<T>();
        }
    }
}
using com.pyxlmedia.core.Controllers;
using UnityEngine;

namespace com.pyxlmedia.core.States
{
    public interface IState<in T> where T : IStateController
    {
        void Enter(T controller);
        void Exit(T controller);
        
        void FixedUpdate(T controller);
        void LateUpdate(T controller);
        void Update(T controller);
        
        void OnCollisionEnter(T controller, Collision other);
        void OnCollisionExit(T controller, Collision other);
        void OnCollisionStay(T controller, Collision other);
        void OnCollisionEnter2D(T controller, Collision2D other);
        void OnCollisionExit2D(T controller, Collision2D other);
        void OnCollisionStay2D(T controller, Collision2D other);
        
        void OnTriggerEnter(T controller, Collider other);
        void OnTriggerExit(T controller, Collider other);
        void OnTriggerStay(T controller, Collider other);
        void OnTriggerEnter2D(T controller, Collider2D other);
        void OnTriggerExit2D(T controller, Collider2D other);
        void OnTriggerStay2D(T controller, Collider2D other);
    }
}
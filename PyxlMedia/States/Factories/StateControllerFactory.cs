using PyxlMedia.States.Controllers;

namespace PyxlMedia.States.Factories
{
    /**
     * Used to create a thread-safe, singleton instance of a
     * state controller.
     */
    public abstract class StateControllerFactory<T> : StateController where T : StateController
    {
        private static bool _destroyed;
        private static T _instance;
        private static readonly object Lock = new object();

        public static T Instance
        {
            get
            {
                if (_destroyed) return null;
                lock (Lock)
                {
                    return _instance;
                }
            }
            set
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = value;
                        DontDestroyOnLoad(value);
                    }
                    else
                    {
                        Destroy(value);
                    }
                }
            }
        }

        private void Awake()
        {
            gameObject.AddComponent<T>();
            Instance = gameObject.GetComponent<T>();
        }

        public override void SetState(State state)
        {
            Instance.CurrentState?.Exit(this);
            Instance.CurrentState = state;
            Instance.CurrentState?.Enter(this);
        }

        private void OnApplicationQuit()
        {
            _destroyed = true;
        }
        
    }
}
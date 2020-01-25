using System;
using com.pyxlmedia.core.States;

namespace com.pyxlmedia.core.Factories
{
    public sealed class StateFactory<T> where T : State, new()
    {
        private static readonly Lazy<T> Lazy = new Lazy<T>(() => new T());
        public static T Instance => Lazy.Value;
    }
}
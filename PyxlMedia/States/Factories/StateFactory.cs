using System;

namespace PyxlMedia.States.Factories
{
    public sealed class StateFactory<T> where T : State, new()
    {
        private static readonly Lazy<T> Lazy = new Lazy<T>(() => new T());
        public static T Instance => Lazy.Value;
    }
}
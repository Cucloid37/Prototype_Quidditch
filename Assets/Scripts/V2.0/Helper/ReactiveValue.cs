using System;
using System.Collections.Generic;

namespace V2._0
{
    public class ReactiveValue<T> : IDisposable
    {
        private T currentState;

        private readonly EqualityComparer<T> comparer;
        public event Action<T> OnChange;

        public ReactiveValue()
        {
            comparer = EqualityComparer<T>.Default;
        }

        public ReactiveValue(T defaultValue)
        {
            currentState = defaultValue;
            comparer = EqualityComparer<T>.Default;
        }

        public T CurrentValue
        {
            get => currentState;
            set
            {
                if (value == null && currentState == null)
                    return;
                if (value == null || !comparer.Equals(currentState, value))
                {
                    currentState = value;
                    OnChange?.Invoke(currentState);
                }
            }
        }

        public void Signal()
        {
            OnChange?.Invoke(currentState);
        }

        public void Dispose()
        {
            OnChange = null;
        }
    }
}
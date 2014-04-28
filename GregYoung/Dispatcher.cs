using System;
using System.Collections.Generic;

namespace GregYoung
{
    public class Dispatcher
    {
        private readonly Dictionary<Type, Action<ICommand>> _dictionary = new Dictionary<Type, Action<ICommand>>();

        public void Register<TCommand>(Action<TCommand> func) where TCommand : ICommand
        {
            _dictionary.Add(typeof(TCommand), x => func((TCommand)x));
        }

        public void Dispatch(ICommand m)
        {
            Action<ICommand> handler;
            if (!_dictionary.TryGetValue(m.GetType(), out handler))
            {
                throw new Exception("cannot map " + m.GetType());
            }
            handler(m);
        }
    }
}
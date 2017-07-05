using System;
using System.Collections.Generic;
using System.Linq;

namespace TypeSafeEnumPattern
{
    public class Forum
    {
        public string Title { get; private set; }
        public State State { get; private set; }

        public Forum(string title)
        {
            Title = title;
            State = State.Open;
        }

        public void ChangeState(State state)
        {
            State = state;
        }
    }

    public enum States
    {
        Open = 1,
        Closed = 2
    }

    public sealed class State
    {
        public static readonly State Open = new State(1, nameof(Open));
        public static readonly State Closed = new State(2, nameof(Closed));

        public readonly int Id;
        public readonly string Name;

        private State(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static IReadOnlyCollection<State> GetStates()
        {
            return new[] { Open, Closed };
        }

        public static State FindBy(int id)
        {
            var state = GetStates().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentOutOfRangeException($"Invalid id {id}");
            }

            return state;
        }
    }
}

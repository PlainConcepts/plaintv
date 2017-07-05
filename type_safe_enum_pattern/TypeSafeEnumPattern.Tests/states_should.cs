using Xunit;
using FluentAssertions;
using System;

namespace TypeSafeEnumPattern.Tests
{
    public class states_should
    {
        [Fact]
        public void returns_a_state_if_id_exists()
        {
            var state = State.FindBy(State.Open.Id);

            state.Should().NotBeNull();
            state.Name.Should().Be(State.Open.Name);
        }

        [Fact]
        public void throws_an_exception_if_the_id_does_not_exists()
        {
            Action action = () => State.FindBy(3);

            action.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}

using Xunit;
using FluentAssertions;

namespace TypeSafeEnumPattern.Tests
{
    public class forum_should
    {
        [Fact]
        public void allows_to_change_his_state()
        {
            var forum = new Forum("Forocoches");
            forum.ChangeState(State.Closed);
            forum.State.Should().Be(State.Closed);
        }
    }
}

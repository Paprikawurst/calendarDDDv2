using System;
using calendarDDD.Domain.AggregateModels.UserAggregate;
using Xunit;

namespace calendarDDD.Domain.Test
{
    public class UserEntityTests
    {
        [Fact]
        public void UserEntityAlwaysUniqueGuid()
        {
            UserEntity user1 = new UserEntity
            {
                Id = Guid.NewGuid(),
                PreName = "Test",
                SurName = "Test",
                Team = null
            };

            UserEntity user2 = new UserEntity
            {
                Id = Guid.NewGuid(),
                PreName = "Test",
                SurName = "Test",
                Team = null
            };

            Assert.NotEqual(user1, user2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Identity;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Identity
{
    [TestFixture]
    public class UserTests
    {

        [Test]
        public void CreateUser_should_throw_exception_if_email_is_invalid()
        {
            Action action = () => new User(Guid.NewGuid(), "wrong email");

            action.Should().Throw<Exception>();
        }
    }
}

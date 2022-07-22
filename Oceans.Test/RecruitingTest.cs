using System;
using System.Collections.Generic;
using Xunit;
using Oceans.Exercise;

namespace Oceans.Test
{
    public class RecruitingTest
    {
        [Fact]
        public void Test1_SubscriptionsExpiredLastMonth()
        {
            var date = DateTime.Now.AddMonths(-1);

            var subscriptions = new List<Subscription>
            {
                new Subscription(date.Month, date.Year) { Name = "Netflix" },
                new Subscription(date.Month, date.Year) { Name = "Amazon Prime" }
            };

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.True(user.ExpiredSubscriptions == 2, $"Expected expired subscriptions: 2 - Your code returns: {user.ExpiredSubscriptions}");
        }

        [Fact]
        public void Test2_SubscriptionsExpiringNextMonth()
        {
            var date = DateTime.Now.AddMonths(1);

            var subscriptions = new List<Subscription>
            {
                new Subscription(date.Month, date.Year) { Name = "Netflix" },
                new Subscription(date.Month, date.Year) { Name = "Amazon Prime" }
            };

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.True(user.ExpiredSubscriptions == 0, $"Expected expired subscriptions: 0 - Your code returns: {user.ExpiredSubscriptions}");
        }

        [Fact]
        public void Test3_SubscriptionsExpiredLastYear()
        {
            var date = DateTime.Now.AddYears(-1);

            var subscriptions = new List<Subscription>
            {
                new Subscription(date.Month, date.Year) { Name = "Netflix" },
                new Subscription(date.Month, date.Year) { Name = "Amazon Prime" }
            };

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.True(user.ExpiredSubscriptions == 2, $"Expected expired subscriptions: 2 - Your code returns: {user.ExpiredSubscriptions}");
        }

        [Fact]
        public void Test4_SubscriptionsExpiredLastYearPreviousMonth()
        {
            var date = DateTime.Now.AddYears(-1).AddMonths(-1);

            var subscriptions = new List<Subscription>
            {
                new Subscription(date.Month, date.Year) { Name = "Netflix" },
                new Subscription(date.Month, date.Year) { Name = "Amazon Prime" }
            };

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.True(false, "Finish this test and remove this line");
        }

        [Fact]
        public void Test5_SubscriptionsExpiringNextYearNextMonth()
        {
            Assert.True(false, "Implement this test and remove this line");
        }

        [Fact]
        public void Test6_UserInformationUpdates()
        {
            var date = DateTime.Now;

            var subscriptions = new List<Subscription>
            {
                new Subscription(date.Month, date.Year) { Name = "Netflix" },
                new Subscription(date.Month, date.Year) { Name = "Amazon Prime" }
            };

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            user.UpdateUserName();

            Assert.True(user.Name == "Oceans Code Experts", "User name updated unsuccessfully");

            user.UpdateUserInformation();

            Assert.True(user.Name == "Recruiting Oceans Code Experts", "User name updated unsuccessfully after tuple management");
        }

        [Fact]
        public void Test7_OptionalFluentAssertions_SubscriptionsExpiredLastMonth()
        {
            var date = DateTime.Now.AddMonths(-1);

            var subscriptions = new List<Subscription>
            {
                new Subscription(date.Month, date.Year) { Name = "Netflix" },
                new Subscription(date.Month, date.Year) { Name = "Amazon Prime" }
            };

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.True(false, "Implement this using fluent assertions and remove this line");
        }
    }
}
// filepath: /workspaces/APL2007M4PrimeService/Numbers/PrimeServiceTest.cs
using System;
using Xunit;

namespace System.Numbers.UnitTests
{
    public class PrimeServiceTest
    {
        private readonly PrimeService _primeService;

        public PrimeServiceTest()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void IsPrime_InputIs1_ReturnsFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void IsPrime_InputIs3_ReturnsTrue()
        {
            var result = _primeService.IsPrime(3);
            Assert.True(result, "3 should be prime");
        }

        [Fact]
        public void IsPrime_InputIs4_ReturnsFalse()
        {
            var result = _primeService.IsPrime(4);
            Assert.False(result, "4 should not be prime");
        }

        [Fact]
        public void IsPrime_InputIs5_ReturnsTrue()
        {
            var result = _primeService.IsPrime(5);
            Assert.True(result, "5 should be prime");
        }

        [Fact]
        public void IsPrime_InputIs29_ReturnsTrue()
        {
            var result = _primeService.IsPrime(29);
            Assert.True(result, "29 should be prime");
        }

        [Fact]
        public void IsPrime_InputIs30_ReturnsFalse()
        {
            var result = _primeService.IsPrime(30);
            Assert.False(result, "30 should not be prime");
        }
    }
}
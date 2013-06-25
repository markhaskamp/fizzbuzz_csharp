using System;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class Class1
    {
        private global::FizzBuzz.FizzBuzz fb;

        [SetUp]
        public void SetUp() {
            fb = new global::FizzBuzz.FizzBuzz();
        }

        [Test]
        public void Mod_1_returns_n() {
            Assert.AreEqual("1", fb.FizzBuzzerate(1));
        }

        [Test]
        public void divisible_by_3_means_fizz() {
            Assert.AreEqual("fizz", fb.FizzBuzzerate(3));
        }

        [Test]
        public void divisible_by_5_means_buzz() {
            Assert.AreEqual("buzz", fb.FizzBuzzerate(5));
        }

        [Test]
        public void divisible_by_3_and_5_means_fizzbuzz_15() {
            Assert.AreEqual("fizzbuzz", fb.FizzBuzzerate(15));
        }

        [Test]
        public void divisible_by_3_and_5_means_fizzbuzz_30() {
            Assert.AreEqual("uh, wut?", fb.FizzBuzzerate(30));
        }
    }
}

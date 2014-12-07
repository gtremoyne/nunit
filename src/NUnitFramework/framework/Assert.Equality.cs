// ***********************************************************************
// Copyright (c) 2014 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;
using NUnit.Framework.Internal;

namespace NUnit.Framework
{
    public partial class Assert
    {
        #region AreEqual

        #region Ints

        /// <summary>
        /// Verifies that two ints are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(int expected, int actual, string message, params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two ints are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(int expected, int actual, string message)
        {
            Assert.That(actual, Is.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two ints are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(int expected, int actual)
        {
            Assert.That(actual, Is.EqualTo(expected), null, null);
        }

        #endregion

        #region Longs

        /// <summary>
        /// Verifies that two longs are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(long expected, long actual, string message, params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two longs are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(long expected, long actual, string message)
        {
            Assert.That(actual, Is.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two longs are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(long expected, long actual)
        {
            Assert.That(actual, Is.EqualTo(expected), null, null);
        }

        #endregion

        #region Unsigned Ints

        /// <summary>
        /// Verifies that two unsigned ints are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreEqual(uint expected, uint actual, string message, params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two unsigned ints are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreEqual(uint expected, uint actual, string message)
        {
            Assert.That(actual, Is.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two unsigned ints are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreEqual(uint expected, uint actual)
        {
            Assert.That(actual, Is.EqualTo(expected), null, null);
        }

        #endregion

        #region Unsigned Longs

        /// <summary>
        /// Verifies that two unsigned longs are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreEqual(ulong expected, ulong actual, string message, params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two unsigned longs are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreEqual(ulong expected, ulong actual, string message)
        {
            Assert.That(actual, Is.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two unsigned longs are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreEqual(ulong expected, ulong actual)
        {
            Assert.That(actual, Is.EqualTo(expected), null, null);
        }

        #endregion

        #region Decimals

        /// <summary>
        /// Verifies that two decimals are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(decimal expected, decimal actual, string message, params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two decimals are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(decimal expected, decimal actual, string message)
        {
            Assert.That(actual, Is.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two decimals are equal. If they are not, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(decimal expected, decimal actual)
        {
            Assert.That(actual, Is.EqualTo(expected), null, null);
        }

        #endregion

        #region Doubles

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="AssertionException"/> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(double expected, double actual, double delta, string message, params object[] args)
        {
            AssertDoublesAreEqual(expected, actual, delta, message, args);
        }
        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="AssertionException"/> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(double expected, double actual, double delta, string message)
        {
            AssertDoublesAreEqual(expected, actual, delta, message, null);
        }
        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="AssertionException"/> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        public static void AreEqual(double expected, double actual, double delta)
        {
            AssertDoublesAreEqual(expected, actual, delta, null, null);
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="AssertionException"/> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(double expected, double? actual, double delta, string message, params object[] args)
        {
            AssertDoublesAreEqual(expected, (double)actual, delta, message, args);
        }
        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="AssertionException"/> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(double expected, double? actual, double delta, string message)
        {
            AssertDoublesAreEqual(expected, (double)actual, delta, message, null);
        }
        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If 
        /// they are not equal then an <see cref="AssertionException"/> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        public static void AreEqual(double expected, double? actual, double delta)
        {
            AssertDoublesAreEqual(expected, (double)actual, delta, null, null);
        }

        #endregion

        #region Objects

        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(object expected, object actual, string message, params object[] args)
        {
            Assert.That(actual, Is.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(object expected, object actual, string message)
        {
            Assert.That(actual, Is.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(object expected, object actual)
        {
            Assert.That(actual, Is.EqualTo(expected), null, null);
        }

        #endregion

        #endregion

        #region AreNotEqual

        #region Ints

        /// <summary>
        /// Verifies that two ints are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(int expected, int actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two ints are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(int expected, int actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two ints are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(int expected, int actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #region Longs

        /// <summary>
        /// Verifies that two longs are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(long expected, long actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two longs are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(long expected, long actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two longs are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(long expected, long actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #region Unsigned Ints

        /// <summary>
        /// Verifies that two unsigned ints are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(uint expected, uint actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two unsigned ints are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(uint expected, uint actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two unsigned ints are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(uint expected, uint actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #region Unsigned Longs

        /// <summary>
        /// Verifies that two unsigned longs are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(ulong expected, ulong actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two unsigned longs are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(ulong expected, ulong actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two unsigned longs are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(ulong expected, ulong actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #region Decimals

        /// <summary>
        /// Verifies that two decimals are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(decimal expected, decimal actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two decimals are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(decimal expected, decimal actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two decimals are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(decimal expected, decimal actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #region Floats

        /// <summary>
        /// Verifies that two floats are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(float expected, float actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two floats are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(float expected, float actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two floats are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(float expected, float actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #region Doubles

        /// <summary>
        /// Verifies that two doubles are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(double expected, double actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two doubles are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(double expected, double actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two doubles are not equal. If they are equal, then an 
        /// <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(double expected, double actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #region Objects

        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(object expected, object actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, args);
        }
        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(object expected, object actual, string message)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), message, null);
        }
        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(object expected, object actual)
        {
            Assert.That(actual, Is.Not.EqualTo(expected), null, null);
        }

        #endregion

        #endregion

        #region AreSame

        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreSame(object expected, object actual, string message, params object[] args)
        {
            Assert.That(actual, Is.SameAs(expected), message, args);
        }
        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreSame(object expected, object actual, string message)
        {
            Assert.That(actual, Is.SameAs(expected), message, null);
        }
        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        public static void AreSame(object expected, object actual)
        {
            Assert.That(actual, Is.SameAs(expected), null, null);
        }

        #endregion

        #region AreNotSame

        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotSame(object expected, object actual, string message, params object[] args)
        {
            Assert.That(actual, Is.Not.SameAs(expected), message, args);
        }
        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotSame(object expected, object actual, string message)
        {
            Assert.That(actual, Is.Not.SameAs(expected), message, null);
        }
        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="AssertionException"/> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        public static void AreNotSame(object expected, object actual)
        {
            Assert.That(actual, Is.Not.SameAs(expected), null, null);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Helper for Assert.AreEqual(double expected, double actual, ...)
        /// allowing code generation to work consistently.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        protected static void AssertDoublesAreEqual(double expected, double actual, double delta, string message, object[] args)
        {
            if (double.IsNaN(expected) || double.IsInfinity(expected))
                Assert.That(actual, Is.EqualTo(expected), message, args);
            else
                Assert.That(actual, Is.EqualTo(expected).Within(delta), message, args);
        }

        private static void IncrementAssertCount()
        {
            TestExecutionContext.CurrentContext.IncrementAssertCount();
        }

        #endregion
    }
}
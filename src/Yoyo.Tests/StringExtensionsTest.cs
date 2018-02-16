using System;
using Yoyo.Extensions;

namespace Yoyo.Tests
{
	using NUnit.Framework;

	[TestFixture]
	public class StringExtensionsTest
	{
		[Test]
		public void ToEnum()
		{
			var a = ((string) null).ToEnum<DayOfWeek>();
			var b = "".ToEnum<DayOfWeek>();
			var c = " ".ToEnum<DayOfWeek>();

			Assert.AreEqual(default(DayOfWeek), a);
			Assert.AreEqual(default(DayOfWeek), b);
			Assert.AreEqual(default(DayOfWeek), c);
		}

		[Test]
		public void ToEnum1()
		{
			var a = "Monday".ToEnum<DayOfWeek>();
			var b = "monday".ToEnum<DayOfWeek>();

			Assert.AreEqual(DayOfWeek.Monday, a);
			Assert.AreEqual(DayOfWeek.Monday, b);
		}

		[Test]
		public void ToEnum2()
		{
			var a = "Monday".ToEnum<DayOfWeek>(false);
			var b = "monday".ToEnum<DayOfWeek>(false);

			Assert.AreEqual(DayOfWeek.Monday, a);
			Assert.AreEqual(default(DayOfWeek), b);
		}
	}
}
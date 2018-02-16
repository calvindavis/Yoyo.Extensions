using System;
using Yoyo.Extensions;

namespace Yoyo.Tests
{
	using NUnit.Framework;

	[TestFixture]
	public class StringExtensionsTest
	{
		private static DayOfWeek DefaultDayOfWeek => default(DayOfWeek);
		private static DayOfWeek Monday => DayOfWeek.Monday;

		[Test]
		public void ToEnumStringIsEmpty()
		{
			var a = ((string) null).ToEnum<DayOfWeek>();
			var b = "".ToEnum<DayOfWeek>();
			var c = " ".ToEnum<DayOfWeek>();

			Assert.That(a, Is.EqualTo(DefaultDayOfWeek));
			Assert.That(b, Is.EqualTo(DefaultDayOfWeek));
			Assert.That(c, Is.EqualTo(DefaultDayOfWeek));
		}

		[Test]
		public void ToEnum()
		{
			var a = "Monday".ToEnum<DayOfWeek>();
			var b = "monday".ToEnum<DayOfWeek>();

			Assert.That(a, Is.EqualTo(Monday));
			Assert.That(b, Is.EqualTo(Monday));
		}

		[Test]
		public void ToEnumIgnoreCaseIsFalse()
		{
			var a = "Monday".ToEnum<DayOfWeek>(false);
			var b = "monday".ToEnum<DayOfWeek>(false);

			Assert.That(a, Is.EqualTo(Monday));
			Assert.That(b, Is.EqualTo(DefaultDayOfWeek));
		}
	}
}
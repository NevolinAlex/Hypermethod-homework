#include "stdafx.h"
#include "CppUnitTest.h"
#include "../DateBoxing/DateExtension.h"
#include <iostream>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace BoxingText
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(DayOfWeekTests)
		{
			DateExtension date(31, 12, 2011);
			Assert::AreEqual(date.GetDayOfWeek(), std::string("Saturday"));

			DateExtension date1(19, 2, 2007);
			Assert::AreEqual(date1.GetDayOfWeek(), std::string("Monday"));

			DateExtension date2(1, 1, 1905);
			Assert::AreEqual(date2.GetDayOfWeek(), std::string("Sunday"));
			std::string temp = date2.PrintCalendar();

			DateExtension date3(14, 1, 2015);
			DateExtension date3_plus = date3.AddDays(366);

			Assert::AreEqual(15, date3_plus.day);
			Assert::AreEqual(1, date3_plus.month);
			Assert::AreEqual(2016, date3_plus.year);
			Logger::WriteMessage(temp.c_str());
		}
		TEST_METHOD(PrintCalendarTest) {
			DateExtension date(31, 12, 2011);
			std::string temp = date.PrintCalendar();
		}
		TEST_METHOD(AdditionDaysToDateTests)
		{
			DateExtension date1(14, 1, 2015);
			DateExtension date1_plus = date1.AddDays(366);
			Assert::AreEqual(15, date1_plus.day);
			Assert::AreEqual(1, date1_plus.month);
			Assert::AreEqual(2016, date1_plus.year);

			DateExtension date2(14, 1, 2015);
			DateExtension date2_plus = date2.AddDays(10);
			Assert::AreEqual(24, date2_plus.day);
			Assert::AreEqual(1
, date2_plus.month);
			Assert::AreEqual(2015, date2_plus.year);

			DateExtension date3(14, 3, 2015);
			DateExtension date3_plus = date3.AddDays(366);
			Assert::AreEqual(14, date3_plus.day);
			Assert::AreEqual(3, date3_plus.month);
			Assert::AreEqual(2016, date3_plus.year);
		}
		TEST_METHOD(CompareDates) {
			DateExtension date1(14, 1, 2015);
			DateExtension date2(14, 2, 2015);
			DateExtension date3(14, 1, 2015);

			Assert::AreEqual(true, date1 < date2);
			Assert::AreEqual(true, date2 > date1);
			Assert::AreEqual(true, date3 == date1);

		}
		TEST_METHOD(DatesDiffernce) {
			DateExtension date1(1, 2, 2000);
			DateExtension date2(1, 2, 2004);
			Assert::AreEqual(1461, date1.GetDiffernce(date2));

			DateExtension date3(1, 2, 2000);
			DateExtension date4(30, 2, 2000);
			Assert::AreEqual(29, date3.GetDiffernce(date4));
		}
	};
}
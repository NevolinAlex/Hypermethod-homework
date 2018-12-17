#include "pch.h"
#include "DateExtension.h"
#include <sstream>
#define _CRT_SECURE_NO_WARNINGS

using namespace std;

bool operator> (const DateExtension &d1, const DateExtension &d2)
{
	if (d1.year > d2.year)
		return true;
	if (d1.month > d2.month)
		return true;
	if (d1.day > d2.day)
		return true;
	return false;
}

bool operator< (const DateExtension &d1, const DateExtension &d2)
{
	if (d1.year < d2.year)
		return true;
	if (d1.month < d2.month)
		return true;
	if (d1.day < d2.day)
		return true;
	return false;
}

bool operator== (const DateExtension &d1, const DateExtension &d2)
{
	if (d1.year == d2.year && d1.month == d2.month && d1.day == d2.day)
		return true;
	return false;
}

bool operator!= (const DateExtension &d1, const DateExtension &d2)
{
	if (d1.year != d2.year || d1.month != d2.month || d1.day != d2.day)
		return true;
	return false;
}

const std::string DateExtension::months[12] = { "January", "February", "March",
					   "April", "May", "June",
					   "July", "August", "September",
					   "October", "November", "December"
};

DateExtension::DateExtension(int day, int month, int year) {
	this->day =	day;
	this->month = month;
	this->year = year;
	
}

std::string DateExtension::GetDayOfWeek()
{
	switch (DayNumber(day, month, year))
	{
		case 0:
			return "Monday";
		case 1:
			return "Tuesday";
		case 2:
			return "Wednesday";
		case 3:
			return "Thursday";
		case 4:
			return "Friday";
		case 5:
			return "Saturday";
		case 6:
			return "Sunday";
	}
}

int DateExtension::offsetDays()
{
	int offset = day;

	switch (month - 1)
	{
	case 11:
		offset += 30;
	case 10:
		offset += 31;
	case 9:
		offset += 30;
	case 8:
		offset += 31;
	case 7:
		offset += 31;
	case 6:
		offset += 30;
	case 5:
		offset += 31;
	case 4:
		offset += 30;
	case 3:
		offset += 31;
	case 2:
		offset += 28;
	case 1:
		offset += 31;
	}

	if (isLeap(year) && month > 2)
		offset += 1;

	return offset;
}

bool DateExtension::isLeap(int y)
{
	if (y % 100 != 0 && y % 4 == 0 || y % 400 == 0)
		return true;

	return false;
}

int DateExtension::GetDiffernce(DateExtension date2) {

	int monthDays[12] = { 31, 28, 31, 30, 31, 30,
						   31, 31, 30, 31, 30, 31 };
	// COUNT TOTAL NUMBER OF DAYS BEFORE FIRST DATE 'this' 

	// initialize count using years and day 
	long int n1 = year * 365 + day;

	// Add days for months in given date 
	for (int i = 0; i < month - 1; i++)
		n1 += monthDays[i];

	// Since every leap year is of 366 days, 
	// Add a day for every leap year 
	n1 += countLeapYears(*this);

	// SIMILARLY, COUNT TOTAL NUMBER OF DAYS BEFORE 'dt2' 

	long int n2 = date2.year * 365 + date2.day;
	for (int i = 0; i < date2.month - 1; i++)
		n2 += monthDays[i];
	n2 += countLeapYears(date2);

	// return difference between two counts 
	return (n2 - n1);
}

// This function counts number of leap years before the 
// given date 
int DateExtension::countLeapYears(DateExtension d)
{
	int years = d.year;

	// Check if the current year needs to be considered 
	// for the count of leap years or not 
	if (d.month <= 2)
		years--;

	// An year is a leap year if it is a multiple of 4, 
	// multiple of 400 and not a multiple of 100. 
	return years / 4 - years / 100 + years / 400;
}
DateExtension DateExtension::AddDays(int x)
{
	int offset1 = offsetDays();
	int remDays = isLeap(year) ? (366 - offset1) : (365 - offset1);

	// y2 is going to store result year and 
	// offset2 is going to store offset days 
	// in result year. 
	int y2, offset2;
	if (x <= remDays)
	{
		y2 = year;
		offset2 = offset1 + x;
	}

	else
	{
		// x may store thousands of days. 
		// We find correct year and offset 
		// in the year. 
		x -= remDays;
		y2 = year + 1;
		int y2days = isLeap(y2) ? 366 : 365;
		while (x >= y2days)
		{
			x -= y2days;
			y2++;
			y2days = isLeap(y2) ? 366 : 365;
		}
		offset2 = x;
	}

	// Find values of day and month from 
	// offset of result year. 
	int m2, d2;
	revoffsetDays(offset2, y2, &d2, &m2);

	return DateExtension(d2, m2, y2);
}

// Given a year and days elapsed in it, finds 
// date by storing results in d and m. 
void DateExtension::revoffsetDays(int offset, int y, int *d, int *m)
{
	int month[13] = { 0, 31, 28, 31, 30, 31, 30,
					  31, 31, 30, 31, 30, 31 };

	if (isLeap(y))
		month[2] = 29;

	int i;
	for (i = 1; i <= 12; i++)
	{
		if (offset <= month[i])
			break;
		offset = offset - month[i];
	}

	*d = offset;
	*m = i;
}


/*
  A Function that returns the name of the month
  with a given month number

  Month Number     Name
  0                January
  1                February
  2                March
  3                April
  4                May
  5                June
  6                July
  7                August
  8                September
  9                October
  10               November
  11               December */
std::string DateExtension::GetMonthName(int monthNumber)
{
	return months[monthNumber];
}

/* A Function to return the number of days in
   a month

  Month Number     Name        Number of Days
  0                January     31
  1                February    28 (non-leap) / 29 (leap)
  2                March       31
  3                April       30
  4                May         31
  5                June        30
  6                July        31
  7                August      31
  8                September   30
  9                October     31
  10               November    30
  11               December    31

*/
int DateExtension::NumberOfDaysInMonths(int monthNumber, int year)
{
	// January 
	if (monthNumber == 0)
		return (31);

	// February 
	if (monthNumber == 1)
	{
		// Високосный год
		if (year % 400 == 0 ||
			(year % 4 == 0 && year % 100 != 0))
			return (29);
		else
			return (28);
	}

	// March 
	if (monthNumber == 2)
		return (31);

	// April 
	if (monthNumber == 3)
		return (30);

	// May 
	if (monthNumber == 4)
		return (31);

	// June 
	if (monthNumber == 5)
		return (30);

	// July 
	if (monthNumber == 6)
		return (31);

	// August 
	if (monthNumber == 7)
		return (31);

	// September 
	if (monthNumber == 8)
		return (30);

	// October 
	if (monthNumber == 9)
		return (31);

	// November 
	if (monthNumber == 10)
		return (30);

	// December 
	if (monthNumber == 11)
		return (31);
}

/*A Function that returns the index of the day
  of the date- day/month/year
  For e.g-

  Index     Day
  0         Monday
  1         Tuesday
  2         Wednesday
  3         Thursday
  4         Friday
  5         Saturday
  6         Sunday*/
int DateExtension::DayNumber(int day, int month, int year)
{
	static int t[] = { 0, 3, 2, 5, 0, 3, 5, 1,
				   4, 6, 2, 4 };
	int year1 = year;
	year1 -= month < 3;
	return (year1 + year1 / 4 - year1 / 100 +
		year1 / 400 + t[month - 1] + day - 1) % 7;
}

std::string DateExtension::PrintCalendar()
{
	std::stringstream ss;
	ss << "         Calendar - ";
	ss << year;
	int days;

	// Index of the day from 0 to 6 
	int current = DayNumber(1, 1, year);

	// i --> Iterate through all the months 
	// j --> Iterate through all the days of the 
	//       month - i 
	for (int i = 0; i < 12; i++)
	{
		days = NumberOfDaysInMonths(i, year);
		// Print the current month name 
		ss << "\n  ------------";
		ss << GetMonthName(i).c_str();
		ss << "  ------------\n";

		// Print the columns 
		ss << "  Mon  Tue  Wed  Thu  Fri  Sat  Sun\n";

		// Print appropriate spaces 
		int k;
		for (k = 0; k < current; k++)
			ss << "     ";

		for (int j = 1; j <= days; j++)
		{
			char * buf= new char[5];
			int r = std::sprintf(buf, "%5d", j);
			ss << buf;

			if (++k > 6)
			{
				k = 0;
				ss << "\n";
			}
		}

		if (k)
			ss << "\n";

		current = k;
	}

	return ss.str();
}


DateExtension::~DateExtension()
{
}
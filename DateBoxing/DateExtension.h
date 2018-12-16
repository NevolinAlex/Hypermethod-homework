#pragma once
#include <string>
class DateExtension
{
public:
	int year;
	int month;
	int day;
	DateExtension(int day, int month, int year);
	std::string GetDayOfWeek();
	std::string PrintCalendar();
	friend bool operator> (const DateExtension &d1, const DateExtension &d2);
	friend bool operator< (const DateExtension &d1, const DateExtension &d2);
	friend bool operator== (const DateExtension &d1, const DateExtension &d2);
	friend bool operator!= (const DateExtension &d1, const DateExtension &d2);
	DateExtension AddDays(int x);
	int GetDiffernce(DateExtension date2);
	~DateExtension();
private:
	std::string GetMonthName(int monthNumber);
	int countLeapYears(DateExtension d);
	int offsetDays();
	bool isLeap(int y);
	int NumberOfDaysInMonths(int monthNumber, int year);
	int DayNumber(int day, int month, int year);
	void revoffsetDays(int offset, int y, int * d, int * m);
	static const std::string months[12];
};



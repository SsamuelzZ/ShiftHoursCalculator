// ShiftHoursCalc.cpp : Defines the entry point for the application.
//

#include "ShiftHoursCalc.h"

using namespace std;

/// <summary>
/// Main runtime entry point for ShiftHoursCalc
/// </summary>
/// <returns></returns>
int main()
{
	cout << "Shift Hours Calc V2, By Samuel Crouch" << endl;
	cout << "See license.md for more information about distribution" << endl;

	try {
		cout << "What is your hourly rate? £";
		cin >> hourlyPay;
		throw 505;
	}
	catch (int errorCode) {
		cout << "Please input your hourly rate!!" << endl;
	}
	cout << "What is your hourly rate? £";
	cin >> hourlyPay;
	

	cout << "What is your holiday pay percentage? Type 0 for £";
	cin >> holidayPercentage;
	return 0;
}

float InputCalc(float startTime, float EndTime) {
	return 0.0f;
}

float DecimalToSexagesimalCalc(float hoursAndMins) {
	return 0.0f;
}

float TotalAmountEarnedCalc(float timeWorked, float hourlyRate) {
	return 0.0f;
}

float HolidayPayCalculation(float totalAmountEarned, float holidayPayPercent) {
	return 0.0f;
}



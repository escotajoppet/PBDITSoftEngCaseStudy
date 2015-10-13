# PBDITSoftwareEngineeringCaseStudy
PBDIT Software Engineering Case Study


Using RAD tool such as Visual Basic, write a program that will compute time and billing of project
contractors for ABC Company.


# In order to accomplish the program, the programmer must be familiar with the following:
	- Control Structures – conditional and loop statements
	- Arrays
	- DateTimePicker control
	- Date and Time Functions
 	- Error Handling - MsgBox
	- String Manipulations
	- Text File Handling
	- Database


# Entity Relationship:
	Client has_many Projects
	Employee has_and_belongs_to_many Projects
	Project belongs_to Client
	Project has_and_belongs_to_many Employees
	

# Program Requirements:

1. Regular office hours are from 8:00 am to 5:00 pm, Mondays to Fridays. Each day, an employee is required to have at most 30-minute break time.

2. An employee is not allowed to work if there is only 2 and a half hours remaining for the day. For example, an employee is not allowed to log if the time is already past 3:45 pm.

3. Billing rates are based on the hourly rate of the employees.

4. If an employee works on Saturday, billing rate is 30% more than the standard rate.

5. An employee can work on multiple projects at a given time. For example, an employee loggedfor project “A” from 8:00 am to 12 noon can log or project “B” from 12:30 pm to 4:30 pm but cannot log for project “C” with 9:00 to 11:00 am.

6. When working on one project, the employee logs into the system to record the date and time.

7. Create a CRUD (A form with View Records, Add, Update, and Delete operations) Form for employees. The following data must be stored in a database: employee number, employee last name, first name, middle name, birthdate, rate per hour, employee type(employee type possible values –RANK_AND_FILE or PROJECT_MANAGER)

8. Create a CRUD (A form with View Records, Add, Update, and Delete operations) Form for projects. The following data must be stored in a database: project code, project name, project manager, project start date, project end date.

9. Create a CRUD Form for clients. The following data must be stored in a database: client code, client name, address, city, contact person, contact number.

10. Create a Form where a client can have one or more projects to be made. Make sure there are no conflict project schedules.

11. Create a Form where one or more employees can be assigned to one or more projects. Make sure there are no conflict employee project assignment as well as project schedules.

12. Create a Form where an employee can log-in/log out. When logging in, an employee must select a project input his employee number and password. When logging out, an employee must input his employee number and password.

13. View Search or Finder Form for:
		a. List of Clients
		b. List of Employees in a given Project
		c. List of Projects

14. A form that computes the billing hours spent by an employee on a specific project. The billing invoice will be export to a text file (there must be a Save To dialog) where contains the following: client information such as client code, name, address and employee information such as employee number, name, rate, billing date, total hours billed, total amount and amount due date. There are two ways to compute the billing invoice:

		d. Select a client then select one or more projects associated to its client.
		e. Select a range of clients then select one or more projects associated to its client.

15. Text File Layout
																			ABC Company
																		Billing Invoice

Client Code 																																Billing Date
Client Name
Client Address


																		Billing Details

Project code 															Project Name
Project Manager

Employee Number 												Name 											Rate 

Total Hours Billed
TOTAL NO. HOURS
Due Date
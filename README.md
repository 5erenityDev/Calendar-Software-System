# Calendar-Software-System
Final Group Project for CSC 340



CURRENT VALID USER LOGINS:


User 1 (EMPLOYEE):
- Username: Adkins
- Password: user1

User 2 (EMPLOYEE):
- Username: Blankenship
- Password: user2

User 3 (EMPLOYEE):
- Username: Blevins
- Password: user3

User 4 (EMPLOYEE):
- Username: Colfer
- Password: user4

User 5 (MANAGER):
- Username: Chang
- Password: user5

CURRENT TABLES:


csop_employee (EMPLOYEE/MANAGER/USER DATABASE)
- col 1: int empID
- col 2: varchar name
- col 3: varchar username
- col 4: varchar password
- col 5: int isManager (for whatever reason I couldn't make it a boolean value so for now 0 is false and 1 is true)

csop_event (EVENT/CALENDAR DATABASE)
- col 1: int evntID
- col 2: varchar title
- col 3: varchar description
- col 4: varchar location
- col 5: varchar startDate
- col 6: varchar endDate
- col 7: varchar attendants
- col 8: int empID
# recruitment-exercise-net-core

## Exercise

1. Complete the logic for the ExpiredSubscriptions property following the directions given.

	To complete this section take into account:
	The first 5 tests (Test1 to Test5) are related to the User.ExpiredSubscriptions property.
	The first three (Test1, Test2, Test3) are implemented already and should not be modified, and the other two (Test4, Test5) need to be completed.
	At running all the tests before doing any change, only the Test2 will pass right of the bat.

	- Implement the ExpiredSubscriptions property in User class. An user has a list of subscriptions, which in turn might contain expired subscriptions. This property must return the number of expired subscriptions that the user has. Be aware that you can do any coding you need in both the Subscription and the User classes to solve the exercise, after you implement this property correctly the first three tests should pass.

	- Implement the two remaining unit tests for ExpiredSubscriptions (Test4, Test5). For this, if you want you can copy and paste the code located in any of the previous existing tests. Keep in mind that you *will have to modify at most* two lines of code in order to make the two unit tests fulfill their purpose. The method name suggests what needs to be corrected and serves the purpose of instructing what the unit test is meant for.


	Note: Assume that the expiration date of a subscription works similar to how credit/debit cards work (they expire the last day of the month).
	Example: a subscription has an expiration date of Jan 31, 2019. If the current date is Feb 14, 2019, this subscription is considered as expired.

2. You need to make the Test6 pass, to do so you need to properly implement the methods UpdateUserName, UserInformation, UpdateUserInformation inside the User class. 
	The logic of each method must be consistent with its name, follow the instructions given in methods' comments.

## Keep in Mind
- You are allowed to ask any questions regarding the structure of the code.

- Feel free to do any research that can be of aid to solve the exercise.

- The scope of the exercise can be reduced or guided by the instructor during the exercise.


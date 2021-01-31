# Lesson 7 Part 1

1. Create a base class named Employee (don't forget the constructor). This class should contain the following string variables:

    - name
    - salary
    - hireDate

2. Add the following three methods to the Employee class — each should be virtual:

    - getName()
    - getSalary()
    - hiredDate()

3. Each of the above methods should print out the value of the corresponding variable along with a label.

        See below for the output.


4. Create a subclass named Engineer that inherits from Employee and includes a new string variable, schoolAttended. Don't forget the constructor.

5. Within the Main method, instantiate a new Engineer object and call each of the methods (from # 2).

6. Your output should look similar to the following: 

```zsh
Employee Name: Rupert Scott
Salary: 42000
Hire Date: 11/22/12
```
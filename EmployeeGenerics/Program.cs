using System.Collections.Generic;

namespace EmployeeGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------------In the Stack:-------------");
            Employee employee1 = new Employee(101, "Charles Xavier", "Male", 200000);
            Employee employee2 = new Employee(102, "Tony Stark", "Male", 100000);
            Employee employee3 = new Employee(103, "Jean Grey", "Female", 80000);
            Employee employee4 = new Employee(104, "Peter Parker", "Male", 40000);
            Employee employee5 = new Employee(105, "Bruce Banner", "Male", 60000);

            Stack<Employee> myStack = new Stack<Employee>();
            myStack.Push(employee1);
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);

            foreach (Employee stackItem in myStack)
            {
                Console.WriteLine($"ID: {stackItem.ID} - {stackItem.Name} - {stackItem.Gender} - {stackItem.Salary}");
                Console.WriteLine($"Items left in the stack = {myStack.Count}");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Retrieve Using Pop Method");

            while (myStack.Count > 0)
            {
                Employee stackItem = myStack.Pop();
                Console.WriteLine($"ID: {stackItem.ID} - {stackItem.Name} - {stackItem.Gender} - {stackItem.Salary}");
                Console.WriteLine($"Items left in the stack = {myStack.Count}");
            }

            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };
            foreach (Employee stackItem in employees)
            {
                myStack.Push(stackItem);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Retrieve Using Peek Method");

            Employee topEmployee1 = myStack.Peek();
            Employee topEmployee2 = myStack.Peek();
            Console.WriteLine($"ID: {topEmployee1.ID} - {topEmployee1.Name} - {topEmployee1.Gender} - {topEmployee1.Salary}");
            Console.WriteLine($"Items left in the stack = {myStack.Count}");
            Console.WriteLine($"ID: {topEmployee2.ID} - {topEmployee2.Name} - {topEmployee2.Gender} - {topEmployee2.Salary}");
            Console.WriteLine($"Items left in the stack = {myStack.Count}");

            Console.WriteLine("----------------------------------------");

            bool isEmployee3InStack = myStack.Contains(employee3);
            if (isEmployee3InStack)
            {
                Console.WriteLine("Employee3 object exists in the stack.");
            }
            else
            {
                Console.WriteLine("Nah, employee not found.");
            }


            //Här början list-delen av uppgiften

            Console.WriteLine("\n--------------In the List:--------------");
            List<Employee> myList = new List<Employee>() { employee1, employee2, employee3, employee4, employee5 };

            Console.WriteLine("----------------------------------------");

            if (myList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }

            Console.WriteLine("----------------------------------------");

            Employee firstMaleEmployee = myList.Find(employee => employee.Gender == "Male");
            Console.WriteLine($"The first male we can find is: \n{firstMaleEmployee.Name}");

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("The males in the list are:");
            List<Employee> allMaleEmployees = myList.FindAll(employee => employee.Gender == "Male");
            foreach (Employee emp in allMaleEmployees)
            {
                Console.WriteLine($"{emp.Name}");
            }
        }
    }
}

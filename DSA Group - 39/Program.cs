using DSA_Group___39;
using System;

class Program
{
    static EmployeeList employeeList = new EmployeeList();
    static PayrollSystem payrollSystem = new PayrollSystem();

    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    RegisterEmployee();
                    break;
                case 2:
                    CalculateEmployeeSalary();
                    break;
                case 3:
                    DeleteEmployee();
                    break;
                case 4:
                    DisplayAllEmployees();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
            Console.WriteLine("Press Enter to Continue....");
            Console.ReadLine();
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Register Employee");
        Console.WriteLine("2. Calculate Salary");
        Console.WriteLine("3. Delete Employee");
        Console.WriteLine("4. Display All Employees");
        Console.WriteLine("5. Exit");
        Console.WriteLine();
    }

    static void RegisterEmployee()
    {
        Console.Write("Enter ID: ");
        int id;
        while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
        {
            Console.WriteLine("Invalid input! Enter a valid Employee ID (positive number).");
            Console.Write("Enter ID: ");
        }

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Telephone: ");
        string telephone = Console.ReadLine();

        Console.Write("Enter Service Time (Years): ");
        int serviceTime;
        while (!int.TryParse(Console.ReadLine(), out serviceTime) || serviceTime < 0)
        {
            Console.WriteLine("Invalid input! Enter a valid Service Time (positive number).");
            Console.Write("Enter Service Time (Years): ");
        }

        Console.Write("Enter Position (1 - Employee, 2 - Supervisor, 3 - Assistant Manager, 4 - Manager): ");
        int position;
        while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > 4)
        {
            Console.WriteLine("Invalid input! Enter a valid Position (1-4).");
            Console.Write("Enter Position: ");
        }

        double basicSalary = position * 50000;

        Employee emp = new Employee(id, name, telephone, serviceTime, position, basicSalary);
        employeeList.AddEmployee(emp);

        Console.WriteLine("Employee registered successfully!");
    }

    static void DeleteEmployee()
    {
        Console.Write("Enter Employee ID to delete: ");
        int empId;
        while (!int.TryParse(Console.ReadLine(), out empId) || empId < 0)
        {
            Console.WriteLine("Invalid input! Enter a valid Employee ID.");
            Console.Write("Enter Employee ID: ");
        }

        bool deleted = employeeList.DeleteEmployee(empId);
        if (deleted)
        {
            Console.WriteLine($"Employee with ID {empId} has been successfully deleted.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }




    static void CalculateEmployeeSalary()
    {
        Console.Write("Enter Employee ID: ");
        int empId;
        while (!int.TryParse(Console.ReadLine(), out empId) || empId < 0)
        {
            Console.WriteLine("Invalid input! Enter a valid Employee ID.");
            Console.Write("Enter Employee ID: ");
        }

        Employee found = employeeList.GetEmployee(empId);
        if (found != null)
        {
            Console.Write("Enter Attendance (Days per Month): ");
            int attendance;
            while (!int.TryParse(Console.ReadLine(), out attendance) || attendance < 0 || attendance > 31)
            {
                Console.WriteLine("Invalid input! Enter a valid attendance (0-31 days).");
                Console.Write("Enter Attendance (Days per Month): ");
            }

            double salary = payrollSystem.CalculateSalary(attendance, found);
            if (salary != 0)
            {
                Console.WriteLine($"Final Salary for {found.Name} - (Rs.): {salary}");
            }
            else
            {
                Console.WriteLine("Entered Wrong Value!!!");
            }
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }



    static void DisplayAllEmployees()
    {
        Console.WriteLine("Employee List (Sorted by ID):");
        employeeList.DisplayEmployees();
    }
}





//merge sort code


//using DSA_Group___39;
//using System;

//class Program
//{
//    static EmployeeList employeeList = new EmployeeList();
//    static PayrollSystem payrollSystem = new PayrollSystem();

//    static void Main()
//    {
//        while (true)
//        {
//            DisplayMenu();
//            Console.Write("Enter your choice: ");
//            int choice;
//            if (!int.TryParse(Console.ReadLine(), out choice))
//            {
//                Console.WriteLine("Invalid input! Please enter a number.");
//                continue;
//            }

//            switch (choice)
//            {
//                case 1:
//                    RegisterEmployee();
//                    break;
//                case 2:
//                    CalculateEmployeeSalary();
//                    break;
//                case 3:
//                    DisplayAllEmployees();
//                    break;
//                case 4:
//                    return; // Exit
//                default:
//                    Console.WriteLine("Invalid choice. Please enter a valid option.");
//                    break;
//            }
//            Console.WriteLine("Press Enter to Continue....");
//            Console.ReadLine();
//        }
//    }

//    static void DisplayMenu()
//    {
//        Console.Clear();
//        Console.WriteLine("1. Register Employee");
//        Console.WriteLine("2. Calculate Salary");
//        Console.WriteLine("3. Display All Employees");
//        Console.WriteLine("4. Exit");
//        Console.WriteLine();
//    }

//    static void RegisterEmployee()
//    {
//        Console.Write("Enter ID: ");
//        int id;
//        while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Employee ID (positive number).");
//            Console.Write("Enter ID: ");
//        }

//        Console.Write("Enter Name: ");
//        string name = Console.ReadLine();

//        Console.Write("Enter Telephone: ");
//        string telephone = Console.ReadLine();

//        Console.Write("Enter Service Time (Years): ");
//        int serviceTime;
//        while (!int.TryParse(Console.ReadLine(), out serviceTime) || serviceTime < 0)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Service Time (positive number).");
//            Console.Write("Enter Service Time (Years): ");
//        }

//        Console.Write("Enter Position (1 - Employee, 2 - Supervisor, 3 - Assistant Manager, 4 - Manager): ");
//        int position;
//        while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > 4)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Position (1-4).");
//            Console.Write("Enter Position: ");
//        }

//        double basicSalary = position * 50000; // Example salary calculation

//        Employee emp = new Employee(id, name, telephone, serviceTime, position, basicSalary);
//        employeeList.AddEmployee(emp);

//        Console.WriteLine("Employee registered successfully!");
//    }

//    static void CalculateEmployeeSalary()
//    {
//        Console.Write("Enter Employee ID: ");
//        int empId;
//        while (!int.TryParse(Console.ReadLine(), out empId) || empId < 0)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Employee ID.");
//            Console.Write("Enter Employee ID: ");
//        }

//        Employee found = employeeList.GetEmployee(empId);
//        if (found != null)
//        {
//            Console.Write("Enter Attendance (Days per Month): ");
//            int attendance;
//            while (!int.TryParse(Console.ReadLine(), out attendance) || attendance < 0 || attendance > 31)
//            {
//                Console.WriteLine("Invalid input! Enter a valid attendance (0-31 days).");
//                Console.Write("Enter Attendance (Days per Month): ");
//            }

//            double salary = payrollSystem.CalculateSalary(attendance, found);
//            if (salary != 0)
//            {
//                Console.WriteLine($"Final Salary for {found.Name} - (Rs.): {salary}");
//            }
//            else
//            {
//                Console.WriteLine("Entered Wrong Value!!!");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Employee not found.");
//        }
//    }

//    static void DisplayAllEmployees()
//    {
//        Console.WriteLine("Employee List (Sorted by ID):");
//        employeeList.DisplayEmployees();
//    }
//}




//bubble sort code


//using DSA_Group___39;
//using System;

//class Program
//{
//    static EmployeeList employeeList = new EmployeeList();
//    static PayrollSystem payrollSystem = new PayrollSystem();

//    static void Main()
//    {
//        while (true)
//        {
//            DisplayMenu();
//            Console.Write("Enter your choice: ");
//            int choice;
//            if (!int.TryParse(Console.ReadLine(), out choice))
//            {
//                Console.WriteLine("Invalid input! Please enter a number.");
//                continue;
//            }

//            switch (choice)
//            {
//                case 1:
//                    RegisterEmployee();
//                    break;
//                case 2:
//                    CalculateEmployeeSalary();
//                    break;
//                case 3:
//                    DisplayAllEmployees();
//                    break;
//                case 4:
//                    return; // Exit
//                default:
//                    Console.WriteLine("Invalid choice. Please enter a valid option.");
//                    break;
//            }
//            Console.WriteLine("Press Enter to Continue....");
//            Console.ReadLine();
//        }
//    }

//    static void DisplayMenu()
//    {
//        Console.Clear();
//        Console.WriteLine("1. Register Employee");
//        Console.WriteLine("2. Calculate Salary");
//        Console.WriteLine("3. Display All Employees");
//        Console.WriteLine("4. Exit");
//        Console.WriteLine();
//    }

//    static void RegisterEmployee()
//    {
//        Console.Write("Enter ID: ");
//        int id;
//        while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Employee ID (positive number).");
//            Console.Write("Enter ID: ");
//        }

//        Console.Write("Enter Name: ");
//        string name = Console.ReadLine();

//        Console.Write("Enter Telephone: ");
//        string telephone = Console.ReadLine();

//        Console.Write("Enter Service Time (Years): ");
//        int serviceTime;
//        while (!int.TryParse(Console.ReadLine(), out serviceTime) || serviceTime < 0)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Service Time (positive number).");
//            Console.Write("Enter Service Time (Years): ");
//        }

//        Console.Write("Enter Position (1 - Employee, 2 - Supervisor, 3 - Assistant Manager, 4 - Manager): ");
//        int position;
//        while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > 4)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Position (1-4).");
//            Console.Write("Enter Position: ");
//        }

//        double basicSalary = position * 50000; // Example salary calculation

//        Employee emp = new Employee(id, name, telephone, serviceTime, position, basicSalary);
//        employeeList.AddEmployee(emp);

//        Console.WriteLine("Employee registered successfully!");
//    }

//    static void CalculateEmployeeSalary()
//    {
//        Console.Write("Enter Employee ID: ");
//        int empId;
//        while (!int.TryParse(Console.ReadLine(), out empId) || empId < 0)
//        {
//            Console.WriteLine("Invalid input! Enter a valid Employee ID.");
//            Console.Write("Enter Employee ID: ");
//        }

//        Employee found = employeeList.GetEmployee(empId);
//        if (found != null)
//        {
//            Console.Write("Enter Attendance (Days per Month): ");
//            int attendance;
//            while (!int.TryParse(Console.ReadLine(), out attendance) || attendance < 0 || attendance > 31)
//            {
//                Console.WriteLine("Invalid input! Enter a valid attendance (0-31 days).");
//                Console.Write("Enter Attendance (Days per Month): ");
//            }

//            double salary = payrollSystem.CalculateSalary(attendance, found);
//            if (salary != 0)
//            {
//                Console.WriteLine($"Final Salary for {found.Name} - (Rs.): {salary}");
//            }
//            else
//            {
//                Console.WriteLine("Entered Wrong Value!!!");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Employee not found.");
//        }
//    }

//    static void DisplayAllEmployees()
//    {
//        Console.WriteLine("Employee List (Sorted by ID):");
//        employeeList.DisplayEmployees();
//    }
//}







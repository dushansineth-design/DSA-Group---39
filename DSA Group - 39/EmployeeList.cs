using System;
using System.Collections.Generic;

namespace DSA_Group___39
{
    class Node 
    {
        public Employee Data;
        public Node Next;

        public Node(Employee employee) 
        {
            Data = employee;
            Next = null;
        }
    }

    class EmployeeList
    {
        private Node head;
        public int count;

        public EmployeeList()
        {
            count = 0;
        }

        public void AddEmployee(Employee emp)
        {
            Node newNode = new Node(emp);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            count++;


            SortEmployeesByID();
        }


        private List<Employee> ConvertToList()
        {
            List<Employee> employees = new List<Employee>();
            Node temp = head;
            while (temp != null)
            {
                employees.Add(temp.Data);
                temp = temp.Next;
            }
            return employees;
        }


        private void ConvertToLinkedList(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                head = null;
                return;
            }

            head = new Node(employees[0]);
            Node temp = head;

            for (int i = 1; i < employees.Count; i++)
            {
                temp.Next = new Node(employees[i]);
                temp = temp.Next;
            }
        }


        private void QuickSort(List<Employee> employees, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(employees, low, high);
                QuickSort(employees, low, pi - 1);
                QuickSort(employees, pi + 1, high);
            }
        }

        private int Partition(List<Employee> employees, int low, int high)
        {
            Employee pivot = employees[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (employees[j].ID < pivot.ID)
                {
                    i++;
                    (employees[i], employees[j]) = (employees[j], employees[i]);
                }
            }
            (employees[i + 1], employees[high]) = (employees[high], employees[i + 1]);
            return i + 1;
        }

        public bool DeleteEmployee(int id)
        {
            if (head == null) return false;

            if (head.Data.ID == id)  // Delete first node
            {
                head = head.Next;
                count--;
                return true;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data.ID != id)
            {
                current = current.Next;
            }

            if (current.Next == null) return false;

            current.Next = current.Next.Next;
            count--;
            return true;
        }

        private void SortEmployeesByID()
        {
            List<Employee> employees = ConvertToList();
            QuickSort(employees, 0, employees.Count - 1);
            ConvertToLinkedList(employees);
        }

        public Employee GetEmployee(int id)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.ID == id)
                    return temp.Data;
                temp = temp.Next;
            }
            return null;
        }


        public void DisplayEmployees()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.Data.ID}, Name: {temp.Data.Name}");
                temp = temp.Next;
            }
        }
    }
}



//merge sort code


//using System;
//using System.Collections.Generic;

//namespace DSA_Group___39
//{
//    class Node
//    {
//        public Employee Data;
//        public Node Next;

//        public Node(Employee employee)
//        {
//            Data = employee;
//            Next = null;
//        }
//    }

//    class EmployeeList
//    {
//        private Node head;
//        public int count;

//        public EmployeeList()
//        {
//            count = 0;
//        }

//        public void AddEmployee(Employee emp)
//        {
//            Node newNode = new Node(emp);
//            if (head == null)
//            {
//                head = newNode;
//            }
//            else
//            {
//                Node temp = head;
//                while (temp.Next != null)
//                {
//                    temp = temp.Next;
//                }
//                temp.Next = newNode;
//            }
//            count++;

//            // **Sort employees by ID after adding a new employee using Merge Sort**
//            head = MergeSort(head);
//        }

//        // Merge Sort algorithm for sorting the linked list by Employee ID
//        private Node MergeSort(Node head)
//        {
//            if (head == null || head.Next == null)
//                return head;

//            Node middle = GetMiddle(head);
//            Node nextOfMiddle = middle.Next;
//            middle.Next = null;

//            Node left = MergeSort(head);
//            Node right = MergeSort(nextOfMiddle);

//            return Merge(left, right);
//        }

//        private Node Merge(Node left, Node right)
//        {
//            if (left == null) return right;
//            if (right == null) return left;

//            Node result;
//            if (left.Data.ID <= right.Data.ID)
//            {
//                result = left;
//                result.Next = Merge(left.Next, right);
//            }
//            else
//            {
//                result = right;
//                result.Next = Merge(left, right.Next);
//            }
//            return result;
//        }

//        private Node GetMiddle(Node head)
//        {
//            if (head == null) return head;
//            Node slow = head, fast = head;
//            while (fast.Next != null && fast.Next.Next != null)
//            {
//                slow = slow.Next;
//                fast = fast.Next.Next;
//            }
//            return slow;
//        }

//        public Employee GetEmployee(int id)
//        {
//            Node temp = head;
//            while (temp != null)
//            {
//                if (temp.Data.ID == id)
//                    return temp.Data;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        // Display all employees (for debugging)
//        public void DisplayEmployees()
//        {
//            Node temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine($"ID: {temp.Data.ID}, Name: {temp.Data.Name}");
//                temp = temp.Next;
//            }
//        }
//    }
//}





//bubble sort code


//using System;
//using System.Collections.Generic;

//namespace DSA_Group___39
//{
//    class Node
//    {
//        public Employee Data;
//        public Node Next;

//        public Node(Employee employee)
//        {
//            Data = employee;
//            Next = null;
//        }
//    }

//    class EmployeeList
//    {
//        private Node head;
//        public int count;

//        public EmployeeList()
//        {
//            count = 0;
//        }

//        public void AddEmployee(Employee emp)
//        {
//            Node newNode = new Node(emp);
//            if (head == null)
//            {
//                head = newNode;
//            }
//            else
//            {
//                Node temp = head;
//                while (temp.Next != null)
//                {
//                    temp = temp.Next;
//                }
//                temp.Next = newNode;
//            }
//            count++;

//            // **Sort employees by ID after adding a new employee**
//            SortEmployeesByID();
//        }

//        // Convert linked list to a List<Employee> for sorting
//        private List<Employee> ConvertToList()
//        {
//            List<Employee> employees = new List<Employee>();
//            Node temp = head;
//            while (temp != null)
//            {
//                employees.Add(temp.Data);
//                temp = temp.Next;
//            }
//            return employees;
//        }

//        // Convert List<Employee> back to linked list after sorting
//        private void ConvertToLinkedList(List<Employee> employees)
//        {
//            if (employees.Count == 0)
//            {
//                head = null;
//                return;
//            }

//            head = new Node(employees[0]);
//            Node temp = head;

//            for (int i = 1; i < employees.Count; i++)
//            {
//                temp.Next = new Node(employees[i]);
//                temp = temp.Next;
//            }
//        }

//        // Bubble Sort algorithm to sort employees by ID
//        private void BubbleSort(List<Employee> employees)
//        {
//            int n = employees.Count;
//            for (int i = 0; i < n - 1; i++)
//            {
//                for (int j = 0; j < n - i - 1; j++)
//                {
//                    if (employees[j].ID > employees[j + 1].ID) // Sorting by ID
//                    {
//                        (employees[j], employees[j + 1]) = (employees[j + 1], employees[j]);
//                    }
//                }
//            }
//        }

//        // Sort Employees by ID when a new employee is registered
//        private void SortEmployeesByID()
//        {
//            List<Employee> employees = ConvertToList();
//            BubbleSort(employees);
//            ConvertToLinkedList(employees);
//        }

//        public Employee GetEmployee(int id)
//        {
//            Node temp = head;
//            while (temp != null)
//            {
//                if (temp.Data.ID == id)
//                    return temp.Data;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        // Display all employees (for debugging)
//        public void DisplayEmployees()
//        {
//            Node temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine($"ID: {temp.Data.ID}, Name: {temp.Data.Name}");
//                temp = temp.Next;
//            }
//        }
//    }
//}




namespace Labb_4_O.O.P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Stefan", "Male", 50000.00m);
            Employee employee2 = new Employee(2, "Olof", "Male", 35000.00m);
            Employee employee3 = new Employee(3, "Niklas", "Male", 32000.00m);
            Employee employee4 = new Employee(4, "Agnes", "Female", 30000.00m);
            Employee employee5 = new Employee(5, "Ulrika", "Female", 25000.00m);



            Stack<Employee> EmpStack = new Stack<Employee>();

            EmpStack.Push(employee1);
            EmpStack.Push(employee2);
            EmpStack.Push(employee3);
            EmpStack.Push(employee4);
            EmpStack.Push(employee5);

            Console.WriteLine("User in stack:");
            foreach (var employee in EmpStack)
            {
                Console.WriteLine($" {employee.ID}, {employee.Name}, {employee.Gender}, {employee.Salary} ");
                Console.WriteLine($"Items kvar i Stack: {EmpStack.Count}");
            }

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Retrive using Pop Method:");
            while (EmpStack.Count > 0)
            {
                Employee currentEmployee = EmpStack.Pop();
                Console.WriteLine($"{currentEmployee.ID},  {currentEmployee.Name}, {currentEmployee.Gender}, {currentEmployee.Salary} ");
                Console.WriteLine($"Items kvar i Stack: {EmpStack.Count}");
            }

            Console.WriteLine("---------------------------------------------------------------------");

            EmpStack.Push(employee1);
            EmpStack.Push(employee2);
            EmpStack.Push(employee3);
            EmpStack.Push(employee4);
            EmpStack.Push(employee5);

            Console.WriteLine("Retrive using Peek Method:");

            if (EmpStack.Count >= 2)
            {
                Employee topEmployee1 = EmpStack.Peek();
                Console.WriteLine($"{topEmployee1.ID},  {topEmployee1.Name}, {topEmployee1.Gender}, {topEmployee1.Salary} ");
                Console.WriteLine($"Items kvar i Stack: {EmpStack.Count}");

                Employee topEmployee2 = EmpStack.ElementAt(1);
                Console.WriteLine($"{topEmployee2.ID},  {topEmployee2.Name}, {topEmployee2.Gender}, {topEmployee2.Salary} ");
                Console.WriteLine($"Items kvar i Stack: {EmpStack.Count}");
            }


            Console.WriteLine("---------------------------------------------------------------------");

            if (EmpStack.Contains(employee3))
            {
                Console.WriteLine("Employee3 is in the stack");
            }
            else
            {
                Console.WriteLine("Employee3 is NOT the stack");
            }



            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("LIST!!!");



            List<Employee> listEmp = new List<Employee>();

            listEmp.Add(employee1);
            listEmp.Add(employee2);
            listEmp.Add(employee3);
            listEmp.Add(employee4);
            listEmp.Add(employee5);


            if (listEmp.Contains(employee2))
            {
                Console.WriteLine("Employee 2 object exist in the list...");
            }
            else
            {
                Console.WriteLine("Employee 2 objekt does not exist...");
            }
            Console.WriteLine(" ");


            Employee malePerson = listEmp.Find(p => p.Gender == "Male");

            if (malePerson != null)
            {
                Console.WriteLine($"ID: {malePerson.ID}, Name: {malePerson.Name}, Gender: {malePerson.Gender}, Salary: {malePerson.Salary}");
            }
            else
            {
                Console.WriteLine("Non with gender male is found");
            }

            Console.WriteLine("---------------------------------------------------------------------");

            List<Employee> maleEmployees = listEmp.FindAll(p => p.Gender == "Male");

            // Skriv ut informationen om de hittade anställda, om det finns några
            if (maleEmployees.Count > 0)
            {

                foreach (var employee in maleEmployees)
                {
                    Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
                }
            }
            else
            {
                Console.WriteLine("Non with gender male is found");
            }

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDBBuilder
{
    class Program
    {
        static public List<Employee> employeesList;
        static void Main(string[] args)
        {
            employeesList = new List<Employee>();
            employeesList.Add(new Employee() { firstName = "Joe", lastName = "Smith", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Joe", lastName = "Baker", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Tod", lastName = "Rodgers", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Bill", lastName = "Livingston", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Randy", lastName = "Shellnader", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Craig", lastName = "Grippenthorpe", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Butters", lastName = "Deadenbauch", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Jeff", lastName = "Waters", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Bill", lastName = "Anderson", iD = NextId() });
            employeesList.Add(new Employee() { firstName = "Ed", lastName = "Smith", iD = NextId() });

            List<Employee> joesList = new List<Employee>();
            foreach (var item in employeesList)
            {
                if (item.firstName == "Joe") joesList.Add(item);
            }
            Console.WriteLine("foreach list counted " + joesList.Count + " joes");
            List<Employee> joesListLambdaStyle = employeesList.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine("lambda expression list counted " + joesListLambdaStyle.Count + " joes");
            List<Employee> greaterIDThanFiveList = employeesList.Where(x => x.iD > 5).ToList();
            Console.WriteLine("lambda search for id > 5 counted " + greaterIDThanFiveList.Count + " employees");
            Console.Read();
        }
        static int nextIDToAssign = -1;
        static public int NextId()
        {
            nextIDToAssign++;
            return nextIDToAssign;
        }
    }
}

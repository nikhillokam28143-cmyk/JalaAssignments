using System;
using System.Data;
using System.Collections;

class CollectionAssignments
{
    static void Main(string[] args)
    {
        // Uncomment one method at a time

        //DataTableDemo();
        //SecondDataTable();
        //DataSetDemo();
        ArrayListDemo();
    }

    // 1 - 10 DataTable
    static void DataTableDemo()
    {
        // 1 & 2
        DataTable employeeTable = new DataTable("EmployeeTable");

        // 5
        employeeTable.Columns.Add("EmpId");
        employeeTable.Columns.Add("EmpName");
        employeeTable.Columns.Add("EmpSalary");
        employeeTable.Columns.Add("Department");

        // 6
        employeeTable.Rows.Add("101", "Ravi", "30000", "HR");
        employeeTable.Rows.Add("102", "Kiran", "35000", "IT");
        employeeTable.Rows.Add("103", "Puja", "40000", "Sales");
        employeeTable.Rows.Add("104", "Rahul", "45000", "Finance");
        employeeTable.Rows.Add("105", "Anil", "50000", "Admin");

        // 7 Using For Loop
        Console.WriteLine("Using For Loop");

        for (int i = 0; i < employeeTable.Rows.Count; i++)
        {
            Console.WriteLine(employeeTable.Rows[i]["EmpId"]);
        }

        // 8 Using Foreach Loop
        Console.WriteLine("\nUsing Foreach Loop");

        foreach (DataRow row in employeeTable.Rows)
        {
            Console.WriteLine(row["EmpId"]);
        }

        // 9 Using DataRow
        Console.WriteLine("\nUsing DataRow");

        foreach (DataRow row in employeeTable.Rows)
        {
            Console.WriteLine(row["EmpId"]);
        }
    }

    // 10
    static void SecondDataTable()
    {
        DataTable studentTable = new DataTable("StudentTable");

        studentTable.Columns.Add("Id");
        studentTable.Columns.Add("Name");
        studentTable.Columns.Add("Course");
        studentTable.Columns.Add("City");
        studentTable.Columns.Add("Age");

        studentTable.Rows.Add("1", "Ravi", "C#", "Hyderabad", "22");
        studentTable.Rows.Add("2", "Puja", "Java", "Delhi", "23");
        studentTable.Rows.Add("3", "Rahul", "Python", "Mumbai", "24");
        studentTable.Rows.Add("4", "Anil", ".Net", "Chennai", "25");

        foreach (DataRow row in studentTable.Rows)
        {
            Console.WriteLine(row["Name"]);
        }
    }

    // 11,12,13
    static void DataSetDemo()
    {
        DataTable table1 = new DataTable("Employee");

        table1.Columns.Add("EmpId");
        table1.Columns.Add("EmpName");

        table1.Rows.Add("101", "Ravi");

        DataTable table2 = new DataTable("Student");

        table2.Columns.Add("Id");
        table2.Columns.Add("Name");

        table2.Rows.Add("1", "Puja");

        DataSet myDataSet = new DataSet("MyDataSet");

        myDataSet.Tables.Add(table1);
        myDataSet.Tables.Add(table2);

        Console.WriteLine("Tables in Dataset : " + myDataSet.Tables.Count);
    }

    // 17 - 21 ArrayList
    static void ArrayListDemo()
    {
        ArrayList list = new ArrayList();

        list.Add("One");
        list.Add("Two");
        list.Add("Three");

        Console.WriteLine("Using For Loop");

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine("\nUsing Foreach Loop");

        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        list.Reverse();

        Console.WriteLine("\nAfter Reverse");

        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        list.Sort();

        Console.WriteLine("\nAfter Sort");

        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        list.Clear();

        Console.WriteLine("\nCount After Clear : " + list.Count);
    }
}
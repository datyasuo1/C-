using System;

namespace DisplayDetail
{
    class Employee
    {
        public void DisplayDetail(object emp)
        {
            String fName = "";
            String lName = "";
            int age = 0;
            PropertyInfo[] attrs = emp.GetType().GetProperties();
            foreach (PropertyInfo attr in attrs)
            {
                switch(attr.Name)
                {
                    case "FirstNAme":
                        fName = attr.GetValue(emp, null).ToString();
                        break;
                    case "LastName":
                        lName = attr.GetValue(emp, null).ToString();
                        break;
                    case "Age":
                        age = (int)attr.GetValue(emp, null);
                        break;

                }
            }
            Console.WriteLine("Name:{0} {1},Age:{2}", fName, lName, age);
        }
    }
}

// List<int> ints = new List<int>(){1,3,2,4,5,6};
// ints.Sum();
// List<string> strings = new List<string>(){"Azba", "aa", "a"};
// strings.OrderByDescending(x=>x.Length);
// List<Person> people = new List<Person>();
// Person person = new Person();
// person.Name="Ali";
// person.Age=21;
// Person person1 = new Person();
// person1.Name="Ali";
// person1.Age=20;
// Person person2 = new Person();
// person2.Name="Ali";
// person2.Age=20;
// people.AddRange(person, person1, person2);
// people.OrderBy(x=>x.Age);
// List<int> nums = new List<int>(){1,3,2,4,5,6};
// nums.RemoveAll(x=>x%2!=0);
// System.Console.WriteLine(nums.Max());
// System.Console.WriteLine(nums.Min());
// foreach (var str in strings)
// {
//     bool Unique = str.Distinct().Count() == str.Length;

//     if (Unique)
//     {
//         System.Console.WriteLine("Tabrik texti wumo unikalniy hast");
//     }
//     else System.Console.WriteLine("Mutaasifona i karat nawid");
// }
// foreach (var item in strings)
// {
//     char[] a = new char[item.Length];
//      a=item.ToCharArray();
//     List<char> f =new List<char> ();
//     f.AddRange(a.Reverse());
//     string d= new string(f);
//     if (d == item)
//     {
//         System.Console.WriteLine("palindrome");
//     }
//     else System.Console.WriteLine("No Palindrome");
// }
// foreach (var item in strings)
// {
//     System.Console.Write(item.ToUpper()+" ");
// }
// foreach (var item in nums)
// {
//     System.Console.Write(item+" ");
// }
// // classtask 2
// var employees = new List<Employee>()
// {
//     new Employee()
//     {
//         Id = 1,
//         FirstName = "Alijon",
//         LastName = "Zabirov",
//         Age = 24, 
//         PhoneNumber = "881667007",
//         Salary = 4000
//     },
//     new Employee()
//     {
//         Id = 2,
//         FirstName = "Nurullo",
//         LastName = "Sulaymonov",
//         Age = 30, 
//         PhoneNumber = "908765432",
//         Salary = 8000
//     },
//     new Employee()
//     {
//         Id = 3,
//         FirstName = "Shodmon",
//         LastName = "Inoyatzoda",
//         Age = 26, 
//         PhoneNumber = "987009988",
//         Salary = 7800
//     },
// };
// List<Employee> employeses = new List<Employee>()
// {
//      new Employee()
//     {
//         Id = 3,
//         FirstName = "Shodmon",
//         LastName = "Inoyatzoda",
//         Age = 26, 
//         PhoneNumber = "987009988",
//         Salary = 7800
//     }, new Employee()
//     {
//         Id = 3,
//         FirstName = "Shodmon",
//         LastName = "Inoyatzoda",
//         Age = 26, 
//         PhoneNumber = "987009988",
//         Salary = 7800
//     }
// };
// employees.AddRange(employeses);
// employees.OrderBy(x=>x.Salary);
// employees.RemoveAll(x=>x.Age<25);
// employees.FindAll(x=>x.Salary>=5000);
// employees.FirstOrDefault().Remove();
// bool a =""== employees.FindAll(x=>x.FirstName=="Jura");
// if (a)
// {
//     Employee e = new Employee();
//     e.name="Jura";
//     employees.Add(e);

// }
// List<Employee> employees1 = new List<Employee>();
// employees1.InsertRange(1, employees);
// employees1.OrderByDescending();

// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task
// home task

// List<int> ints = new List<int>(){1,2,3,4,5,6,7,8};
// int a = ints[ints.Count()-1];
// List<int> n = new List<int>(){98,66,54,55,};
// bool v = false;
// foreach (var item in ints)
// {
//     foreach (var j in n)
//     {
//         if (item == j)
//         {
//             System.Console.WriteLine("yes");
//             v=true;
//         }
//         else
//         {
//             v=false;
//         }
//     }
// }
// if(v==false) System.Console.WriteLine("No");

// List<string> strings = new List<string>(){"aa", "vv" , "cc"};
// strings.Reverse();
// bool s = strings.Any();
// System.Console.WriteLine(s);
// Console.Write("vash chek"+strings.Find("aa"));
// strings.Sort();
// // strings.Clear();
 
// System.Console.WriteLine( ints.Max());
// System.Console.WriteLine(ints.Min());

// strings.RemoveAll(x=>x.Length>5);

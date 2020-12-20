using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11._2
{
    delegate bool StudentPredicateDelegate(Student Obj);
    delegate List<Student> StudentPredicateDelegate2(List<Student> List);

    class Program
    {
        static void Main(string[] args)
        {
            // 7
            List<Student> Students = new List<Student>();

            Student num1 = new Student("Anthony", "Hopkins", 82);
            Student num2 = new Student("Andrew", "Garfield", 37);
            Student num3 = new Student("Scarlett", "Johansson", 36);
            Student num4 = new Student("Robert", "Downey", 55);
            Student num5 = new Student("Anya", "Taylor-Joy", 24);
            Student num6 = new Student("Chris", "Hemsworth", 37);
            Student num7 = new Student("Bruce", "Lee", 80);
            Student num8 = new Student("Sophia ", "Lillis", 16);
            Student num9 = new Student("Andrew", "Lloyd Webber", 72);
            Student num10 = new Student("Julian", "Dennison", 15);

            Students.Add(num1);
            Students.Add(num2);
            Students.Add(num3);
            Students.Add(num4);
            Students.Add(num5);
            Students.Add(num6);
            Students.Add(num7);
            Students.Add(num8);
            Students.Add(num9);
            Students.Add(num10);

            // 8
            StudentPredicateDelegate age = Student.Adult;
            List<Student> newListOfStudents = Students.FindStudent(age);

            Console.WriteLine("Added adult students:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tNot found!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }
            // 8
            StudentPredicateDelegate name = Student.AisFirstLetterOfFirstName;
            newListOfStudents = Students.FindStudent(name);

            Console.WriteLine("Added students with A as a first letter of their name:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tNot found!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }
            // 8
            StudentPredicateDelegate surname = Student.MoreThan3LettersInLastName;
            newListOfStudents = Students.FindStudent(surname);

            Console.WriteLine("Добавлены ученики, у которых в фамилии больше трех букв:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tТаких нет!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
            }

            Console.WriteLine("\n\t---To see task with anonymous functions press any key---");
            Console.ReadKey();
            Console.Clear();

            // 9
            StudentPredicateDelegate2 age2 = delegate (List<Student> List)
            {
                List<Student> temp = new List<Student>();

                foreach (Student i in List)
                {
                    if (Student.Adult(i))
                    {
                        temp.Add(i);
                    }
                }

                return temp;
            };
            newListOfStudents = age2(Students);

            Console.WriteLine("Добавлены ученики, анонимными функциями:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tТаких нет!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }
            // 9
            StudentPredicateDelegate2 name2 = delegate (List<Student> List)
            {
                List<Student> temp = new List<Student>();

                foreach (Student i in List)
                {
                    if (Student.AisFirstLetterOfFirstName(i))
                    {
                        temp.Add(i);
                    }
                }

                return temp;
            };
            newListOfStudents = name2(Students);

            Console.WriteLine("Добавлены ученики,первая буква имени начинается на А, анонимные функции:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tТаких нет!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }
            //TASK 9
            StudentPredicateDelegate2 surname2 = delegate (List<Student> List)
            {
                List<Student> temp = new List<Student>();

                foreach (Student i in List)
                {
                    if (Student.MoreThan3LettersInLastName(i))
                    {
                        temp.Add(i);
                    }
                }

                return temp;
            };
            newListOfStudents = surname2(Students);

            Console.WriteLine("Добавлены ученики, у которых в фамилии больше трех букв, анонимные функции:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tТаких нет!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }
            //TASK 10
            StudentPredicateDelegate2 age20_25 = delegate (List<Student> List)
            {
                List<Student> temp = new List<Student>();

                foreach (Student i in List)
                {
                    if (i.Age >= 20 && i.Age <= 25)
                    {
                        temp.Add(i);
                    }
                }

                return temp;
            };
            newListOfStudents = age20_25(Students);

            Console.WriteLine("Добавлены ученики возрастом от 20 до 25:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tТаких нет!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }
            // 11
            StudentPredicateDelegate2 nameAndrew = delegate (List<Student> List)
            {
                List<Student> temp = new List<Student>();

                foreach (Student i in List)
                {
                    if (i.FirstName == "Andrew")
                    {
                        temp.Add(i);
                    }
                }

                return temp;
            };
            newListOfStudents = nameAndrew(Students);

            Console.WriteLine("Добавлен ученик с именем Andrew:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tТаких нет!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }
            // 12
            StudentPredicateDelegate2 surnameTroelsen = delegate (List<Student> List)
            {
                List<Student> temp = new List<Student>();

                foreach (Student i in List)
                {
                    if (i.LastName == "Troelsen")
                    {
                        temp.Add(i);
                    }
                }

                return temp;
            };
            newListOfStudents = surnameTroelsen(Students);

            Console.WriteLine("Добавлен ученик с фамилией Troelsen:\n");
            if (newListOfStudents.Count == 0)
            {
                Console.WriteLine("\tТаких нет!\n");
            }
            else
            {
                foreach (Student i in newListOfStudents)
                {
                    i.StudentInfo();
                }
                newListOfStudents.Clear();
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}

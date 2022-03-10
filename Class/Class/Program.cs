using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hikmet", "Abdulla", "Nermine", "Nazli" };
            string[] surnames = { "Abbasov", "Quliyev", "Quiliyeva", "Abbaszade" };
            int[] ages = { 18, 45, 43, 25 };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]+" "+surnames[i]+" "+ages[i]);
            }

            var human1 = new
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                Age = 18
            };

            var human2 = new
            {
                FullName = "Nermin Abbaszade",
                Age = 43
            };

            int num = 45;
            string sentence = "Hello, World!";
            char letter = 'A';


            Human human3 = new Human()
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                Age = 45
            };

            human3.Age = 46;

            Human human4 = new Human();
            Console.WriteLine(human4.Name + " - "+human4.Surname + " - "+human4.Age);

            human4.Name = "Tofiq";
            human4.Surname = "Dadasov";
            human4.Age = 34;
            Console.WriteLine(human4.Name + " " + human4.Surname + " " + human4.Age);


                
            Human human5;
            human5 = human4;


            Console.WriteLine($"FullName: {human1.Name} {human1.Surname} -  age: {human1.Age}");
            Console.WriteLine($"FullName: {human2.FullName} -  age: {human2.Age}");


            Human[] humans = {human3,human4,human5};

            Console.WriteLine("Humans:");
            foreach (var item in humans)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.Age}");
            }

            Student std1 = new Student
            {
                Name = "Allahverdi",
                Surname = "Ehmedov",
                Age = 5,
                AvgPoint = 0,
                GroupNo = "AP203"
            };

            Student std2 = new Student
            {
                Name = "Mustafa",
                Surname = "Qasimzade",
                AvgPoint = 0,
                Age = 5,
                GroupNo = "AP203"
            };

            Student std3 = new Student
            {
                Name = "Musviq",
                Surname = "Sukurov",
                Age = 20,
                AvgPoint = 75,
                GroupNo = "AP203",
                Gender = true,
               
            };

            Student std4 = new Student();
            std4.GroupNo = "AP205";

            Console.WriteLine(std4.GroupNo);
            Console.WriteLine(std1.GetInfo());

            Human human6 = new Human(45);

            Console.WriteLine(human6.Age);

            Student student7 = new Student(40,"AP203");
            Console.WriteLine(student7.Age + " -  "+ student7.GroupNo);

        }


    }





}

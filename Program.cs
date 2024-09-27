using System;
using System.Collections.Generic;

class Program
{
    public class Person
    {
        public string Name { get; set; } = string.Empty; // Memberikan nilai default
        public int Age { get; set; }
    }

    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        string input;
        int count = 0;

        Console.WriteLine("Program Sensus Penduduk");

        do
        {
            Console.Write("Masukkan nama (atau ketik 'selesai' untuk mengakhiri): ");
            input = Console.ReadLine();

            if (input?.ToLower() == "selesai") // Memastikan input tidak null
                break;

            Person person = new Person { Name = input };

            int age; // Deklarasi variabel di luar lingkup
            Console.Write("Masukkan usia: ");
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Usia tidak valid. Silakan masukkan usia yang benar: ");
            }
            person.Age = age; // Mengatur usia setelah valid

            people.Add(person);
            count++;

        } while (true);

        Console.WriteLine("\nData Sensus Penduduk:");
        foreach (var p in people)
        {
            Console.WriteLine($"Nama: {p.Name}, Usia: {p.Age}");
        }

        Console.WriteLine($"\nTotal penduduk yang disensus: {count}");
    }
}
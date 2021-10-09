using System;
using System.Collections.Generic;

namespace HospitalDictionaryLac
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("PATIENTS THAT ARE VEGETARIAN");
            foreach (var item in Patient.GetPatientDetails())
            {
                if (item.Value.Diet == DietEnum.Diet.Vegetarian)
                {
                    Console.WriteLine($"ID: {item.Key}\nNAME: {item.Value.Name}\nDIET: {item.Value.Diet}");
                    Console.WriteLine("List of Allergies: ");
                    if (item.Value.Allergies.Count > 1)
                    {
                        foreach (var allergy in item.Value.Allergies)
                        {
                            Console.WriteLine($"{allergy}");
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Value.Allergies[0]}\n");
                    }
                }
            }

            Console.WriteLine("PATIENTS THAT ARE ALLERGIC TO PEANUTS");
            foreach (var item in Patient.GetPatientDetails())
            {
                if (item.Value.Allergies.Contains("Peanuts"))
                {
                    Console.WriteLine($"ID: {item.Key}\nNAME: {item.Value.Name}\nDIET: {item.Value.Diet}");
                    Console.WriteLine("List of Allergies: ");
                    if (item.Value.Allergies.Count > 1)
                    {
                        foreach (var allergy in item.Value.Allergies)
                        {
                            Console.WriteLine($"{allergy}");
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Value.Allergies[0]}\n");
                    }
                }
            }
        }
    }
}

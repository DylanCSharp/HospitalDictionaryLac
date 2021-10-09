using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDictionaryLac
{


    public class Patient
    {
        #region Properties
        public string Name { get; set; }
        public DietEnum.Diet Diet { get; set; }
        public double Ward { get; set; }
        public List<string> Allergies { get; set; }
        #endregion

        public static readonly Dictionary<int, Patient> dictionaryPatients = new()
        {
            { 1, new Patient { Name = "Dylan", Diet = DietEnum.Diet.None, Ward = 3, Allergies = new List<string> { "None" } } },
            { 2, new Patient { Name = "Emily", Diet = DietEnum.Diet.Vegetarian, Ward = 4, Allergies = new List<string> { "Tomato", "Peanuts" } } },
            { 3, new Patient { Name = "Andrew", Diet = DietEnum.Diet.None, Ward = 2, Allergies = new List<string> { "None" } } },
            { 4, new Patient { Name = "Wikus", Diet = DietEnum.Diet.None, Ward = 3, Allergies = new List<string> { "Popcorn", "Lettuce", "Peanuts" } } },
            { 5, new Patient { Name = "Simon", Diet = DietEnum.Diet.Vegan, Ward = 3, Allergies = new List<string> { "Meat" } } }
        };

        public static Dictionary<int, Patient> GetPatientDetails()
        {
            return dictionaryPatients;
        }

        public List<string> GetAllergies()
        {
            return Allergies;
        }

        public void SetAllergies(List<string> value)
        {
            Allergies = value;
        }
    }
}

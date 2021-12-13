using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PetRegistry
{
    class Pet
    {
        public string Breed;
        public string Category;
        public string Wool;
        public string Size;
        public string Name;
        public string Photo;
        public string Gender;
        public bool Chipped;
        public string ChipNum;
        public int OwnerType;
        public User OwnerUser;
        public Organization OwnerOrganization;

        //internal Pet(string Breed, string Category, string Wool, string Size,
        //string Name, string Photo, string Gender, bool Chipped, string ChipNum, int OwnerType,
        //User Owner)
        //{

        //}


        public void UpdatePetData(long cardNumber, string[] data)
        {

        }
        public void RegisterNewPet(string[] data)
        {
            if (dataIsCorrect(data))
            {
                MessageBox.Show("P");
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "") data[i] = "NULL";
                }
                PetService.AddNewPet(data);
            }
            else{ MessageBox.Show("NC"); }
            
        }
        private bool dataIsCorrect(string[] data)
        {
            bool isEverythingCorrect = true;
            if (data[0] == "") isEverythingCorrect = false;
            if (data[2] == "") isEverythingCorrect = false;
           // if (data[3] != "М" && data[3] != "Ж") isEverythingCorrect = false;
            if (DateTime.Parse(data[9]) >= DateTime.Parse(data[10])) isEverythingCorrect = false;
            if (DateTime.Parse(data[11]) >= DateTime.Parse(data[12])) isEverythingCorrect = false;
            return isEverythingCorrect;
        }

        public void DeletePetCard(long cardNumber)
        {

        }

        
    }
}

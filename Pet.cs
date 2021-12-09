using System;
using System.Collections.Generic;
using System.Text;

namespace Приложение
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
        public User Owner;

        internal Pet(string Breed, string Category, string Wool, string Size,
        string Name, string Photo, string Gender, bool Chipped, string ChipNum, int OwnerType,
        User Owner)
        {

        }


        public void UpdatePetData(long cardNumber, string[] data)
        {

        }
        public void RegisterNewPet(string[] data)
        {

        }
        private void dataIsCorrect(string[] data)
        {
         
        }

        public void DeletePetCard(long cardNumber)
        {

        }

        public void ExportPetCardToWord(string pathToFile, long cardNumber, long documentType)
        {

        }
        private void ExportDataToWord(string pathToFile, string[] data, long documentType)
        {

        }

    }
}

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


        public void UpdatePetData(long cardNumber, string[] data)
        {

        }
        public string RegisterNewPet(string[] data)
        {
            if (dataIsCorrect(data))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "" || data[i] == null) data[i] = "NULL";
                }
                if(data[14] == "0") data[16]="NULL"; else data[15] = "NULL";
                PetService.AddNewPet(data);
                return "Животное успешно добавлено.";
            }
            else{ return "Неверные данные."; }
            
        }
        private bool dataIsCorrect(string[] data)
        {
            bool isEverythingCorrect = true;
            if (data[0] == "" || data[0]==null) isEverythingCorrect = false;
            if (data[1] == "" || data[1] == null) isEverythingCorrect = false;
            if (data[2] == "" || data[2] == null) isEverythingCorrect = false;
            if ((data[3] != "Мужской" && data[3] != "Женский") || data[3] == null) isEverythingCorrect = false;
            if (data[5] == "" || data[5] == null) isEverythingCorrect = false;
            if (DateTime.Parse(data[9]) >= DateTime.Parse(data[10])) isEverythingCorrect = false;
            if (DateTime.Parse(data[11]) >= DateTime.Parse(data[12])) isEverythingCorrect = false;
            if (data[14] == "" || data[14] == null) isEverythingCorrect = false;
            return isEverythingCorrect;
        }

        
    }
}

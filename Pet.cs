using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PetRegistry
{
    public class Pet
    {
        public string PetName;
        public string Category;
        public string Breed;
        public string Gender;
        public DateTime BirthDate;
        public DateTime RegistrationDate;
        public string PassportNum;
        public string IdentificationNum;
        public string ChipNum;
        public DateTime VacinationDate;
        public DateTime VacinationDateEnd;
        public DateTime DewormingDate;
        public DateTime DewormingDateEnd;
        public string VetAppointments;
        public string OwnerType;
        public string Owner;

        public Pet(string name = null, string gender = null, DateTime birthDate = default, string category = null, string breed = null,  DateTime registrationDate = default, string ownerType = null, string owner = null,
            DateTime vacinationDate = default, DateTime vacinationDateEnd = default, DateTime dewormingDate = default, DateTime dewormingDateEnd = default, string vetAppointments = null, string passportNum = null,
            string identificationNum = null, string chipNum = null)
        {
            PetName = name;
            Category = category;
            Breed = breed;
            Gender = gender;
            BirthDate = birthDate;
            RegistrationDate = registrationDate;
            PassportNum = passportNum;
            IdentificationNum = identificationNum;
            ChipNum = chipNum;
            VacinationDate = vacinationDate;
            VacinationDateEnd = vacinationDateEnd;
            DewormingDate = dewormingDate;
            DewormingDateEnd = dewormingDateEnd;
            VetAppointments = vetAppointments;
            OwnerType = ownerType;
            Owner = owner;
        }

        public string UpdatePetData(string cardNumber, string[] data)
        {
            if (dataIsCorrect(data))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "" || data[i] == null) data[i] = "NULL";
                }
                if (data[14] == "0") data[16] = "NULL"; else data[15] = "NULL";
                PetService.ChangePetData(cardNumber, data);
                return "Карточка успешно изменена.";
            }
            else return "Неверные данные.";
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

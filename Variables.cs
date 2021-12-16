using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistry
{
    public static class Variables
    {
        public static User CurrentUser;
        public static Pet CurrentPet;
        public static Dictionary<string, string[]> MatchingRoles = new Dictionary<string, string[]>
        {
            ["удаление"]= new string[] { "Ветврач" },
            ["открытие карточки"] = new string[] { "Ветврач", "Оператор приюта", "Куратор ВетСлужбы", "Куратор ОМСУ", "Оператор ВетСлужбы", "Оператор ОМСУ", "Подписант ВетСлужбы", "Подписант ОМСУ", "Пользователь" },
            ["добавление"] = new string[] { "Ветврач" },
            ["изменение"] = new string[] { "Ветврач", "Оператор приюта" },
            ["открытие реестров"] = new string[] { "Ветврач", "Оператор приюта", "Куратор ВетСлужбы", "Куратор ОМСУ", "Оператор ВетСлужбы", "Оператор ОМСУ", "Подписант ВетСлужбы", "Подписант ОМСУ" },
            ["открытие дж"] = new string[] {"Пользователь"}
        };
    }
}

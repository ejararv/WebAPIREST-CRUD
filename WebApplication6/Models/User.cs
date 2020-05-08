using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace WebApplication6.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите имя пользователя")]//Валидация
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Возраст должен быть в промежутке от 1 до 100") ]
        [Required(ErrorMessage = "Укажите возраст пользователя")]
        public int Age { get; set; }



        public interface IPrincipal
        {
            IIdentity Identity { get; }
            bool IsInRole(string role);
        }
        public interface IIdentity
        {
            // Тип аутентификации
            string AuthenticationType { get; }
            // атунтифицирован ли пользователь
            bool IsAuthenticated { get; }
            //Имя текущего пользователя 
            string Name { get; }
        }

    }
}

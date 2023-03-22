using System.ComponentModel.DataAnnotations;

namespace PatryInvites_Frimen_.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Выберите один из вариантов")]
        public bool? WillAttend { get; set; }
    }
}

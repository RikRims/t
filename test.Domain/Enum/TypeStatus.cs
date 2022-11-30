using System.ComponentModel.DataAnnotations;

namespace test.Domain.Enum
{
    public enum TypeStatus
    {
        [Display(Name ="Новая")]
        _New = 0,
        [Display(Name = "В работе")]
        _In_job = 1,
        [Display(Name = "Выполнено")]
        _Out_job = 2
    }

    public enum TypeStatusAccount
    {
        [Display(Name = "Заказчик")]
        _New = 0,
        [Display(Name = "Исполнитель")]
        _Job = 1
    }
}
 
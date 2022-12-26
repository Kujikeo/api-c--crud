using System.ComponentModel.DataAnnotations;

namespace MeuTodo2.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }

    }
}

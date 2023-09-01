using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppTaskManagement.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Due Date is required.")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TodoTask
    {
        [Key]
        public int IdTodoTask { get; set; }
        [Required]
        public string TaskDescription{ get; set; }
        public DateTime CreateTime{ get; set; }

        public TodoTask()
        {
            this.CreateTime = DateTime.Now;
        }
    }
}

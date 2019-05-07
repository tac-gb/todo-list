using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Done { get; set; }
    }
}
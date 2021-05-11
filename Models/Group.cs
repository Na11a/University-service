using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
namespace University.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        List<Student> Students { get; set; }

    }
}
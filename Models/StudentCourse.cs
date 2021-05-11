using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
namespace University.Models
{
    public class StudentCourse
    {
        public int Id {get;set;}
        public Student Student { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
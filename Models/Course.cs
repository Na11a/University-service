using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
namespace University.Models{
    public class Course{
        public int Id {get;set;}
        public string Title {get;set;}
        Teacher Teacher {get;set;}
        int TeacherId {get;set;}
        List<StudentCourse> Students {get;set;}
        List<Mark> Marks {get;set;}
    }
}

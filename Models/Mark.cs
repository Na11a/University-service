using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
namespace University.Models{
    public class Mark{
        public int Id{get;set;}
        public DateTime Date {get;set;}
        public int Value {get;set;}
        public Student Student {get;set;}
        public int StudentId {get;set;}
        public Course Course {get;set;}
        public int CourseId {get;set;}
    }
}
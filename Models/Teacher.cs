using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string TeacherCode { get; set; }

        [Required]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
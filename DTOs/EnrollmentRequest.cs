﻿using System;
using System.ComponentModel.DataAnnotations;

namespace cw4.DTOs
{
    public class EnrollmentRequest
    {
        [Required]
        [RegularExpression("^s[0-9]+$")]
        public string IndexNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public string Studies { get; set; }
    }
}
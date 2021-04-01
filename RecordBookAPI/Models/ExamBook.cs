using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecordBookAPI.Models
{
    public class ExamBook
    {
        public long Id { get; set; }
        [Required,JsonIgnore]
        public Student Student { get; set; }
        [ForeignKey("Student")]
        public long Student_id { get; set; }
        [Required, JsonIgnore]
        public Discipline Discipline { get; set; }
        [ForeignKey("Discipline")]
        public long Discipline_id { get; set; }
        [Required,JsonIgnore]
        public ExamType ExamType { get; set; }
        [ForeignKey("ExamType")]
        public long ExamType_id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Evaluation { get; set; }
    }
}

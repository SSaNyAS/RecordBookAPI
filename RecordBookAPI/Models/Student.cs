using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace RecordBookAPI.Models
{
    [Index("CertificateOfEducation",IsUnique = true, Name = "CertificateOfEducation_unique")]
    public class Student
    {
        public long Id { get; set; }
        [MaxLength(14),Required]
        public string CertificateOfEducation { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Middlename { get; set; }
        public string FIO => Lastname + " " + Firstname + " " + Middlename; 
        [Required]
        [JsonIgnore]
        public Group Group { get; set; }
        [ForeignKey("Group")]
        public long Group_id { get; set; }
        [JsonIgnore]
        public IEnumerable<ExamBook> ExamBooks { get; set; }
    }
}

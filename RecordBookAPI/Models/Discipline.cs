using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecordBookAPI.Models
{
    [Index("Name", IsUnique = true, Name = "Name_unique")]
    public class Discipline
    {
        public long Id { get; set; }
        [MaxLength(250),Required]
        public string Name { get; set; }
        [JsonIgnore]
        public IEnumerable<ExamBook> ExamBooks { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecordBookAPI.Models
{
    [Index("Name", IsUnique = true, Name = "Name_unique")]
    public class ExamType
    {
        public long Id { get; set; }

        [MaxLength(250),Required]
        public string Name { get; set; }
        [JsonIgnore]
        public IEnumerable<ExamBook> ExamBooks { get; set; }
    }
}

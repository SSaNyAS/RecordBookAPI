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
    [Index("Name", IsUnique = true, Name = "Name_unique")]
    public class Group
    {
        public long Id { get; set; }
        [MaxLength(250),Required]
        public string Name { get; set; }
        [Required,JsonIgnore]
        public Department Department { get; set; }
        [ForeignKey("Department")]
        public long Department_id { get; set; }
        [JsonIgnore]
        public  IEnumerable<Student> Students { get; set; }
    }
}

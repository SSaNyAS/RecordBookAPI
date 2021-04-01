using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace RecordBookAPI.Models
{
    [Index("Name", IsUnique = true, Name = "Name_unique")]
    public class Department
    {
        public long Id { get; set; }
        [MaxLength(250),Required]
        public string Name { get; set; }
        [JsonIgnore]
        public IEnumerable<Group> Groups { get; set; }
    }
}

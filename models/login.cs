using System.ComponentModel.DataAnnotations;

namespace assignment_WEB_API.models
{
    public class login
    {
        [Key]
        public string uname { get; set; }
        public string upass { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculates.DB
{
    public class Calculate
    {
        [Key]
        public int Id { get; set; }
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public string Operation { get; set; }

        public double Result { get; set; }

        //[ForeignKey("UserId")]
        //public User User { get; set; }
    }
}
using System;
using System.Collection.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bewander.Models
{

    [Table("flag")]
    public class Flag
    {
        public int FlagID [ get; set; }
        public FlagOption Flag Status { get; set; }  //What kind of flag it is
        public int? Post_ID { get; set; }
        public string User_ID { get; set; }
        public int? Review_ID { get; set; }
        
        public virtual Review Review { get; set; }  //Review or Post selected based on the FlagTarget
        public virtual Post Post { get; set; }
        public virtual UserFlagging { get; set; }  //Who flagged it
        
        public DateTime DateFlagged
    
    }
    
}

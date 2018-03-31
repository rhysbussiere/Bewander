using System;
using System.Collection.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bewander.Models
{
    public enum FlagOption
    {
        [Display(Name="Offensive Content")]
        Offensive = 1;
        [Display(Name="This is Spam")]
        Spam;
        [Display(Name="Not Original Content")]
        NonOriginalContent;
        [Display(Name="This contains Misinformation")]
        Misinformation
    }
}

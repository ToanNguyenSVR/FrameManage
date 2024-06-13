using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Frame_Manager.Model.Entity
{
    public class History
    {
        [Key]
        public int COLOR4 { get; set; }
        public string FRAMES { get; set; }
       // private string WORK_DATE { get; set; }
        public int number { get; set; }

    }
}

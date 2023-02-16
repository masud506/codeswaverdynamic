using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodesWeaverNew.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Discription { get; set; }
        public string Boolet1Title { get; set; }
        public string Boolet1TitleDescription { get; set; }
        public string Boolet2Title { get; set; }
        public string Boolet2TitleDescription { get; set; }
        public string Boolet3Title { get; set; }
        public string Boolet3TitleDescription { get; set; }
        public byte[] Image { get; set; }
        public bool willshown { get; set; }
    }
}

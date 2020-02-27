using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCustomRequest.DB
{
    [Serializable]
    public class category
    {
        public category() { }

        [XmlAttribute("id")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("parent")]
        public int parent { get; set; }
        [XmlAttribute("image")]
        public string image { get; set; }

    }
}

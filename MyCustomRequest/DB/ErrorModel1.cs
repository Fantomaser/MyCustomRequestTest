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
    public class ErrorCode
    {
        public ErrorCode() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [XmlAttribute("code")]
        public int Id { get; set; }
        [XmlAttribute("text")]
        public string infotext { get; set; }

    }
}

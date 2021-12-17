using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class HomeApImage
    {

        public int Id { get; set; }
        public int ApartamentId { get; set; }
        public string ApartamentImageURL { get; set; }

        [ForeignKey("ApartamentId")]
        public virtual HomeAp HomeAp { get; set; }
    }
}

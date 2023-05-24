using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusEdukator.DtoLayer.NewFolder
{
    public class CreateCourseAddDto
    {
        public string CourseTitle { get; set; }
        public decimal Price { get; set; }
        public int Score { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
    }
}

using AkademiPlusEdukator.DataAccessLayer.Abstract;
using AkademiPlusEdukator.DataAccessLayer.Concrete;
using AkademiPlusEdukator.DataAccessLayer.Repository;
using AkademiPlusEdukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusEdukator.DataAccessLayer.EntityFramework
{
    public class EfCourseDal : GenericRepository<Course>, ICourseDal
    {
        public List<Course> GetCoursesWithCategories()
        {
            using var context = new Context();
            var values = context.Courses.Include(x => x.Category).ToList();
            return values;
        }
    }
}

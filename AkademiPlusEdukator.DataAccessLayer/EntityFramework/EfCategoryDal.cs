using AkademiPlusEdukator.DataAccessLayer.Abstract;
using AkademiPlusEdukator.DataAccessLayer.Repository;
using AkademiPlusEdukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusEdukator.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}

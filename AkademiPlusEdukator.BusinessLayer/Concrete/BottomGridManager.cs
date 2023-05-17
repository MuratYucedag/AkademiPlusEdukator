using AkademiPlusEdukator.BusinessLayer.Abstract;
using AkademiPlusEdukator.DataAccessLayer.Abstract;
using AkademiPlusEdukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusEdukator.BusinessLayer.Concrete
{
    public class BottomGridManager : IBottomGridService
    {
        private readonly IBottomGridDal _bottomGridDal;
        public BottomGridManager(IBottomGridDal bottomGridDal)
        {
            _bottomGridDal = bottomGridDal;
        }
        public void TDelete(BottomGrid t)
        {
            _bottomGridDal.Delete(t);
        }

        public BottomGrid TGetByID(int id)
        {
           return _bottomGridDal.GetByID(id);
        }

        public List<BottomGrid> TGetList()
        {
           return _bottomGridDal.GetList();
        }

        public void TInsert(BottomGrid t)
        {
            _bottomGridDal.Insert(t);
        }

        public void TUpdate(BottomGrid t)
        {
            _bottomGridDal.Update(t);
        }
    }
}

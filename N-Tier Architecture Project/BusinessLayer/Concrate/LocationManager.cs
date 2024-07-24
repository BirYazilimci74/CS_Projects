using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class LocationManager : ILocationService
    {
        private ILocationDAL _locationDAL; // Dependency Injection

        public LocationManager(ILocationDAL locationDAL)
        {
            _locationDAL = locationDAL;
        }

        public void TDelete(Location t)
        {
            _locationDAL.Delete(t);
        }

        public Location TGetById(int id)
        {
            return _locationDAL.GetByID(id);
        }

        public List<Location> TGetList()
        {
            return _locationDAL.GetList();
        }

        public void TInsert(Location t)
        {
            _locationDAL.Insert(t);
        }

        public void TUpdate(Location t)
        {
            _locationDAL.Update(t);
        }
    }
}

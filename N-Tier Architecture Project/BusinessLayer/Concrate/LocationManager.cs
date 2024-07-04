using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class LocationManager : ILocationService
    {
        ILocationDAL LocationDAL;

        public LocationManager(ILocationDAL locationDAL)
        {
            LocationDAL = locationDAL;
        }

        public void TDelete(Location t)
        {
            LocationDAL.Delete(t);
        }

        public Location TGetById(int id)
        {
            return LocationDAL.GetByID(id);
        }

        public List<Location> TGetList()
        {
            return LocationDAL.GetList();
        }

        public void TInsert(Location t)
        {
            LocationDAL.Insert(t);
        }

        public void TUpdate(Location t)
        {
            LocationDAL.Update(t);
        }
    }
}

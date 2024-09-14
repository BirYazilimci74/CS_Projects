using LibraryApi.DTOs.Catagory;
using LibraryApi.Models;

namespace LibraryApi.Mappers
{
    public static class CatagoryMapper
    {
        public static CatagoryDTO ToCatagoryDTO(this Category catagory)
        {
            return new CatagoryDTO
            {
                Name = catagory.Name,
            };
        }
    }
}
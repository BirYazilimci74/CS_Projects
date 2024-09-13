using LibraryManagementSystemWithAPI.DTOs.Catagory;
using LibraryManagementSystemWithAPI.Models;

namespace LibraryManagementSystemWithAPI.Mappers
{
    public static class CatagoryMapper
    {
        public static CatagoryResponseDTO ToCatagoryResponseDTO(this Category catagory)
        {
            return new CatagoryResponseDTO
            {
                Name = catagory.Name,
            };
        }
    }
}
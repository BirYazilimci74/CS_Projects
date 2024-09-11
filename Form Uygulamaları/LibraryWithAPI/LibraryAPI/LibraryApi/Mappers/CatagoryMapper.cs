using LibraryApi.DTOs.Catagory;
using LibraryApi.Models;

namespace LibraryApi.Mappers
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
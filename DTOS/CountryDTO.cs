using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hotels.DTOS
{ 
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Country Short Name Is Too Long")]
        public string ShortName { get; set; }
    }

    public class CountryDTO
    {       
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }
    }

}

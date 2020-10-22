using System.ComponentModel.DataAnnotations;

namespace FabLabSandboxAPI.Dtos
{
    public class MakerSpaceReadDto
    {
        /// <summary> Id for found some MakerSpase - DB do it self</summary>

        public int Id { get; set; }
        /// <summary>Name for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(250)]
        public string MakerSpaceName { get; set; }

        /// <summary>PostCode for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(4)]
        public string MakerSpacePostCode { get; set; }

        /// <summary>Street for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(100)]
        public string MakerSpaceStreet { get; set; }

        /// <summary>City for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(250)]
        public string MakerSpaceCity { get; set; }

        /// <summary>MakerSpace accepted by Admin or not</summary>
        public bool IsAccepted { get; set; }

    }
}
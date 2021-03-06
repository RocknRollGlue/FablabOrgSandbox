using System.ComponentModel.DataAnnotations;

namespace FabLabSandboxAPI.Dtos.MachineDto
{
    public class MachineReadDto
    {
        /// <summary> Id for found some MakerSpase - DB do it self</summary>

        public int Id { get; set; }
        /// <summary>Name for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        /// <summary>PostCode for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(4)]
        public string PostCode { get; set; }

        /// <summary>Street for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(100)]
        public string Street { get; set; }

        /// <summary>City for create MakerSpase - Required field</summary>
        [Required]
        [MaxLength(250)]
        public string City { get; set; }

        /// <summary>MakerSpace accepted by Admin or not</summary>
        public bool IsAccepted { get; set; }

    }
}
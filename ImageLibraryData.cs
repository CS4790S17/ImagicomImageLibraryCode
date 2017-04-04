using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.DAL
{
    [Table("IMAGE_LIBRARY")]
    public class ImageLibraryData
    {
        [Key, Column("IMAGE_LIBRARY_ID")]
        public int ImageLibraryId { get; set; }

        [Column("IMAGE_DATA")]
        public byte[] ImageData { get; set; }
    }
}

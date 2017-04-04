using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Application.DAL
{
    [Table("IMAGE_LIBRARY")]
    public class ImageLibrary
    {
        #region Private Database Properties

        private string _name;
        private string _imageContentType;
        private string _folderPath;
        private DateTime? _createdDatetime;
        private string _createdName;
        private DateTime? _modifiedDatetime;
        private string _modifiedName;
        private string _status;

        #endregion

        #region Public Database Properties

        [Key, Column("IMAGE_LIBRARY_ID")]
        public int ImageLibraryId { get; set; }

        [MaxLength(40), Column("NAME"), Display(Name = "Name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [MaxLength(100), Column("IMAGE_CONTENT_TYPE"), Display(Name = "Content Type")]
        public string ContentType
        {
            get { return _imageContentType; }
            set { _imageContentType = value; }
        }

        [Column("IMAGE_SIZE"), Display(Name = "Size")]
        public int? Size { get; set; }

        [Column("IMAGE_MODIFIED_DATETIME"), Display(Name = "Date/Time")]
        public DateTime? ImageModifiedDatetime { get; set; }

        [MaxLength(100), Column("FOLDER_PATH"), Display(Name = "Folder")]
        public string FolderPath
        {
            get { return _folderPath; }
            set { _folderPath = value; }
        }

        public virtual ImageLibraryData Data { get; set; }

        [Column("CREATED_DATETIME")]
        public DateTime? CreatedDatetime
        {
            get { return _createdDatetime; }
            set { _createdDatetime = value; }
        }

        [MaxLength(50), Column("CREATED_NAME")]
        public string CreatedName
        {
            get { return _createdName; }
            set { _createdName = value; }
        }

        [Column("MODIFIED_DATETIME")]
        public DateTime? ModifiedDatetime
        {
            get { return _modifiedDatetime; }
            set { _modifiedDatetime = value; }
        }

        [Column("MODIFIED_NAME")]
        public string ModifiedName
        {
            get { return _modifiedName; }
            set { _modifiedName = value; }
        }

        [MaxLength(1), Column("STATUS")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion
    }
}

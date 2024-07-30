


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFriendsV3.Models
{
    [Table("Pictures")]
    public class Picture
    {
        public int Id { get; set; }
        public string PictureName { get; set; }
        public User User { get; set; }
        public byte[] PictureFile { get; set; }
        [NotMapped]
        public IFormFile? SetPicture
        {
            get { return null; }
            set { AddImage(value); }
        }

        public void AddImage(IFormFile file) // קובץ המכיל תמונה מטופס html
        {
            if (file == null)
            {
                return;
            }

            // יצירת מקום בזיכרון במכיל קובץ
            MemoryStream stream = new MemoryStream();
            // העתקת הקובץ למקום בזיכרון
            file.CopyTo(stream);
            // הפיכת המיקום בזיכרון לבייטים ושליחתם לפונקיצה הבאה
            this.PictureFile = stream.ToArray();

        }
    }
}

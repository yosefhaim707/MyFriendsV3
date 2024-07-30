using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFriendsV3.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Picture>? UserPictures { get; set; }
        public byte[] ProfilePicture { get; set; }
        [NotMapped]
        [Display(Name ="Set Profile Image")]
        public IFormFile? SetProfileImage 
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
            this.ProfilePicture = stream.ToArray();

        }
    }
}

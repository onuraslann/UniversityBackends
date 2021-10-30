using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        public static string DepartmanAdded = "Departman eklendi";
        public static string DepartmanDeleted = "Departman silindi";
        public static string NoteAdded = "Note eklendi";
        public static string LessonListed = "Dersler listelendi";
        public static string LecturerAge = "Yaşa göre listelendi";
        public static string StudentAdded = "Öğrenci eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UsersAdded = "Kullanıcı eklendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessLogin = "Login işlemi başarılı";
        public static string UserAlreadyExists = "Başka bir kullanıcı emali giriniz";
        public static string AccessTokenAdded = "Token eklendi";
    }
}

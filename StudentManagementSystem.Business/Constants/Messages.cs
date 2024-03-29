﻿namespace StudentManagementSystem.Business.Constants
{
    public static class Messages
    {
        public static string OfficerLogin = "Memur girişi";
        public static string StudentLogin = "Öğrenci girişi";
        public static string InstructorLogin = "Öğretim görevlisi girişi";

        public static string IncorrectLoginInformation = "Kullanici adiniz veya sifreniz hatali. Kontrol edip tekrar deneyiniz";
        public static string UsernameIsIncorrect = "Kullanici adiniz hatali. Kontrol edip tekrar deneyiniz";
        public static string OnlyNumberForPhone = "'Telefon', alanına yalnızca rakam girebilirsiniz";

        public static string ServerError = "Sunucu hatası";
        private static readonly string _errorStatement = "bir şeyler ters gitti";
        public static readonly string DoYouConfirm = "Onaylıyor musunuz?";
        public static string ApplicationIsRestarting = "Uygulama yeniden başlatılıyor";
        public static string CouldNotBeRetrivedFromServer = "<SUNUCUDAN ALINAMADI>";

        public static string Error = "Hata";
        public static string Warning = "Uyarı";
        public static string Successful = "Başarılı";
        public static string Information = "Bilgilendirme";

        public static string SomethingWentWrongWhileFetchingData = $@"Verileri alırken {_errorStatement}";
        public static string SomethingWentWrongWhileAssignmentProcess = $@"Atama işlemi sırasında {_errorStatement}";
        public static string SomethingWentWrongWhileGettingCurrentDepartments = $@"Mevcut bölümleri alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingCurrentCourses = $@"Mevcut dersleri alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingCurrentInstructors = $@"Mevcut öğretim görevlisi listesini alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingCurrentStudents = $@"Mevcut öğrenci listesini alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingDepartmentDetails = $@"Bölüm detaylarını alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingCourseDetails = $@"Ders detaylarını alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingInstructorDetails = $@"Öğretim görevlisi detaylarını alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingStudentDetails = $@"Öğrenci detaylarını alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingNewProfileInfos = $@"Yeni profil bilgilerini alırken {_errorStatement}";
        public static string SomethingWentWrongWhileGettingStudentsEnrolledCourses = $@"Öğrencinin kayıtlı derslerini alırken {_errorStatement}";
        public static string SomethingWentWrongWhilePasswordChange = $@"Şifre değişikliği sırasında {_errorStatement}";
        public static string SomethingWentWrongWhileCheckPassword = $@"Şifrenizi kontrol ederken {_errorStatement}";
        public static string SomethingWentWrongWhileUpdate = $@"Güncelleme işlemi sırasında {_errorStatement}";
        public static string SomethingWentWrongWhileAddition = $@"Ekleme işlemi sırasında {_errorStatement}";
        public static string SomethingWentWrongWhileDeletion = $@"Silme işlemi sırasında {_errorStatement}";
        public static string SomethingWentWrongWhileSearching = $@"Arama yapılırken {_errorStatement}";

        public static string ProfileHasBeenUpdated = "Profil başarıyla güncellendi";
        public static string DeletionComplete = "Silme işlemi başarıyla tamamlandı";
        public static string AdditionComplete = "Ekleme işlemi başarıyla tamamlandı";
        public static string UpdateComplete = "Güncelleme işlemi başarıyla tamamlandı";
        public static string AssignmentCompletedSuccessfully = "Atama işlemi başarıyla tamamlandı";
        public static string GradeEntryComplete = "Not giriş işlemi başarıyla tamamlandı";

        public static string DeleteConfirmation = "Silme Onayı";
        public static string AddConfirmation = "Ekleme Onayı";
        public static string UpdateConfirmation = "Güncelleme Onayı";
        public static string TransferConfirmation = "Aktarım Onayı";
        public static string ChangeAdviserConfirmation = "Danışman Değişim Onayı";
        public static string GradeEntryConfirmation = "Not Girişi Onayı";
        public static string ApprovalConfirmation = "Onay Verme Onayı";
        public static string SendToDraftConfirmation = "Taslağa Gönderme Onayı";
        public static string DeleteToDraftConfirmation = "Taslakan Silme Onayı";
        public static string SendToAdviserApprovalConfirmation = "Danışman Onayına Gönderme Onayı";

        public static string MustFillInTheFieldsWantToUpdate = "Tüm alanlar boş olamaz.Güncellemek istediğiniz alanları doldurmalısınız";
        public static string TheDataToBeUpdatedIsTheSameAsTheOldData = "Güncellemek istediğiniz veriler eski veriler ile aynı";
        public static string TheInstructorIsAlreadyWorkingInTheDepartmentYouWantToAssign = "Öğretim görevlisi zaten atamak istediğiniz bölümde çalışıyor";
        public static string TheStudentIsAlreadyStudyingInTheDepartmentYouWantToChange = "Öğrenci zaten değiştirmek istediğiniz bölümde öğrenim görüyor";
        public static string MakeSureFillInAllFields = "Tüm alanları doldurduğunuzdan emin olunuz";
        public static string MakeSureSelectAllFields = "Tüm alanları seçtiğinizden emin olunuz";
        public static string NotAllSearchCriteriaCanBeFilledAtOnce = "Tüm arama kriterleri aynı anda doldurulamaz";

        public static string NewPasswordsDoNotMatch = "Yeni şifreler eşleşmiyor";
        public static string NewPasswordCannotBeSameAsOldPassword = "Yeni şifre, eski şifre ile aynı olamaz";
        public static string PasswordHasBeenChanged = "Şifreniz başarıyla değiştirildi";
        public static string LoginAgainWithNewPassword = "Yeni şifrenizle tekrar giriş yapınız";
        public static string OldPasswordEnteredDoesNotMatchCurrentPassword = "Girilen eski şifre, mevcut şifreyle eşleşmiyor";

        public static string DepartmentNumberMustConsistOfNumbersOnly = "Bölüm numarası yalnızca rakamlardan oluşmalıdır";
        public static string DepartmentNumberOfSemesterMustConsistOfNumbersOnly = "Bölüm dönemi yalnızca rakamlardan oluşmalıdır";
        public static string CourseCreditMustConsistOfNumbersOnly = "Ders kredisi yalnızca rakamlardan oluşmalıdır";
        public static string CourseSemesterMustConsistOfNumbersOnly = "Ders dönemi yalnızca rakamlardan oluşmalıdır";
        public static string CourseNoMustConsistOfNumbersOnly = "Ders kodu yalnızca rakamlardan oluşmalıdır";
        public static string InstructorNoMustConsistOfNumbersOnly = "Öğretim görevlisi numarası yalnızca rakamlardan oluşmalıdır";
        public static string StudentNoMustConsistOfNumbersOnly = "Öğrenci numarası yalnızca rakamlardan oluşmalıdır";

        public static string BeforeYouCanAssignAdvisorYouMustFirstSelectAnAdvisor = "Danışman atayabilmek için önce bir danışman seçmelisiniz";
        public static string BeforeYouCanAssignAdvisorYouMustFirstSelectAStudent = "Danışman atayabilmek için önce bir öğrenci seçmelisiniz";
        public static string ThereMustBeAtLeastOneStudentOnTheAdvisorAssignList = "Atama listesinde en az bir öğrenci bulunmalıdır";
        public static string ThereMustBeAtLeastOneDepartmentToBeAbleToAddACourse = "Ders ekleyebilmek için en az bir bölüm olmalıdır";
        public static string ThereMustBeAtLeastOneDepartmentToBeAbleToAddAStudent = "Öğrenci ekleyebilmek için en az bir bölüm olmalıdır";
        public static string ThereMustBeAtLeastOneInstructorToBeAbleToAddACourse = "Ders ekleyebilmek için en az bir öğretim görevlisi olmalıdır";
        public static string ThereMustBeAtLeastOneInstructorToBeAbleToAddAStudent = "Öğrenci ekleyebilmek için danışmanlık işlemlerini yürütecek en az bir öğretim görevlisi olmalıdır";

        public static string AtLeastOneFilterMustBeOn = "Filtreleme yapabilmek için en az bir filtre açık olmalıdır";
        public static string MustSelectADepartmentToBeAbleToFilter = "Filtreleme yapabilmek için bir bölüm seçmelisiniz";
        public static string MustSelectAInstructorToBeAbleToFilter = "Filtreleme yapabilmek için bir öğretim görevlisi seçmelisiniz";

        public static string YouMustSelectAtLeastOneDepartment = "En az bir bölüm seçmelisiniz";
        public static string YouMustSelectAtLeastOneCourse = "En az bir ders seçmelisiniz";
        public static string YouMustSelectAtLeastOneStudent = "En az bir öğrenci seçmelisiniz";
        public static string YouMustSelectAtLeastOneInstructor = "En az bir öğretim görevlisi seçmelisiniz";

        public static string TheAdvisorYouWantToAppointIsTheSameAsTheOldAdvisor = "Atamaya çalıştığınız danışman eski danışman ile aynı";

        public static string AppClosingConfirmation = "Uygulamayı kapatmak istediğinize emin misiniz?";
        public static string AppClosing = "Uygulama Kapatılıyor";
        public static string LogOutConfirmation = "Hesabınızdan çıkış yapmak istediğinize emin misiniz?";
        public static string SafetyLogOut = "Güvenli Çıkış";
        public static string PasswordChangeConfirmation = $"Şifreniz değiştirilecek. {DoYouConfirm}";
        public static string PasswordChanging = "Şifre Değişimi";

        public static string YouMustFirstEnterGrade = "Not girişi yapabilmek için öncelikle bir not girmelisiniz";
        public static string FinalGradeBeforeTheButunlemeGrade = "Bütünleme notu girebilmek için öncelikle final notu girmelisiniz";
        public static string YouMustFirstSelectACourseAndStudent = "Not girişi yapabilmek için bir ders ve öğrenci seçmelisiniz";

        public static string SuccesfullySavedToDraft = "Seçilen dersler başarıyla taslağa kaydedildi. Taslaktaki derslerinizi danışman onayına göndermeyi unutmayınız";
        public static string SuccesfullyDeletedToDraft = "Seçilen dersler başarıyla taslaktan silindi";
        public static string SuccessfulySendToAdviser = "Taslaktaki tüm dersler başarıyla danışman onayına gönderildi";

        public static string CreateSearchResultMessage(int recordFoundInSearch)
        {
            return $@"Arama sonucunda {recordFoundInSearch} adet kayıt bulundu";
        }
        public static string CreateFilterResultMessage(int recordFoundInFilter)
        {
            return $@"Filtreleme sonucunda {recordFoundInFilter} adet kayıt kaldı";
        }
    }
}

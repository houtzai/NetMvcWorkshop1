//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NETMVCWorkshop1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class BOOK_DATA
    {
        public int BOOK_ID { get; set; }
        [DisplayName("書名")]
        public string BOOK_NAME { get; set; }
        [DisplayName("圖書類別")]
        public string BOOK_CLASS_ID { get; set; }
        [DisplayName("作者")]
        public string BOOK_AUTHOR { get; set; }
        [DisplayName("購書日期")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public Nullable<System.DateTime> BOOK_BOUGHT_DATE { get; set; }
        [DisplayName("出版商")]
        public string BOOK_PUBLISHER { get; set; }
        [DisplayName("內容簡介")]
        public string BOOK_NOTE { get; set; }
        [DisplayName("借閱狀態")]
        public string BOOK_STATUS { get; set; }
        [DisplayName("借閱人")]
        public string BOOK_KEEPER { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<System.DateTime> MODIFY_DATE { get; set; }
        public string MODIFY_USER { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BookManaging
{
    interface IBook 
    {
        
        string this [int index]
        {
            get;
            set;
        }

        /// <summary>
        /// Property Title đại diện cho 
        /// tên của sách
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Property Author đại diện cho 
        /// tên của tác giả cuốn sách
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Publisher đại diện cho tên của NXB
        /// </summary>
        string Publisher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string ISBN { get; set; }

        /// <summary>
        /// Property year : năm xuất bản
        /// </summary>
        int Year { get; set; }

        /// <summary>
        /// Mô tả phương thức hiển thị thông tin cuốn sách
        /// </summary>
        void Show();


    }
}

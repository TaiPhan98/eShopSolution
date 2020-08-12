using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Dtos
{
    public class PagingRequestBase
    {
        // vi tri trang so bao nhieu
        public int PageIndex { get; set; }
        //kich co trang
        public int PageSize { get; set; }
    }
}

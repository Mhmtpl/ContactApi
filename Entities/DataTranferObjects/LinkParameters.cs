using Entities.RequestFeatres;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTranferObjects
{
    public record LinkParameters
    {
        public BookParameters BookParameters { get; set; }

        public HttpContext HttpContext { get; set; }
    }
}

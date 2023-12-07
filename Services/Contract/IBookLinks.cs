

using Entities.DataTranferObjects;
using Entities.LinkModels;
using Microsoft.AspNetCore.Http;

namespace Services.Contract
{
    public interface IBookLinks
    {
        LinkResponse TryGenerateLinks(IEnumerable<BookDto> booksDto,
            string fields, HttpContext httpContext);
    }
}

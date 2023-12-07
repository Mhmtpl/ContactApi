﻿using Entities.DataTranferObjects;
using Entities.LinkModels;
using Entities.Models;
using Entities.RequestFeatres;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contract
{
    public interface IBookService
    {
        Task<(LinkResponse linkResponse, MetaData metaData)> GetAllBooksAsync(LinkParameters linkParameters,
            bool trackChanges);
        Task<BookDto> GetOneBookByIdAsync(int id, bool trackChanges);
        Task<List<Book>> GetAllBooksAsync(bool trackChanges);
        Task<BookDto> CreateOneBookAsync(BookDtoForInsertion book);
        Task UpdateOneBookAsync(int id, BookDtoForUpdate bookDto, bool trackChanges);
        Task DeleteOneBookAsync(int id, bool trackChanges);

        Task<(BookDtoForUpdate bookDtoForUpdate, Book book)> GetOneBookForPatchAsync(int id, bool trackChanges);

        Task SaveChangesForPatchAsync(BookDtoForUpdate bookDtoForUpdate, Book book);
    }
}

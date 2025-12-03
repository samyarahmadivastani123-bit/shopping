using aplication.DTO;
using domin;
using infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplication.Interface
{
    public interface ICategory
    {
        Task<List<CreateCategoryDTO>> GetAll();
        Task<CreateCategoryDTO> Get(int id);
        Task <int> Create(CreateCategoryDTO dto);
    }
    public class CategoryService : ICategory
    {
        private AppDbContext mydb;

        public CategoryService(AppDbContext _mydb)
        {

            mydb = _mydb;
        }
        public async Task<int> Create(CreateCategoryDTO dto)
        {
            var cat = new Category()
            {
                Name = dto.Name,
                Picture = dto.Picture,

            };
            mydb.Add(cat);
            await mydb.SaveChangesAsync();

            return cat.Id;

        }

        public Task<CreateCategoryDTO> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CreateCategoryDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SistemaTriagemManchester.Dominio;

namespace SistemaTriagemManchester.Infra.Repositorios
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SistemaTriagemManchesterContext _context;
        public readonly DbSet<T> Set;

        public Repository(SistemaTriagemManchesterContext context)
        {
            _context = context;
            Set = _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Set.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Set.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await Set.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public int Add(T entity)
        {
            Set.Add(entity);
            return _context.SaveChanges();
        }

        public void Update(T entity)
        {
            Set.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            Set.Remove(entity);
            _context.SaveChanges();
        }
    }
}

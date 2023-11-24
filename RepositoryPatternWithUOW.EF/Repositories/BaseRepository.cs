using RepositoryPatternWithUOW.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.EF.Repositories;

public class BaseRepository<T> : IRepository<T> where T:class
{
    protected ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    { 
        _context = context;
    }
    public T GetById(int id)
    {
        var item = _context.Set<T>().Find(id);
        if(item != null)
           return item;
        else
           throw new NullReferenceException();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var item = await _context.Set<T>().FindAsync(id);
        if(item != null)
           return item;
        else
           throw new NullReferenceException();
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T Find(Expression<Func<T,bool>> match)
    {
        return _context.Set<T>().SingleOrDefault(match);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.IRepositories;

public interface IRepository<T> where T:class
{
    T GetById(int id);
}

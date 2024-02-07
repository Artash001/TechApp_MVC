using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tech.DataAccess.Data;
using Tech.DataAccess.Repository.IRepository;
using Tech.Models;

namespace Tech.DataAccess.Repository;

public class CompanyRepository : Repository<Company>, ICompanyRepository
{
    private readonly ApplicationDbContext _db;

    public CompanyRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Company obj)
    {
        _db.Companies.Update(obj);
    }
}

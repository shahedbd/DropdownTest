using DropdownTest2.Data;
using DropdownTest2.Models;
using Microsoft.EntityFrameworkCore;

namespace DropdownTest.Service;

public class Common : ICommon
{
    private readonly ApplicationDbContext _context;
    public Common(ApplicationDbContext context)
        {
            _context = context;
        }
    public IQueryable<ItemDropdownListViewModel> GetCommonddlData(string strTableName)
        {
            var sql = "select Id, Name from " + strTableName + " where Cancelled = 0";
            var result = _context.ItemDropdownListViewModel.FromSqlRaw(sql);
            return result;
        }
}

using DropdownTest2.Models;

namespace DropdownTest.Service;

public interface ICommon
{
    IQueryable<ItemDropdownListViewModel> GetCommonddlData(string strTableName);
}

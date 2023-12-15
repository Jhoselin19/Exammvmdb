using System;
using System.Collections.Generic;
using System.Text;

namespace Exammvmdb.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}

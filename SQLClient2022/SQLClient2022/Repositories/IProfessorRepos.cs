using SQLClient2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLClient2022.Repositories
{
    interface IProfessorRepos
    {
        // ALL
        IEnumerable<ProfessorGet> getAll();
    }
}

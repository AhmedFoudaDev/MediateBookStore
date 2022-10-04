using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Queries.GetAuthorDetails
{
    public class AuthorsDetVM
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
    }
}

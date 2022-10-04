﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Features.Authors.Queries.GetAuthorDetails
{
    public class GetAuthorsDetQuery: IRequest<AuthorsDetVM>
    {
        public Guid AuthorId { get; set; }
    }
}

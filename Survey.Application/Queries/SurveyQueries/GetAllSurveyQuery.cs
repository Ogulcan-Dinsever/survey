﻿using MediatR;
using Survey.Application.Responses;
using Survey.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Application.Queries.SurveyQueries
{
    public class GetAllSurveyQuery : IRequest<Response<List<SurveyResponse>>>
    {
    }
}

﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hann.Application.CargoManager.Application.Features.Terminals.Requests.Commands
{
    public class DeleteTerminalCommand: IRequest
    {
        public int Id { get; set; }
    }
}

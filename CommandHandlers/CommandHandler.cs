﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightConsole.CommandHandlers
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }
}

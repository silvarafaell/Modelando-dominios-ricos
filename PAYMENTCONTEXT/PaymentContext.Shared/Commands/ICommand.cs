using System;

namespace PaymentContext.Shared.Commands
{
    public interface ICommand
    {
        void Validate();
    }
}
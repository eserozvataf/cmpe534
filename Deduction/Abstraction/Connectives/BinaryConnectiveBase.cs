﻿
namespace Deduction.Abstraction.Connectives
{
    public abstract class BinaryConnectiveBase : IConnective
    {
        public abstract bool Operation(bool left, bool right);
    }
}

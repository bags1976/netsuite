using System.Collections.Generic;

namespace Netsuite.Dto
{
    public abstract class TransactionWithLinesQuery<T> : TransactionQuery where T : TransactionLineQuery
    {
        public List<T> Item { get; set; }
    }
}

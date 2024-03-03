using test2.Models;

namespace test2.Repositories;

public class TransactionRepo
{
    private ApplicationContext context;

    public TransactionRepo()
    {
        this.context = new();
    }

    public void Create(Transaction newTransaction)
    {
        context.Transactions.Add(newTransaction);
        context.SaveChanges();
    }

    public Transaction? GetById(int id)
    {
        return context.Transactions.Find(id);
    }

    public IEnumerable<Transaction> GetAll()
    {
        return context.Transactions.AsEnumerable();
    }

    public void Update(Transaction updatedTransaction)
    {
        Transaction? transactionToUpdate = context.Transactions.Find(updatedTransaction.Id);
        transactionToUpdate.DateTime = updatedTransaction.DateTime;
        transactionToUpdate.Type = updatedTransaction.Type;
        transactionToUpdate.Amount = updatedTransaction.Amount;

        context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        context.Transactions.Remove(context.Transactions.Find(id));
        context.SaveChanges();

    }
}
using test2.Models;

namespace test2.Repositories;

public class TransactionRepo {
    private ApplicationContext context;

    public TransactionRepo(ApplicationContext context)
    {
        this.context = context;
    }

    public void Create(Transaction newTransaction) {
        context.Transactions.Add(newTransaction);
        context.SaveChanges();
    }

    public Transaction? GetById(int id) {
        return context.Transactions.Find(id);
    }

    public IEnumerable<Transaction> GetAll() {
        return context.Transactions.AsEnumerable();
    }

    public void Update(Transaction updatedTransaction) {
        context.Transactions.Update(updatedTransaction);
        context.SaveChanges();
    }

    public void DeleteById(int id) {
        context.Transactions.Remove(context.Transactions.Find(id));
        context.SaveChanges();
        
    }
}
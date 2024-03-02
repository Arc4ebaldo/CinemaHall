using System.Transactions;
using test2.DTO;
using test2.Repositories;

namespace test2.Services;

public class TransactionService {
    private TransactionRepo Repo;

    public TransactionService()
    {
        Repo = new();
    }

    public void CreateTransaction(TransactionDTO newTransaction) {
        Repo.Create(newTransaction.ToTransaction());
    }

    public TransactionDTO GetTransactionById(int id) {
        return new TransactionDTO(Repo.GetById(id));
    }

    public List<TransactionDTO> GetAllTransactions() {
        List<TransactionDTO> transactions = new();
        foreach (var transaction in Repo.GetAll())
        {
            transactions.Add(new TransactionDTO(transaction));
        }
        return transactions;
    }

    public void UpdateTransaction(TransactionDTO updatedTransaction) {
        Repo.Update(updatedTransaction.ToTransaction());
    }

    public void DeleteTransactionById(int id) {
        Repo.DeleteById(id);
    }
}
using System;
using Models;
namespace Repository
{
    public interface IExpenseRepository
    {
        bool AddExpense(Expense expensedata);
        bool UpdateExpense(Expense expensedata);
        bool DeleteExpense(string ExpenseId);
        IList<Expense> GetExpenses();
        Expense GetExpenseById(string ExpenseId);
        Expense GetExpenseByUserId(string UserId);
        Expense GetExpenseByCategoryId(string CategoryId);
    }
}
using System;
using Models;
namespace Repository {
    public interface IApprovalHistoryRepository {
        IList<ApprovalHistory> GetApprovalHistories();
        ApprovalHistory GetApprovalHistoryById(string ApprovalHistoryId);
        ApprovalHistory GetApprovalHistoryByManagerId(string ManagerId);
        ApprovalHistory GetApprovalHistoryByCategoryId(string CategoryId);
        bool AddApprovalHistory(ApprovalHistory approvalHistorydata);
        bool UpdateApprovalHistory(ApprovalHistory approvalHistorydata);
        bool DeleteApprovalHistory(string ApprovalHistoryId);
    }
}
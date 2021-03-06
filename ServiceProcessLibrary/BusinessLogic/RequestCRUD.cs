using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class RequestCRUD
    {
        public static int CreateMalfunctionRequest(string clientsName,
                                                   string clientsSurname,
                                                   string clientsemailAddress,
                                                   string description,
                                                   Enums.RequestType requestType,
                                                   Enums.StateType stateType,
                                                   string paymentType,
                                                   DateTime date)
        {
            Request data = new Request
            {
                ClientsName = clientsName,
                ClientsSurname = clientsSurname,
                ClientsEmailAddress = clientsemailAddress,
                Description = description,
                RequestType = requestType,
                StateType = stateType,
                PaymentType = paymentType,
                Date = date,
                Importance = "0"
            };

            string sql = @"INSERT INTO dbo.Request (ClientsName, ClientsSurname, ClientsEmailAddress, Description, RequestType, StateType, PaymentType, Date, Importance)
                           VALUES (@ClientsName, @ClientsSurname, @ClientsEmailAddress, @Description, @RequestType, @StateType, @PaymentType, @Date, @Importance);";

            return SSMSDataAccess.SaveData(sql, data);
        }


        public static List<Request> LoadRequests()
        {
            string sql = @"SELECT *
                           FROM dbo.Request;";

            return SSMSDataAccess.LoadData<Request>(sql);
        }

        public static int DeleteRequest(int requestId)
        {
            Request data = new Request
            {
                Id = requestId
            };

            string sql = @" DELETE 
                            FROM dbo.Request
                            WHERE Id = @Id;";

            return SSMSDataAccess.SaveData(sql, data);
        }

        public static Request LoadRequestById(int requestId)
        {
            string sql = @"SELECT *
                           FROM dbo.Request
                           WHERE Id = @Id;";

            return SSMSDataAccess.LoadRequestById<Request>(sql, requestId);
        }

        public static int UpdateImportance(int requestId, string importance)
        {

            Request data = new Request
            {
                Id = requestId,
                Importance = importance
            };
            string sql = @" UPDATE dbo.Request
                            SET Importance = @Importance
                            WHERE Id = @Id;";


            return SSMSDataAccess.SaveData(sql, data);
        }

        public static int UpdateRequestBillName(int requestId, string billName)
        {

            Request data = new Request
            {
                Id = requestId,
                BillName = billName
            };
            string sql = @" UPDATE dbo.Request
                            SET BillName = @BillName
                            WHERE Id = @Id;";


            return SSMSDataAccess.SaveData(sql, data);
        }
        public static int UpdateRequestInProgress(int requestId, int repairerId)
        {

            Request data = new Request
            {
                Id = requestId,
                StateType = Enums.StateType.in_progress,
                RepairerId = repairerId
            };
            string sql = @" UPDATE dbo.Request
                            SET StateType = @StateType, RepairerId = @RepairerId
                            WHERE Id = @Id;";


            return SSMSDataAccess.SaveData(sql, data);
        }


        public static int UpdateRequestNotificationId(int requestId, int notificaationId)
        {

            Request data = new Request
            {
                Id = requestId,
                NotificationId = notificaationId
            };
            string sql = @" UPDATE dbo.Request
                            SET NotificationId = @NotificationId
                            WHERE Id = @Id;";


            return SSMSDataAccess.SaveData(sql, data);
        }

        public static int UpdateRequestToFinished(int requestId, int reportId)
        {

            Request data = new Request
            {
                Id = requestId,
                StateType = Enums.StateType.finished,
                ReportId = reportId
            };
            string sql = @" UPDATE dbo.Request
                            SET StateType = @StateType, ReportId = @ReportId
                            WHERE Id = @Id;";


            return SSMSDataAccess.SaveData(sql, data);
        }
    }
}

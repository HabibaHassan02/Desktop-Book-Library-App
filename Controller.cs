using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        /*/////////////////////login functions*///////////////////////////
        public DataTable take_password_return_acc_type(string password)
        {
            string query = "select acc_type,ID from Account where userPassword = " + "'"+password+"'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable take_account_type_return_username_M(int ID)
        {
            string query = "select man_Name from Manager where Account_ID ="+ ID;
            return dbMan.ExecuteReader(query);
        }
        public DataTable take_account_type_return_username_E(int ID)
        {
            string query = "select emp_name from Employee where acc_ID ="+ ID;
            return dbMan.ExecuteReader(query);
        }
        public DataTable take_account_type_return_username_C(int ID)
        {
            string query = "select cust_name from Customer where cust_ID = "+ID;
            return dbMan.ExecuteReader(query);
        }
        /*//////////////////////////////////////////////////////////////////////////////////////////*/
        /*///////////////////////manager functionalitys ////////////////////////*/
        public DataTable retrun_all_employess ()  // stored procedure
        {
            string StoredProcedureName = StoredProcedures.Selectallemployees;
            return dbMan.ExecuteReaderproc(StoredProcedureName,null);
        }


        public int update_salary(int salary,int ID)  // stored procedure
        {
            string StoredProcedureName = StoredProcedures.updatesalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@salary", salary);
            Parameters.Add("@id", ID);
            return dbMan.ExecuteNonQueryproc(StoredProcedureName,Parameters);
        }

        public int update_status(string state, int ID)
        {
            string query = "update Account Set acc_state =" + "'"+state+"'" +"where"+ " ID =" + ID;
            return dbMan.ExecuteNonQuery(query);
        }

        public int update_bonus(int bonus  , int SSN)
        {
           string query = "update bonus Set bonus_percentage ="+ bonus+" where Employee_SSN ="+ SSN;
           return dbMan.ExecuteNonQuery(query);
        }

        public DataTable retrun_all_sections()
        {
            string query = "select * from Section";
            return dbMan.ExecuteReader(query);
        }
        public DataTable retrun_all_Manager()
        {
            string query = "select * from Manager";
            return dbMan.ExecuteReader(query);
        }
        public DataTable retrun_all_accounts()
        {
            string query = "select ID,acc_state,acc_type from Account";
            return dbMan.ExecuteReader(query);
        }
        public DataTable retrun_all_racks()
        {
            string query = "select * from Rack";
            return dbMan.ExecuteReader(query);
        }
        public int InsertBook(string book_Name, string book_genre, string ISBN,int section,int rack,string price)
        {
            string query = "insert into Books values("+"'"+ISBN+"'"+","+" '"+book_genre+"'"+","+ "'"+book_Name+"'"+","+ rack+","+ section+","+"'"+price+"'"+")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertEmployee(int SSN, string name, string gender, int salary, int acc_id) {

            string query = "insert into Employee values("+SSN+","+ "'"+name+"'"+","+ "'"+gender+"'"+","+ salary+","+acc_id+")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertAccountEmployee(int acc_id, string name, string status) 
        { string type = "E";

            string query = "insert into Account values("+acc_id+","+ "'"+name+"'"+"," +"'"+status+"'"+","+ "'"+type+"'"+")";
            return dbMan.ExecuteNonQuery(query);
        }


        /*//////////////////////////////////////////////////////////////////////////////////////////*/
        /*///////////////////////customer functionalitys ////////////////////////*/

        public DataTable select_book_byname(string bookname)
        {
            string StoredProcedureName = StoredProcedures.selectbookbyname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bookname", bookname);
            return dbMan.ExecuteReaderproc(StoredProcedureName, Parameters);
        }
        public DataTable select_ISBN_byname(string bookname)
        {
            string query = "select ISBN from Books where title = '" + bookname + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable select_genres()
        {
            string query = "select distinct genre from Books;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable select_titles_of_genres( string genre)
        {
            string StoredProcedureName = StoredProcedures.select_titlegenre;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@genre",genre);
            return dbMan.ExecuteReaderproc(StoredProcedureName, Parameters);
        }
        public DataTable select_price_of_book(string title)
        {
            string query = "select price from Books where title= '" + title + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertPurchase(int purchase_id, DateTime purchase_date, int emp_ssn, int cust_id)
        {
            string StoredProcedureName = StoredProcedures.insertpur;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@purchaseid", purchase_id);
            Parameters.Add("@purchasedate", purchase_date);
            Parameters.Add("@empssn", emp_ssn);
            Parameters.Add("@customerid", cust_id);
            return dbMan.ExecuteNonQueryproc(StoredProcedureName, Parameters);
        }

        public int InsertPurchasedBooks(int purchase_id, string ISBN)
        {
            string StoredProcedureName = StoredProcedures.insertpurbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@purchaseid", purchase_id);
            Parameters.Add("@ISBN", ISBN);
           
            return dbMan.ExecuteNonQueryproc(StoredProcedureName, Parameters);
        }

        public DataTable get_all_customer_info(int cust_ID)
        {
            string StoredProcedureName = StoredProcedures.customerinfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@custid", cust_ID);
            return dbMan.ExecuteReaderproc(StoredProcedureName, Parameters);
        }

        public int cancelMembership(int cust_ID)
        {
            string query = "delete from Account where ID=" + cust_ID +";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int update_password(string pass,int ID )
        {
            string query = "update Account Set userPassword ='" + pass + "' where ID =" + ID;
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertCustReservation(int order_id, DateTime res_date, string ISBN, int cust_ID)
        {
            string query = "insert into Book_reservation values(" + order_id + ",'"+res_date.Date+"','" + ISBN + "',null,"+cust_ID+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable select_reservation(int order_ID)
        {
            string query = "select  * from Book_reservation where order_ID= " + order_ID + ";";
            return dbMan.ExecuteReader(query);
        }

        public int InsertCustLending(int order_id, DateTime res_date, string ISBN ,int cust_ID)
        {
            string StoredProcedureName = StoredProcedures.insertcustlend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderid", order_id);
            Parameters.Add("@resdata",res_date.Date);
            Parameters.Add("@ISBN", ISBN);
            //Parameters.Add("@ssn", SSN);
            Parameters.Add("@cusid", cust_ID);
            return dbMan.ExecuteNonQueryproc(StoredProcedureName, Parameters);
           
        }

        public DataTable select_lending(int order_ID)
        {
            string StoredProcedureName = StoredProcedures.selectlend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderid", order_ID);
            return dbMan.ExecuteReaderproc(StoredProcedureName, Parameters);
        }

        /*//////////////////////////////////////////////////////////////////////////////////////////*/
        public int InsertBook(string name_book, int auth_id, int type_id)
        {
            string query = " Insert " + " Into " + " Novel " + " ( "+" Title "+" , "+ " Author_id "+" , " +" Type_id " +" ) "  +" values "+" ( " +"'"+name_book+"'"+" , "+ auth_id+" , "+ type_id+" ) ";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllBooks(/**ADD PARAMS HERE IF NEEDED**/)
        {
            string query = "SELECT * FROM Novel;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAuthorsOfType(/**ADD PARAMS HERE IF NEEDED**/int typeID)
        {
            string query = "Select "+ " distinct "+ " Name From Author a "+ " , "  +" Novel n "+ " , "+ " type t "+ " Where a.id "+ " = "+ " n.Author_id "+ " and n.Type_id = "+ typeID;
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAuthors(/**ADD PARAMS HERE IF NEEDED**/)
        {
            string query = "SELECT DISTINCT * FROM Author;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTypes(/**ADD PARAMS HERE IF NEEDED**/)
        {
            string query = "SELECT DISTINCT * FROM Type;";
            return dbMan.ExecuteReader(query);
        }
        //////////////////////////Employee Functionalities/////////////

        public int InsertCustomerAccount(int custID, string user_password, string accState)
        {
            string accType = "C";
            string query = "Insert into Account values(" + custID + ",'" + user_password + "','" + accState + "','" + accType + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertCustomer(int custID, string custName, string custAddress)
        {
            string query = "Insert into Customer values(" + custID + ",'" + custName + "','" + custAddress + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsetNotificationContent(int customerID, string NotificationType, string content, string SSN)
        {
            string query = "insert into Notification_table values('" + DateTime.Now + "','" + NotificationType + "','" + content + "'," + customerID + ",'" + SSN + "');";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable ReturnAllCustomersID()
        {
            string StoredProcedureName = StoredProcedures.customerid;
            return dbMan.ExecuteReaderproc(StoredProcedureName, null);
        }

        public int InsertEmployeeReservation(int order_id, DateTime res_date, string ISBN,string SSN, int cust_ID)
        {
            string query = "insert into Book_reservation values(" + order_id + ",'" + res_date.Date + "','" + ISBN + "','"+SSN+"'," + cust_ID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertEmployeeLending(int order_id, DateTime res_date, string ISBN, string SSN, int cust_ID)
        {
            string query = "insert into Book_lending values(" + order_id + ",'" + res_date.Date + "','" + ISBN + "','" + SSN + "'," + cust_ID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable select_SSN_by_empID(int emp_ID)
        {
            string StoredProcedureName = StoredProcedures.selectssnbyempid;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@empid", emp_ID);
            return dbMan.ExecuteReaderproc(StoredProcedureName, Parameters);
        }

        public DataTable ReturnNotificationTypes()
        {
            string query = "select no_type from Notification_table ;";
            return dbMan.ExecuteReader(query);
        }

   
        public int UpdateCustomerInfo(string address)
        {
            string query = "UPDATE Customer SET cust_address='" + address + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ReturnEmployeeInfo(string empSSN)
        {
            string query = "select SSN, emp_name,gender,Salary,acc_ID,userPassword,acc_state,acc_type from Employee,Account where SSN=" + empSSN + "and ID=acc_ID;";
            return dbMan.ExecuteReader(query);
        }
    }
}

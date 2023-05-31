using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBapplication
{
    class StoredProcedures
    {
        public static string Selectallemployees = "return_employee";
        public static string updatesalary = "updatesalary";
        public static string selectbookbyname = "bookbyname";
        public static string select_titlegenre = "select_title_genre";
        public static string insertpur = "insertpurchase";
        public static string insertpurbooks = "insertpurchasebooks";
        public static string insertcustlend = "customerlend";
        public static string customerinfo = "getcustomerinfo";
        public static string customerid = "returncustomerid";
        public static string selectlend = "selectlend";
        public static string selectssnbyempid = "selectssnbyempid";


    }
}

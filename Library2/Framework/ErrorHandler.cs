using Core;
using Microsoft.Data.SqlClient;

namespace System
{
    public static class ErrorHandler
    {
        public static string GetError(Exception ex)
        {
            string errorMessage = "Error";
            if (ex.GetType() == typeof(DivideByZeroException))
            {
                errorMessage = "Divide by zero error";
            }
            if (ex.GetType() == typeof(FormatException))
            {
                errorMessage = "Format error";
            }
            if (ex.GetType() == typeof(Microsoft.EntityFrameworkCore.DbUpdateException))
            {

                if (ex?.InnerException?.GetType() == typeof(SqlException))
                {
                    SqlException? sqlError = ex.InnerException as SqlException;
                    errorMessage = GetSqlExceptionErrorMessage(sqlError);
                }
                Database.Context.ChangeTracker.Clear();
            }

            if (ex?.GetType() == typeof(SqlException))
            {
                SqlException? sqlError = ex as SqlException;

                errorMessage = GetSqlExceptionErrorMessage(sqlError);
            }
            if (ex?.GetType() == typeof(AuthenticateException))
            {
                errorMessage = "user or password is incorrect";
            }
            if (ex?.GetType() == typeof(AuthourizeException))
            {
                errorMessage = "You do not have access to this section";
            }
            MyMessageBox.ValidationErrorMessage(errorMessage);
            return errorMessage;
        }

        private static string GetSqlExceptionErrorMessage(SqlException? sqlError)
        {
            string errorMessage = "Database error";
            if (sqlError?.Number == 2627 || sqlError.Number == 2601)
            {
                errorMessage = "Duplicate information";
            }
            if (sqlError.Number == 547)
            {
                errorMessage = " It cannot be deleted because the information is used in other parts ";
            }

            return errorMessage;
        }
    }

    public class AuthenticateException : Exception
    {
    }
    public class AuthourizeException : Exception
    {
    }


}

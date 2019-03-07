using System;

namespace _10___13._Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;

//            4
//error
//credit card purchase
//INvalid Customer address
//500
//warning
//Email not confirmed
//success
//user registration
//User registered successfully
//warning
//Customer has not email assigned

            for (int i = 0; i < n; i++)
            {
                var successOrError = Console.ReadLine();

                if (successOrError == "success")
                {
                    string operationSuccess = Console.ReadLine();
                    string messageSuccess = Console.ReadLine();
                    string success = ShowSuccessMessage(operationSuccess, messageSuccess);


                        result += success + "\n\n";
                }
                else if (successOrError == "warning")
                {
                    string messageWarning = Console.ReadLine();
                    string warning = ShowWarningMessage(messageWarning);

                    result += warning + "\n\n";
                }
                else if (successOrError == "error")
                {
                    string operationError = Console.ReadLine();
                    string messageError = Console.ReadLine();
                    int codeError = int.Parse(Console.ReadLine());
                    string error = ShowErrorMessage(operationError, messageError, codeError);

                    result += error + "\n\n";
                }
            }

            Console.Write(result);
        }

        static string ShowSuccessMessage(string operation, string message)
        {
            return $"Successfully executed { operation}.\n{new string('=', operation.Length + 23)}\n{ message}.";
        }

        static string ShowWarningMessage(string message)
        {
            return $"Warning: {message}.\n{new string('=', message.Length + 10)}";
        }

        static string ShowErrorMessage(string operation, string message, int errorCode)
        {
            return $"Error: Failed to execute {operation}.\n{new string('=', operation.Length + 26)}\nReason: {message}.\nError Code: {errorCode}.";
        }

        //static string ReadAndProcessMessage()
        //{

        //}
    }
}

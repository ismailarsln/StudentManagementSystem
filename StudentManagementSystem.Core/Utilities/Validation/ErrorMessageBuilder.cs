﻿using System.Collections.Generic;
using FluentValidation.Results;

namespace StudentManagementSystem.Core.Utilities.Validation
{
    public static class ErrorMessageBuilder
    {
        public static string CreateErrorMessageFromValidationFailure(List<ValidationFailure> validationFailures)
        {
            var errorMessage = "";
            foreach (var error in validationFailures)
            {
                errorMessage += $"-{error.ErrorMessage}\n\n";
            }

            return errorMessage;
        }

        public static string CreateErrorMessageFromStringList(List<string> errorList)
        {
            var errorMessage = "";
            foreach (var error in errorList)
            {
                if (error != null)
                {
                    errorMessage += $"-{error}\n\n";
                }
            }

            return errorMessage;
        }
    }
}

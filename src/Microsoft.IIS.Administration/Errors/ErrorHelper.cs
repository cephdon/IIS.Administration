// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


namespace Microsoft.IIS.Administration {
    using System.Net;


    public static class ErrorHelper {

        public static dynamic AntiforgeryValidationError() {
            return new {
                title = "Forbidden",
                detail = "Antiforgery validation failed",
                status = (int)HttpStatusCode.Forbidden
            };
        }

        public static dynamic UnauthorizedError(string schema) {
            return new {
                title = "Unauthorized",
                authentication_scheme = schema,
                status = (int)HttpStatusCode.Forbidden
            };
        }
    }
}

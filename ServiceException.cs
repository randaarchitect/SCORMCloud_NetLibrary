/* Software License Agreement (BSD License)
 * 
 * Copyright (c) 2010-2011, Rustici Software, LLC
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the <organization> nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL Rustici Software, LLC BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;

namespace RusticiSoftware.HostedEngine.Client
{
    /// <summary>
    /// General exception type for errors generated in the Hosted Engine
    /// web service client
    /// </summary>
    [Serializable]
    public class ServiceException : ApplicationException
    {
        private int errorCode = 0;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceException()
        {
        }

        /// <summary>
        /// Constructor with exception message
        /// </summary>
        /// <param name="errorCode">Error Code</param>
        /// <param name="message">Message to display</param>
        public ServiceException(int errorCode, string message) : base(message)
        {
            this.errorCode = errorCode;
        }

        /// <summary>
        /// Constructor with exception message
        /// </summary>
        /// <param name="errorCode">Error Code</param>
        /// <param name="message">Message to display</param>
        public ServiceException(ErrorCode errorCode, string message)
            :
            base(message + "errorCode: " + errorCode)
        {
            this.errorCode = (int)errorCode;
        }

        /// <summary>
        /// Constructor with exception message
        /// </summary>
        /// <param name="message">Message to display</param>
        public ServiceException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor with message and inner exception
        /// </summary>
        /// <param name="message">Message to display</param>
        /// <param name="inner">Inner Exception</param>
        public ServiceException(string message, Exception inner) : base(message, inner)
        {
        }

        public int ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ConfidentialLedger
{
    /// <summary> Response returned to a query for the transaction status. </summary>
    public partial class TransactionStatus
    {
        /// <summary> Initializes a new instance of TransactionStatus. </summary>
        /// <param name="state"></param>
        /// <param name="transactionId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="transactionId"/> is null. </exception>
        public TransactionStatus(TransactionState state, string transactionId)
        {
            Argument.AssertNotNull(transactionId, nameof(transactionId));

            State = state;
            TransactionId = transactionId;
        }

        public TransactionState State { get; set; }

        public string TransactionId { get; set; }
    }
}

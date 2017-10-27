﻿using Binance.Accounts;

namespace Binance.Api.WebSocket.Events
{
    /// <summary>
    /// User data web socket client event.
    /// </summary>
    public sealed class AccountUpdateEventArgs : UserDataEventArgs
    {
        #region Public Properties

        /// <summary>
        /// Get the account.
        /// </summary>
        public Account Account { get; private set; }

        #endregion Public Properties

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="timestamp">The event time.</param>
        /// <param name="account">The account.</param>
        public AccountUpdateEventArgs(long timestamp, Account account)
            : base(timestamp)
        {
            Throw.IfNull(account, nameof(account));

            Account = account;
        }

        #endregion Constructors
    }
}

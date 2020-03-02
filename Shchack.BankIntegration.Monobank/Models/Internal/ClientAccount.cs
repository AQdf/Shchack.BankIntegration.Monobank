﻿namespace Sho.BankIntegration.Monobank.Models.Internal
{
    /// <summary>
    /// Example: <https://api.monobank.ua/docs/#/definitions/UserInfo>
    /// </summary>
    internal class ClientAccount
    {
        /// <summary>
        /// Account identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The value in minimal currency units (cent, kopiyka)
        /// </summary>
        public long Balance { get; set; }

        /// <summary>
        /// The value in minimal currency units (cent, kopiyka)
        /// </summary>
        public long CreditLimit { get; set; }

        /// <summary>
        /// Currency code according to ISO 4217
        /// </summary>
        public int CurrencyCode { get; set; }

        /// <summary>
        /// String enum [None, UAH, Miles]
        /// </summary>
        public string CashbackType { get; set; }
    }
}

﻿using System;

namespace Sho.BankIntegration.Monobank.Models
{
    /// <summary>
    /// Account transaction.
    /// </summary>
    public class MonobankAccountTransaction
    {
        public MonobankAccountTransaction(
            string id,
            DateTime date,
            string description,
            int currencyCode,
            long amount,
            long balance,
            int mcc,
            bool hold,
            long fee,
            long cashback)
        {
            Id = id;
            TransactionDate = date;
            Description = description;
            Currency = new MonobankCurrency(currencyCode);
            Amount = (decimal)amount / 100;
            Balance = (decimal)balance / 100;
            MerchantCategoryCode = mcc;
            Hold = hold;
            FeeAmount = (decimal)fee / 100;
            CashbackAmount = (decimal)cashback / 100;
        }

        /// <summary>
        /// Unique identifier of the transaction in Monobank system.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Date and time of the transaction.
        /// </summary>
        public DateTime TransactionDate { get; }

        /// <summary>
        /// Transaction description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Currency according to ISO 4217.
        /// </summary>
        public MonobankCurrency Currency { get; }

        /// <summary>
        /// Amount in account currency.
        /// </summary>
        public decimal Amount { get; }

        /// <summary>
        /// Account balance in account currency after transaction.
        /// </summary>
        public decimal Balance { get; }

        /// <summary>
        /// Type of the transaction according to ISO 18245.
        /// Reference: <https://en.wikipedia.org/wiki/ISO_18245>.
        /// </summary>
        public int MerchantCategoryCode { get; }

        /// <summary>
        /// Transaction amount blocking status.
        /// </summary>
        public bool Hold { get; }

        /// <summary>
        /// Fee amount.
        /// </summary>
        public decimal FeeAmount { get; }

        /// <summary>
        /// Cashback amount.
        /// </summary>
        public decimal CashbackAmount { get; }
    }
}

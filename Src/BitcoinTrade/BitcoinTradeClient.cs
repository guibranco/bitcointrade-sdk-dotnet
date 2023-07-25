// ***********************************************************************
// Assembly         : BitcoinTrade
// Author           : Guilherme Branco Stracini
// Created          : 07-06-2020
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 07-06-2020
// ***********************************************************************
// <copyright file="BitcoinTradeClient.cs" company="Guilherme Branco Stracini ME">
//     � 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Net.Http;

namespace BitcoinTrade
{
    /// <summary>
    /// Class BitcoinTradeClient.
    /// Implements the <see cref="BitcoinTrade.IBitcoinTradeClient" />
    /// </summary>
    /// <seealso cref="BitcoinTrade.IBitcoinTradeClient" />
    public class BitcoinTradeClient : IBitcoinTradeClient
    {
        /// <summary>
        /// The HTTP client
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="BitcoinTradeClient"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <exception cref="ArgumentNullException">httpClient</exception>
        public BitcoinTradeClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
    }
}

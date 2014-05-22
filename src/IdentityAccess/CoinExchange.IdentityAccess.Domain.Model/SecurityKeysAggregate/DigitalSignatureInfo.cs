﻿using System;

namespace CoinExchange.IdentityAccess.Domain.Model.SecurityKeysAggregate
{
    /// <summary>
    /// Digital Signature Info(Api key and Secret key)
    /// </summary>
    public class DigitalSignatureInfo
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DigitalSignatureInfo()
        {
            
        }

        public DigitalSignatureInfo(string keyDescription, SecurityKeys securityKeys, string userName, DateTime expirationDate, DateTime startDate, DateTime endDate, DateTime lastModified, bool systemGenerated)
        {
            KeyDescription = keyDescription;
            SecurityKeys = securityKeys;
            UserName = userName;
            ExpirationDate = expirationDate;
            StartDate = startDate;
            EndDate = endDate;
            LastModified = lastModified;
            SystemGenerated = systemGenerated;
        }

        #region Private Fields

        private SecurityKeys _securityKeys;

        #endregion Private Fields

        #region Methods

        /// <summary>
        /// Change the value of the API Key
        /// </summary>
        /// <param name="securityKeys"> </param>
        /// <returns></returns>
        public bool ChangeApiKeyValue(SecurityKeys securityKeys)
        {
            if (IsApiKeyValid(securityKeys.ApiKey) && IsSecretKeyValid(securityKeys.SecretKey))
            {
                _securityKeys = securityKeys;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifies if the given API Key is valid or not
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        private bool IsApiKeyValid(string apiKey)
        {
            if (!string.IsNullOrEmpty(apiKey))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifies if the given Secret Key is valid or not
        /// </summary>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        private bool IsSecretKeyValid(string secretKey)
        {
            if (!string.IsNullOrEmpty(secretKey))
            {
                return true;
            }
            return false;
        }

        #endregion Methods

        /// <summary>
        /// Key Description
        /// </summary>
        public string KeyDescription
        {
            get; private set;
        }
        /// <summary>
        /// Security Keys
        /// </summary>
        public SecurityKeys SecurityKeys { get { return _securityKeys; } set { _securityKeys = value; } }

        /// <summary>
        /// Username
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// Expiration Date
        /// </summary>
        public DateTime ExpirationDate { get; private set; }

        /// <summary>
        /// StartDate
        /// </summary>
        public DateTime StartDate { get; private set; }
        
        /// <summary>
        /// EndDate
        /// </summary>
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// LastModified
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// SystemGenerated
        /// </summary>
        public bool SystemGenerated { get; private set; }
    }
}

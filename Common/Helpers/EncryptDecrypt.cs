/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;
using System.Security.Cryptography;
using System.Text;

namespace RecurringIntegrationsScheduler.Common.Helpers
{
    public static class EncryptDecrypt
    {
        /// <summary>
        /// Decrypts a given string.
        /// </summary>
        /// <param name="cipher">A base64 encoded string that was created
        /// through the <see cref="Encrypt(string)" /> or
        /// <see cref="Encrypt(string)" /> extension methods.</param>
        /// <returns>
        /// The decrypted string.
        /// </returns>
        /// <exception cref="ArgumentNullException">If <paramref name="cipher" />
        /// is a null reference.</exception>
        /// <remarks>
        /// Keep in mind that the decrypted string remains in memory
        /// and makes your application vulnerable per se. If runtime protection
        /// is essential, <see cref="System.Security.SecureString" /> should be used.
        /// </remarks>
        public static string Decrypt(string cipher)
        {
            try
            {
                //parse base64 string
                var data = Convert.FromBase64String(cipher);

                //decrypt data
                var decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.LocalMachine);
                return Encoding.Unicode.GetString(decrypted);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Encrypts a given password and returns the encrypted data
        /// as a base64 string.
        /// </summary>
        /// <param name="plainText">An unencrypted string that needs
        /// to be secured.</param>
        /// <returns>
        /// A base64 encoded string that represents the encrypted
        /// binary data.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">plainText</exception>
        /// <exception cref="ArgumentNullException">If <paramref name="plainText" />
        /// is a null reference.</exception>
        /// <remarks>
        /// This solution is not really secure as we are
        /// keeping strings in memory. If runtime protection is essential,
        /// <see cref="System.Security.SecureString" /> should be used.
        /// </remarks>
        public static string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            try
            {
                //encrypt data
                var data = Encoding.Unicode.GetBytes(plainText);
                var encrypted = ProtectedData.Protect(data, null, DataProtectionScope.LocalMachine);

                //return as base64 string
                return Convert.ToBase64String(encrypted);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
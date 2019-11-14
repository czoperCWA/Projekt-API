using Swizzer.Shared.Domain.Users.Dto;
using Swizzer.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Swizzer.Web.Infrustructure.Framework.Security
{
    public interface ISecuritySerice
    {
        string GetSalt();
        string GetHash(string value, string salt);
        JwtDto GetJwt(UserDto user);
    }
    public class SecurityService : ISecuritySerice
    {
        private const int BytesInetationsCount = 1000;
        private const int SaltSize = 40;
        private readonly SecuritySettings _securitySettings;

        public SecurityService(SecuritySettings securitySettings)
        {
            _securitySettings = securitySettings;
        }
        public string GetHash(string value, string salt)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(salt))
                {
                throw new SwizzerServerException(ErrorCodes.InvalidParameter, $"salt: {salt}, value: {value}");
                }
            var pbkdf2 = new Rfc2898DeriveBytes(value, GetBytes(salt), BytesInetationsCount);
            return Convert.ToBase64String(pbkdf2.GetBytes(SaltSize));
        }

        private static byte[] GetBytes(string value)
        {
            var bytes = new byte[value.Length * sizeof(char)];
            Buffer.BlockCopy(value.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        public JwtDto GetJwt(UserDto user)
        {
            
        }

        public string GetSalt()
        {
            var saltBytes = new byte[SaltSize];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }
    }
}

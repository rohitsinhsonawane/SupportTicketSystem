using System;
using System.IO;
using System.Text.Json;

namespace SupportTicketSystem.Desktop.Services
{
    public static class TokenManager
    {
        private static readonly string TokenFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "token.json");

        private class TokenData
        {
            public string? Token { get; set; }
            public int UserId { get; set; }
            public string? Role { get; set; }
        }

        public static void SaveToken(string token, int userId, string role)
        {
            try
            {
                var data = new TokenData { Token = token, UserId = userId, Role = role };
                var json = JsonSerializer.Serialize(data);
                File.WriteAllText(TokenFilePath, json);
            }
            catch (Exception ex)
            {
                // Silently fail if save fails
            }
        }

        public static string? GetToken()
        {
            try
            {
                if (!File.Exists(TokenFilePath))
                    return null;

                var json = File.ReadAllText(TokenFilePath);
                var data = JsonSerializer.Deserialize<TokenData>(json);
                return data?.Token;
            }
            catch
            {
                return null;
            }
        }

        public static int GetUserId()
        {
            try
            {
                if (!File.Exists(TokenFilePath))
                    return 0;

                var json = File.ReadAllText(TokenFilePath);
                var data = JsonSerializer.Deserialize<TokenData>(json);
                return data?.UserId ?? 0;
            }
            catch
            {
                return 0;
            }
        }

        public static string? GetRole()
        {
            try
            {
                if (!File.Exists(TokenFilePath))
                    return null;

                var json = File.ReadAllText(TokenFilePath);
                var data = JsonSerializer.Deserialize<TokenData>(json);
                return data?.Role;
            }
            catch
            {
                return null;
            }
        }

        public static void ClearToken()
        {
            try
            {
                if (File.Exists(TokenFilePath))
                    File.Delete(TokenFilePath);
            }
            catch (Exception ex)
            {
                // Silently fail if delete fails
            }
        }

        public static bool IsTokenValid()
        {
            return !string.IsNullOrEmpty(GetToken());
        }
    }
}

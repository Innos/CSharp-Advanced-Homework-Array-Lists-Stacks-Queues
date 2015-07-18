// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Test">
//  Just testing.
// </copyright>
// <summary>
//   This class allows the transformation of a string into other types,latin letters, hash code or getting parts/extensions of the string.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace _01StringExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This class allows the transformation of a string into other types,latin letters, hash code or getting parts/extensions of the string.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// The method converts a string into a md5 hash code and returns it.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a string representing a md5 Hash code.
        /// </returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(i.ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// The method converts a string into a boolean value based on if the string includes certain text and returns it.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a boolean value representing whether the string contains any of the specified values meaning true.
        /// </returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// The method tries to convert a string into short.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns the result of short.parse or short's default value if the parse is unsuccessful.
        /// </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// The method tries to convert a string into integer.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns the result of integer.parse or integer's default value if the parse is unsuccessful.
        /// </returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// The method tries to convert a string into long.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns the result of long.parse or long's default value if the parse is unsuccessful.
        /// </returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// The method tries to convert a string into a DateTime and returns the result of the Try parse.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns the result of DateTime.parse or DateTime's default value if the parse is unsuccessful.
        /// </returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// The method capitalizes the first letter of a input string and then returns the string, if the string is empty it returns it.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns the input string with a capitalized first letter.
        /// </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return
                input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) +
                input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// The method returns a substring from a given string delimited by a starting string and an ending string, with an option to start from an offset.
        /// If the delimiting strings aren't contained in the input string or the offset is wrong it returns string.Empty.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <param name="startString">
        /// Represents the starting delimiter string.
        /// </param>
        /// <param name="endString">
        /// Represents the ending delimiter string.
        /// </param>
        /// <param name="startFrom">
        /// Represents the offset.
        /// </param>
        /// <returns>
        /// Returns a substring from the given string delimited by two given strings with a possibility of specifying an start offset, or string.Empty if any of the values are incorrect.
        /// </returns>
        public static string GetStringBetween(
            this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition =
                input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// The method converts the cyrillic letters in a given string to their latin representation based on their sound.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a string where all cyrillic letters have been changed with their latin representations based on their sound.
        /// </returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
                                           "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(
                    bulgarianLetters[i].ToUpper(),
                    latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// The method converts the the latin letters in a string to cyrillic based on their keyboard position.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a string where all Latin letters have been changed with their Cyrillic representations based on their keyboard position.
        /// </returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// The method calls the "ConvertCyrillicToLatinLetters" method and then replaces any non word characters with the exception of the dot ('.') with string.Empty.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a string where all cyrillic letters and all non word characters with the exception of the '.'(dot) have been replaced.
        /// </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// The method replaces all whitespaces in a string to the '-'(dash) char, then calls the "ConvertCyrillicToLatinLetters" method and then replaces any non word characters with the exception of the dot ('.') and the dash('-') with string.Empty.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a string where all cyrillic letters and all non word characters with the exception of '.'(dot) and '-'(dash)  have been replaced.
        /// </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// The method returns a substring from a given string.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <param name="charsCount">
        /// Represents the length of the desired substring.
        /// </param>
        /// <returns>
        /// Returns a substring of given length or the entire input string if specified length is bigger than the input string's length.
        /// </returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// The method returns the extension of a filename given as a string, by splitting the string on the '.'(dot) delimiter, if the string doesn't split or is null or empty returns string.Empty.
        /// </summary>
        /// <param name="fileName">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns the file extension from a file name given as a string or string empty if given string is incorrect.
        /// </returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// The method returns the content type of an extension given as a string, by comparing it to a dictionary of predefined values.
        /// If a match is not found in the dictionary it returns a default response.
        /// </summary>
        /// <param name="fileExtension">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a string meaning a specific content type from a given file extension as a string.
        /// </returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// The method returns a given string as a byte array with the size of the string length multiplied by the size of char.
        /// </summary>
        /// <param name="input">
        /// Represents the string we'll be working with.
        /// </param>
        /// <returns>
        /// Returns a byte array with the length of a given string's length multiplied by the size of char.
        /// </returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}

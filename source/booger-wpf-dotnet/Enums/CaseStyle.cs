﻿#region Copyright Jsinh Booger WPF .NET
// ************************************************************************************
// <copyright file="CaseStyle.cs" company="Jaspalsinh Chauhan">
// Copyright © Jaspalsinh Chauhan 2015. All right reserved.
// </copyright>
// ************************************************************************************
// <author>Jaspalsinh Chauhan</author>
// <url>http://jsinh.in</url>
// <url>https://github.com/jsinh/booger-wpf-net</url>
// ************************************************************************************
#endregion

namespace Jsinh.BoogerWpf
{
    /// <summary>
    /// Defines a list of all case styles that <seealso cref="StringCaseConverter"/> can support.
    /// </summary>
    public enum CaseStyle
    {
        /// <summary>
        /// Default option.
        /// </summary>
        None,

        /// <summary>
        /// All words in input string will be converted to capital case.
        /// </summary>
        AllCaps,

        /// <summary>
        /// All words in input string will be converted to lower case.
        /// </summary>
        AllLower,

        /// <summary>
        /// First letter of the first word within a sentence will be converted to lower case and all other words will be .
        /// </summary>
        CamelCase,

        /// <summary>
        /// First letter of the first word within a sentence will be converted to upper case.
        /// </summary>
        SentenceCase,

        /// <summary>
        /// First letter of all words found in string will be converted to upper case.
        /// </summary>
        TitleCase
    }
}
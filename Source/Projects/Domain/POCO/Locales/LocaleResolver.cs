// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Identity = zAppDev.DotNet.Framework.Identity;

namespace DSS5_SupplyChainFinancialsOptimisation.Locales
{

    public class LocaleResolver
    {
        private static Dictionary<string, XmlDocument> _cache = new Dictionary<string, XmlDocument>();
        private static List<string> _availiableLanguages = new List<string> { "en-us","el" };
        private static string _defaultLang = "en-us";

        public static XmlDocument GetLocales(string lang = null)
        {
            var cultureInfo = new CultureInfo(Identity.ProfileHelper.GetCurrentProfileLanguageLCID());
            lang = lang ?? cultureInfo.TwoLetterISOLanguageName;
            if (!_availiableLanguages.Contains(lang))
            {
                lang = _defaultLang;
            }
            if (_cache.ContainsKey(lang))
            {
                return _cache[lang];
            }
            var doc = new XmlDocument();
            doc.LoadXml(ReadEmbededResource(lang + "Locales.xml"));
            _cache.Add(lang, doc);
            return doc;
        }

        public static string Get(string name, int code = 0)
        {
            return GetResourceValue(name, code);
        }

        public static string Get(string name, params object[] args)
        {
            return string.Format(GetResourceValue(name), args);
        }

        private static string GetResourceValue(string name, int code = 0)
        {
            var xml = code > 0 ? GetLocales(GetLocaleNameFromCode(code)) : GetLocales();
            var node = xml.DocumentElement.SelectSingleNode("/Locales/Loc[@Key='" + name + "']");
            if (node == null)
            {
                xml = GetLocales(_defaultLang);
                node = xml.DocumentElement.SelectSingleNode("/Locales/Loc[@Key='" + name + "']");
            }
            return node.Attributes["Value"].Value;
        }

        private static string GetLocaleNameFromCode(int code)
        {
            var ci = new CultureInfo(code);
            if (_availiableLanguages.Contains(ci.TwoLetterISOLanguageName))
            {
                return ci.TwoLetterISOLanguageName;
            }
            var alternative = ci.TextInfo.CultureName.ToLower();
            if (_availiableLanguages.Contains(alternative))
            {
                return alternative;
            }
            return _defaultLang;
        }

        private static string ReadEmbededResource(string fullPath)
        {
            var contents = string.Empty;
            var stream = typeof(DSS5_SupplyChainFinancialsOptimisation.Locales.LocaleResolver).Assembly.GetManifestResourceStream(fullPath);
            if (stream == null)
            {
                stream = typeof(DSS5_SupplyChainFinancialsOptimisation.Locales.LocaleResolver).Assembly.GetManifestResourceStream("Locales." + fullPath);
            }
            if(stream == null)
            {
                stream = typeof(DSS5_SupplyChainFinancialsOptimisation.Locales.LocaleResolver).Assembly.GetManifestResourceStream("DSS5_SupplyChainFinancialsOptimisation."+ "Locales." + fullPath);
            }
            if(stream == null)
            {
                stream = typeof(DSS5_SupplyChainFinancialsOptimisation.Locales.LocaleResolver).Assembly.GetManifestResourceStream("DSS5_SupplyChainFinancialsOptimisation."+ "Locales.Locales." + fullPath);
            }
            if(stream == null)
            {
                stream = typeof(DSS5_SupplyChainFinancialsOptimisation.Locales.LocaleResolver).Assembly.GetManifestResourceStream("DSS5_SupplyChainFinancialsOptimisation.Backend."+ "Locales.Locales." + fullPath);
            }
            using (StreamReader reader = new StreamReader(stream))
            {
                contents = reader.ReadToEnd();
            }
            stream.Dispose();
            return contents;
        }

    }
}
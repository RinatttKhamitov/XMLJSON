﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XMLJSON.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("XMLJSON.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;catalog&gt;
        ///    &lt;part id=&quot;1&quot;&gt;
        ///        &lt;name&gt;Двигатель&lt;/name&gt;
        ///        &lt;description&gt;Используется для машины&lt;/description&gt;
        ///        &lt;brand&gt;Subaru&lt;/brand&gt;
        ///        &lt;model&gt;A12&lt;/model&gt;
        ///        &lt;price currency=&quot;USD&quot;&gt;420.00&lt;/price&gt;
        ///        &lt;compatibility&gt;
        ///            &lt;make&gt;Subaru&lt;/make&gt;
        ///            &lt;model&gt;F-150&lt;/model&gt;
        ///            &lt;year&gt;2010&lt;/year&gt;
        ///        &lt;/compatibility&gt;
        ///    &lt;/part&gt;
        ///    &lt;part id=&quot;2&quot;&gt;
        ///        &lt;name&gt;Масляный фильтр&lt;/name&gt;
        ///        &lt;description&gt;Фильт [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string catalog {
            get {
                return ResourceManager.GetString("catalog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap tree {
            get {
                object obj = ResourceManager.GetObject("tree", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}

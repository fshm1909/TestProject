using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Web.App_Code
{
    /// <summary>
    /// 用于测试web.config文件中的configSections节点功能
    /// </summary>
    public class TestSection : IConfigurationSectionHandler
    {
        /// <summary>
        /// 实现接口方法
        /// </summary>
        /// <param name="parent"> 父对象。</param>
        /// <param name="configContext">配置上下文对象。</param>
        /// <param name="section">节 XML 节点。</param>
        /// <returns></returns>
        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            //表示可通过键或索引访问的关联 String 键和 String 值的集合。
            NameValueCollection configs;

            //提供配置节中的名称/值对配置信息。NameValueSectionHandler 这个类也继承IConfigurationSectionHandler
            NameValueSectionHandler baseHandler = new NameValueSectionHandler();

            configs = (NameValueCollection)baseHandler.Create(parent, configContext, section);
            return configs;
        }
    }
}
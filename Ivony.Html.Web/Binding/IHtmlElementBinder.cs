﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ivony.Html.Web.Binding
{
  /// <summary>
  /// 定义 HTML 元素绑定器
  /// </summary>
  public interface IHtmlElementBinder
  {



    /// <summary>
    /// 绑定元素属性，将在绑定元素之前被调用
    /// </summary>
    /// <param name="context">数据绑定上下文</param>
    /// <param name="attribute">要绑定的属性</param>
    /// <returns>是否执行了绑定，若执行了绑定，则对于这个属性其他绑定器不再运行</returns>
    bool BindAttribute( HtmlBindingContext context, AttributeBindingExpression attribute );


    /// <summary>
    /// 绑定元素
    /// </summary>
    /// <param name="context">数据绑定上下文</param>
    /// <param name="element">要绑定的元素</param>
    /// <returns>是否执行了绑定，若执行了绑定，则对于这个元素其他绑定器不再运行</returns>
    bool BindElement( HtmlBindingContext context, IHtmlElement element );

  }
}

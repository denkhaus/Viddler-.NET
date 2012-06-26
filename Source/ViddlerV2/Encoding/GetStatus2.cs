﻿using System;
using System.Xml.Serialization;

namespace Viddler.Encoding
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.encoding.getStatus2
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.encoding.getStatus2", ElementName = "list_result", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class GetStatus2 : Viddler.Data.VideoEncodingList
  {
  }
}
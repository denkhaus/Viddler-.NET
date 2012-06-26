﻿using System;
using System.Xml.Serialization;

namespace Viddler.Users
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.users.logout
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.users.logout", ElementName = "success", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Get)]
  public class Logout : Viddler.ViddlerResponseSuccess
  {
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ServiceTest
{
  public class SubnetScanner
  {
    public SubnetScanner()
    {

    }
  }

  public class SubnetMask
  {
    public IPAddress Mask { get; set; }

    /// <summary>
    /// Object for represent subnet mask.
    /// </summary>
    /// <param name="strMask">Subnet Mask string, must be ip address and only contains only 0 or 255.</param>
    public SubnetMask(string strMask)
    {
      IPAddress? strSubnetMask = null;
      if(IPAddress.TryParse(strMask, out strSubnetMask) == false)
      {
        throw new ArgumentException($"Invalid Subnet mask string: {strMask}");
      }
    }
  }
}
